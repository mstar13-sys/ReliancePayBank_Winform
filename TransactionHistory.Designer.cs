namespace ReliancePayBank
{
    partial class TransactionHistory
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
            this.historyTable = new System.Windows.Forms.DataGridView();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.historybtn);
            this.panel1.Controls.Add(this.transferbtn);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.transacbtn);
            this.panel1.Controls.Add(this.accountbtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 694);
            this.panel1.TabIndex = 15;
            // 
            // historybtn
            // 
            this.historybtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.historybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historybtn.Location = new System.Drawing.Point(0, 375);
            this.historybtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historybtn.Name = "historybtn";
            this.historybtn.Size = new System.Drawing.Size(193, 92);
            this.historybtn.TabIndex = 10;
            this.historybtn.Text = "Transaction History";
            this.historybtn.UseVisualStyleBackColor = false;
            // 
            // transferbtn
            // 
            this.transferbtn.BackColor = System.Drawing.SystemColors.Control;
            this.transferbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferbtn.Location = new System.Drawing.Point(0, 284);
            this.transferbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transferbtn.Name = "transferbtn";
            this.transferbtn.Size = new System.Drawing.Size(193, 92);
            this.transferbtn.TabIndex = 9;
            this.transferbtn.Text = "Transfer Money";
            this.transferbtn.UseVisualStyleBackColor = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Transaction History";
            // 
            // historyTable
            // 
            this.historyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyTable.Location = new System.Drawing.Point(207, 196);
            this.historyTable.Name = "historyTable";
            this.historyTable.RowHeadersVisible = false;
            this.historyTable.RowHeadersWidth = 62;
            this.historyTable.RowTemplate.Height = 28;
            this.historyTable.Size = new System.Drawing.Size(981, 484);
            this.historyTable.TabIndex = 17;
            this.historyTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyTable_CellContentClick);
            // 
            // searchtxt
            // 
            this.searchtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.searchtxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(861, 148);
            this.searchtxt.Multiline = true;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(327, 42);
            this.searchtxt.TabIndex = 18;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(752, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(201, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "History";
            // 
            // TransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.historyTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "TransactionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionHistory";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).EndInit();
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
        private System.Windows.Forms.DataGridView historyTable;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}