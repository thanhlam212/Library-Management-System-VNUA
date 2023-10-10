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
                conn.Open();
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
                conn.Close();
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
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("InsertDataLibrarians", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LibID", LibID.Text.Trim());
                    cmd.Parameters.AddWithValue("@LibName", LibName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LibPassword", LibPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@LibPhone", LibPhone.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Librarians Added Successfully.");
                    Populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
