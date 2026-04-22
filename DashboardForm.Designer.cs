namespace ReliancePayBank
{
    partial class DashboardForm
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
            this.labelcreateaccount = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.accountbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.historybtn = new System.Windows.Forms.Button();
            this.transferbtn = new System.Windows.Forms.Button();
            this.transacbtn = new System.Windows.Forms.Button();
            this.accPanel = new System.Windows.Forms.Panel();
            this.balancePanel = new System.Windows.Forms.Panel();
            this.balancelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAcc = new System.Windows.Forms.Panel();
            this.accnum = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.editpassbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.withdrawbtn = new System.Windows.Forms.Button();
            this.depositbtn = new System.Windows.Forms.Button();
            this.updatePassPanel = new System.Windows.Forms.Panel();
            this.newpass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmationpasstxt = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.newpasstxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.accPanel.SuspendLayout();
            this.balancePanel.SuspendLayout();
            this.panelAcc.SuspendLayout();
            this.updatePassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelcreateaccount
            // 
            this.labelcreateaccount.AutoSize = true;
            this.labelcreateaccount.BackColor = System.Drawing.Color.Transparent;
            this.labelcreateaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcreateaccount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelcreateaccount.Location = new System.Drawing.Point(525, 14);
            this.labelcreateaccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcreateaccount.Name = "labelcreateaccount";
            this.labelcreateaccount.Size = new System.Drawing.Size(140, 29);
            this.labelcreateaccount.TabIndex = 2;
            this.labelcreateaccount.Text = "Dashboard";
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
            // accountbtn
            // 
            this.accountbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.accountbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountbtn.Location = new System.Drawing.Point(0, 109);
            this.accountbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accountbtn.Name = "accountbtn";
            this.accountbtn.Size = new System.Drawing.Size(193, 92);
            this.accountbtn.TabIndex = 7;
            this.accountbtn.Text = "Account Summary";
            this.accountbtn.UseVisualStyleBackColor = false;
            this.accountbtn.Click += new System.EventHandler(this.button2_Click);
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
            this.panel1.TabIndex = 11;
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
            // transacbtn
            // 
            this.transacbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transacbtn.Location = new System.Drawing.Point(0, 196);
            this.transacbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transacbtn.Name = "transacbtn";
            this.transacbtn.Size = new System.Drawing.Size(193, 92);
            this.transacbtn.TabIndex = 8;
            this.transacbtn.Text = "Transaction";
            this.transacbtn.UseVisualStyleBackColor = true;
            this.transacbtn.Click += new System.EventHandler(this.transacbtn_Click);
            // 
            // accPanel
            // 
            this.accPanel.Controls.Add(this.panelAcc);
            this.accPanel.Controls.Add(this.editpassbtn);
            this.accPanel.Controls.Add(this.deletebtn);
            this.accPanel.Controls.Add(this.withdrawbtn);
            this.accPanel.Controls.Add(this.depositbtn);
            this.accPanel.Controls.Add(this.balancePanel);
            this.accPanel.Location = new System.Drawing.Point(200, 0);
            this.accPanel.Name = "accPanel";
            this.accPanel.Size = new System.Drawing.Size(1000, 689);
            this.accPanel.TabIndex = 12;
            this.accPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.accPanel_Paint);
            // 
            // balancePanel
            // 
            this.balancePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.balancePanel.Controls.Add(this.label7);
            this.balancePanel.Controls.Add(this.label1);
            this.balancePanel.Controls.Add(this.balancelbl);
            this.balancePanel.Location = new System.Drawing.Point(2, 1);
            this.balancePanel.Name = "balancePanel";
            this.balancePanel.Size = new System.Drawing.Size(997, 241);
            this.balancePanel.TabIndex = 15;
            this.balancePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.balancePanel_Paint);
            // 
            // balancelbl
            // 
            this.balancelbl.AutoSize = true;
            this.balancelbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancelbl.Location = new System.Drawing.Point(738, 152);
            this.balancelbl.Name = "balancelbl";
            this.balancelbl.Size = new System.Drawing.Size(149, 48);
            this.balancelbl.TabIndex = 0;
            this.balancelbl.Text = "Balance";
            this.balancelbl.Click += new System.EventHandler(this.balancelbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Balance: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelAcc
            // 
            this.panelAcc.Controls.Add(this.label6);
            this.panelAcc.Controls.Add(this.label5);
            this.panelAcc.Controls.Add(this.updatePassPanel);
            this.panelAcc.Controls.Add(this.label4);
            this.panelAcc.Controls.Add(this.label3);
            this.panelAcc.Controls.Add(this.date);
            this.panelAcc.Controls.Add(this.username);
            this.panelAcc.Controls.Add(this.name);
            this.panelAcc.Controls.Add(this.accnum);
            this.panelAcc.Location = new System.Drawing.Point(1, 238);
            this.panelAcc.Name = "panelAcc";
            this.panelAcc.Size = new System.Drawing.Size(999, 399);
            this.panelAcc.TabIndex = 17;
            // 
            // accnum
            // 
            this.accnum.AutoSize = true;
            this.accnum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accnum.Location = new System.Drawing.Point(206, 46);
            this.accnum.Name = "accnum";
            this.accnum.Size = new System.Drawing.Size(91, 28);
            this.accnum.TabIndex = 17;
            this.accnum.Text = "Acc Num";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(206, 100);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 28);
            this.name.TabIndex = 18;
            this.name.Text = "Acc Name";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(206, 150);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(96, 28);
            this.username.TabIndex = 19;
            this.username.Text = "username";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(206, 201);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(123, 28);
            this.date.TabIndex = 20;
            this.date.Text = "Date created";
            // 
            // editpassbtn
            // 
            this.editpassbtn.BackColor = System.Drawing.Color.Black;
            this.editpassbtn.ForeColor = System.Drawing.Color.White;
            this.editpassbtn.Location = new System.Drawing.Point(214, 643);
            this.editpassbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editpassbtn.Name = "editpassbtn";
            this.editpassbtn.Size = new System.Drawing.Size(189, 46);
            this.editpassbtn.TabIndex = 26;
            this.editpassbtn.Text = "Change Password";
            this.editpassbtn.UseVisualStyleBackColor = false;
            this.editpassbtn.Click += new System.EventHandler(this.editpassbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Black;
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(17, 643);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(189, 46);
            this.deletebtn.TabIndex = 25;
            this.deletebtn.Text = "Delete Account";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // withdrawbtn
            // 
            this.withdrawbtn.BackColor = System.Drawing.Color.Black;
            this.withdrawbtn.ForeColor = System.Drawing.Color.White;
            this.withdrawbtn.Location = new System.Drawing.Point(595, 643);
            this.withdrawbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.withdrawbtn.Name = "withdrawbtn";
            this.withdrawbtn.Size = new System.Drawing.Size(189, 46);
            this.withdrawbtn.TabIndex = 23;
            this.withdrawbtn.Text = "Withdraw";
            this.withdrawbtn.UseVisualStyleBackColor = false;
            this.withdrawbtn.Click += new System.EventHandler(this.withdrawbtn_Click_1);
            // 
            // depositbtn
            // 
            this.depositbtn.BackColor = System.Drawing.Color.Black;
            this.depositbtn.ForeColor = System.Drawing.Color.White;
            this.depositbtn.Location = new System.Drawing.Point(792, 643);
            this.depositbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depositbtn.Name = "depositbtn";
            this.depositbtn.Size = new System.Drawing.Size(189, 46);
            this.depositbtn.TabIndex = 24;
            this.depositbtn.Text = "Deposit";
            this.depositbtn.UseVisualStyleBackColor = false;
            this.depositbtn.Click += new System.EventHandler(this.depositbtn_Click_1);
            // 
            // updatePassPanel
            // 
            this.updatePassPanel.Controls.Add(this.newpasstxt);
            this.updatePassPanel.Controls.Add(this.update);
            this.updatePassPanel.Controls.Add(this.confirmationpasstxt);
            this.updatePassPanel.Controls.Add(this.label2);
            this.updatePassPanel.Controls.Add(this.newpass);
            this.updatePassPanel.Location = new System.Drawing.Point(0, 3);
            this.updatePassPanel.Name = "updatePassPanel";
            this.updatePassPanel.Size = new System.Drawing.Size(999, 399);
            this.updatePassPanel.TabIndex = 21;
            this.updatePassPanel.Visible = false;
            // 
            // newpass
            // 
            this.newpass.AutoSize = true;
            this.newpass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass.Location = new System.Drawing.Point(27, 28);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(141, 28);
            this.newpass.TabIndex = 20;
            this.newpass.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Confirm New Password:";
            // 
            // confirmationpasstxt
            // 
            this.confirmationpasstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirmationpasstxt.Location = new System.Drawing.Point(38, 180);
            this.confirmationpasstxt.MaxLength = 50;
            this.confirmationpasstxt.Name = "confirmationpasstxt";
            this.confirmationpasstxt.Size = new System.Drawing.Size(923, 35);
            this.confirmationpasstxt.TabIndex = 23;
            this.confirmationpasstxt.UseSystemPasswordChar = true;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Black;
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(409, 263);
            this.update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(189, 46);
            this.update.TabIndex = 27;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Account Number: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Account Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Username: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "Date Created: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 48);
            this.label7.TabIndex = 2;
            this.label7.Text = "Dashboard";
            // 
            // newpasstxt
            // 
            this.newpasstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newpasstxt.Location = new System.Drawing.Point(35, 76);
            this.newpasstxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newpasstxt.Name = "newpasstxt";
            this.newpasstxt.Size = new System.Drawing.Size(926, 35);
            this.newpasstxt.TabIndex = 28;
            this.newpasstxt.UseSystemPasswordChar = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.accPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelcreateaccount);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.panel1.ResumeLayout(false);
            this.accPanel.ResumeLayout(false);
            this.balancePanel.ResumeLayout(false);
            this.balancePanel.PerformLayout();
            this.panelAcc.ResumeLayout(false);
            this.panelAcc.PerformLayout();
            this.updatePassPanel.ResumeLayout(false);
            this.updatePassPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcreateaccount;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button accountbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button historybtn;
        private System.Windows.Forms.Button transferbtn;
        private System.Windows.Forms.Button transacbtn;
        private System.Windows.Forms.Panel accPanel;
        private System.Windows.Forms.Panel balancePanel;
        private System.Windows.Forms.Label balancelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAcc;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label accnum;
        private System.Windows.Forms.Button editpassbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button withdrawbtn;
        private System.Windows.Forms.Button depositbtn;
        private System.Windows.Forms.Panel updatePassPanel;
        private System.Windows.Forms.Label newpass;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox confirmationpasstxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox newpasstxt;
    }
}