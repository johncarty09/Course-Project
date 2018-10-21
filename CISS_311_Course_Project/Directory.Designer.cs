namespace CISS_311_Course_Project
{
    partial class Directory
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.data_Bookinfo = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Bookinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(185, 31);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(270, 20);
            this.txt_ISBN.TabIndex = 1;
            this.txt_ISBN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(185, 115);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(185, 73);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(270, 20);
            this.txt_Title.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Title";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(355, 115);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(100, 20);
            this.txt_LastName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name";
            // 
            // data_Bookinfo
            // 
            this.data_Bookinfo.AllowUserToAddRows = false;
            this.data_Bookinfo.AllowUserToDeleteRows = false;
            this.data_Bookinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Bookinfo.Location = new System.Drawing.Point(25, 161);
            this.data_Bookinfo.Name = "data_Bookinfo";
            this.data_Bookinfo.ReadOnly = true;
            this.data_Bookinfo.Size = new System.Drawing.Size(540, 150);
            this.data_Bookinfo.TabIndex = 8;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(25, 330);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(146, 41);
            this.btn_Search.TabIndex = 22;
            this.btn_Search.Text = "&Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(419, 330);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(146, 41);
            this.btn_exit.TabIndex = 23;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 392);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.data_Bookinfo);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.label1);
            this.Name = "Directory";
            this.Text = "Directory";
            ((System.ComponentModel.ISupportInitialize)(this.data_Bookinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView data_Bookinfo;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_exit;
    }
}