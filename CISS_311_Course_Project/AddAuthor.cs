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
    public partial class AddAuthor : Form
    {
        public event EventHandler updateEvent;
        int maxID;
        string connectionString;    //global variable to hold the connection string
        SqlConnection conn;         //global variable to hold sql connection


        public AddAuthor()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings[
             "CISS_311_Course_Project.Properties.Settings.LibraryDBConnectionString"]
             .ConnectionString;
        }

        private void btn_addAuthor_Click(object sender, EventArgs e)
        {
            int newID = GetNewAuthorID();
            string firstName = txt_firstName.Text;
            string lastName = txt_lastName.Text;
            string bio = txt_Bio.Text;
            MessageBox.Show(firstName + lastName + bio);

            if (firstName == "" || lastName == "" || bio == "")
            {
                MessageBox.Show("Please enter a value in the First Name, Last Name and About box.");
            } else
            {
                using (conn = new SqlConnection(connectionString))
                using (SqlCommand comd = new SqlCommand(
                    "INSERT INTO LibraryDB.dbo.Author (AuthorID, AuthorFirstName, AuthorLastName, AboutAuthor)" +
                        "VALUES (@NewID, @firstName, @lastName, @bio)", conn))
                {
                    conn.Open();
                    comd.Parameters.AddWithValue("@FirstName", firstName);
                    comd.Parameters.AddWithValue("@LastName", lastName);
                    comd.Parameters.AddWithValue("@bio", bio);
                    comd.Parameters.AddWithValue("@NewID", newID);
                    comd.ExecuteScalar();
                }

            }

        }


        private int GetNewAuthorID()
        {
            
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select max(a.AuthorID) AS aID from LibraryDB.dbo.Author a", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                DataTable BorrowerTable = new DataTable();
                adapter.Fill(BorrowerTable);
                DataRow dr = BorrowerTable.Rows[0];
                maxID = int.Parse(dr["aID"].ToString());
                maxID++;
                return maxID;

            }


        }

        public string SetFirstName
        {
            set { txt_firstName.Text = value; }
        }
        public string SetLastName
        {
            set { txt_lastName.Text = value; }
        }

        public int ReturnNewID
        {
            get { return this.maxID; }
        }
            

        private void AddAuthor_Load(object sender, EventArgs e)
        {
            txt_Bio.Select();
        }
    }
}
