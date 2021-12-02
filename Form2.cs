using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Group_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            this.Hide();
            f4.Show();
            //this.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();

            this.Hide();
            f6.Show();
            //this.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();

            this.Hide();
            f7.Show();
            //this.BringToFront();
        }
    }
}
