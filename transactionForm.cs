using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ReliancePayBank
{
    public partial class transactionForm : Form
    {
        public transactionForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void SwitchPanels(Panel panelToShow, Panel panelToHide)
        {
            panelToHide.Visible = false;
            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }
        private void realdepositbtn_Click(object sender, EventArgs e)
        {
            SwitchPanels(depositPanel, withdrawPanel);

        }

        private void realwithdarwbtn_Click(object sender, EventArgs e)
        {
            SwitchPanels(withdrawPanel, depositPanel);
        }

        private void accountbtn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Close();
        }

        private void transferbtn_Click(object sender, EventArgs e)
        {
            transferForm transfer = new transferForm();
            transfer.Show();
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

        private bool VerifyUserCredentials(int enteredAccountId, string enteredName, string enteredPassword, out string errorMessage)
        {
            // Check if ang entered ID mo match sa session ID
            if (enteredAccountId != SessionManager.CurrentAccountId)
            {
                errorMessage = "Entered Account ID does not match the logged-in user.";
                return false;
            }

            //Check if the entered Name matches the session Username
            if (!enteredName.Equals(SessionManager.CurrentUsername, StringComparison.OrdinalIgnoreCase))
            {
                errorMessage = "Entered Account Name does not match the logged-in user.";
                return false;
            }

            // 3. Verify the password against the database
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM users WHERE account_id = @id AND password = @pass";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", SessionManager.CurrentAccountId);
                        cmd.Parameters.AddWithValue("@pass", enteredPassword);
                        conn.Open();

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 0)
                        {
                            errorMessage = "Invalid confirmation password.";
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = $"Database error during authentication: {ex.Message}";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }


        // --- DEPOSIT TRANSACTION LOGIC (MODIFIED) ---
        private void transacdepositbtn_Click(object sender, EventArgs e)
        {
            // Assuming deposit amount is in deposittxt
            if (!decimal.TryParse(deposittxt.Text, out decimal depositAmount) || depositAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive deposit amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(accountnumtxt.Text, out int enteredAccountId))
            {
                MessageBox.Show("Please enter a valid Account ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- 1. Enhanced Validation ---
            string enteredName = accountnametxt.Text.Trim();
            string enteredPassword = passtxt.Text;
            string errorMessage;

            if (!VerifyUserCredentials(enteredAccountId, enteredName, enteredPassword, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Deposit Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Description is optional, assuming a field named txtDepositDescription exists or using an empty string.
            string description = string.Empty;

            int accountId = SessionManager.CurrentAccountId;
            decimal previousBalance = SessionManager.CurrentBalance;
            decimal newBalance = previousBalance + depositAmount;

            // --- 2. Database Transaction ---
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction sqlTrans = conn.BeginTransaction();

                try
                {
                    // Update the user's balance
                    string updateQuery = "UPDATE users SET balance = @newBalance WHERE account_id = @accountId";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, sqlTrans))
                    {
                        updateCmd.Parameters.AddWithValue("@newBalance", newBalance);
                        updateCmd.Parameters.AddWithValue("@accountId", accountId);
                        updateCmd.ExecuteNonQuery();
                    }

                    // Insert the transaction history record
                    string historyQuery = @"INSERT INTO TransactionHistory 
                                            (AccountID, TransactionType, Amount, PreviousBalance, NewBalance, Description) 
                                            VALUES (@accountId, 'Deposit', @amount, @prevBalance, @newBalance, @description)";

                    using (SqlCommand historyCmd = new SqlCommand(historyQuery, conn, sqlTrans))
                    {
                        historyCmd.Parameters.AddWithValue("@accountId", accountId);
                        historyCmd.Parameters.AddWithValue("@amount", depositAmount);
                        historyCmd.Parameters.AddWithValue("@prevBalance", previousBalance);
                        historyCmd.Parameters.AddWithValue("@newBalance", newBalance);
                        historyCmd.Parameters.AddWithValue("@description", string.IsNullOrEmpty(description) ? "Cash Deposit" : description);
                        historyCmd.ExecuteNonQuery();
                    }

                    // Commit the transaction and update the session balance
                    sqlTrans.Commit();
                    SessionManager.CurrentBalance = newBalance;

                    MessageBox.Show($"Deposit of ₱{depositAmount:N2} successful! New balance: ₱{newBalance:N2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear input fields after success
                    deposittxt.Clear();
                    accountnumtxt.Clear();
                    accountnametxt.Clear();
                    passtxt.Clear();

                }
                catch (Exception ex)
                {
                    sqlTrans.Rollback();
                    MessageBox.Show($"An error occurred during the deposit: {ex.Message}", "Deposit Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- WITHDRAW TRANSACTION LOGIC (MODIFIED) ---
        private void transacwithdrawbtn_Click(object sender, EventArgs e)
        {
            // Assuming withdraw amount is in withdrawtxt
            if (!decimal.TryParse(withdrawtxt.Text, out decimal withdrawAmount) || withdrawAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive withdrawal amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(accnumbertxt.Text, out int enteredAccountId))
            {
                MessageBox.Show("Please enter a valid Account ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- 1. Enhanced Validation ---
            string enteredName = accnametxt.Text.Trim();
            string enteredPassword = passwordtxt.Text;
            string errorMessage;

            if (!VerifyUserCredentials(enteredAccountId, enteredName, enteredPassword, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Withdrawal Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Description is optional, assuming a field named txtWithdrawDescription exists or using an empty string.
            string description = string.Empty;

            int accountId = SessionManager.CurrentAccountId;
            decimal previousBalance = SessionManager.CurrentBalance;

            // Check for insufficient funds before proceeding
            if (withdrawAmount > previousBalance)
            {
                MessageBox.Show($"Insufficient funds. Your current balance is ₱{previousBalance:N2}.", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal newBalance = previousBalance - withdrawAmount;

            // --- 2. Database Transaction ---
            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction sqlTrans = conn.BeginTransaction();

                try
                {
                    // Update the user's balance
                    string updateQuery = "UPDATE users SET balance = @newBalance WHERE account_id = @accountId";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, sqlTrans))
                    {
                        updateCmd.Parameters.AddWithValue("@newBalance", newBalance);
                        updateCmd.Parameters.AddWithValue("@accountId", accountId);
                        updateCmd.ExecuteNonQuery();
                    }

                    // Insert the transaction history record
                    string historyQuery = @"INSERT INTO TransactionHistory 
                                            (AccountID, TransactionType, Amount, PreviousBalance, NewBalance, Description) 
                                            VALUES (@accountId, 'Withdrawal', @amount, @prevBalance, @newBalance, @description)";

                    using (SqlCommand historyCmd = new SqlCommand(historyQuery, conn, sqlTrans))
                    {
                        historyCmd.Parameters.AddWithValue("@accountId", accountId);
                        historyCmd.Parameters.AddWithValue("@amount", withdrawAmount);
                        historyCmd.Parameters.AddWithValue("@prevBalance", previousBalance);
                        historyCmd.Parameters.AddWithValue("@newBalance", newBalance);
                        historyCmd.Parameters.AddWithValue("@description", string.IsNullOrEmpty(description) ? "Cash Withdrawal" : description);
                        historyCmd.ExecuteNonQuery();
                    }

                    // Commit the transaction and update the session balance
                    sqlTrans.Commit();
                    SessionManager.CurrentBalance = newBalance;

                    MessageBox.Show($"Withdrawal of ₱{withdrawAmount:N2} successful! New balance: ₱{newBalance:N2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear input fields after success
                    withdrawtxt.Clear();
                    accnumbertxt.Clear();
                    accnametxt.Clear();
                    passwordtxt.Clear();
                }
                catch (Exception ex)
                {
                    sqlTrans.Rollback();
                    MessageBox.Show($"An error occurred during the withdrawal: {ex.Message}", "Withdrawal Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}