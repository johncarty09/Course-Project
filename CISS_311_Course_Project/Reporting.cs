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
    public partial class Reporting : Form
    {
        string connectionString;    //global variable to hold the connection string
        SqlConnection conn;         //global variable to hold sql connection


        public Reporting()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings[
 "CISS_311_Course_Project.Properties.Settings.LibraryDBConnectionString"]
 .ConnectionString;
        }

        private void Directory_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select * from LibraryDB.dbo.[Transaction] where ReturnDate IS NULL", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {

                DataTable TransactionTable = new DataTable();
                adapter.Fill(TransactionTable);
                data_Reports.ReadOnly = true;
                data_Reports.DataSource = TransactionTable.DefaultView;
            }
        }

        private void btn_LateBooks_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select ISBN, CONCAT(b.BorrowerFirstName, ' ', b.BorrowerLastName) AS Borrower, " + 
                "CheckOutDate, DATEADD(month, 1, CheckOutDate) AS DueDate, " + 
                "DATEDIFF(day, DATEADD(month, 1, CheckOutDate), GETDATE()) AS DaysLate " +
                "from LibraryDB.dbo.[Transaction] t " +
                "join LibraryDB.dbo.Borrower b on t.BorrowerID = b.BorrowerID " +
                "where ReturnDate IS NULL " +
                "and GETDATE() > DATEADD(month, 1, CheckOutDate)", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {

                DataTable TransactionTable = new DataTable();
                adapter.Fill(TransactionTable);
                data_Reports.ReadOnly = true;
                data_Reports.DataSource = TransactionTable.DefaultView;
            }
        }

        private void btn_Transactions_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select t.TransactionID, t.ISBN, t.CheckOutDate, t.ReturnDate, " +
                "CONCAT(b.BorrowerFirstName, ' ', b.BorrowerLastName) AS Borrower " +
                "from LibraryDB.dbo.[Transaction] t " +
                "join LibraryDB.dbo.Borrower b on t.BorrowerID = b.BorrowerID", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {

                DataTable TransactionTable = new DataTable();
                adapter.Fill(TransactionTable);
                data_Reports.ReadOnly = true;
                data_Reports.DataSource = TransactionTable.DefaultView;
            }
        }

        private void btn_AllBooks_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select b.ISBN, b.Title, " + 
                "CONCAT(a.AuthorFirstName, ' ', a.AuthorLastName) AS Author, " +
                " b.[Location], b.CopiesInStock from LibraryDB.dbo.Books b " +
                "join LibraryDB.dbo.Author a on a.AuthorID = b.AuthorID", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {

                DataTable TransactionTable = new DataTable();
                adapter.Fill(TransactionTable);
                data_Reports.ReadOnly = true;
                data_Reports.DataSource = TransactionTable.DefaultView;
            }
        }

        private void btn_AllBorrowers_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select * from LibraryDB.dbo.Borrower b", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {

                DataTable TransactionTable = new DataTable();
                adapter.Fill(TransactionTable);
                data_Reports.ReadOnly = true;
                data_Reports.DataSource = TransactionTable.DefaultView;
            }
        }

        private void btn_AllAuthors_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select *from LibraryDB.dbo.Author", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {

                DataTable TransactionTable = new DataTable();
                adapter.Fill(TransactionTable);
                data_Reports.ReadOnly = true;
                data_Reports.DataSource = TransactionTable.DefaultView;
            }
        }
    }
}
