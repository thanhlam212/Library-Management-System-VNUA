namespace Library_Management_System_VNUA
{
    partial class LibrariansForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrariansForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StudentsDataTable = new System.Windows.Forms.DataGridView();
            this.librariansTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLibraryDBDataSet = new Library_Management_System_VNUA.eLibraryDBDataSet();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddStudentsBtn = new System.Windows.Forms.Button();
            this.LibName = new System.Windows.Forms.TextBox();
            this.LibPhone = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.LibID = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.LibPass = new System.Windows.Forms.TextBox();
            this.librariansTblTableAdapter = new Library_Management_System_VNUA.eLibraryDBDataSetTableAdapters.LibrariansTblTableAdapter();
            this.libIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librariansTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLibraryDBDataSet)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1058, 53);
            this.panel1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Library Management System Librarians";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 15);
            this.panel2.TabIndex = 21;
            // 
            // StudentsDataTable
            // 
            this.StudentsDataTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.StudentsDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StudentsDataTable.AutoGenerateColumns = false;
            this.StudentsDataTable.BackgroundColor = System.Drawing.Color.White;
            this.StudentsDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentsDataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudentsDataTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.StudentsDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.libIDDataGridViewTextBoxColumn,
            this.libNameDataGridViewTextBoxColumn,
            this.libPasswordDataGridViewTextBoxColumn,
            this.libPhoneDataGridViewTextBoxColumn});
            this.StudentsDataTable.DataSource = this.librariansTblBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentsDataTable.DefaultCellStyle = dataGridViewCellStyle7;
            this.StudentsDataTable.Location = new System.Drawing.Point(453, 65);
            this.StudentsDataTable.Name = "StudentsDataTable";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.StudentsDataTable.Size = new System.Drawing.Size(593, 441);
            this.StudentsDataTable.TabIndex = 43;
            this.StudentsDataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDataTable_CellContentClick);
            // 
            // librariansTblBindingSource
            // 
            this.librariansTblBindingSource.DataMember = "LibrariansTbl";
            this.librariansTblBindingSource.DataSource = this.eLibraryDBDataSet;
            // 
            // eLibraryDBDataSet
            // 
            this.eLibraryDBDataSet.DataSetName = "eLibraryDBDataSet";
            this.eLibraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(9)))), ((int)(((byte)(104)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(136, 392);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(173, 30);
            this.DeleteBtn.TabIndex = 42;
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
            this.UpdateBtn.Location = new System.Drawing.Point(238, 346);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(173, 30);
            this.UpdateBtn.TabIndex = 41;
            this.UpdateBtn.Text = "Edit";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddStudentsBtn
            // 
            this.AddStudentsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(234)))), ((int)(((byte)(136)))));
            this.AddStudentsBtn.FlatAppearance.BorderSize = 0;
            this.AddStudentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentsBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentsBtn.ForeColor = System.Drawing.Color.White;
            this.AddStudentsBtn.Location = new System.Drawing.Point(40, 346);
            this.AddStudentsBtn.Name = "AddStudentsBtn";
            this.AddStudentsBtn.Size = new System.Drawing.Size(173, 30);
            this.AddStudentsBtn.TabIndex = 40;
            this.AddStudentsBtn.Text = "Add";
            this.AddStudentsBtn.UseVisualStyleBackColor = false;
            this.AddStudentsBtn.Click += new System.EventHandler(this.AddStudentsBtn_Click);
            // 
            // LibName
            // 
            this.LibName.BackColor = System.Drawing.Color.White;
            this.LibName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibName.ForeColor = System.Drawing.Color.Black;
            this.LibName.Location = new System.Drawing.Point(158, 171);
            this.LibName.Name = "LibName";
            this.LibName.Size = new System.Drawing.Size(215, 31);
            this.LibName.TabIndex = 32;
            // 
            // LibPhone
            // 
            this.LibPhone.BackColor = System.Drawing.Color.White;
            this.LibPhone.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibPhone.ForeColor = System.Drawing.Color.Black;
            this.LibPhone.Location = new System.Drawing.Point(158, 271);
            this.LibPhone.Name = "LibPhone";
            this.LibPhone.Size = new System.Drawing.Size(215, 31);
            this.LibPhone.TabIndex = 39;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(36, 174);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(66, 22);
            this.nameLbl.TabIndex = 33;
            this.nameLbl.Text = "Name";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(36, 274);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(69, 22);
            this.phoneLbl.TabIndex = 38;
            this.phoneLbl.Text = "Phone";
            // 
            // LibID
            // 
            this.LibID.BackColor = System.Drawing.Color.White;
            this.LibID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibID.ForeColor = System.Drawing.Color.Black;
            this.LibID.Location = new System.Drawing.Point(158, 125);
            this.LibID.Name = "LibID";
            this.LibID.Size = new System.Drawing.Size(215, 31);
            this.LibID.TabIndex = 34;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(36, 225);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(95, 22);
            this.passwordLbl.TabIndex = 37;
            this.passwordLbl.Text = "Password";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLbl.Location = new System.Drawing.Point(36, 128);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(29, 22);
            this.IdLbl.TabIndex = 35;
            this.IdLbl.Text = "ID";
            // 
            // LibPass
            // 
            this.LibPass.BackColor = System.Drawing.Color.White;
            this.LibPass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibPass.ForeColor = System.Drawing.Color.Black;
            this.LibPass.Location = new System.Drawing.Point(158, 222);
            this.LibPass.Name = "LibPass";
            this.LibPass.Size = new System.Drawing.Size(215, 31);
            this.LibPass.TabIndex = 36;
            // 
            // librariansTblTableAdapter
            // 
            this.librariansTblTableAdapter.ClearBeforeFill = true;
            // 
            // libIDDataGridViewTextBoxColumn
            // 
            this.libIDDataGridViewTextBoxColumn.DataPropertyName = "LibID";
            this.libIDDataGridViewTextBoxColumn.HeaderText = "LibID";
            this.libIDDataGridViewTextBoxColumn.Name = "libIDDataGridViewTextBoxColumn";
            this.libIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // libNameDataGridViewTextBoxColumn
            // 
            this.libNameDataGridViewTextBoxColumn.DataPropertyName = "LibName";
            this.libNameDataGridViewTextBoxColumn.HeaderText = "LibName";
            this.libNameDataGridViewTextBoxColumn.Name = "libNameDataGridViewTextBoxColumn";
            this.libNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // libPasswordDataGridViewTextBoxColumn
            // 
            this.libPasswordDataGridViewTextBoxColumn.DataPropertyName = "LibPassword";
            this.libPasswordDataGridViewTextBoxColumn.HeaderText = "LibPassword";
            this.libPasswordDataGridViewTextBoxColumn.Name = "libPasswordDataGridViewTextBoxColumn";
            this.libPasswordDataGridViewTextBoxColumn.Width = 140;
            // 
            // libPhoneDataGridViewTextBoxColumn
            // 
            this.libPhoneDataGridViewTextBoxColumn.DataPropertyName = "LibPhone";
            this.libPhoneDataGridViewTextBoxColumn.HeaderText = "LibPhone";
            this.libPhoneDataGridViewTextBoxColumn.Name = "libPhoneDataGridViewTextBoxColumn";
            this.libPhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // LibrariansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 527);
            this.Controls.Add(this.StudentsDataTable);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddStudentsBtn);
            this.Controls.Add(this.LibName);
            this.Controls.Add(this.LibPhone);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.LibID);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.LibPass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibrariansForm";
            this.Text = "Librarians";
            this.Load += new System.EventHandler(this.LibrariansForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librariansTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLibraryDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView StudentsDataTable;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddStudentsBtn;
        private System.Windows.Forms.TextBox LibName;
        private System.Windows.Forms.TextBox LibPhone;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox LibID;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.TextBox LibPass;
        private eLibraryDBDataSet eLibraryDBDataSet;
        private System.Windows.Forms.BindingSource librariansTblBindingSource;
        private eLibraryDBDataSetTableAdapters.LibrariansTblTableAdapter librariansTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn libIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libPhoneDataGridViewTextBoxColumn;
    }
}