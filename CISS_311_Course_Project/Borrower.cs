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
    public partial class Borrower : Form
    {

        public event EventHandler updateEvent;
        string connectionString;    //global variable to hold the connection string
        SqlConnection conn;         //global variable to hold sql connection

        public Borrower()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings[
             "CISS_311_Course_Project.Properties.Settings.LibraryDBConnectionString"]
             .ConnectionString;

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int newID = GetNewBorrowerID();
            string firstName = txt_firstName.Text;
            string lastName = txt_lastName.Text;
            string type = cbox_Type.SelectedItem.ToString();
            MessageBox.Show(firstName + lastName + type);

            if(firstName == "" || lastName == "" || type == "")
            {
                MessageBox.Show("Please enter a value in the First Name, Last Name and Type box.");
            } else
            {
                using (conn = new SqlConnection(connectionString))
                using (SqlCommand comd = new SqlCommand(
                    "INSERT INTO LibraryDB.dbo.Borrower (BorrowerID, BorrowerType, BorrowerFirstName, BorrowerLastName, InventoryOut)" + 
                      "VALUES (@NewID, @Type, @FirstName, @LastName, 0)", conn))
                {
                    conn.Open();
                    comd.Parameters.AddWithValue("@FirstName", firstName);
                    comd.Parameters.AddWithValue("@LastName", lastName);
                    comd.Parameters.AddWithValue("@Type", type);
                    comd.Parameters.AddWithValue("@NewID", newID);
                    comd.ExecuteScalar();
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Borrower_Load(object sender, EventArgs e)
        {

            
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select b.BorrowerID, concat(b.BorrowerFirstName, ' ', b.BorrowerLastName) as 'Name'," +
                "b.InventoryOut from LibraryDB.dbo.Borrower b", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                DataTable BorrowerTable = new DataTable();
                adapter.Fill(BorrowerTable);


                data_Borrowers.ReadOnly = true;
                data_Borrowers.DataSource = BorrowerTable.DefaultView;

            }

            
        }

        private int GetNewBorrowerID()
        {
            int maxID;
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select max(b.BorrowerID) AS bID from LibraryDB.dbo.Borrower b", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                DataTable BorrowerTable = new DataTable();
                adapter.Fill(BorrowerTable);
                DataRow dr = BorrowerTable.Rows[0];
                maxID = int.Parse(dr["bID"].ToString());
                maxID++;
                return maxID;

            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            cbox_Type.SelectedIndex = -1;
        }
    }
}
