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
    public partial class Directory : Form
    {

        string connectionString;    //global variable to hold the connection string
        SqlConnection conn;         //global variable to hold sql connection

        public Directory()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings[
             "CISS_311_Course_Project.Properties.Settings.LibraryDBConnectionString"]
             .ConnectionString;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand(
                "select b.Title, b.[Location], CopiesInStock from LibraryDB.dbo.Books b " + "join LibraryDB.dbo.Author a on a.AuthorID = b.AuthorID " +
                  "where ISBN = @ISBN or a.AuthorFirstName = @firstName or " + "a.AuthorLastName = @lastName or b.Title = @title", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@ISBN", txt_ISBN.Text);
                comd.Parameters.AddWithValue("@firstName", txt_FirstName.Text);
                comd.Parameters.AddWithValue("@lastName", txt_LastName.Text);
                comd.Parameters.AddWithValue("@title", txt_Title.Text);

                DataTable TransactionTable = new DataTable();
                adapter.Fill(TransactionTable);
                data_Bookinfo.ReadOnly = true;
                data_Bookinfo.DataSource = TransactionTable.DefaultView;
                data_Bookinfo.Columns[0].Width = 150;
            }
        }
    }
}