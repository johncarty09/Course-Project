﻿using System;
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
    public partial class Directory : Form
    {

        public event EventHandler updateEvent;

        public Directory()
        {
            InitializeComponent();
        }

        private void Directory_Load(object sender, EventArgs e)
        {

        }
    }
}
