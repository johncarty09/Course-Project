﻿using System;
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
        string connectionString;    //global variable to hold the connection string
        SqlConnection conn;         //global variable to hold sql connection
        int selectedID;

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
                "select count(a.AuthorID) AS aID from LibraryDB.dbo.Author a "+
                "where a.AuthorFirstName = @firstName and a.AuthorLastName = @lastName", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@firstName", firstName);
                comd.Parameters.AddWithValue("@lastName", lastName);

                DataTable AuthorTable = new DataTable();
                adapter.Fill(AuthorTable);
                DataRow dr = AuthorTable.Rows[0];
                count = int.Parse(dr["aID"].ToString());
                if (count == 0)
                {
                    //open add author form
                    AddAuthor form3 = new AddAuthor();
                    form3.SetFirstName = firstName;
                    form3.SetLastName = lastName;
                    form3.ShowDialog();

                    txt_AuthorID.Text = form3.ReturnNewID.ToString();                    
             

                } else if (count == 1)
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "select AuthorID from LibraryDB.dbo.Author " +
                        "where AuthorFirstName = @firstName and AuthorLastName = @lastName", conn))
                    using (SqlDataAdapter adapter2 = new SqlDataAdapter(cmd))
                    {
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        DataTable AuthorIDtable = new DataTable();
                        adapter2.Fill(AuthorIDtable);
                        DataRow dr2 = AuthorIDtable.Rows[0];
                        txt_AuthorID.Text = dr2["AuthorID"].ToString();
                    }
                } else
                {
                    //load form to select correct author
                    AuthorSelect form_Author = new AuthorSelect();
                    form_Author.FirstName = txtFirstName.Text;
                    form_Author.LastName = txtLastName.Text;
                    form_Author.ShowDialog();

                    selectedID = form_Author.SelectedID;
                    txt_AuthorID.Text = selectedID.ToString();
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool passed;
            string title = txtTitle.Text;
            string ISBN = txtISBN.Text;
            string shelf = txtShelf.Text;
            passed = int.TryParse(txtYear.Text.ToString(), out int year);
            passed = int.TryParse(txtQty.Text.ToString(), out int qty);
            int.TryParse(txt_AuthorID.Text.ToString(), out int authorID);

            if (ISBN == "" || title == "" || shelf == "" || authorID < 0 
                || !passed || year > 2018 || year < 0 || qty < 0)
            {
                MessageBox.Show("Please enter a valid value in all fields.");
            }
            else if (!NewISBN())
            {
                MessageBox.Show("ISBN is not unique, please re-enter.");
            }
            else
            {
                using (conn = new SqlConnection(connectionString))
                using (SqlCommand comd = new SqlCommand(
                    "INSERT INTO LibraryDB.dbo.Books (ISBN, AuthorID, Title, CopywrightYear, Location, CopiesOwned, CopiesInStock)" +
                      "VALUES (@ISBN, @AuthorID, @Title, @Year, @Location, @CopiesOwned, @InStock)", conn))
                {
                    conn.Open();
                    comd.Parameters.AddWithValue("@ISBN", ISBN);
                    comd.Parameters.AddWithValue("@AuthorID", authorID);
                    comd.Parameters.AddWithValue("@Title", title);
                    comd.Parameters.AddWithValue("@Year", year);
                    comd.Parameters.AddWithValue("@Location", shelf);
                    comd.Parameters.AddWithValue("@CopiesOwned", qty);
                    comd.Parameters.AddWithValue("@InStock", qty);
                    comd.ExecuteScalar();
                }
                MessageBox.Show("Book added.");
                btnClear_Click(null, EventArgs.Empty);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLastName.Text = "";
            txtISBN.Text = "";
            txtFirstName.Text = "";
            txtQty.Text = "";
            txtShelf.Text = "";
            txtTitle.Text = "";
            txtYear.Text = "";
            txt_AuthorID.Text = "";
        }
        
        private bool NewISBN()
        {
            bool passed;
            int count;
            string ISBN = txtISBN.Text.ToString();
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select count(b.ISBN) AS bID from LibraryDB.dbo.Books b where ISBN = @ISBN", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@ISBN", ISBN);
                DataTable BorrowerTable = new DataTable();
                adapter.Fill(BorrowerTable);
                DataRow dr = BorrowerTable.Rows[0];
                count = int.Parse(dr["bID"].ToString());

            }

            if (count == 0)
            {
                passed = true;
            } else
            {
                passed = false;
            }

            return passed;
        }
    }
}
