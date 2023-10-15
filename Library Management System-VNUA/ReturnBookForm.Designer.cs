namespace Library_Management_System_VNUA
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpDateIssue = new System.Windows.Forms.DateTimePicker();
            this.dateLbl = new System.Windows.Forms.Label();
            this.cbBooks = new System.Windows.Forms.ComboBox();
            this.BookLbl = new System.Windows.Forms.Label();
            this.cbStuID = new System.Windows.Forms.ComboBox();
            this.txtStdPhone = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.txtStdDep = new System.Windows.Forms.TextBox();
            this.usnLbl = new System.Windows.Forms.Label();
            this.DepartmentLbl = new System.Windows.Forms.Label();
            this.txtReturnNum = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.NumLbl = new System.Windows.Forms.Label();
            this.txtStdName = new System.Windows.Forms.TextBox();
            this.dtpDateReturn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.IssueBookDataTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReturnBooksDataTable = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ReturnBookBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssueBookDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBooksDataTable)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1166, 53);
            this.panel1.TabIndex = 3;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Library Management System Return Book";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 573);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 15);
            this.panel2.TabIndex = 22;
            // 
            // dtpDateIssue
            // 
            this.dtpDateIssue.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIssue.Location = new System.Drawing.Point(170, 387);
            this.dtpDateIssue.Name = "dtpDateIssue";
            this.dtpDateIssue.Size = new System.Drawing.Size(215, 31);
            this.dtpDateIssue.TabIndex = 56;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(12, 390);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(56, 22);
            this.dateLbl.TabIndex = 63;
            this.dateLbl.Text = "Date";
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
            this.cbBooks.Location = new System.Drawing.Point(170, 339);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(215, 30);
            this.cbBooks.TabIndex = 55;
            // 
            // BookLbl
            // 
            this.BookLbl.AutoSize = true;
            this.BookLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookLbl.Location = new System.Drawing.Point(12, 344);
            this.BookLbl.Name = "BookLbl";
            this.BookLbl.Size = new System.Drawing.Size(55, 22);
            this.BookLbl.TabIndex = 62;
            this.BookLbl.Text = "Book";
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
            this.cbStuID.Location = new System.Drawing.Point(170, 140);
            this.cbStuID.Name = "cbStuID";
            this.cbStuID.Size = new System.Drawing.Size(215, 30);
            this.cbStuID.TabIndex = 51;
            // 
            // txtStdPhone
            // 
            this.txtStdPhone.BackColor = System.Drawing.Color.White;
            this.txtStdPhone.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStdPhone.ForeColor = System.Drawing.Color.Black;
            this.txtStdPhone.Location = new System.Drawing.Point(170, 291);
            this.txtStdPhone.Name = "txtStdPhone";
            this.txtStdPhone.Size = new System.Drawing.Size(215, 31);
            this.txtStdPhone.TabIndex = 54;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(12, 297);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(69, 22);
            this.phoneLbl.TabIndex = 61;
            this.phoneLbl.Text = "Phone";
            // 
            // txtStdDep
            // 
            this.txtStdDep.BackColor = System.Drawing.Color.White;
            this.txtStdDep.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStdDep.ForeColor = System.Drawing.Color.Black;
            this.txtStdDep.Location = new System.Drawing.Point(170, 237);
            this.txtStdDep.Name = "txtStdDep";
            this.txtStdDep.Size = new System.Drawing.Size(215, 31);
            this.txtStdDep.TabIndex = 53;
            // 
            // usnLbl
            // 
            this.usnLbl.AutoSize = true;
            this.usnLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usnLbl.Location = new System.Drawing.Point(12, 143);
            this.usnLbl.Name = "usnLbl";
            this.usnLbl.Size = new System.Drawing.Size(45, 22);
            this.usnLbl.TabIndex = 57;
            this.usnLbl.Text = "USN";
            // 
            // DepartmentLbl
            // 
            this.DepartmentLbl.AutoSize = true;
            this.DepartmentLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLbl.Location = new System.Drawing.Point(12, 243);
            this.DepartmentLbl.Name = "DepartmentLbl";
            this.DepartmentLbl.Size = new System.Drawing.Size(123, 22);
            this.DepartmentLbl.TabIndex = 60;
            this.DepartmentLbl.Text = "Department";
            // 
            // txtReturnNum
            // 
            this.txtReturnNum.BackColor = System.Drawing.Color.White;
            this.txtReturnNum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnNum.ForeColor = System.Drawing.Color.Black;
            this.txtReturnNum.Location = new System.Drawing.Point(170, 91);
            this.txtReturnNum.Name = "txtReturnNum";
            this.txtReturnNum.Size = new System.Drawing.Size(215, 31);
            this.txtReturnNum.TabIndex = 50;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(12, 194);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(66, 22);
            this.nameLbl.TabIndex = 59;
            this.nameLbl.Text = "Name";
            // 
            // NumLbl
            // 
            this.NumLbl.AutoSize = true;
            this.NumLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumLbl.Location = new System.Drawing.Point(11, 94);
            this.NumLbl.Name = "NumLbl";
            this.NumLbl.Size = new System.Drawing.Size(150, 22);
            this.NumLbl.TabIndex = 58;
            this.NumLbl.Text = "Return Number";
            // 
            // txtStdName
            // 
            this.txtStdName.BackColor = System.Drawing.Color.White;
            this.txtStdName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStdName.ForeColor = System.Drawing.Color.Black;
            this.txtStdName.Location = new System.Drawing.Point(170, 188);
            this.txtStdName.Name = "txtStdName";
            this.txtStdName.Size = new System.Drawing.Size(215, 31);
            this.txtStdName.TabIndex = 52;
            // 
            // dtpDateReturn
            // 
            this.dtpDateReturn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateReturn.Location = new System.Drawing.Point(170, 436);
            this.dtpDateReturn.Name = "dtpDateReturn";
            this.dtpDateReturn.Size = new System.Drawing.Size(215, 31);
            this.dtpDateReturn.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 65;
            this.label2.Text = "Return";
            // 
            // IssueBookDataTable
            // 
            this.IssueBookDataTable.BackgroundColor = System.Drawing.Color.White;
            this.IssueBookDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssueBookDataTable.Location = new System.Drawing.Point(404, 90);
            this.IssueBookDataTable.Name = "IssueBookDataTable";
            this.IssueBookDataTable.Size = new System.Drawing.Size(750, 210);
            this.IssueBookDataTable.TabIndex = 66;
            this.IssueBookDataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IssueBookDataTable_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(738, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 67;
            this.label3.Text = "BOOKS ISSUED";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(738, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 68;
            this.label4.Text = "BOOKS RETURN";
            // 
            // ReturnBooksDataTable
            // 
            this.ReturnBooksDataTable.BackgroundColor = System.Drawing.Color.White;
            this.ReturnBooksDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnBooksDataTable.Location = new System.Drawing.Point(404, 347);
            this.ReturnBooksDataTable.Name = "ReturnBooksDataTable";
            this.ReturnBooksDataTable.Size = new System.Drawing.Size(750, 210);
            this.ReturnBooksDataTable.TabIndex = 69;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(9)))), ((int)(((byte)(104)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(111, 537);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(173, 30);
            this.DeleteBtn.TabIndex = 72;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(43)))), ((int)(((byte)(243)))));
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(212, 489);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(173, 30);
            this.UpdateBtn.TabIndex = 71;
            this.UpdateBtn.Text = "Edit";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // ReturnBookBtn
            // 
            this.ReturnBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(234)))), ((int)(((byte)(136)))));
            this.ReturnBookBtn.FlatAppearance.BorderSize = 0;
            this.ReturnBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnBookBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBookBtn.ForeColor = System.Drawing.Color.White;
            this.ReturnBookBtn.Location = new System.Drawing.Point(12, 489);
            this.ReturnBookBtn.Name = "ReturnBookBtn";
            this.ReturnBookBtn.Size = new System.Drawing.Size(173, 30);
            this.ReturnBookBtn.TabIndex = 70;
            this.ReturnBookBtn.Text = "Return Book";
            this.ReturnBookBtn.UseVisualStyleBackColor = false;
            this.ReturnBookBtn.Click += new System.EventHandler(this.ReturnBookBtn_Click);
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1166, 588);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ReturnBookBtn);
            this.Controls.Add(this.ReturnBooksDataTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IssueBookDataTable);
            this.Controls.Add(this.dtpDateReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDateIssue);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.cbBooks);
            this.Controls.Add(this.BookLbl);
            this.Controls.Add(this.cbStuID);
            this.Controls.Add(this.txtStdPhone);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.txtStdDep);
            this.Controls.Add(this.usnLbl);
            this.Controls.Add(this.DepartmentLbl);
            this.Controls.Add(this.txtReturnNum);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.NumLbl);
            this.Controls.Add(this.txtStdName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IssueBookDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBooksDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpDateIssue;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.ComboBox cbBooks;
        private System.Windows.Forms.Label BookLbl;
        private System.Windows.Forms.ComboBox cbStuID;
        private System.Windows.Forms.TextBox txtStdPhone;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox txtStdDep;
        private System.Windows.Forms.Label usnLbl;
        private System.Windows.Forms.Label DepartmentLbl;
        private System.Windows.Forms.TextBox txtReturnNum;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label NumLbl;
        private System.Windows.Forms.TextBox txtStdName;
        private System.Windows.Forms.DateTimePicker dtpDateReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView IssueBookDataTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ReturnBooksDataTable;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ReturnBookBtn;
    }
}