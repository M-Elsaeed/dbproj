﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_GUI
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Program.serviceFrom.Show();
            this.Close();
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            //Functional code
            Program.serviceFrom.Show();
            this.Close();
        }
    }
}