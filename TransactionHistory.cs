using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReliancePayBank
{
    public partial class TransactionHistory : Form
    {
        public TransactionHistory()
        {
            InitializeComponent();
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory(string searchTerm = "")
        {
            try
            {
                int accountId = SessionManager.CurrentAccountId;

                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string query = @"SELECT 
                                TransactionID, 
                                TransactionType, 
                                Amount, 
                                PreviousBalance, 
                                NewBalance, 
                                TransactionDate, 
                                Description
                             FROM TransactionHistory 
                             WHERE AccountID = @accountId";

                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += " AND (TransactionType LIKE @searchTerm OR Description LIKE @searchTerm)";
                    }

                    //sort by TransactionID
                    query += " ORDER BY TransactionID ASC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@accountId", accountId);

                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                        }

                        conn.Open();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // connect the data
                        historyTable.DataSource = dt;

                        // Format numeric and date columns
                        historyTable.Columns["Amount"].DefaultCellStyle.Format = "N2";
                        historyTable.Columns["PreviousBalance"].DefaultCellStyle.Format = "N2";
                        historyTable.Columns["NewBalance"].DefaultCellStyle.Format = "N2";
                        historyTable.Columns["TransactionDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

                        historyTable.Columns["TransactionID"].HeaderText = "ID";
                        historyTable.Columns["TransactionType"].HeaderText = "Type";
                        historyTable.Columns["Amount"].HeaderText = "Amount";
                        historyTable.Columns["PreviousBalance"].HeaderText = "Previous Balance";
                        historyTable.Columns["NewBalance"].HeaderText = "New Balance";
                        historyTable.Columns["TransactionDate"].HeaderText = "Date";
                        historyTable.Columns["Description"].HeaderText = "Description";

                        historyTable.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transaction history: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void transferbtn_Click(object sender, EventArgs e)
        {
            transferForm transfer = new transferForm();
            transfer.Show();
            this.Close();
        }

        private void transacbtn_Click(object sender, EventArgs e)
        {
            transactionForm transac = new transactionForm();
            transac.Show();
            this.Close();
        }

        private void accountbtn_Click(object sender, EventArgs e)
        {
            DashboardForm account = new DashboardForm();
            account.Show();
            this.Close();
        }

        private void historyTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            LoadTransactionHistory(searchtxt.Text);
        }
    }
}