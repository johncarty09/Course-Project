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
        string connectionString;    //global variable to hold the connection string
        SqlConnection conn;         //global variable to hold sql connection

        public Borrower()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings[
             "CISS_311_Course_Project.Properties.Settings.TeachingDBConnectionString"]
             .ConnectionString;
        }

        /*
         * 
         *  INSERT INTO [LibraryDB].[dbo].[Instructors]()
         *  VALUES (1,'John Carty');
         * 
         */

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txt_firstName.Text.ToString();
            string lastName = txt_lastName.Text.ToString();
            string type = box_Type.SelectedText;
            MessageBox.Show(firstName, lastName);

            /*
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "INSERT INTO [LibraryDB].[dbo].[Borrower] (BorrowerID, BorrowerType, BorrowerFirstName, BorrowerLastName, InventoryOut) VALUES (@BorrowerID, @Type, @FirstName, @LastName, 0)", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {

            }
            */
        }
    }
}
