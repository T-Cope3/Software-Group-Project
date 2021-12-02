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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        String name, phoneNumber, Address, closeInt;

        private void cardInformation6_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.Show();  
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Address = address_textBox.Text;
        }

        private void phoneNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            phoneNumber = phoneNumber_textBox.Text;
        }

        private void closeInt_textBox_TextChanged(object sender, EventArgs e)
        {
            closeInt = closeInt_textBox.Text;
        }

        private void homeButton6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void backButton6_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = name_textBox.Text;
        }
    }
}
