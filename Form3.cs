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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        String phoneNumber;
        String password;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (phoneNumber == null || password == null || phoneNumber == "" || password == "")
            {
                Console.WriteLine("Should we have a pop up here? just do nothing?");
                
            }
            else
            {
                Form4 f4 = new Form4();

                this.Hide();
                f4.Show();
            }
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void back_Button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            this.Hide();
            f2.Show();
            //this.BringToFront();
        }

        private void home_Button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            this.Hide();
            f1.Show();
            //this.BringToFront();
        }

        private void noAccount_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            this.Hide();
            f5.Show();
            //this.BringToFront();
        }

        private void noAccount_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            this.Hide();
            f5.Show();
            //this.BringToFront();
        }
        private void help_Button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("What does this button even do what why do we even have it who the heck doenst know how to type in a username and password what does this even mean");
        }

        
        private void phoneNumber_textBox_TextChanged(object sender, EventArgs e)
        {
        phoneNumber = phoneNumber_textBox.Text;
           
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            password = password_textBox.Text;
        }
    }
}
