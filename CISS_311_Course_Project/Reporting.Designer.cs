namespace CISS_311_Course_Project
{
    partial class Reporting
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.data_Reports = new System.Windows.Forms.DataGridView();
            this.btn_CheckedOutBooks = new System.Windows.Forms.Button();
            this.btn_LateBooks = new System.Windows.Forms.Button();
            this.btn_AllBooks = new System.Windows.Forms.Button();
            this.btn_AllBorrowers = new System.Windows.Forms.Button();
            this.btn_AllAuthors = new System.Windows.Forms.Button();
            this.btn_Transactions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Reports)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(301, 472);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 50);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 471);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 11;
            // 
            // data_Reports
            // 
            this.data_Reports.AllowUserToAddRows = false;
            this.data_Reports.AllowUserToDeleteRows = false;
            this.data_Reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Reports.Location = new System.Drawing.Point(10, 213);
            this.data_Reports.Name = "data_Reports";
            this.data_Reports.ReadOnly = true;
            this.data_Reports.RowTemplate.Height = 24;
            this.data_Reports.Size = new System.Drawing.Size(777, 252);
            this.data_Reports.TabIndex = 17;
            // 
            // btn_CheckedOutBooks
            // 
            this.btn_CheckedOutBooks.Location = new System.Drawing.Point(27, 13);
            this.btn_CheckedOutBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CheckedOutBooks.Name = "btn_CheckedOutBooks";
            this.btn_CheckedOutBooks.Size = new System.Drawing.Size(195, 50);
            this.btn_CheckedOutBooks.TabIndex = 18;
            this.btn_CheckedOutBooks.Text = "View All Outstanding Books";
            this.btn_CheckedOutBooks.UseVisualStyleBackColor = true;
            this.btn_CheckedOutBooks.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_LateBooks
            // 
            this.btn_LateBooks.Location = new System.Drawing.Point(301, 13);
            this.btn_LateBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LateBooks.Name = "btn_LateBooks";
            this.btn_LateBooks.Size = new System.Drawing.Size(195, 50);
            this.btn_LateBooks.TabIndex = 19;
            this.btn_LateBooks.Text = "View All Late Books";
            this.btn_LateBooks.UseVisualStyleBackColor = true;
            this.btn_LateBooks.Click += new System.EventHandler(this.btn_LateBooks_Click);
            // 
            // btn_AllBooks
            // 
            this.btn_AllBooks.Location = new System.Drawing.Point(575, 13);
            this.btn_AllBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AllBooks.Name = "btn_AllBooks";
            this.btn_AllBooks.Size = new System.Drawing.Size(195, 50);
            this.btn_AllBooks.TabIndex = 20;
            this.btn_AllBooks.Text = "View All Books";
            this.btn_AllBooks.UseVisualStyleBackColor = true;
            this.btn_AllBooks.Click += new System.EventHandler(this.btn_AllBooks_Click);
            // 
            // btn_AllBorrowers
            // 
            this.btn_AllBorrowers.Location = new System.Drawing.Point(301, 142);
            this.btn_AllBorrowers.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AllBorrowers.Name = "btn_AllBorrowers";
            this.btn_AllBorrowers.Size = new System.Drawing.Size(195, 50);
            this.btn_AllBorrowers.TabIndex = 22;
            this.btn_AllBorrowers.Text = "View All Borrowers";
            this.btn_AllBorrowers.UseVisualStyleBackColor = true;
            this.btn_AllBorrowers.Click += new System.EventHandler(this.btn_AllBorrowers_Click);
            // 
            // btn_AllAuthors
            // 
            this.btn_AllAuthors.Location = new System.Drawing.Point(27, 142);
            this.btn_AllAuthors.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AllAuthors.Name = "btn_AllAuthors";
            this.btn_AllAuthors.Size = new System.Drawing.Size(195, 50);
            this.btn_AllAuthors.TabIndex = 21;
            this.btn_AllAuthors.Text = "View All Authors";
            this.btn_AllAuthors.UseVisualStyleBackColor = true;
            this.btn_AllAuthors.Click += new System.EventHandler(this.btn_AllAuthors_Click);
            // 
            // btn_Transactions
            // 
            this.btn_Transactions.Location = new System.Drawing.Point(575, 142);
            this.btn_Transactions.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Transactions.Name = "btn_Transactions";
            this.btn_Transactions.Size = new System.Drawing.Size(195, 50);
            this.btn_Transactions.TabIndex = 23;
            this.btn_Transactions.Text = "View All Transactions";
            this.btn_Transactions.UseVisualStyleBackColor = true;
            this.btn_Transactions.Click += new System.EventHandler(this.btn_Transactions_Click);
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 535);
            this.Controls.Add(this.btn_Transactions);
            this.Controls.Add(this.btn_AllBorrowers);
            this.Controls.Add(this.btn_AllAuthors);
            this.Controls.Add(this.btn_AllBooks);
            this.Controls.Add(this.btn_LateBooks);
            this.Controls.Add(this.btn_CheckedOutBooks);
            this.Controls.Add(this.data_Reports);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Directory";
            this.Text = "Directory";
            this.Load += new System.EventHandler(this.Directory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Reports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data_Reports;
        private System.Windows.Forms.Button btn_CheckedOutBooks;
        private System.Windows.Forms.Button btn_LateBooks;
        private System.Windows.Forms.Button btn_AllBooks;
        private System.Windows.Forms.Button btn_AllBorrowers;
        private System.Windows.Forms.Button btn_AllAuthors;
        private System.Windows.Forms.Button btn_Transactions;
    }
}