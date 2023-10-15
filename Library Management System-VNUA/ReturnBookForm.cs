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
    public partial class ReturnBookForm : Form
    {
        SqlConnection conn = new SqlConnection(Library_Management_System_VNUA.Properties.Settings.Default.connectionDB);

        Bitmap bitmap;

        public ReturnBookForm()
        {
            InitializeComponent();
        }
        public void Populate()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "GetDataFromIssueBookTbl";
                SqlDataAdapter dap = new SqlDataAdapter(query, conn);
                SqlCommandBuilder cmd = new SqlCommandBuilder(dap);
                DataSet ds = new DataSet();
                dap.Fill(ds);
                IssueBookDataTable.DataSource = ds.Tables[0];
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

        public void PopulateReturn()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "GetDataFromReturnTbl";
                SqlDataAdapter dap = new SqlDataAdapter(query, conn);
                SqlCommandBuilder cmd = new SqlCommandBuilder(dap);
                DataSet ds = new DataSet();
                dap.Fill(ds);
                ReturnBooksDataTable.DataSource = ds.Tables[0];
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


        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            Populate();
            PopulateReturn();
            FillBooks();
        }

        private void IssueBookDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < IssueBookDataTable.Rows.Count && IssueBookDataTable.SelectedRows.Count > 0)
            {
                txtReturnNum.Text = IssueBookDataTable.SelectedRows[0].Cells[0].Value?.ToString();
                cbStuID.SelectedItem = IssueBookDataTable.SelectedRows[0].Cells[1].Value?.ToString();
                txtStdName.Text = IssueBookDataTable.SelectedRows[0].Cells[2].Value?.ToString();
                txtStdDep.Text = IssueBookDataTable.SelectedRows[0].Cells[3].Value?.ToString();
                txtStdPhone.Text = IssueBookDataTable.SelectedRows[0].Cells[4].Value?.ToString();
                cbBooks.Text = IssueBookDataTable.SelectedRows[0].Cells[5].Value?.ToString();
            }
        }

        private void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtReturnNum.Text) || string.IsNullOrEmpty(txtStdName.Text))
                {
                    MessageBox.Show("Missing Information");
                    return;
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "InsertDataFromReturnTbl";
                    string IssueDate = dtpDateIssue.Value.ToString("dd/MM/yyyy");
                    string ReturnDate = dtpDateReturn.Value.ToString("dd/MM/yyyy");

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ReturnNum", txtReturnNum.Text.Trim());
                    cmd.Parameters.AddWithValue("@StdID", cbStuID.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@StdName", txtStdName.Text.Trim());
                    cmd.Parameters.AddWithValue("@StdDept", txtStdDep.Text.Trim());
                    cmd.Parameters.AddWithValue("@StdPhone", txtStdPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@BookReturned", cbBooks.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                    cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Successfully Returned.");
                    UpdateQuantityBook();
                    PopulateReturn();
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


        private void UpdateQuantityBook()
        {
            try
            {
                int Qty, newQty;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "UpdateBook";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@BookName", cbBooks.SelectedItem.ToString());
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Qty = Convert.ToInt32(dr["Quantity"].ToString());
                    newQty = Qty + 1;
                    string updateQtyBookTbl = "UpdateQuantityFromBookTbl";
                    SqlCommand sqlCommand = new SqlCommand(updateQtyBookTbl, conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@NewQuantity", newQty);
                    sqlCommand.Parameters.AddWithValue("@BookName", cbBooks.SelectedValue.ToString());

                    sqlCommand.ExecuteNonQuery();
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

        protected void FillBooks()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "FillBook";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("BookName", typeof(string));
                dt.Load(dr);
                cbBooks.ValueMember = "BookName";
                cbBooks.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap,0,0);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y,0,0,size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
