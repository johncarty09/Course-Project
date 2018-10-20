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
    public partial class AuthorSelect : Form
    {

        string firstName, lastName;
        string connectionString;    //global variable to hold the connection string
        SqlConnection conn;         //global variable to hold sql connection
        int selectedID;

        public AuthorSelect()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings[
           "CISS_311_Course_Project.Properties.Settings.LibraryDBConnectionString"]
           .ConnectionString;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AuthorSelect_Load(object sender, EventArgs e)
        {
           
           //column3.Width = 700;

            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select a.AuthorID, CONCAT(a.AuthorFirstName, ' ', a.AuthorLastName)" +
                "AS AuthorName, a.AboutAuthor from LibraryDB.dbo.Author a " +
                "where a.AuthorFirstName = @firstName and a.AuthorLastName = @lastName"
                , conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@firstName", firstName);
                comd.Parameters.AddWithValue("@lastName", lastName);
                DataTable BorrowerTable = new DataTable();
                adapter.Fill(BorrowerTable);
                data_Authors.ReadOnly = true;
                data_Authors.DataSource = BorrowerTable.DefaultView;
                data_Authors.Columns[2].Width = 345;
                
                //detailsListBox.DataSource = BorrowerTable;
                //detailsListBox.DisplayMember = "BorrowerID";
            }
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedAuthor;
            selectedAuthor = data_Authors.SelectedRows[0];
            selectedID = int.Parse(selectedAuthor.Cells[0].Value.ToString());
            this.Close();
        }

        public string FirstName
        {
            set { this.firstName = value; }
        }
        public string LastName
        {
            set { this.lastName = value; }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int SelectedID
        {
            get { return selectedID; }
        }
    }
}
