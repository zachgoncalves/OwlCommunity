﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OwlCommunity.Controllers;
using OwlCommunity.Classes;

namespace OwlCommunity.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateUndergrad_Click(object sender, EventArgs e)
        {
            FormController.activateAddButtons(this);
        }
    }
}
