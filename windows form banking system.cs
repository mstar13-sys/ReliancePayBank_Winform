
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReliancePayBank
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labellogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Enter username and password");
                return;
            }

            try
            {
                using (SqlConnection conn = DbHelper.GetConnection())
                {
                    string query = "SELECT account_id, balance, username, account_name, created FROM users WHERE username=@u AND password=@p";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SessionManager.CurrentAccountId = reader.GetInt32(reader.GetOrdinal("account_id"));
                                SessionManager.CurrentBalance = reader.GetDecimal(reader.GetOrdinal("balance"));
                                SessionManager.CurrentUsername = reader.GetString(reader.GetOrdinal("username"));
                                SessionManager.CurrentAccountName = reader.GetString(reader.GetOrdinal("account_name"));
                                SessionManager.CreatedDate = reader.GetDateTime(reader.GetOrdinal("created"));

                                MessageBox.Show("Login Successful!");
                                DashboardForm main = new DashboardForm();
                                main.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }

    public static class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            string connString = ConfigurationManager
                .ConnectionStrings["BankDB"]
                .ConnectionString;

            return new SqlConnection(connString);
        }
    }
    public static class SessionManager
    {
        public static int CurrentAccountId { get; set; }
        public static string CurrentAccountName { get; set; } 
        public static string CurrentUsername { get; set; }
        public static decimal CurrentBalance { get; set; }
        public static DateTime CreatedDate { get; set; }    
    }
}