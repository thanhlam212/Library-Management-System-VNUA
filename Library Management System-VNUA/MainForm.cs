﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_VNUA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StudentsBtn_Click(object sender, EventArgs e)
        {
            StudentsForm students = new StudentsForm();
            students.Show();
            this.Hide();
        }

        private void BooksBtn_Click(object sender, EventArgs e)
        {
            BookTbl bookTbl = new BookTbl();
            bookTbl.Show();
            this.Hide();
        }

        private void IssueBooksBtn_Click(object sender, EventArgs e)
        {
            IssueBookForm issueBookForm = new IssueBookForm();  
            issueBookForm.Show();
            this.Hide();
        }

        private void ReturnBooksBtn_Click(object sender, EventArgs e)
        {

        }

        private void LibrariansBtn_Click(object sender, EventArgs e)
        {
            LibrariansForm librariansForm = new LibrariansForm();
            librariansForm.Show();
            this.Hide();
        }
    }
}
