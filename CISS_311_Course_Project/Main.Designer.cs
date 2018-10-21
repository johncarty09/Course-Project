namespace CISS_311_Course_Project
{
    partial class mainForm
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_CheckInOut = new System.Windows.Forms.Button();
            this.btn_AddAuthor = new System.Windows.Forms.Button();
            this.btn_BookSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Library management System";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(6, 35);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(149, 88);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Add New &Book";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 158);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(149, 88);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "&Reporting";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(206, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 88);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(356, 35);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(149, 88);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "Add New &Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_BookSearch);
            this.groupBox1.Controls.Add(this.btn_CheckInOut);
            this.groupBox1.Controls.Add(this.btn_AddAuthor);
            this.groupBox1.Controls.Add(this.btnAddMember);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Location = new System.Drawing.Point(25, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 265);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click and option to proceed";
            // 
            // btn_CheckInOut
            // 
            this.btn_CheckInOut.Location = new System.Drawing.Point(181, 158);
            this.btn_CheckInOut.Name = "btn_CheckInOut";
            this.btn_CheckInOut.Size = new System.Drawing.Size(149, 88);
            this.btn_CheckInOut.TabIndex = 6;
            this.btn_CheckInOut.Text = "Book &Check In/Out";
            this.btn_CheckInOut.UseVisualStyleBackColor = true;
            this.btn_CheckInOut.Click += new System.EventHandler(this.btn_CheckInOut_Click);
            // 
            // btn_AddAuthor
            // 
            this.btn_AddAuthor.Location = new System.Drawing.Point(181, 35);
            this.btn_AddAuthor.Name = "btn_AddAuthor";
            this.btn_AddAuthor.Size = new System.Drawing.Size(149, 88);
            this.btn_AddAuthor.TabIndex = 5;
            this.btn_AddAuthor.Text = "Add New &Author";
            this.btn_AddAuthor.UseVisualStyleBackColor = true;
            this.btn_AddAuthor.Click += new System.EventHandler(this.btn_AddAuthor_Click);
            // 
            // btn_BookSearch
            // 
            this.btn_BookSearch.Location = new System.Drawing.Point(356, 158);
            this.btn_BookSearch.Name = "btn_BookSearch";
            this.btn_BookSearch.Size = new System.Drawing.Size(149, 88);
            this.btn_BookSearch.TabIndex = 7;
            this.btn_BookSearch.Text = "&Directory";
            this.btn_BookSearch.UseVisualStyleBackColor = true;
            this.btn_BookSearch.Click += new System.EventHandler(this.btn_BookSearch_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Name = "mainForm";
            this.Text = "Library Management System";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddAuthor;
        private System.Windows.Forms.Button btn_CheckInOut;
        private System.Windows.Forms.Button btn_BookSearch;
    }
}

