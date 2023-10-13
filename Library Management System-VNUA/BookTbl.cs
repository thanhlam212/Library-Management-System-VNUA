using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_VNUA
{
    public partial class BookTbl : Form
    {
        SqlConnection conn = new SqlConnection(Library_Management_System_VNUA.Properties.Settings.Default.connectionDB);

        public BookTbl()
        {
            InitializeComponent();
        }

        private void BookTbl_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void BackHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        protected void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Add book burron click*/
        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBookName.Text == "" || txtAuthorName.Text == "" || txtPrice.Text == "" || txtPublisherName.Text == "" || txtQuantity.Text == "")
                {
                    MessageBox.Show("Missing Information.");
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "InsertDataBookTbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookName", txtBookName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Author", txtAuthorName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Publisher", txtPublisherName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Price", txtPrice.Text.ToString());
                    cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Book Successfully.");
                    ClearField();
                    Populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        //Delete button click
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBookName.Text == "")
                {
                    MessageBox.Show("Enter Book Name.");
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "DeleteDataFromBookTbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookName", txtBookName.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Deleted Successfully.");
                    ClearField();
                    Populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        protected void Populate()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "GetDataFromBookTbl";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dap.Fill(ds);
                BooksDataTable.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) { conn.Close(); }
            }
        }

        protected void ClearField()
        {
            txtBookName.Text = "";
            txtAuthorName.Text = "";
            txtPrice.Text = "";
            txtPublisherName.Text = "";
            txtQuantity.Text = "";
        }

        protected void BookDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < BooksDataTable.Rows.Count && BooksDataTable.SelectedRows.Count > 0)
            {
                txtBookName.Text = BooksDataTable.SelectedRows[0].Cells[0].Value?.ToString();
                txtAuthorName.Text = BooksDataTable.SelectedRows[0].Cells[1].Value?.ToString();
                txtPublisherName.Text = BooksDataTable.SelectedRows[0].Cells[2].Value?.ToString();
                txtPrice.Text = BooksDataTable.SelectedRows[0].Cells[3].Value?.ToString();
                txtQuantity.Text = BooksDataTable.SelectedRows[0].Cells[4].Value?.ToString();
            }
        }

        //Update button click
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBookName.Text == "" || txtAuthorName.Text == "" || txtPrice.Text == "" || txtPublisherName.Text == "" || txtQuantity.Text == "")
                {
                    MessageBox.Show("Missing Information.");
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "UpdateDataFromBookTbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookName", txtBookName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Author", txtAuthorName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Publisher", txtPublisherName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Price", txtPrice.Text.ToString());
                    cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Book Successfully.");
                    ClearField();
                    Populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        
    }
}
