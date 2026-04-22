using System;
using System.Data.SqlClient; 
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace ReliancePayBank
{
    public partial class transferForm : Form
    {
        public transferForm()
        {
            InitializeComponent();
        }
        private void sendbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(receiveraccnumbertxt.Text) ||
                string.IsNullOrEmpty(receivernametxt.Text) ||
                string.IsNullOrEmpty(transferamounttxt.Text) ||
                string.IsNullOrEmpty(passtxt.Text))
            {
                MessageBox.Show("Please fill in all required fields (Account, Name, Amount, Password).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(receiveraccnumbertxt.Text, out int receiverAccountId))
            {
                MessageBox.Show("Receiver Account Number must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(transferamounttxt.Text, out decimal transferAmount) || transferAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive transfer amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int senderAccountId = SessionManager.CurrentAccountId;
            decimal senderPreviousBalance = SessionManager.CurrentBalance;
            string senderPassword = passtxt.Text;
            string transferDescription = descriptiontxt.Text.Trim();
            string receiverName = receivernametxt.Text.Trim();

            if (senderAccountId == receiverAccountId)
            {
                MessageBox.Show("Cannot transfer money to your own account ID.", "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (transferAmount > senderPreviousBalance)
            {
                MessageBox.Show($"Insufficient funds. Your current balance is ₱{senderPreviousBalance:N2}.", "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction sqlTrans = conn.BeginTransaction();

                try
                {
                    string verifyQuery = @"SELECT password, (SELECT account_name FROM users WHERE account_id = @receiverId) AS ReceiverName, 
                                            (SELECT balance FROM users WHERE account_id = @receiverId) AS ReceiverBalance
                                           FROM users 
                                           WHERE account_id = @senderId AND password = @senderPass";


                    using (SqlCommand verifyCmd = new SqlCommand(verifyQuery, conn, sqlTrans))
                    {
                        verifyCmd.Parameters.AddWithValue("@senderId", senderAccountId);
                        verifyCmd.Parameters.AddWithValue("@senderPass", senderPassword);
                        verifyCmd.Parameters.AddWithValue("@receiverId", receiverAccountId);

                        using (SqlDataReader reader = verifyCmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                sqlTrans.Rollback();
                                MessageBox.Show("Invalid confirmation password or Sender Account ID not found.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Get receiver info
                            if (reader["ReceiverName"] == DBNull.Value)
                            {
                                sqlTrans.Rollback();
                                MessageBox.Show("Receiver Account ID not found.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string dbReceiverName = reader["ReceiverName"].ToString();

                            // Check if receiver name matches the input
                            if (!dbReceiverName.Equals(receiverName, StringComparison.OrdinalIgnoreCase))
                            {
                                sqlTrans.Rollback();
                                MessageBox.Show("Receiver Name does not match the account ID.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Store receiver balance for the history log
                            decimal receiverPreviousBalance = reader.GetDecimal(reader.GetOrdinal("ReceiverBalance"));

                            reader.Close();

                            decimal senderNewBalance = senderPreviousBalance - transferAmount;
                            decimal receiverNewBalance = receiverPreviousBalance + transferAmount;

                            //Update Balance
                            string updateQuery = @"
                                -- Sender
                                UPDATE users SET balance = @senderNewBalance WHERE account_id = @senderId;
                                -- Receiver
                                UPDATE users SET balance = @receiverNewBalance WHERE account_id = @receiverId;";

                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, sqlTrans))
                            {
                                updateCmd.Parameters.AddWithValue("@senderNewBalance", senderNewBalance);
                                updateCmd.Parameters.AddWithValue("@senderId", senderAccountId);
                                updateCmd.Parameters.AddWithValue("@receiverNewBalance", receiverNewBalance);
                                updateCmd.Parameters.AddWithValue("@receiverId", receiverAccountId);
                                updateCmd.ExecuteNonQuery();
                            }

                            //Log Transaction History
                            string historyQuery = @"
                                -- Sender Log (Type: Transfer OUT)
                                INSERT INTO TransactionHistory (AccountID, TransactionType, Amount, PreviousBalance, NewBalance, Description) 
                                VALUES (@senderId, 'Transfer Sent', @amount, @senderPrevBalance, @senderNewBalance, @senderDesc);

                                -- Receiver Log (Type: Transfer IN)
                                INSERT INTO TransactionHistory (AccountID, TransactionType, Amount, PreviousBalance, NewBalance, Description) 
                                VALUES (@receiverId, 'Transfer Received', @amount, @receiverPrevBalance, @receiverNewBalance, @receiverDesc);";

                            // description in history
                            string senderHistoryDesc = $"Transfer to Account {receiverAccountId} ({receiverName}). " + transferDescription;
                            string receiverHistoryDesc = $"Transfer from Account {senderAccountId} (You). " + transferDescription;

                            using (SqlCommand historyCmd = new SqlCommand(historyQuery, conn, sqlTrans))
                            {
                                historyCmd.Parameters.AddWithValue("@amount", transferAmount);
                                historyCmd.Parameters.AddWithValue("@senderId", senderAccountId);
                                historyCmd.Parameters.AddWithValue("@senderPrevBalance", senderPreviousBalance);
                                historyCmd.Parameters.AddWithValue("@senderNewBalance", senderNewBalance);
                                historyCmd.Parameters.AddWithValue("@senderDesc", senderHistoryDesc);

                                historyCmd.Parameters.AddWithValue("@receiverId", receiverAccountId);
                                historyCmd.Parameters.AddWithValue("@receiverPrevBalance", receiverPreviousBalance);
                                historyCmd.Parameters.AddWithValue("@receiverNewBalance", receiverNewBalance);
                                historyCmd.Parameters.AddWithValue("@receiverDesc", receiverHistoryDesc);

                                historyCmd.ExecuteNonQuery();
                            }

                            //Save the Transaction and Update Session
                            sqlTrans.Commit();
                            SessionManager.CurrentBalance = senderNewBalance;

                            MessageBox.Show($"Transfer of ₱{transferAmount:N2} to {receiverName} successful! New balance: ₱{senderNewBalance:N2}",
                                "Transfer Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            receiveraccnumbertxt.Clear();
                            receivernametxt.Clear();
                            transferamounttxt.Clear();
                            descriptiontxt.Clear();
                            passtxt.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    sqlTrans.Rollback();
                    MessageBox.Show($"A critical error occurred during the transfer: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void transacbtn_Click(object sender, EventArgs e)
        {
            transactionForm transaction = new transactionForm();
            transaction.Show();
            this.Close();
        }

        private void accountbtn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Close();
        }

        private void historybtn_Click(object sender, EventArgs e)
        {
            TransactionHistory history = new TransactionHistory();
            history.Show();
            this.Close();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}