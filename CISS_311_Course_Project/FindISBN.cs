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
    public partial class FindISBN : Form
    {

        string connectionString;    //global variable to hold the connection string
        SqlConnection conn;         //global variable to hold sql connection
        long selectedISBN;

        public FindISBN()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings[
             "CISS_311_Course_Project.Properties.Settings.LibraryDBConnectionString"]
             .ConnectionString;
        }

        //this could be better, needs to handle a use case of more than one
        //book having the same author and title. 
        private void btn_findISBN_Click(object sender, EventArgs e)
        {
            string firstName = txt_firstName.Text;
            string lastName = txt_lastName.Text;
            string title = txt_title.Text;
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select b.ISBN " +
                "from LibraryDB.dbo.Books b " +
                "join LibraryDB.dbo.Author a on b.AuthorID = a.AuthorID " +
                "where a.AuthorFirstName = @firstName " +
                "and   a.AuthorLastName = @lastName " +
                "and   b.Title = @title", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@firstName", firstName);
                comd.Parameters.AddWithValue("@lastName", lastName);
                comd.Parameters.AddWithValue("@title", title);

                DataTable ISBNtable = new DataTable();
                adapter.Fill(ISBNtable);
                if(ISBNtable.Rows.Count == 0 )
                {
                    MessageBox.Show("No match found, please try again.");
                } else
                {
                    DataRow dr = ISBNtable.Rows[0];
                    selectedISBN = long.Parse(dr["ISBN"].ToString());
                    MessageBox.Show(selectedISBN.ToString());
                    txt_ISBN.Text = selectedISBN.ToString();
                }

            }
        }

        public string GetISBN
        {
            get { return selectedISBN.ToString(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_ISBN.Text = "";
            txt_lastName.Text = "";
            txt_title.Text = "";
            txt_firstName.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
