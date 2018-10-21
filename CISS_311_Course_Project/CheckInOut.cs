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
    public partial class CheckInOut : Form
    {
        string connectionString;    //global variable to hold the connection string
        SqlConnection conn;         //global variable to hold sql connection
        int F = 3, S  = 2;          //max inventory for students and faculty

        public CheckInOut()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings[
 "CISS_311_Course_Project.Properties.Settings.LibraryDBConnectionString"]
 .ConnectionString;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*
         * INSERT INTO [LibraryDB].[dbo].[Transaction](TransactionID, ISBN, BorrowerID, CheckOutDate)
            VALUES (1,1234567894567,12345, GETDATE());
         * 
         * */

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            //check how many borrower has out already max F 3 and S 2 
            //select InventoryOut from LibraryDB.dbo.Borrower where BorrowerID = @ID
            //if ok then check if book is in stock 
            //if ok then create transaction and decrement inventory of book
            string ISBN = txt_ISBN.Text;
            int borrowerID = int.Parse(txtMemberID.Text.ToString());
            int inventoryOut= 0, maxOut = 0, inventoryAvail = 0;
            string type = "";
            bool allowed;
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select InventoryOut, BorrowerType from LibraryDB.dbo.Borrower where BorrowerID = @ID", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@ID", borrowerID);


                DataTable BorrowerTable = new DataTable();
                adapter.Fill(BorrowerTable);
                if (BorrowerTable.Rows.Count == 0)
                {
                    MessageBox.Show("No match found, please try again.");
                } else
                {
                    DataRow dr = BorrowerTable.Rows[0];
                    inventoryOut = int.Parse(dr["InventoryOut"].ToString());
                    type = dr["BorrowerType"].ToString();

                    maxOut = (type == "F") ? F : S;
                    allowed = (inventoryOut < maxOut) ? true : false;

                    if(allowed)
                    {
                        //check if book in stock
                        using (SqlCommand cmd = new SqlCommand(
                        "select ISBN , CopiesInStock from LibraryDB.dbo.Books where ISBN = @ISBN", conn))
                        using (SqlDataAdapter adapter2 = new SqlDataAdapter(cmd))
                        {
                            cmd.Parameters.AddWithValue("@ISBN", ISBN);
                            DataTable ISBNtable = new DataTable();
                            adapter2.Fill(ISBNtable);

                            if (ISBNtable.Rows.Count == 0)
                            {
                                MessageBox.Show("No match found, please try again.");
                            } else
                            {
                                DataRow dr2 = ISBNtable.Rows[0];
                                inventoryAvail = int.Parse(dr2["CopiesInStock"].ToString());

                                allowed = (inventoryAvail > 0) ? true : false;

                                if(allowed)
                                {
                                    //process transaction and decrement inventory.
                                    using (conn = new SqlConnection(connectionString))
                                    using (SqlCommand cmd2 = new SqlCommand(
                                        "UPDATE LibraryDB.dbo.Books " +
                                        "SET CopiesInStock = (CopiesInStock - 1) " +
                                        "Where ISBN = @ISBN", conn))
                                    {
                                        conn.Open();
                                        cmd2.Parameters.AddWithValue("@ISBN", ISBN);
                                        cmd2.ExecuteScalar();
                                    }
                                    using (conn = new SqlConnection(connectionString))
                                    using (SqlCommand cmd2 = new SqlCommand(
                                        "INSERT INTO [LibraryDB].[dbo].[Transaction](TransactionID, " + 
                                        "ISBN, BorrowerID, CheckOutDate) VALUES(@newID, @ISBN, @BorrowerID, " +
                                        " GETDATE()); ", conn))
                                    {
                                        conn.Open();
                                        cmd2.Parameters.AddWithValue("@ISBN", ISBN);
                                        cmd2.Parameters.AddWithValue("@newID", NewID());
                                        cmd2.Parameters.AddWithValue("@BorrowerID", borrowerID);
                                        cmd2.ExecuteScalar();
                                    }
                                    MessageBox.Show("Book successfully checked out.");
                                    txt_ISBN.Text = "";
                                } else
                                {
                                    MessageBox.Show("Book is out of stock, please enter a different ISBN");
                                }
                            }
                         }

                    } else
                    {
                        MessageBox.Show("Maximum inventory out reached, please check a book in first.");
                    }
                }  
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            //modify check out transaction to show book is in
            //increment on hand for book.
            //check if book is indeed checked out to user
            //if so update transaction with todays date on return date
            //then increment on hand for book
            //select * from LibraryDB.dbo.[Transaction] where ISBN = @ISBN and BorrowerID = @BorrowerID and ReturnDate IS NULL
            string ISBN = txt_ISBN.Text;
            int borrowerID = int.Parse(txtMemberID.Text.ToString());
            int transactionID;
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select * from LibraryDB.dbo.[Transaction] where ISBN = @ISBN and BorrowerID = @BorrowerID " +
                "and ReturnDate IS NULL", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@BorrowerID", borrowerID);
                comd.Parameters.AddWithValue("@ISBN", ISBN);


                DataTable TransactionTable = new DataTable();
                adapter.Fill(TransactionTable);
                if (TransactionTable.Rows.Count == 0)
                {
                    MessageBox.Show("This book is not currently check out to this customer.");
                    return;
                }
                DataRow dr = TransactionTable.Rows[0];
                transactionID = int.Parse(dr["TransactionID"].ToString());
            }
            //update transaction with todays date on return date
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "UPDATE LibraryDB.dbo.[Transaction] " +
                "SET ReturnDate = GETDATE() " +
                "WHERE TransactionID = @transactionID", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@transactionID", transactionID);
                comd.ExecuteScalar();
            }
            //then increment on hand for book
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "UPDATE LibraryDB.dbo.Books " +
                 "SET CopiesInStock = (CopiesInStock + 1) " +
                 "Where ISBN = @ISBN", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@ISBN", ISBN);
                comd.ExecuteScalar();
            }
            MessageBox.Show("Book successfully checked in.");
            txt_ISBN.Text = "";
        }

        private void New_Member_Load(object sender, EventArgs e)
        {

        }

        private void btn_FindID_Click(object sender, EventArgs e)
        {
            //open form to search for member by name then return id
            FindBorrower form2 = new FindBorrower();
            form2.ShowDialog();
            txtMemberID.Text = form2.GetBorrowerID;
        }

        private void btn_findISBN_Click(object sender, EventArgs e)
        {
            //open for to search for book by title and author then return isbn
            FindISBN form2 = new FindISBN();
            form2.ShowDialog();
            txt_ISBN.Text = form2.GetISBN;
        }

        private int NewID()
        {
            int newID = 0;

            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select max(t.TransactionID) AS tID from LibraryDB.dbo.[Transaction] t", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                DataTable BorrowerTable = new DataTable();
                adapter.Fill(BorrowerTable);
                DataRow dr = BorrowerTable.Rows[0];
                newID = int.Parse(dr["tID"].ToString());
                newID++;
                return newID;

            }

        }
    }
}
