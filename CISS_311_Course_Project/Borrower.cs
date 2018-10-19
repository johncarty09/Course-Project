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

        }

        /*
         * 
         *  INSERT INTO [LibraryDB].[dbo].[Instructors]()
         *  VALUES (1,'John Carty');
         *  
         *              connectionString = ConfigurationManager.ConnectionStrings[
             "CISS_311_Course_Project.Properties.Settings.TeachingDBConnectionString"]
             .ConnectionString;
         * 
         */

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txt_firstName.Text.ToString();
            string lastName = txt_lastName.Text.ToString();
            string type = cbox_Type.SelectedItem.ToString();
            MessageBox.Show(firstName + lastName + type);

            /*
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "INSERT INTO [LibraryDB].[dbo].[Borrower] (BorrowerID, BorrowerType, BorrowerFirstName, BorrowerLastName, InventoryOut) VALUES (@BorrowerID, @Type, @FirstName, @LastName, 0)", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {

            }
            */
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
