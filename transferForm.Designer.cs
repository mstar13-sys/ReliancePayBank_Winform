namespace ReliancePayBank
{
    partial class transferForm
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
            this.historybtn = new System.Windows.Forms.Button();
            this.transferbtn = new System.Windows.Forms.Button();
            this.transacbtn = new System.Windows.Forms.Button();
            this.accountbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sendbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptiontxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.transferamounttxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.receivernametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.receiveraccnumbertxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.transferbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.transferbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferbtn.Location = new System.Drawing.Point(0, 284);
            this.transferbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transferbtn.Name = "transferbtn";
            this.transferbtn.Size = new System.Drawing.Size(193, 92);
            this.transferbtn.TabIndex = 9;
            this.transferbtn.Text = "Transfer Money";
            this.transferbtn.UseVisualStyleBackColor = false;
            // 
            // transacbtn
            // 
            this.transacbtn.BackColor = System.Drawing.SystemColors.Control;
            this.transacbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transacbtn.Location = new System.Drawing.Point(0, 196);
            this.transacbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transacbtn.Name = "transacbtn";
            this.transacbtn.Size = new System.Drawing.Size(193, 92);
            this.transacbtn.TabIndex = 8;
            this.transacbtn.Text = "Transaction";
            this.transacbtn.UseVisualStyleBackColor = false;
            this.transacbtn.Click += new System.EventHandler(this.transacbtn_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.historybtn);
            this.panel1.Controls.Add(this.transferbtn);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.transacbtn);
            this.panel1.Controls.Add(this.accountbtn);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 694);
            this.panel1.TabIndex = 13;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Transfer Money";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sendbtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.passtxt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.descriptiontxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.transferamounttxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.receivernametxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.receiveraccnumbertxt);
            this.panel2.Location = new System.Drawing.Point(199, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 580);
            this.panel2.TabIndex = 15;
            // 
            // sendbtn
            // 
            this.sendbtn.BackColor = System.Drawing.Color.Black;
            this.sendbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.ForeColor = System.Drawing.Color.White;
            this.sendbtn.Location = new System.Drawing.Point(409, 465);
            this.sendbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(191, 65);
            this.sendbtn.TabIndex = 11;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = false;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 30);
            this.label6.TabIndex = 26;
            this.label6.Text = "Put your password to confirm: ";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(317, 382);
            this.passtxt.Multiline = true;
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(471, 40);
            this.passtxt.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "Description: ";
            // 
            // descriptiontxt
            // 
            this.descriptiontxt.Location = new System.Drawing.Point(317, 210);
            this.descriptiontxt.Multiline = true;
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.Size = new System.Drawing.Size(471, 134);
            this.descriptiontxt.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "Amount to be Send: ";
            // 
            // transferamounttxt
            // 
            this.transferamounttxt.Location = new System.Drawing.Point(317, 139);
            this.transferamounttxt.Multiline = true;
            this.transferamounttxt.Name = "transferamounttxt";
            this.transferamounttxt.Size = new System.Drawing.Size(471, 40);
            this.transferamounttxt.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Receiver Account Name: ";
            // 
            // receivernametxt
            // 
            this.receivernametxt.Location = new System.Drawing.Point(317, 76);
            this.receivernametxt.Multiline = true;
            this.receivernametxt.Name = "receivernametxt";
            this.receivernametxt.Size = new System.Drawing.Size(471, 40);
            this.receivernametxt.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Receiver Account Number: ";
            // 
            // receiveraccnumbertxt
            // 
            this.receiveraccnumbertxt.Location = new System.Drawing.Point(317, 20);
            this.receiveraccnumbertxt.Multiline = true;
            this.receiveraccnumbertxt.Name = "receiveraccnumbertxt";
            this.receiveraccnumbertxt.Size = new System.Drawing.Size(471, 40);
            this.receiveraccnumbertxt.TabIndex = 17;
            // 
            // transferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "transferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transferForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button historybtn;
        private System.Windows.Forms.Button transferbtn;
        private System.Windows.Forms.Button transacbtn;
        private System.Windows.Forms.Button accountbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox receiveraccnumbertxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox receivernametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox transferamounttxt;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptiontxt;
    }
}