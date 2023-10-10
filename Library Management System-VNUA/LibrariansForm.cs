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
    public partial class LibrariansForm : Form
    {
        SqlConnection conn = new SqlConnection(Library_Management_System_VNUA.Properties.Settings.Default.connectionDB);

        public LibrariansForm()
        {
            InitializeComponent();
        }

        private void LibrariansForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Populate()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SelectDataLibrarians";
                SqlDataAdapter dap = new SqlDataAdapter(query, conn);
                SqlCommandBuilder cmd = new SqlCommandBuilder(dap);
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
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void AddStudentsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LibID.Text == "" || LibName.Text == "" || LibPass.Text == "" || LibPhone.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("InsertDataLibrarians", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LibID", LibID.Text.Trim());
                    cmd.Parameters.AddWithValue("@LibName", LibName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LibPassword", LibPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@LibPhone", LibPhone.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Librarians Added Successfully.");
                    ClearField();
                    Populate();
                }
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LibID.Text == "")
                {
                    MessageBox.Show("Enter The Library ID.");
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "DeleteDataLibrariansTbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LibID", LibID.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Librarian Deleted Successfully.");
                    ClearField();
                    Populate();
                }
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

        protected void StudentsDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < StudentsDataTable.Rows.Count && StudentsDataTable.SelectedRows.Count > 0)
            {
                LibID.Text = StudentsDataTable.SelectedRows[0].Cells[0].Value?.ToString();
                LibName.Text = StudentsDataTable.SelectedRows[0].Cells[1].Value?.ToString();
                LibPass.Text = StudentsDataTable.SelectedRows[0].Cells[2].Value?.ToString();
                LibPhone.Text = StudentsDataTable.SelectedRows[0].Cells[3].Value?.ToString();
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (LibID.Text == "" || LibName.Text == "" || LibPass.Text == "" || LibPhone.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "UpdateDataLibrariansTbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LibID", LibID.Text.Trim());
                    cmd.Parameters.AddWithValue("@LibName", LibName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LibPassword", LibPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@LibPhone", LibPhone.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Librarians Successfully.");
                    ClearField();
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

        protected void ClearField()
        {
            LibID.Text = "";
            LibName.Text = "";
            LibPass.Text = "";
            LibPhone.Text = "";
        }
    }
}
