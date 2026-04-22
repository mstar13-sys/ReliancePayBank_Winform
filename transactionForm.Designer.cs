namespace ReliancePayBank
{
    partial class transactionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.historybtn = new System.Windows.Forms.Button();
            this.transferbtn = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.transacbtn = new System.Windows.Forms.Button();
            this.accountbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.realwithdarwbtn = new System.Windows.Forms.Button();
            this.realdepositbtn = new System.Windows.Forms.Button();
            this.withdrawPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.transacwithdrawbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.withdrawtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accnumbertxt = new System.Windows.Forms.TextBox();
            this.depositPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.transacdepositbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.deposittxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.accountnametxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.accountnumtxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.withdrawPanel.SuspendLayout();
            this.depositPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.historybtn);
            this.panel1.Controls.Add(this.transferbtn);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.transacbtn);
            this.panel1.Controls.Add(this.accountbtn);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 694);
            this.panel1.TabIndex = 12;
            // 
            // historybtn
            // 
            this.historybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historybtn.Location = new System.Drawing.Point(0, 375);
            this.historybtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historybtn.Name = "historybtn";
            this.historybtn.Size = new System.Drawing.Size(193, 92);
            this.historybtn.TabIndex = 10;
            this.historybtn.Text = "Transaction History";
            this.historybtn.UseVisualStyleBackColor = true;
            this.historybtn.Click += new System.EventHandler(this.historybtn_Click);
            // 
            // transferbtn
            // 
            this.transferbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferbtn.Location = new System.Drawing.Point(0, 284);
            this.transferbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transferbtn.Name = "transferbtn";
            this.transferbtn.Size = new System.Drawing.Size(193, 92);
            this.transferbtn.TabIndex = 9;
            this.transferbtn.Text = "Transfer Money";
            this.transferbtn.UseVisualStyleBackColor = true;
            this.transferbtn.Click += new System.EventHandler(this.transferbtn_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Black;
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(4, 643);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(189, 46);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // transacbtn
            // 
            this.transacbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.transacbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transacbtn.Location = new System.Drawing.Point(0, 196);
            this.transacbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transacbtn.Name = "transacbtn";
            this.transacbtn.Size = new System.Drawing.Size(193, 92);
            this.transacbtn.TabIndex = 8;
            this.transacbtn.Text = "Transaction";
            this.transacbtn.UseVisualStyleBackColor = false;
            // 
            // accountbtn
            // 
            this.accountbtn.BackColor = System.Drawing.SystemColors.Control;
            this.accountbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountbtn.Location = new System.Drawing.Point(0, 109);
            this.accountbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accountbtn.Name = "accountbtn";
            this.accountbtn.Size = new System.Drawing.Size(193, 92);
            this.accountbtn.TabIndex = 7;
            this.accountbtn.Text = "Account Summary";
            this.accountbtn.UseVisualStyleBackColor = false;
            this.accountbtn.Click += new System.EventHandler(this.accountbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Transaction ";
            // 
            // realwithdarwbtn
            // 
            this.realwithdarwbtn.BackColor = System.Drawing.SystemColors.Control;
            this.realwithdarwbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.realwithdarwbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realwithdarwbtn.Location = new System.Drawing.Point(785, 122);
            this.realwithdarwbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.realwithdarwbtn.Name = "realwithdarwbtn";
            this.realwithdarwbtn.Size = new System.Drawing.Size(203, 63);
            this.realwithdarwbtn.TabIndex = 11;
            this.realwithdarwbtn.Text = "Withdraw";
            this.realwithdarwbtn.UseVisualStyleBackColor = false;
            this.realwithdarwbtn.Click += new System.EventHandler(this.realwithdarwbtn_Click);
            // 
            // realdepositbtn
            // 
            this.realdepositbtn.BackColor = System.Drawing.SystemColors.Control;
            this.realdepositbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.realdepositbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realdepositbtn.Location = new System.Drawing.Point(424, 122);
            this.realdepositbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.realdepositbtn.Name = "realdepositbtn";
            this.realdepositbtn.Size = new System.Drawing.Size(203, 63);
            this.realdepositbtn.TabIndex = 14;
            this.realdepositbtn.Text = "Deposit";
            this.realdepositbtn.UseVisualStyleBackColor = false;
            this.realdepositbtn.Click += new System.EventHandler(this.realdepositbtn_Click);
            // 
            // withdrawPanel
            // 
            this.withdrawPanel.Controls.Add(this.label9);
            this.withdrawPanel.Controls.Add(this.passwordtxt);
            this.withdrawPanel.Controls.Add(this.transacwithdrawbtn);
            this.withdrawPanel.Controls.Add(this.label4);
            this.withdrawPanel.Controls.Add(this.withdrawtxt);
            this.withdrawPanel.Controls.Add(this.label3);
            this.withdrawPanel.Controls.Add(this.accnametxt);
            this.withdrawPanel.Controls.Add(this.label2);
            this.withdrawPanel.Controls.Add(this.accnumbertxt);
            this.withdrawPanel.Location = new System.Drawing.Point(201, 196);
            this.withdrawPanel.Name = "withdrawPanel";
            this.withdrawPanel.Size = new System.Drawing.Size(997, 493);
            this.withdrawPanel.TabIndex = 15;
            this.withdrawPanel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(309, 30);
            this.label9.TabIndex = 28;
            this.label9.Text = "Put your password to confirm: ";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(321, 195);
            this.passwordtxt.Multiline = true;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(466, 40);
            this.passwordtxt.TabIndex = 27;
            // 
            // transacwithdrawbtn
            // 
            this.transacwithdrawbtn.BackColor = System.Drawing.SystemColors.Control;
            this.transacwithdrawbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transacwithdrawbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transacwithdrawbtn.Location = new System.Drawing.Point(366, 302);
            this.transacwithdrawbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transacwithdrawbtn.Name = "transacwithdrawbtn";
            this.transacwithdrawbtn.Size = new System.Drawing.Size(203, 63);
            this.transacwithdrawbtn.TabIndex = 16;
            this.transacwithdrawbtn.Text = "Withdraw";
            this.transacwithdrawbtn.UseVisualStyleBackColor = false;
            this.transacwithdrawbtn.Click += new System.EventHandler(this.transacwithdrawbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Amount to Withdraw: ";
            // 
            // withdrawtxt
            // 
            this.withdrawtxt.Location = new System.Drawing.Point(265, 140);
            this.withdrawtxt.Multiline = true;
            this.withdrawtxt.Name = "withdrawtxt";
            this.withdrawtxt.Size = new System.Drawing.Size(522, 40);
            this.withdrawtxt.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Account Name: ";
            // 
            // accnametxt
            // 
            this.accnametxt.Location = new System.Drawing.Point(224, 88);
            this.accnametxt.Multiline = true;
            this.accnametxt.Name = "accnametxt";
            this.accnametxt.Size = new System.Drawing.Size(563, 40);
            this.accnametxt.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Account Number: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // accnumbertxt
            // 
            this.accnumbertxt.Location = new System.Drawing.Point(224, 35);
            this.accnumbertxt.Multiline = true;
            this.accnumbertxt.Name = "accnumbertxt";
            this.accnumbertxt.Size = new System.Drawing.Size(563, 40);
            this.accnumbertxt.TabIndex = 0;
            // 
            // depositPanel
            // 
            this.depositPanel.Controls.Add(this.label8);
            this.depositPanel.Controls.Add(this.passtxt);
            this.depositPanel.Controls.Add(this.transacdepositbtn);
            this.depositPanel.Controls.Add(this.label5);
            this.depositPanel.Controls.Add(this.deposittxt);
            this.depositPanel.Controls.Add(this.label6);
            this.depositPanel.Controls.Add(this.accountnametxt);
            this.depositPanel.Controls.Add(this.label7);
            this.depositPanel.Controls.Add(this.accountnumtxt);
            this.depositPanel.Location = new System.Drawing.Point(200, 196);
            this.depositPanel.Name = "depositPanel";
            this.depositPanel.Size = new System.Drawing.Size(997, 493);
            this.depositPanel.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(309, 30);
            this.label8.TabIndex = 28;
            this.label8.Text = "Put your password to confirm: ";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(317, 197);
            this.passtxt.Multiline = true;
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(471, 40);
            this.passtxt.TabIndex = 27;
            // 
            // transacdepositbtn
            // 
            this.transacdepositbtn.BackColor = System.Drawing.SystemColors.Control;
            this.transacdepositbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transacdepositbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transacdepositbtn.Location = new System.Drawing.Point(366, 302);
            this.transacdepositbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transacdepositbtn.Name = "transacdepositbtn";
            this.transacdepositbtn.Size = new System.Drawing.Size(203, 63);
            this.transacdepositbtn.TabIndex = 16;
            this.transacdepositbtn.Text = "Deposit";
            this.transacdepositbtn.UseVisualStyleBackColor = false;
            this.transacdepositbtn.Click += new System.EventHandler(this.transacdepositbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Amount to Deposit: ";
            // 
            // deposittxt
            // 
            this.deposittxt.Location = new System.Drawing.Point(246, 140);
            this.deposittxt.Multiline = true;
            this.deposittxt.Name = "deposittxt";
            this.deposittxt.Size = new System.Drawing.Size(542, 40);
            this.deposittxt.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Account Name: ";
            // 
            // accountnametxt
            // 
            this.accountnametxt.Location = new System.Drawing.Point(224, 88);
            this.accountnametxt.Multiline = true;
            this.accountnametxt.Name = "accountnametxt";
            this.accountnametxt.Size = new System.Drawing.Size(564, 40);
            this.accountnametxt.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Account Number: ";
            // 
            // accountnumtxt
            // 
            this.accountnumtxt.Location = new System.Drawing.Point(224, 35);
            this.accountnumtxt.Multiline = true;
            this.accountnumtxt.Name = "accountnumtxt";
            this.accountnumtxt.Size = new System.Drawing.Size(564, 40);
            this.accountnumtxt.TabIndex = 0;
            // 
            // transactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.depositPanel);
            this.Controls.Add(this.realdepositbtn);
            this.Controls.Add(this.realwithdarwbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.withdrawPanel);
            this.Name = "transactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transactionForm";
            this.panel1.ResumeLayout(false);
            this.withdrawPanel.ResumeLayout(false);
            this.withdrawPanel.PerformLayout();
            this.depositPanel.ResumeLayout(false);
            this.depositPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button historybtn;
        private System.Windows.Forms.Button transferbtn;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button transacbtn;
        private System.Windows.Forms.Button accountbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button realwithdarwbtn;
        private System.Windows.Forms.Button realdepositbtn;
        private System.Windows.Forms.Panel withdrawPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accnumbertxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accnametxt;
        private System.Windows.Forms.Panel depositPanel;
        private System.Windows.Forms.Button transacdepositbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deposittxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox accountnametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox accountnumtxt;
        private System.Windows.Forms.Button transacwithdrawbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox withdrawtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox passtxt;
    }
}