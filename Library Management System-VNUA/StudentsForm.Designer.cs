namespace Library_Management_System_VNUA
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.StudentsName = new System.Windows.Forms.Label();
            this.tbStuName = new System.Windows.Forms.TextBox();
            this.Usn = new System.Windows.Forms.Label();
            this.tbUsn = new System.Windows.Forms.TextBox();
            this.DepartmaentLbl = new System.Windows.Forms.Label();
            this.tbDep = new System.Windows.Forms.TextBox();
            this.SemesterLbl = new System.Windows.Forms.Label();
            this.cbSem = new System.Windows.Forms.ComboBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.tbPhoneNo = new System.Windows.Forms.TextBox();
            this.AddStudentsBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.StudentsDataTable = new System.Windows.Forms.DataGridView();
            this.stdIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdDepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdSemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLibraryDBDataSet1 = new Library_Management_System_VNUA.eLibraryDBDataSet1();
            this.BackHomeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eLibraryDBDataSet = new Library_Management_System_VNUA.eLibraryDBDataSet();
            this.eLibraryDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTblTableAdapter = new Library_Management_System_VNUA.eLibraryDBDataSet1TableAdapters.StudentsTblTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLibraryDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLibraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLibraryDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.QuitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 53);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(259, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(531, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-Library Management System Students";
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuitBtn.BackgroundImage")));
            this.QuitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuitBtn.FlatAppearance.BorderSize = 0;
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.QuitBtn.Location = new System.Drawing.Point(999, 9);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(47, 33);
            this.QuitBtn.TabIndex = 2;
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // StudentsName
            // 
            this.StudentsName.AutoSize = true;
            this.StudentsName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsName.Location = new System.Drawing.Point(26, 185);
            this.StudentsName.Name = "StudentsName";
            this.StudentsName.Size = new System.Drawing.Size(143, 22);
            this.StudentsName.TabIndex = 4;
            this.StudentsName.Text = "Student Name";
            // 
            // tbStuName
            // 
            this.tbStuName.BackColor = System.Drawing.Color.White;
            this.tbStuName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStuName.ForeColor = System.Drawing.Color.Black;
            this.tbStuName.Location = new System.Drawing.Point(175, 182);
            this.tbStuName.Name = "tbStuName";
            this.tbStuName.Size = new System.Drawing.Size(215, 31);
            this.tbStuName.TabIndex = 3;
            // 
            // Usn
            // 
            this.Usn.AutoSize = true;
            this.Usn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usn.Location = new System.Drawing.Point(26, 139);
            this.Usn.Name = "Usn";
            this.Usn.Size = new System.Drawing.Size(41, 22);
            this.Usn.TabIndex = 6;
            this.Usn.Text = "Usn";
            // 
            // tbUsn
            // 
            this.tbUsn.BackColor = System.Drawing.Color.White;
            this.tbUsn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsn.ForeColor = System.Drawing.Color.Black;
            this.tbUsn.Location = new System.Drawing.Point(175, 136);
            this.tbUsn.Name = "tbUsn";
            this.tbUsn.Size = new System.Drawing.Size(215, 31);
            this.tbUsn.TabIndex = 5;
            // 
            // DepartmaentLbl
            // 
            this.DepartmaentLbl.AutoSize = true;
            this.DepartmaentLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmaentLbl.Location = new System.Drawing.Point(26, 236);
            this.DepartmaentLbl.Name = "DepartmaentLbl";
            this.DepartmaentLbl.Size = new System.Drawing.Size(123, 22);
            this.DepartmaentLbl.TabIndex = 8;
            this.DepartmaentLbl.Text = "Department";
            // 
            // tbDep
            // 
            this.tbDep.BackColor = System.Drawing.Color.White;
            this.tbDep.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDep.ForeColor = System.Drawing.Color.Black;
            this.tbDep.Location = new System.Drawing.Point(175, 233);
            this.tbDep.Name = "tbDep";
            this.tbDep.Size = new System.Drawing.Size(215, 31);
            this.tbDep.TabIndex = 7;
            // 
            // SemesterLbl
            // 
            this.SemesterLbl.AutoSize = true;
            this.SemesterLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterLbl.Location = new System.Drawing.Point(26, 284);
            this.SemesterLbl.Name = "SemesterLbl";
            this.SemesterLbl.Size = new System.Drawing.Size(92, 22);
            this.SemesterLbl.TabIndex = 10;
            this.SemesterLbl.Text = "Semester";
            // 
            // cbSem
            // 
            this.cbSem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSem.FormattingEnabled = true;
            this.cbSem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbSem.Location = new System.Drawing.Point(175, 284);
            this.cbSem.Name = "cbSem";
            this.cbSem.Size = new System.Drawing.Size(215, 30);
            this.cbSem.TabIndex = 11;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(26, 336);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(100, 22);
            this.phoneLbl.TabIndex = 12;
            this.phoneLbl.Text = "Phone No";
            // 
            // tbPhoneNo
            // 
            this.tbPhoneNo.BackColor = System.Drawing.Color.White;
            this.tbPhoneNo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNo.ForeColor = System.Drawing.Color.Black;
            this.tbPhoneNo.Location = new System.Drawing.Point(175, 333);
            this.tbPhoneNo.Name = "tbPhoneNo";
            this.tbPhoneNo.Size = new System.Drawing.Size(215, 31);
            this.tbPhoneNo.TabIndex = 13;
            // 
            // AddStudentsBtn
            // 
            this.AddStudentsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(234)))), ((int)(((byte)(136)))));
            this.AddStudentsBtn.FlatAppearance.BorderSize = 0;
            this.AddStudentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentsBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentsBtn.ForeColor = System.Drawing.Color.White;
            this.AddStudentsBtn.Location = new System.Drawing.Point(30, 440);
            this.AddStudentsBtn.Name = "AddStudentsBtn";
            this.AddStudentsBtn.Size = new System.Drawing.Size(173, 30);
            this.AddStudentsBtn.TabIndex = 14;
            this.AddStudentsBtn.Text = "Add";
            this.AddStudentsBtn.UseVisualStyleBackColor = false;
            this.AddStudentsBtn.Click += new System.EventHandler(this.AddStudentsBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(43)))), ((int)(((byte)(243)))));
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(235, 440);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(173, 30);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "Edit";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(9)))), ((int)(((byte)(104)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(428, 440);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(173, 30);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // StudentsDataTable
            // 
            this.StudentsDataTable.AutoGenerateColumns = false;
            this.StudentsDataTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentsDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdIDDataGridViewTextBoxColumn,
            this.stdNameDataGridViewTextBoxColumn,
            this.stdDepDataGridViewTextBoxColumn,
            this.stdSemDataGridViewTextBoxColumn,
            this.stdPhoneDataGridViewTextBoxColumn});
            this.StudentsDataTable.DataSource = this.studentsTblBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentsDataTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentsDataTable.Location = new System.Drawing.Point(461, 76);
            this.StudentsDataTable.Name = "StudentsDataTable";
            this.StudentsDataTable.Size = new System.Drawing.Size(563, 338);
            this.StudentsDataTable.TabIndex = 17;
            this.StudentsDataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDataTable_CellContentClick);
            // 
            // stdIDDataGridViewTextBoxColumn
            // 
            this.stdIDDataGridViewTextBoxColumn.DataPropertyName = "StdID";
            this.stdIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.stdIDDataGridViewTextBoxColumn.Name = "stdIDDataGridViewTextBoxColumn";
            // 
            // stdNameDataGridViewTextBoxColumn
            // 
            this.stdNameDataGridViewTextBoxColumn.DataPropertyName = "StdName";
            this.stdNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.stdNameDataGridViewTextBoxColumn.Name = "stdNameDataGridViewTextBoxColumn";
            this.stdNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // stdDepDataGridViewTextBoxColumn
            // 
            this.stdDepDataGridViewTextBoxColumn.DataPropertyName = "StdDep";
            this.stdDepDataGridViewTextBoxColumn.HeaderText = "Depaertment";
            this.stdDepDataGridViewTextBoxColumn.Name = "stdDepDataGridViewTextBoxColumn";
            // 
            // stdSemDataGridViewTextBoxColumn
            // 
            this.stdSemDataGridViewTextBoxColumn.DataPropertyName = "StdSem";
            this.stdSemDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.stdSemDataGridViewTextBoxColumn.Name = "stdSemDataGridViewTextBoxColumn";
            // 
            // stdPhoneDataGridViewTextBoxColumn
            // 
            this.stdPhoneDataGridViewTextBoxColumn.DataPropertyName = "StdPhone";
            this.stdPhoneDataGridViewTextBoxColumn.HeaderText = "Phone No ";
            this.stdPhoneDataGridViewTextBoxColumn.Name = "stdPhoneDataGridViewTextBoxColumn";
            // 
            // studentsTblBindingSource
            // 
            this.studentsTblBindingSource.DataMember = "StudentsTbl";
            this.studentsTblBindingSource.DataSource = this.eLibraryDBDataSet1;
            // 
            // eLibraryDBDataSet1
            // 
            this.eLibraryDBDataSet1.DataSetName = "eLibraryDBDataSet1";
            this.eLibraryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.BackHomeBtn.Location = new System.Drawing.Point(891, 476);
            this.BackHomeBtn.Name = "BackHomeBtn";
            this.BackHomeBtn.Size = new System.Drawing.Size(133, 30);
            this.BackHomeBtn.TabIndex = 18;
            this.BackHomeBtn.Text = "Back Home";
            this.BackHomeBtn.UseVisualStyleBackColor = false;
            this.BackHomeBtn.Click += new System.EventHandler(this.BackHomeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 15);
            this.panel2.TabIndex = 19;
            // 
            // eLibraryDBDataSet
            // 
            this.eLibraryDBDataSet.DataSetName = "eLibraryDBDataSet";
            this.eLibraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eLibraryDBDataSetBindingSource
            // 
            this.eLibraryDBDataSetBindingSource.DataSource = this.eLibraryDBDataSet;
            this.eLibraryDBDataSetBindingSource.Position = 0;
            // 
            // studentsTblTableAdapter
            // 
            this.studentsTblTableAdapter.ClearBeforeFill = true;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BackHomeBtn);
            this.Controls.Add(this.StudentsDataTable);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddStudentsBtn);
            this.Controls.Add(this.tbPhoneNo);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.cbSem);
            this.Controls.Add(this.SemesterLbl);
            this.Controls.Add(this.DepartmaentLbl);
            this.Controls.Add(this.tbDep);
            this.Controls.Add(this.Usn);
            this.Controls.Add(this.tbUsn);
            this.Controls.Add(this.StudentsName);
            this.Controls.Add(this.tbStuName);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentsForm";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLibraryDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLibraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLibraryDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label StudentsName;
        private System.Windows.Forms.TextBox tbStuName;
        private System.Windows.Forms.Label Usn;
        private System.Windows.Forms.TextBox tbUsn;
        private System.Windows.Forms.Label DepartmaentLbl;
        private System.Windows.Forms.TextBox tbDep;
        private System.Windows.Forms.Label SemesterLbl;
        private System.Windows.Forms.ComboBox cbSem;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox tbPhoneNo;
        private System.Windows.Forms.Button AddStudentsBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView StudentsDataTable;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button BackHomeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource eLibraryDBDataSetBindingSource;
        private eLibraryDBDataSet eLibraryDBDataSet;
        private eLibraryDBDataSet1 eLibraryDBDataSet1;
        private System.Windows.Forms.BindingSource studentsTblBindingSource;
        private eLibraryDBDataSet1TableAdapters.StudentsTblTableAdapter studentsTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdDepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdSemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdPhoneDataGridViewTextBoxColumn;
    }
}