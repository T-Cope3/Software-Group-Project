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
    public partial class Class4 : Form
    {
        private Button p11_back;
        private Button p11_home;
        private Button p11_help;
        private Button p11_next;
        private Label p11_labeltop;
        private Button p11_cheese;
        private Button p11_pepp;
        private Button p11_bacon;
        private Button p11_ham;
        private Button p11_pine;
        private Button p11_mush;
        private Button p11_olive;
        private Button p11_doub;
        private Button p11_meatcombo;
        private Button p11_veglove;

        public Class4()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.p11_back = new System.Windows.Forms.Button();
            this.p11_home = new System.Windows.Forms.Button();
            this.p11_help = new System.Windows.Forms.Button();
            this.p11_next = new System.Windows.Forms.Button();
            this.p11_labeltop = new System.Windows.Forms.Label();
            this.p11_cheese = new System.Windows.Forms.Button();
            this.p11_pepp = new System.Windows.Forms.Button();
            this.p11_bacon = new System.Windows.Forms.Button();
            this.p11_ham = new System.Windows.Forms.Button();
            this.p11_pine = new System.Windows.Forms.Button();
            this.p11_mush = new System.Windows.Forms.Button();
            this.p11_olive = new System.Windows.Forms.Button();
            this.p11_doub = new System.Windows.Forms.Button();
            this.p11_meatcombo = new System.Windows.Forms.Button();
            this.p11_veglove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p11_back
            // 
            this.p11_back.Location = new System.Drawing.Point(13, 13);
            this.p11_back.Name = "p11_back";
            this.p11_back.Size = new System.Drawing.Size(75, 23);
            this.p11_back.TabIndex = 0;
            this.p11_back.Text = "Back";
            this.p11_back.UseVisualStyleBackColor = true;
            // 
            // p11_home
            // 
            this.p11_home.Location = new System.Drawing.Point(513, 12);
            this.p11_home.Name = "p11_home";
            this.p11_home.Size = new System.Drawing.Size(75, 23);
            this.p11_home.TabIndex = 1;
            this.p11_home.Text = "Home";
            this.p11_home.UseVisualStyleBackColor = true;
            // 
            // p11_help
            // 
            this.p11_help.Location = new System.Drawing.Point(13, 331);
            this.p11_help.Name = "p11_help";
            this.p11_help.Size = new System.Drawing.Size(75, 23);
            this.p11_help.TabIndex = 2;
            this.p11_help.Text = "Help";
            this.p11_help.UseVisualStyleBackColor = true;
            // 
            // p11_next
            // 
            this.p11_next.Location = new System.Drawing.Point(513, 331);
            this.p11_next.Name = "p11_next";
            this.p11_next.Size = new System.Drawing.Size(75, 23);
            this.p11_next.TabIndex = 3;
            this.p11_next.Text = "Next";
            this.p11_next.UseVisualStyleBackColor = true;
            // 
            // p11_labeltop
            // 
            this.p11_labeltop.AutoSize = true;
            this.p11_labeltop.Location = new System.Drawing.Point(240, 47);
            this.p11_labeltop.Name = "p11_labeltop";
            this.p11_labeltop.Size = new System.Drawing.Size(108, 13);
            this.p11_labeltop.TabIndex = 4;
            this.p11_labeltop.Text = "Toppings each $0.50";
            // 
            // p11_cheese
            // 
            this.p11_cheese.Location = new System.Drawing.Point(95, 112);
            this.p11_cheese.Name = "p11_cheese";
            this.p11_cheese.Size = new System.Drawing.Size(75, 23);
            this.p11_cheese.TabIndex = 5;
            this.p11_cheese.Text = "Cheese";
            this.p11_cheese.UseVisualStyleBackColor = true;
            // 
            // p11_pepp
            // 
            this.p11_pepp.Location = new System.Drawing.Point(202, 111);
            this.p11_pepp.Name = "p11_pepp";
            this.p11_pepp.Size = new System.Drawing.Size(75, 23);
            this.p11_pepp.TabIndex = 6;
            this.p11_pepp.Text = "Pepperoni";
            this.p11_pepp.UseVisualStyleBackColor = true;
            // 
            // p11_bacon
            // 
            this.p11_bacon.Location = new System.Drawing.Point(305, 112);
            this.p11_bacon.Name = "p11_bacon";
            this.p11_bacon.Size = new System.Drawing.Size(75, 23);
            this.p11_bacon.TabIndex = 7;
            this.p11_bacon.Text = "Bacon";
            this.p11_bacon.UseVisualStyleBackColor = true;
            // 
            // p11_ham
            // 
            this.p11_ham.Location = new System.Drawing.Point(403, 112);
            this.p11_ham.Name = "p11_ham";
            this.p11_ham.Size = new System.Drawing.Size(75, 23);
            this.p11_ham.TabIndex = 8;
            this.p11_ham.Text = "Ham";
            this.p11_ham.UseVisualStyleBackColor = true;
            // 
            // p11_pine
            // 
            this.p11_pine.Location = new System.Drawing.Point(95, 163);
            this.p11_pine.Name = "p11_pine";
            this.p11_pine.Size = new System.Drawing.Size(75, 23);
            this.p11_pine.TabIndex = 9;
            this.p11_pine.Text = "Pineapple";
            this.p11_pine.UseVisualStyleBackColor = true;
            // 
            // p11_mush
            // 
            this.p11_mush.Location = new System.Drawing.Point(202, 162);
            this.p11_mush.Name = "p11_mush";
            this.p11_mush.Size = new System.Drawing.Size(75, 23);
            this.p11_mush.TabIndex = 10;
            this.p11_mush.Text = "Mushroom";
            this.p11_mush.UseVisualStyleBackColor = true;
            // 
            // p11_olive
            // 
            this.p11_olive.Location = new System.Drawing.Point(305, 162);
            this.p11_olive.Name = "p11_olive";
            this.p11_olive.Size = new System.Drawing.Size(75, 23);
            this.p11_olive.TabIndex = 11;
            this.p11_olive.Text = "Olives";
            this.p11_olive.UseVisualStyleBackColor = true;
            // 
            // p11_doub
            // 
            this.p11_doub.Location = new System.Drawing.Point(403, 163);
            this.p11_doub.Name = "p11_doub";
            this.p11_doub.Size = new System.Drawing.Size(94, 23);
            this.p11_doub.TabIndex = 12;
            this.p11_doub.Text = "Double Cheese";
            this.p11_doub.UseVisualStyleBackColor = true;
            // 
            // p11_meatcombo
            // 
            this.p11_meatcombo.Location = new System.Drawing.Point(137, 216);
            this.p11_meatcombo.Name = "p11_meatcombo";
            this.p11_meatcombo.Size = new System.Drawing.Size(100, 65);
            this.p11_meatcombo.TabIndex = 13;
            this.p11_meatcombo.Text = "3 Meat and Cheese Combo";
            this.p11_meatcombo.UseVisualStyleBackColor = true;
            // 
            // p11_veglove
            // 
            this.p11_veglove.Location = new System.Drawing.Point(334, 216);
            this.p11_veglove.Name = "p11_veglove";
            this.p11_veglove.Size = new System.Drawing.Size(100, 65);
            this.p11_veglove.TabIndex = 14;
            this.p11_veglove.Text = "Veggie Lovers Combo";
            this.p11_veglove.UseVisualStyleBackColor = true;
            // 
            // Class4
            // 
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.p11_veglove);
            this.Controls.Add(this.p11_meatcombo);
            this.Controls.Add(this.p11_doub);
            this.Controls.Add(this.p11_olive);
            this.Controls.Add(this.p11_mush);
            this.Controls.Add(this.p11_pine);
            this.Controls.Add(this.p11_ham);
            this.Controls.Add(this.p11_bacon);
            this.Controls.Add(this.p11_pepp);
            this.Controls.Add(this.p11_cheese);
            this.Controls.Add(this.p11_labeltop);
            this.Controls.Add(this.p11_next);
            this.Controls.Add(this.p11_help);
            this.Controls.Add(this.p11_home);
            this.Controls.Add(this.p11_back);
            this.Name = "Class4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}