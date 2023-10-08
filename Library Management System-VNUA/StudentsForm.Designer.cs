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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentsName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Usn = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DepartmaentLbl = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SemesterLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.AddStudentsBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.StudentsDataTable = new System.Windows.Forms.DataGridView();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.BackHomeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataTable)).BeginInit();
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
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Library Management System Students";
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(175, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 31);
            this.textBox1.TabIndex = 3;
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
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(175, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 31);
            this.textBox2.TabIndex = 5;
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
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(175, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 31);
            this.textBox3.TabIndex = 7;
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
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(175, 284);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 30);
            this.comboBox1.TabIndex = 11;
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
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(175, 333);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(215, 31);
            this.textBox4.TabIndex = 13;
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
            // 
            // StudentsDataTable
            // 
            this.StudentsDataTable.BackgroundColor = System.Drawing.Color.White;
            this.StudentsDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataTable.Location = new System.Drawing.Point(461, 76);
            this.StudentsDataTable.Name = "StudentsDataTable";
            this.StudentsDataTable.Size = new System.Drawing.Size(563, 338);
            this.StudentsDataTable.TabIndex = 17;
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
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(127)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1058, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BackHomeBtn);
            this.Controls.Add(this.StudentsDataTable);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddStudentsBtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SemesterLbl);
            this.Controls.Add(this.DepartmaentLbl);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Usn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.StudentsName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StudentsName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Usn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label DepartmaentLbl;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label SemesterLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button AddStudentsBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView StudentsDataTable;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button BackHomeBtn;
        private System.Windows.Forms.Panel panel2;
    }
}