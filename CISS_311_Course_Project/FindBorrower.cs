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
    public partial class FindBorrower : Form
    {

        string connectionString;    //global variable to hold the connection string
        SqlConnection conn;         //global variable to hold sql connection
        int borrowerID; 

        public FindBorrower()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings[
 "CISS_311_Course_Project.Properties.Settings.LibraryDBConnectionString"]
 .ConnectionString;
        }

        private void FindBorrower_Load(object sender, EventArgs e)
        {

        }
        public string GetBorrowerID
        {
            get { return borrowerID.ToString(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txt_firstName.Text;
            string lastName = txt_lastName.Text;
            string type = cbox_Type.SelectedItem.ToString();
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select b.BorrowerID from LibraryDB.dbo.Borrower b " +
                "where b.BorrowerFirstName = @firstName and b.BorrowerLastName = @lastName " +
                "and b.BorrowerType = @type ", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@firstName", firstName);
                comd.Parameters.AddWithValue("@lastName", lastName);
                comd.Parameters.AddWithValue("@type", type);

                DataTable ISBNtable = new DataTable();
                adapter.Fill(ISBNtable);
                if (ISBNtable.Rows.Count == 0)
                {
                    MessageBox.Show("No match found, please try again.");
                } else
                {
                    DataRow dr = ISBNtable.Rows[0];
                    borrowerID = int.Parse(dr["BorrowerID"].ToString());
                    MessageBox.Show(borrowerID.ToString());
                    txt_borrowerID.Text = borrowerID.ToString();
                }

            }
        }
    }
}
