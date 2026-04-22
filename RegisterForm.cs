using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ReliancePayBank
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dhaccountlabel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        //helper method for database connection
        private SqlConnection GetConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["BankDB"].ConnectionString;
            return new SqlConnection(connStr);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtPass.Text.Trim();
            string email = txtemail.Text.Trim();
            string account_name = AccNametxt.Text.ToUpper();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(account_name))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();

                    // Check if username 
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE username=@username OR email=@email";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        checkCmd.Parameters.AddWithValue("@email", email);

                        int exists = (int)checkCmd.ExecuteScalar();
                        if (exists > 0)
                        {
                            MessageBox.Show("Username or email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user
                    string insertQuery = "INSERT INTO users (account_name, username, password, email) VALUES (@name, @username, @password, @email)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", account_name);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@email", email);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Form1 main = new Form1();
                    main.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
