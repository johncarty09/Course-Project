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

        /*
         * INSERT INTO [LibraryDB].[dbo].[Transaction](TransactionID, ISBN, BorrowerID, CheckOutDate)
            VALUES (1,1234567894567,12345, GETDATE());
         * 
         * */

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            //check how many borrower has out already max F 3 and S 2
            //if ok then check if book is in stock 
            //if ok then create transaction and decrement inventory of book

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            //modify check out transaction to show book is in
            //increment on hand for book.
            
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
    }
}
