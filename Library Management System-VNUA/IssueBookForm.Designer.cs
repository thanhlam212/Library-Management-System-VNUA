namespace Library_Management_System_VNUA
{
    partial class IssueBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBookForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtStdPhone = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.IssueBookDataTable = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddIssueBookBtn = new System.Windows.Forms.Button();
            this.txtStdDep = new System.Windows.Forms.TextBox();
            this.usnLbl = new System.Windows.Forms.Label();
            this.DepartmentLbl = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.NumLbl = new System.Windows.Forms.Label();
            this.txtStdName = new System.Windows.Forms.TextBox();
            this.cbStuID = new System.Windows.Forms.ComboBox();
            this.BookLbl = new System.Windows.Forms.Label();
            this.cbBooks = new System.Windows.Forms.ComboBox();
            this.dateLbl = new System.Windows.Forms.Label();
            this.dtpDateIssue = new System.Windows.Forms.DateTimePicker();
            this.BackHomeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssueBookDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.QuitBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 53);
            this.panel1.TabIndex = 2;
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuitBtn.BackgroundImage")));
            this.QuitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuitBtn.FlatAppearance.BorderSize = 0;
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.QuitBtn.Location = new System.Drawing.Point(1179, 9);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(47, 33);
            this.QuitBtn.TabIndex = 0;
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Library Management System Issue Books\r\n\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 15);
            this.panel2.TabIndex = 22;
            // 
            // txtStdPhone
            // 
            this.txtStdPhone.BackColor = System.Drawing.Color.White;
            this.txtStdPhone.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStdPhone.ForeColor = System.Drawing.Color.Black;
            this.txtStdPhone.Location = new System.Drawing.Point(168, 295);
            this.txtStdPhone.Name = "txtStdPhone";
            this.txtStdPhone.Size = new System.Drawing.Size(215, 31);
            this.txtStdPhone.TabIndex = 4;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(18, 304);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(69, 22);
            this.phoneLbl.TabIndex = 44;
            this.phoneLbl.Text = "Phone";
            // 
            // IssueBookDataTable
            // 
            this.IssueBookDataTable.BackgroundColor = System.Drawing.Color.White;
            this.IssueBookDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssueBookDataTable.Location = new System.Drawing.Point(453, 65);
            this.IssueBookDataTable.Name = "IssueBookDataTable";
            this.IssueBookDataTable.Size = new System.Drawing.Size(750, 363);
            this.IssueBookDataTable.TabIndex = 43;
            this.IssueBookDataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IssueBookDataTable_CellClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(9)))), ((int)(((byte)(104)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(210, 457);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(173, 30);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(43)))), ((int)(((byte)(243)))));
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(399, 457);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(173, 30);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "Print";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // AddIssueBookBtn
            // 
            this.AddIssueBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(234)))), ((int)(((byte)(136)))));
            this.AddIssueBookBtn.FlatAppearance.BorderSize = 0;
            this.AddIssueBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddIssueBookBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIssueBookBtn.ForeColor = System.Drawing.Color.White;
            this.AddIssueBookBtn.Location = new System.Drawing.Point(22, 457);
            this.AddIssueBookBtn.Name = "AddIssueBookBtn";
            this.AddIssueBookBtn.Size = new System.Drawing.Size(173, 30);
            this.AddIssueBookBtn.TabIndex = 7;
            this.AddIssueBookBtn.Text = "Issue Book";
            this.AddIssueBookBtn.UseVisualStyleBackColor = false;
            this.AddIssueBookBtn.Click += new System.EventHandler(this.AddIssueBookBtn_Click);
            // 
            // txtStdDep
            // 
            this.txtStdDep.BackColor = System.Drawing.Color.White;
            this.txtStdDep.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStdDep.ForeColor = System.Drawing.Color.Black;
            this.txtStdDep.Location = new System.Drawing.Point(168, 241);
            this.txtStdDep.Name = "txtStdDep";
            this.txtStdDep.Size = new System.Drawing.Size(215, 31);
            this.txtStdDep.TabIndex = 3;
            // 
            // usnLbl
            // 
            this.usnLbl.AutoSize = true;
            this.usnLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usnLbl.Location = new System.Drawing.Point(18, 150);
            this.usnLbl.Name = "usnLbl";
            this.usnLbl.Size = new System.Drawing.Size(45, 22);
            this.usnLbl.TabIndex = 33;
            this.usnLbl.Text = "USN";
            // 
            // DepartmentLbl
            // 
            this.DepartmentLbl.AutoSize = true;
            this.DepartmentLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLbl.Location = new System.Drawing.Point(18, 250);
            this.DepartmentLbl.Name = "DepartmentLbl";
            this.DepartmentLbl.Size = new System.Drawing.Size(123, 22);
            this.DepartmentLbl.TabIndex = 38;
            this.DepartmentLbl.Text = "Department";
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.White;
            this.txtNum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.ForeColor = System.Drawing.Color.Black;
            this.txtNum.Location = new System.Drawing.Point(168, 95);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(215, 31);
            this.txtNum.TabIndex = 0;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(18, 201);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(66, 22);
            this.nameLbl.TabIndex = 37;
            this.nameLbl.Text = "Name";
            // 
            // NumLbl
            // 
            this.NumLbl.AutoSize = true;
            this.NumLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumLbl.Location = new System.Drawing.Point(18, 98);
            this.NumLbl.Name = "NumLbl";
            this.NumLbl.Size = new System.Drawing.Size(132, 22);
            this.NumLbl.TabIndex = 35;
            this.NumLbl.Text = "Issue Number";
            // 
            // txtStdName
            // 
            this.txtStdName.BackColor = System.Drawing.Color.White;
            this.txtStdName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStdName.ForeColor = System.Drawing.Color.Black;
            this.txtStdName.Location = new System.Drawing.Point(168, 192);
            this.txtStdName.Name = "txtStdName";
            this.txtStdName.Size = new System.Drawing.Size(215, 31);
            this.txtStdName.TabIndex = 2;
            // 
            // cbStuID
            // 
            this.cbStuID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStuID.FormattingEnabled = true;
            this.cbStuID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbStuID.Location = new System.Drawing.Point(168, 144);
            this.cbStuID.Name = "cbStuID";
            this.cbStuID.Size = new System.Drawing.Size(215, 30);
            this.cbStuID.TabIndex = 1;
            this.cbStuID.SelectionChangeCommitted += new System.EventHandler(this.cbStuID_SelectionChangeCommitted);
            // 
            // BookLbl
            // 
            this.BookLbl.AutoSize = true;
            this.BookLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookLbl.Location = new System.Drawing.Point(18, 351);
            this.BookLbl.Name = "BookLbl";
            this.BookLbl.Size = new System.Drawing.Size(55, 22);
            this.BookLbl.TabIndex = 47;
            this.BookLbl.Text = "Book";
            // 
            // cbBooks
            // 
            this.cbBooks.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBooks.FormattingEnabled = true;
            this.cbBooks.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbBooks.Location = new System.Drawing.Point(168, 343);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(215, 30);
            this.cbBooks.TabIndex = 5;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(18, 397);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(56, 22);
            this.dateLbl.TabIndex = 49;
            this.dateLbl.Text = "Date";
            // 
            // dtpDateIssue
            // 
            this.dtpDateIssue.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIssue.Location = new System.Drawing.Point(168, 391);
            this.dtpDateIssue.Name = "dtpDateIssue";
            this.dtpDateIssue.Size = new System.Drawing.Size(215, 31);
            this.dtpDateIssue.TabIndex = 6;
            // 
            // BackHomeBtn
            // 
            this.BackHomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackHomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackHomeBtn.FlatAppearance.BorderSize = 0;
            this.BackHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackHomeBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackHomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackHomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackHomeBtn.Location = new System.Drawing.Point(1093, 476);
            this.BackHomeBtn.Name = "BackHomeBtn";
            this.BackHomeBtn.Size = new System.Drawing.Size(133, 30);
            this.BackHomeBtn.TabIndex = 10;
            this.BackHomeBtn.Text = "Back Home";
            this.BackHomeBtn.UseVisualStyleBackColor = false;
            this.BackHomeBtn.Click += new System.EventHandler(this.BackHomeBtn_Click);
            // 
            // IssueBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 527);
            this.Controls.Add(this.BackHomeBtn);
            this.Controls.Add(this.dtpDateIssue);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.cbBooks);
            this.Controls.Add(this.BookLbl);
            this.Controls.Add(this.cbStuID);
            this.Controls.Add(this.txtStdPhone);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.IssueBookDataTable);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddIssueBookBtn);
            this.Controls.Add(this.txtStdDep);
            this.Controls.Add(this.usnLbl);
            this.Controls.Add(this.DepartmentLbl);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.NumLbl);
            this.Controls.Add(this.txtStdName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBook";
            this.Load += new System.EventHandler(this.IssueBookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssueBookDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtStdPhone;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.DataGridView IssueBookDataTable;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddIssueBookBtn;
        private System.Windows.Forms.TextBox txtStdDep;
        private System.Windows.Forms.Label usnLbl;
        private System.Windows.Forms.Label DepartmentLbl;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label NumLbl;
        private System.Windows.Forms.TextBox txtStdName;
        private System.Windows.Forms.ComboBox cbStuID;
        private System.Windows.Forms.Label BookLbl;
        private System.Windows.Forms.ComboBox cbBooks;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.DateTimePicker dtpDateIssue;
        private System.Windows.Forms.Button BackHomeBtn;
    }
}