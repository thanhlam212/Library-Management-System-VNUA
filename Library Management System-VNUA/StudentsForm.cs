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
    
    public partial class StudentsForm : Form
    {
        SqlConnection conn = new SqlConnection(Library_Management_System_VNUA.Properties.Settings.Default.connectionDB);

        public StudentsForm()
        {
            InitializeComponent();
        }

        protected void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void BackHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eLibraryDBDataSet1.StudentsTbl' table. You can move, or remove it, as needed.
            this.studentsTblTableAdapter.Fill(this.eLibraryDBDataSet1.StudentsTbl);
            Populate();
        }

        protected void AddStudentsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsn.Text == "" || tbStuName.Text == "" || tbDep.Text == "" || cbSem.Text == "" || tbPhoneNo.Text == "")
                {
                    MessageBox.Show("Missing Information.");
                }
                else
                {
                    if(conn.State == ConnectionState.Closed) 
                    {
                        conn.Open();
                    }
                    string query = "InsertDataForStudentsTbl";
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StdID", tbUsn.Text.Trim());
                    cmd.Parameters.AddWithValue("@StdName", tbStuName.Text.Trim());
                    cmd.Parameters.AddWithValue("@StdDep", tbDep.Text.Trim());
                    cmd.Parameters.AddWithValue("@StdSem", cbSem.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@StdPhone", tbPhoneNo.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Student Successfully.");
                    Populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        protected void Populate()
        {
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "GetDataFromStudentsTbl";
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dap.Fill(ds);
                StudentsDataTable.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(conn.State == ConnectionState.Open) { conn.Close(); }
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsn.Text == "")
                {
                    MessageBox.Show("Enter Student ID.");
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "DeleteStudentsTbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StdID", tbUsn.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted Successfully.");
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

        protected void ClearField()
        {
            tbUsn.Text = "";
            tbStuName.Text = "";
            tbPhoneNo.Text = "";
            tbDep.Text = "";
            cbSem.Text = "";
        }


        protected void StudentsDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < StudentsDataTable.Rows.Count && StudentsDataTable.SelectedRows.Count > 0)
            {
                tbUsn.Text = StudentsDataTable.SelectedRows[0].Cells[0].Value?.ToString();
                tbStuName.Text = StudentsDataTable.SelectedRows[0].Cells[1].Value?.ToString();
                tbDep.Text = StudentsDataTable.SelectedRows[0].Cells[2].Value?.ToString();
                cbSem.Text = StudentsDataTable.SelectedRows[0].Cells[3].Value?.ToString();
                tbPhoneNo.Text = StudentsDataTable.SelectedRows[0].Cells[4].Value?.ToString();
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsn.Text == "" || tbStuName.Text == "" || tbDep.Text == "" || cbSem.Text == "" || tbPhoneNo.Text == "")
                {
                    MessageBox.Show("Missing Information.");
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "UpdateDataFromStudentsTbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StdID", tbUsn.Text.Trim());
                    cmd.Parameters.AddWithValue("@StdName", tbStuName.Text.Trim());
                    cmd.Parameters.AddWithValue("@StdDep", tbDep.Text.Trim());
                    cmd.Parameters.AddWithValue("@StdSem", cbSem.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@StdPhone", tbPhoneNo.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Student Successfully.");
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
