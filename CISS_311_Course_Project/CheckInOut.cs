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
    public partial class CheckInOut : Form
    {
        public CheckInOut()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //create transaction for todays date and link to member and isbn
            //needs to decrement the on hand for book
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            //modify check out transaction to show book is in
            //increment on hand for book.
            
        }

        private void New_Member_Load(object sender, EventArgs e)
        {

        }
    }
}
