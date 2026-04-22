namespace ReliancePayBank
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.labelcreateaccount = new System.Windows.Forms.Label();
            this.descriptionlabel = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelpass = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dhaccountlabel = new System.Windows.Forms.Label();
            this.linklogin = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.AccNametxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelcreateaccount
            // 
            this.labelcreateaccount.AutoSize = true;
            this.labelcreateaccount.BackColor = System.Drawing.Color.Transparent;
            this.labelcreateaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcreateaccount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelcreateaccount.Location = new System.Drawing.Point(468, 90);
            this.labelcreateaccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcreateaccount.Name = "labelcreateaccount";
            this.labelcreateaccount.Size = new System.Drawing.Size(235, 37);
            this.labelcreateaccount.TabIndex = 1;
            this.labelcreateaccount.Text = "Create Acount";
            // 
            // descriptionlabel
            // 
            this.descriptionlabel.AutoSize = true;
            this.descriptionlabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlabel.ForeColor = System.Drawing.Color.White;
            this.descriptionlabel.Location = new System.Drawing.Point(499, 136);
            this.descriptionlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionlabel.Name = "descriptionlabel";
            this.descriptionlabel.Size = new System.Drawing.Size(149, 50);
            this.descriptionlabel.TabIndex = 5;
            this.descriptionlabel.Text = "Please fill in the\r\nrequired details.";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(443, 323);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(295, 26);
            this.txtusername.TabIndex = 6;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(443, 395);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(295, 26);
            this.txtemail.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(443, 463);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(295, 26);
            this.txtPass.TabIndex = 8;
            this.txtPass.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.BackColor = System.Drawing.Color.Transparent;
            this.labelusername.ForeColor = System.Drawing.Color.White;
            this.labelusername.Location = new System.Drawing.Point(438, 298);
            this.labelusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(83, 20);
            this.labelusername.TabIndex = 9;
            this.labelusername.Text = "Username";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.BackColor = System.Drawing.Color.Transparent;
            this.labelemail.ForeColor = System.Drawing.Color.White;
            this.labelemail.Location = new System.Drawing.Point(438, 371);
            this.labelemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(111, 20);
            this.labelemail.TabIndex = 10;
            this.labelemail.Text = "Email Address\r\n";
            // 
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.BackColor = System.Drawing.Color.Transparent;
            this.labelpass.ForeColor = System.Drawing.Color.White;
            this.labelpass.Location = new System.Drawing.Point(438, 438);
            this.labelpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(78, 20);
            this.labelpass.TabIndex = 11;
            this.labelpass.Text = "Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(443, 524);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(112, 35);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(627, 524);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 35);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dhaccountlabel
            // 
            this.dhaccountlabel.AutoSize = true;
            this.dhaccountlabel.BackColor = System.Drawing.Color.Transparent;
            this.dhaccountlabel.ForeColor = System.Drawing.Color.White;
            this.dhaccountlabel.Location = new System.Drawing.Point(438, 604);
            this.dhaccountlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dhaccountlabel.Name = "dhaccountlabel";
            this.dhaccountlabel.Size = new System.Drawing.Size(170, 20);
            this.dhaccountlabel.TabIndex = 14;
            this.dhaccountlabel.Text = "Already have account?\r\n";
            this.dhaccountlabel.Click += new System.EventHandler(this.dhaccountlabel_Click);
            // 
            // linklogin
            // 
            this.linklogin.AutoSize = true;
            this.linklogin.BackColor = System.Drawing.Color.Transparent;
            this.linklogin.LinkColor = System.Drawing.Color.White;
            this.linklogin.Location = new System.Drawing.Point(648, 604);
            this.linklogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklogin.Name = "linklogin";
            this.linklogin.Size = new System.Drawing.Size(52, 20);
            this.linklogin.TabIndex = 15;
            this.linklogin.TabStop = true;
            this.linklogin.Text = "Log in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(438, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Account Name";
            // 
            // AccNametxt
            // 
            this.AccNametxt.Location = new System.Drawing.Point(443, 254);
            this.AccNametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccNametxt.Name = "AccNametxt";
            this.AccNametxt.Size = new System.Drawing.Size(295, 26);
            this.AccNametxt.TabIndex = 16;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 723);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccNametxt);
            this.Controls.Add(this.linklogin);
            this.Controls.Add(this.dhaccountlabel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.descriptionlabel);
            this.Controls.Add(this.labelcreateaccount);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcreateaccount;
        private System.Windows.Forms.Label descriptionlabel;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label dhaccountlabel;
        private System.Windows.Forms.LinkLabel linklogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AccNametxt;
    }
}