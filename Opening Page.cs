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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            //this.Hide();
            f3.Show();
            //this.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl control = new UserControl();
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
