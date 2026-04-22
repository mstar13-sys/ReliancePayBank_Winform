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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            DisplayUserBalance();
            DisplayUserDetails();
        }

        // data display

        private void DisplayUserDetails()
        {
            try
            {
                name.Text = SessionManager.CurrentAccountName;
                accnum.Text = SessionManager.CurrentAccountId.ToString("D3");
                username.Text = SessionManager.CurrentUsername;
                date.Text = SessionManager.CreatedDate.ToString("yyyy-MM-dd");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying user details: " + ex.Message, "Display Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayUserBalance()
        {
            try
            {
                string formattedBalance = SessionManager.CurrentBalance.ToString("N2");
                balancelbl.Text = $"₱ {formattedBalance}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying balance: " + ex.Message, "Display Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //change pass
        private void update_Click(object sender, EventArgs e)
        {
            string newPassword = newpasstxt.Text;
            string confirmationPassword = confirmationpasstxt.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmationPassword))
            {
                MessageBox.Show("Please fill in both password fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmationPassword)
            {
                MessageBox.Show("New password and confirmation password do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string query = "UPDATE users SET password = @newPass WHERE account_id = @accountId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newPass", newPassword);
                        cmd.Parameters.AddWithValue("@accountId", SessionManager.CurrentAccountId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully! Please remember your new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            updatePassPanel.Visible = false;
                            panelAcc.BringToFront();
                        }
                        else
                        {
                            MessageBox.Show("Could not update password. Account not found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the password: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void deletebtn_Click(object sender, EventArgs e)
        //{
        //    int accountId = SessionManager.CurrentAccountId;
        //    string accountName = SessionManager.CurrentAccountName;

        //    // 1. Confirmation Prompt
        //    DialogResult dialogResult = MessageBox.Show(
        //        $"WARNING: This action is irreversible.\nAre you absolutely sure you want to permanently delete account: {accountName} (ID: {accountId})?",
        //        "Confirm Account Deletion",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Warning);

        //    if (dialogResult == DialogResult.No)
        //    {
        //        return;
        //    }
        //    using (SqlConnection conn = DbHelper.GetConnection())
        //    {
        //        conn.Open();
        //        SqlTransaction sqlTrans = conn.BeginTransaction();

        //        try
        //        {
        //            //Delete all related transactions
        //            string deleteHistoryQuery = "DELETE FROM TransactionHistory WHERE AccountID = @accountId";
        //            using (SqlCommand historyCmd = new SqlCommand(deleteHistoryQuery, conn, sqlTrans))
        //            {
        //                historyCmd.Parameters.AddWithValue("@accountId", accountId);
        //                historyCmd.ExecuteNonQuery();
        //            }

        //            //Delete user account
        //            string deleteUserQuery = "DELETE FROM users WHERE account_id = @accountId";
        //            using (SqlCommand userCmd = new SqlCommand(deleteUserQuery, conn, sqlTrans))
        //            {
        //                userCmd.Parameters.AddWithValue("@accountId", accountId);
        //                int rowsAffected = userCmd.ExecuteNonQuery();

        //                if (rowsAffected == 0)
        //                {
        //                    // If the user wasn't found, rollback the history deletion just in case
        //                    sqlTrans.Rollback();
        //                    MessageBox.Show("Account not found or already deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    return;
        //                }
        //            }

        //            //save changes and log out
        //            sqlTrans.Commit();

        //            MessageBox.Show($"Account {accountName} (ID: {accountId}) has been permanently deleted.", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            this.Close();
        //            Form1 login = new Form1();
        //            login.Show();
        //        }
        //        catch (Exception ex)
        //        {
        //            sqlTrans.Rollback();
        //            MessageBox.Show($"A critical database error occurred during deletion: {ex.Message}\nDeletion failed.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
        private void deletebtn_Click(object sender, EventArgs e)
        {
            int accountId = SessionManager.CurrentAccountId;
            string accountName = SessionManager.CurrentAccountName;

            DialogResult dialogResult = MessageBox.Show(
                $"WARNING: This action is irreversible.\nAre you absolutely sure you want to permanently delete account: {accountName} (ID: {accountId})?",
                "Confirm Account Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            using (SqlConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                SqlTransaction sqlTrans = conn.BeginTransaction();

                try
                {

                    // Only delete the user account
                    string deleteUserQuery = "DELETE FROM users WHERE account_id = @accountId";
                    using (SqlCommand userCmd = new SqlCommand(deleteUserQuery, conn, sqlTrans))
                    {
                        userCmd.Parameters.AddWithValue("@accountId", SessionManager.CurrentAccountId);
                        int rowsAffected = userCmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            sqlTrans.Rollback();
                            MessageBox.Show("Account not found or already deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    // save and logout
                    sqlTrans.Commit();
                    MessageBox.Show($"Account {SessionManager.CurrentAccountName} has been permanently deleted.", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    new Form1().Show();
                }
                catch (Exception ex)
                {
                    sqlTrans.Rollback();
                    MessageBox.Show($"A critical database error occurred: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful!");
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void transacbtn_Click(object sender, EventArgs e)
        {
            transactionForm transact = new transactionForm();
            transact.Show();
            this.Close();
        }

        private void depositbtn_Click(object sender, EventArgs e)
        {
            transactionForm transaction = new transactionForm();
            transaction.Show();
            this.Close();
        }

        private void withdrawbtn_Click(object sender, EventArgs e)
        {
            transactionForm transaction = new transactionForm();
            transaction.Show();
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

        private void editpassbtn_Click(object sender, EventArgs e)
        {
            newpasstxt.Clear();
            confirmationpasstxt.Clear();

            updatePassPanel.Visible = true;
            updatePassPanel.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void button5_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void accPanel_Paint(object sender, PaintEventArgs e) { }
        private void balancelbl_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void balancePanel_Paint(object sender, PaintEventArgs e) { }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void depositbtn_Click_1(object sender, EventArgs e)
        {
            transactionForm transaction = new transactionForm();
            transaction.Show();
            this.Close();
        }

        private void withdrawbtn_Click_1(object sender, EventArgs e)
        {
            transactionForm transaction = new transactionForm();
            transaction.Show();
            this.Close();

        }
    }
}