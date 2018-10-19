using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISS_311_Course_Project
{
    public partial class NewBook : Form
    {
        public event EventHandler updateEvent;
        string connectionString;    //global variable to hold the connection string
        SqlConnection conn;         //global variable to hold sql connection

        public NewBook()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings[
             "CISS_311_Course_Project.Properties.Settings.LibraryDBConnectionString"]
             .ConnectionString;

        }

        private void New_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFindAuthor_Click(object sender, EventArgs e)
        {
            int count;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select count(a.AuthorID) AS aID from LibraryDB.dbo.Author a"+
                "where a.FirstName = @firstName and a.LastName = @lastName", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                DataTable BorrowerTable = new DataTable();
                adapter.Fill(BorrowerTable);
                DataRow dr = BorrowerTable.Rows[0];
                count = int.Parse(dr["aID"].ToString());
                if (count == 0)
                {
                    //open add author form
                } else if (count == 1)
                {
                    //load author info
                } else
                {
                    //load form to select correct author
                }

            }
        }
    }
}
