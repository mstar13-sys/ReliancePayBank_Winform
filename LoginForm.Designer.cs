namespace ReliancePayBank
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labellogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Usernamelabel = new System.Windows.Forms.Label();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.checkremember = new System.Windows.Forms.CheckBox();
            this.dhaccountlabel = new System.Windows.Forms.Label();
            this.linkregister = new System.Windows.Forms.LinkLabel();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.BackColor = System.Drawing.Color.Transparent;
            this.labellogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labellogin.Location = new System.Drawing.Point(345, 92);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(81, 25);
            this.labellogin.TabIndex = 0;
            this.labellogin.Text = "LOGIN";
            this.labellogin.Click += new System.EventHandler(this.labellogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(330, 266);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(282, 154);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(228, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(282, 203);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(228, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // Usernamelabel
            // 
            this.Usernamelabel.AutoSize = true;
            this.Usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.Usernamelabel.ForeColor = System.Drawing.Color.White;
            this.Usernamelabel.Location = new System.Drawing.Point(279, 138);
            this.Usernamelabel.Name = "Usernamelabel";
            this.Usernamelabel.Size = new System.Drawing.Size(55, 13);
            this.Usernamelabel.TabIndex = 4;
            this.Usernamelabel.Text = "Username";
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.Passwordlabel.ForeColor = System.Drawing.Color.White;
            this.Passwordlabel.Location = new System.Drawing.Point(279, 187);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(53, 13);
            this.Passwordlabel.TabIndex = 5;
            this.Passwordlabel.Text = "Password";
            // 
            // checkremember
            // 
            this.checkremember.AutoSize = true;
            this.checkremember.BackColor = System.Drawing.Color.Transparent;
            this.checkremember.ForeColor = System.Drawing.Color.White;
            this.checkremember.Location = new System.Drawing.Point(285, 232);
            this.checkremember.Name = "checkremember";
            this.checkremember.Size = new System.Drawing.Size(94, 17);
            this.checkremember.TabIndex = 6;
            this.checkremember.Text = "Remember me\r\n";
            this.checkremember.UseVisualStyleBackColor = false;
            // 
            // dhaccountlabel
            // 
            this.dhaccountlabel.AutoSize = true;
            this.dhaccountlabel.BackColor = System.Drawing.Color.Transparent;
            this.dhaccountlabel.ForeColor = System.Drawing.Color.White;
            this.dhaccountlabel.Location = new System.Drawing.Point(282, 313);
            this.dhaccountlabel.Name = "dhaccountlabel";
            this.dhaccountlabel.Size = new System.Drawing.Size(107, 13);
            this.dhaccountlabel.TabIndex = 7;
            this.dhaccountlabel.Text = "Don\'t have account?";
            // 
            // linkregister
            // 
            this.linkregister.AutoSize = true;
            this.linkregister.BackColor = System.Drawing.Color.Transparent;
            this.linkregister.LinkColor = System.Drawing.Color.White;
            this.linkregister.Location = new System.Drawing.Point(463, 313);
            this.linkregister.Name = "linkregister";
            this.linkregister.Size = new System.Drawing.Size(46, 13);
            this.linkregister.TabIndex = 8;
            this.linkregister.TabStop = true;
            this.linkregister.Text = "Register";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(285, 342);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.linkregister);
            this.Controls.Add(this.dhaccountlabel);
            this.Controls.Add(this.checkremember);
            this.Controls.Add(this.Passwordlabel);
            this.Controls.Add(this.Usernamelabel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labellogin);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Usernamelabel;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.CheckBox checkremember;
        private System.Windows.Forms.Label dhaccountlabel;
        private System.Windows.Forms.LinkLabel linkregister;
        private System.Windows.Forms.Button btnBack;
    }
}