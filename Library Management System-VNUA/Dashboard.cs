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
    public partial class Dashboard : Form
    {
        SqlConnection conn = new SqlConnection(Library_Management_System_VNUA.Properties.Settings.Default.connectionDB);

       
        public Dashboard()
        {
            InitializeComponent();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                string query;
                SqlDataAdapter dap;
                DataTable dt;

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                query = "SelectCountFromBookTbl";
                dap = new SqlDataAdapter(query, conn);
                dt = new DataTable(); 
                dap.Fill(dt);
                LblBooks.Text = dt.Rows[0][0].ToString();

                query = "SelectCountFromIssueBookSTbl";
                dap = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                dap.Fill(dt);
                lblIssueBook.Text = dt.Rows[0][0].ToString();

                query = "SelectCountFromLibrariansTbl";
                dap = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                dap.Fill(dt);
                lblLibrarians.Text = dt.Rows[0][0].ToString();

                query = "SelectCountFromReturnTbl";
                dap = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                dap.Fill(dt);
                lblReturnBook.Text = dt.Rows[0][0].ToString();

                query = "SelectCountFromStudentTbl";
                dap = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                dap.Fill(dt);
                lblStudents.Text = dt.Rows[0][0].ToString();
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
    }
}
