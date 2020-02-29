using System;
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
    public partial class create_new_day : Form
    {
        public create_new_day()
        {
            InitializeComponent();
        }

        private void btGo_Day_Click(object sender, EventArgs e)
        {
            Form Select_excersises = new Select_Exc();
            Select_excersises.Show();
            this.Close();
        }
    }
}
