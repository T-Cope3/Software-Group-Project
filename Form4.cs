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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        String currentPassword, confirmNewPassword, newPassword;
        
        private void Clicker_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
           
            //this.Hide();
            f3.Show();
            //this.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)//the home button
        {
            Form1 f1 = new Form1();

            //this.Hide();
            f1.Show();
            //this.BringToFront();
        }

        private void newPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            newPassword = newPassword_textBox.Text;
        }

        private void confirmNewPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            confirmNewPassword = confirmNewPassword_textBox.Text;
        }

        private void submit4_Click(object sender, EventArgs e)
        {
            if((confirmNewPassword == null || newPassword == null || currentPassword == null|| confirmNewPassword == "" || newPassword == "" || currentPassword == "") ||(confirmNewPassword!=newPassword))
            {
                Console.WriteLine("Don't continue enter your password stuipd.");
            }
            else
            {
                Form5 f5 = new Form5();

                //this.Hide();
                f5.Show();
                //this.BringToFront();
            }
        }

        private void help_Button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("What does this button even do what why do we even have it who the heck doenst know how to type in a username and password what does this even mean");
        }

        private void currentPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            currentPassword = currentPassword_textBox.Text;
        }
    }
}
