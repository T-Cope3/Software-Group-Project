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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        String debCred, cardType, cardNum, expDate, CVV;

        private void credit5_Click(object sender, EventArgs e)
        {
            debCred = "Credit";
            Console.WriteLine("Credit");
        }

        private void visa5_Click(object sender, EventArgs e)
        {
            cardType = "Visa";
            Console.WriteLine("Visa");
        }

        private void discover5_Click(object sender, EventArgs e)
        {
            cardType = "Discover";
            Console.WriteLine("Discover");
        }

        private void master5_Click(object sender, EventArgs e)
        {
            cardType = "Master Card";
            Console.WriteLine("Master Card");
        }

        private void americanEx5_Click(object sender, EventArgs e)
        {
            cardType = "American Express";
            Console.WriteLine("American Express");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cardNum = cardNum_textBox.Text;

        }

        private void expDate_textBox_TextChanged(object sender, EventArgs e)
        {
            expDate = expDate_textBox.Text;
        }

        private void cvv_textBox_TextChanged(object sender, EventArgs e)
        {
            CVV = cvv_textBox.Text;
        }

        private void help5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Help");
        }

        private void submit5_Click(object sender, EventArgs e)
        {
            //Form8 f8 = new Form8();
            this.Hide();
            //f8.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void back5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
        }

        private void home5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();    
            f1.Show();
        }

        private void debit5_Click(object sender, EventArgs e)
        {
            debCred = "Debit";
            Console.WriteLine("Debit");
        }
    }
}
