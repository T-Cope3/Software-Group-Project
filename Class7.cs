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
    public partial class Class7 : Form
    {
        private Button p14_back;
        private Button p14_Help;
        private Button p14_finalize;
        private Button p14_orderanother;
        private Label p14_tip;
        private Label p14_total;
        private TextBox p14_tipBox;
        private TextBox p14_totalBox;
        private Label p14_label;
        private Button p14_caltip;
        private Button p14_delivery;
        private Button p14_carryout;
        private Button p14_cash;
        private Button p14_card;
        private Button p14_check;
        private Button p14_Home;

        public Class7()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.p14_back = new System.Windows.Forms.Button();
            this.p14_Home = new System.Windows.Forms.Button();
            this.p14_Help = new System.Windows.Forms.Button();
            this.p14_finalize = new System.Windows.Forms.Button();
            this.p14_orderanother = new System.Windows.Forms.Button();
            this.p14_tip = new System.Windows.Forms.Label();
            this.p14_total = new System.Windows.Forms.Label();
            this.p14_tipBox = new System.Windows.Forms.TextBox();
            this.p14_totalBox = new System.Windows.Forms.TextBox();
            this.p14_label = new System.Windows.Forms.Label();
            this.p14_caltip = new System.Windows.Forms.Button();
            this.p14_delivery = new System.Windows.Forms.Button();
            this.p14_carryout = new System.Windows.Forms.Button();
            this.p14_cash = new System.Windows.Forms.Button();
            this.p14_card = new System.Windows.Forms.Button();
            this.p14_check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p14_back
            // 
            this.p14_back.Location = new System.Drawing.Point(12, 12);
            this.p14_back.Name = "p14_back";
            this.p14_back.Size = new System.Drawing.Size(75, 23);
            this.p14_back.TabIndex = 0;
            this.p14_back.Text = "Back";
            this.p14_back.UseVisualStyleBackColor = true;
            // 
            // p14_Home
            // 
            this.p14_Home.Location = new System.Drawing.Point(387, 12);
            this.p14_Home.Name = "p14_Home";
            this.p14_Home.Size = new System.Drawing.Size(75, 23);
            this.p14_Home.TabIndex = 1;
            this.p14_Home.Text = "Home";
            this.p14_Home.UseVisualStyleBackColor = true;
            this.p14_Home.Click += new System.EventHandler(this.button2_Click);
            // 
            // p14_Help
            // 
            this.p14_Help.Location = new System.Drawing.Point(12, 246);
            this.p14_Help.Name = "p14_Help";
            this.p14_Help.Size = new System.Drawing.Size(75, 23);
            this.p14_Help.TabIndex = 2;
            this.p14_Help.Text = "Help";
            this.p14_Help.UseVisualStyleBackColor = true;
            // 
            // p14_finalize
            // 
            this.p14_finalize.Location = new System.Drawing.Point(349, 232);
            this.p14_finalize.Name = "p14_finalize";
            this.p14_finalize.Size = new System.Drawing.Size(113, 37);
            this.p14_finalize.TabIndex = 3;
            this.p14_finalize.Text = "Finalize Order";
            this.p14_finalize.UseVisualStyleBackColor = true;
            this.p14_finalize.Click += new System.EventHandler(this.p14_finalize_Click);
            // 
            // p14_orderanother
            // 
            this.p14_orderanother.Location = new System.Drawing.Point(219, 232);
            this.p14_orderanother.Name = "p14_orderanother";
            this.p14_orderanother.Size = new System.Drawing.Size(113, 37);
            this.p14_orderanother.TabIndex = 4;
            this.p14_orderanother.Text = "Order Another";
            this.p14_orderanother.UseVisualStyleBackColor = true;
            this.p14_orderanother.Click += new System.EventHandler(this.p14_orderanother_Click);
            // 
            // p14_tip
            // 
            this.p14_tip.AutoSize = true;
            this.p14_tip.Location = new System.Drawing.Point(142, 74);
            this.p14_tip.Name = "p14_tip";
            this.p14_tip.Size = new System.Drawing.Size(30, 16);
            this.p14_tip.TabIndex = 5;
            this.p14_tip.Text = "Tip:";
            // 
            // p14_total
            // 
            this.p14_total.AutoSize = true;
            this.p14_total.Location = new System.Drawing.Point(133, 130);
            this.p14_total.Name = "p14_total";
            this.p14_total.Size = new System.Drawing.Size(41, 16);
            this.p14_total.TabIndex = 6;
            this.p14_total.Text = "Total:";
            // 
            // p14_tipBox
            // 
            this.p14_tipBox.Location = new System.Drawing.Point(200, 74);
            this.p14_tipBox.Name = "p14_tipBox";
            this.p14_tipBox.Size = new System.Drawing.Size(100, 22);
            this.p14_tipBox.TabIndex = 7;
            this.p14_tipBox.TextChanged += new System.EventHandler(this.p14_tipBox_TextChanged);
            // 
            // p14_totalBox
            // 
            this.p14_totalBox.Location = new System.Drawing.Point(200, 130);
            this.p14_totalBox.Name = "p14_totalBox";
            this.p14_totalBox.Size = new System.Drawing.Size(100, 22);
            this.p14_totalBox.TabIndex = 8;
            // 
            // p14_label
            // 
            this.p14_label.AutoSize = true;
            this.p14_label.Location = new System.Drawing.Point(216, 22);
            this.p14_label.Name = "p14_label";
            this.p14_label.Size = new System.Drawing.Size(63, 16);
            this.p14_label.TabIndex = 9;
            this.p14_label.Text = "Checkout";
            // 
            // p14_caltip
            // 
            this.p14_caltip.Location = new System.Drawing.Point(306, 55);
            this.p14_caltip.Name = "p14_caltip";
            this.p14_caltip.Size = new System.Drawing.Size(59, 39);
            this.p14_caltip.TabIndex = 10;
            this.p14_caltip.Text = "Calculate Tip";
            this.p14_caltip.UseVisualStyleBackColor = true;
            this.p14_caltip.Click += new System.EventHandler(this.p14_caltip_Click);
            // 
            // p14_delivery
            // 
            this.p14_delivery.Location = new System.Drawing.Point(145, 165);
            this.p14_delivery.Name = "p14_delivery";
            this.p14_delivery.Size = new System.Drawing.Size(75, 23);
            this.p14_delivery.TabIndex = 11;
            this.p14_delivery.Text = "Delivery";
            this.p14_delivery.UseVisualStyleBackColor = true;
            // 
            // p14_carryout
            // 
            this.p14_carryout.Location = new System.Drawing.Point(250, 165);
            this.p14_carryout.Name = "p14_carryout";
            this.p14_carryout.Size = new System.Drawing.Size(75, 23);
            this.p14_carryout.TabIndex = 12;
            this.p14_carryout.Text = "Carryout";
            this.p14_carryout.UseVisualStyleBackColor = true;
            // 
            // p14_cash
            // 
            this.p14_cash.Location = new System.Drawing.Point(103, 194);
            this.p14_cash.Name = "p14_cash";
            this.p14_cash.Size = new System.Drawing.Size(75, 23);
            this.p14_cash.TabIndex = 13;
            this.p14_cash.Text = "Cash";
            this.p14_cash.UseVisualStyleBackColor = true;
            // 
            // p14_card
            // 
            this.p14_card.Location = new System.Drawing.Point(200, 194);
            this.p14_card.Name = "p14_card";
            this.p14_card.Size = new System.Drawing.Size(75, 23);
            this.p14_card.TabIndex = 14;
            this.p14_card.Text = "Card";
            this.p14_card.UseVisualStyleBackColor = true;
            // 
            // p14_check
            // 
            this.p14_check.Location = new System.Drawing.Point(306, 194);
            this.p14_check.Name = "p14_check";
            this.p14_check.Size = new System.Drawing.Size(75, 23);
            this.p14_check.TabIndex = 15;
            this.p14_check.Text = "Check";
            this.p14_check.UseVisualStyleBackColor = true;
            // 
            // Class7
            // 
            this.ClientSize = new System.Drawing.Size(596, 356);
            this.Controls.Add(this.p14_check);
            this.Controls.Add(this.p14_card);
            this.Controls.Add(this.p14_cash);
            this.Controls.Add(this.p14_carryout);
            this.Controls.Add(this.p14_delivery);
            this.Controls.Add(this.p14_caltip);
            this.Controls.Add(this.p14_label);
            this.Controls.Add(this.p14_totalBox);
            this.Controls.Add(this.p14_tipBox);
            this.Controls.Add(this.p14_total);
            this.Controls.Add(this.p14_tip);
            this.Controls.Add(this.p14_orderanother);
            this.Controls.Add(this.p14_finalize);
            this.Controls.Add(this.p14_Help);
            this.Controls.Add(this.p14_Home);
            this.Controls.Add(this.p14_back);
            this.Name = "Class7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void p14_finalize_Click(object sender, EventArgs e)
        {

        }

        private void p14_orderanother_Click(object sender, EventArgs e)
        {

        }

        private void p14_tipBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void p14_caltip_Click(object sender, EventArgs e)
        {

        }
    }
}