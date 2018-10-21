using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISS_311_Course_Project
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewBook form2 = new NewBook();

            form2.ShowDialog();
            this.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporting form2 = new Reporting();

            form2.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {

            this.Hide();
            Borrower form2 = new Borrower();

            form2.ShowDialog();
            this.Show();

        }

        private void btn_AddAuthor_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAuthor form2 = new AddAuthor();

            form2.ShowDialog();
            this.Show();
        }

        private void btn_CheckInOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckInOut form2 = new CheckInOut();
            form2.ShowDialog();
            this.Show();

        }

        private void btn_BookSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directory form2 = new Directory();
            form2.ShowDialog();
            this.Show();
        }
    }
}
