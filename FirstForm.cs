using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPM
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm(this, comboBox1.SelectedIndex);
            secondForm.Show();
            this.Hide();
        }
    }
}
