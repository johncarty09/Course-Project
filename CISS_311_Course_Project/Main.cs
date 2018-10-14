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

            //Register the update event
            form2.updateEvent += new EventHandler(handleUpdateEvent);

            //Register form closed event
            form2.FormClosed += new FormClosedEventHandler(form2_FormClosed);

            form2.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Directory form2 = new Directory();
            form2.Show();

            //Register the update event
            form2.updateEvent += new EventHandler(handleUpdateEvent);

            //Register form closed event
            form2.FormClosed += new FormClosedEventHandler(form2_FormClosed);

            form2.Show();
        }

        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        //Handler for the event from form 2
        void handleUpdateEvent(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
