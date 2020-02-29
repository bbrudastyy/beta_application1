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
    public partial class Select_Exc : Form
    {
        public Select_Exc()
        {
            InitializeComponent();
        }

        private void LDate_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Select_Exc_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("sdvf");
            comboBox1.Items.Add("sssdgdvf");
            comboBox1.ValueMember = "Selected";
        }
    }
}
