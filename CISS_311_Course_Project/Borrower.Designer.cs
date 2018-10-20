namespace CISS_311_Course_Project
{
    partial class Borrower
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn_addBorrower = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.cbox_Type = new System.Windows.Forms.ComboBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.data_Borrowers = new System.Windows.Forms.DataGridView();
            this.libraryDBDataSet = new CISS_311_Course_Project.LibraryDBDataSet();
            this.libraryDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Borrowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(572, 261);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 50);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(295, 261);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 50);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn_addBorrower
            // 
            this.btn_addBorrower.Location = new System.Drawing.Point(23, 261);
            this.btn_addBorrower.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addBorrower.Name = "btn_addBorrower";
            this.btn_addBorrower.Size = new System.Drawing.Size(133, 50);
            this.btn_addBorrower.TabIndex = 14;
            this.btn_addBorrower.Text = "Add Member";
            this.btn_addBorrower.UseVisualStyleBackColor = true;
            this.btn_addBorrower.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 462);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Type);
            this.groupBox1.Controls.Add(this.cbox_Type);
            this.groupBox1.Controls.Add(this.txt_lastName);
            this.groupBox1.Controls.Add(this.txt_firstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(19, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(689, 235);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Details";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Location = new System.Drawing.Point(8, 82);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(40, 17);
            this.lbl_Type.TabIndex = 11;
            this.lbl_Type.Text = "Type";
            this.lbl_Type.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbox_Type
            // 
            this.cbox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Type.FormattingEnabled = true;
            this.cbox_Type.Items.AddRange(new object[] {
            "S",
            "F"});
            this.cbox_Type.Location = new System.Drawing.Point(92, 75);
            this.cbox_Type.Name = "cbox_Type";
            this.cbox_Type.Size = new System.Drawing.Size(121, 24);
            this.cbox_Type.TabIndex = 10;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(429, 33);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(247, 22);
            this.txt_lastName.TabIndex = 9;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(92, 33);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(247, 22);
            this.txt_firstName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // data_Borrowers
            // 
            this.data_Borrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Borrowers.Location = new System.Drawing.Point(23, 329);
            this.data_Borrowers.Name = "data_Borrowers";
            this.data_Borrowers.RowTemplate.Height = 24;
            this.data_Borrowers.Size = new System.Drawing.Size(685, 150);
            this.data_Borrowers.TabIndex = 17;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryDBDataSetBindingSource
            // 
            this.libraryDBDataSetBindingSource.DataSource = this.libraryDBDataSet;
            this.libraryDBDataSetBindingSource.Position = 0;
            // 
            // Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 490);
            this.Controls.Add(this.data_Borrowers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn_addBorrower);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Borrower";
            this.Text = "New Member";
            this.Load += new System.EventHandler(this.Borrower_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Borrowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn_addBorrower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.ComboBox cbox_Type;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.DataGridView data_Borrowers;
        private System.Windows.Forms.BindingSource libraryDBDataSetBindingSource;
        private LibraryDBDataSet libraryDBDataSet;
    }
}