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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        String name, phoneNumber, Address, closeInt;

        private void phoneNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            phoneNumber = phoneNumber_textBox.Text;
        }

        private void address_textBox_TextChanged(object sender, EventArgs e)
        {
            Address = address_textBox.Text;
        }

        private void closeInt_textBox_TextChanged(object sender, EventArgs e)
        {
            closeInt = closeInt_textBox.Text;
        }

        private void cardInf_Click(object sender, EventArgs e)
        {
            if (Address == null || phoneNumber == null || closeInt == null || Name == null || Address == "" || phoneNumber == "" || closeInt == "" || Name == "")
            {
                Console.WriteLine("aaaaaaaaaaa");
            }
            else
            {
                Form6 f6 = new Form6();
                this.Hide();
                f6.Show();
                //this.BringToFront();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void home_button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            this.Hide();
            f1.Show();
            //this.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            name = name_textBox.Text;
        }

        private void back_Button5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            this.Hide();
            f4.Show();
            //this.BringToFront();
        }
    }
}
