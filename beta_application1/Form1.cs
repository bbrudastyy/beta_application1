﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beta_application1
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
           
        }

        private void btnCreateDay_Click(object sender, EventArgs e)
        {
            Form create_new_day = new create_new_day();
            create_new_day.Show();
        }
    }
}
