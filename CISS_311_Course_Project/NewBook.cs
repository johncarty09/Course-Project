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
    public partial class NewBook : Form
    {
        public event EventHandler updateEvent;
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
            int count, aID;
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

        }
    }
}
