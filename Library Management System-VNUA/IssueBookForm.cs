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
    public partial class IssueBookForm : Form
    {
        SqlConnection conn = new SqlConnection(Library_Management_System_VNUA.Properties.Settings.Default.connectionDB);
        public IssueBookForm()
        {
            InitializeComponent();
        }

        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            FillStudent();
            FillBooks();
            Populate();
        }

        private void BackHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void FillStudent()
        {
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "FillStudent";
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("StdId", typeof(int));
                dt.Load(dr);
                cbStuID.ValueMember = "StdId";
                cbStuID.DataSource = dt;
            }
            catch(Exception ex)
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

        protected void fecthStudentData()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "FecthDataStudentsTbl";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StdId", cbStuID.SelectedValue.ToString());
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtStdName.Text = dr["StdName"].ToString();
                    txtStdDep.Text = dr["StdDep"].ToString();
                    txtStdPhone.Text = dr["StdPhone"].ToString();
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

                cmd.Parameters.AddWithValue("@BookName", cbBooks.SelectedValue.ToString());
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Qty = Convert.ToInt32(dr["Quantity"].ToString());
                    newQty = Qty - 1;
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

        protected void Populate()
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
            catch(Exception ex)
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

        private void cbStuID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fecthStudentData();
        }

        private void AddIssueBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNum.Text) || string.IsNullOrEmpty(txtStdName.Text))
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

                    string query = "InsertDataFromIssueBookTbl";
                    string IssueDate = dtpDateIssue.Value.ToString("dd/MM/yyyy");               
                   
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IssueNum", txtNum.Text.Trim());
                    cmd.Parameters.AddWithValue("@StuID", cbStuID.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StdName", txtStdName.Text.Trim());
                    cmd.Parameters.AddWithValue("@StdDept",txtStdDep.Text.Trim());
                    cmd.Parameters.AddWithValue("@StdPhone", txtStdPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@BookIssued", cbBooks.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@IssueDate", IssueDate);   

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Successfully Issued.");
                    ClearField();
                    UpdateQuantityBook();
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

        protected void ClearField()
        {
            txtNum.Text = "";
            txtStdName.Text = "";
            txtStdDep.Text = "";
            txtStdPhone.Text = "";
            cbBooks.Text = "";
            cbBooks.Text = "";
        }

        private void IssueBookDataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < IssueBookDataTable.Rows.Count && IssueBookDataTable.SelectedRows.Count > 0)
            {
                txtNum.Text = IssueBookDataTable.SelectedRows[0].Cells[0].Value?.ToString();
                cbStuID.Text = IssueBookDataTable.SelectedRows[0].Cells[1].ToString();
                txtStdName.Text = IssueBookDataTable.SelectedRows[0].Cells[2].Value?.ToString();
                txtStdDep.Text = IssueBookDataTable.SelectedRows[0].Cells[3].Value?.ToString();
                txtStdPhone.Text = IssueBookDataTable.SelectedRows[0].Cells[4].Value?.ToString();
                cbBooks.Text = IssueBookDataTable.SelectedRows[0].Cells[5].Value?.ToString();

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNum.Text == "")
                {
                    MessageBox.Show("Enter The Issue Number.");
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "DeleteDataFromIssueBooksTbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IssueNum", txtNum.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Issue Successfully Canceled.");
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
