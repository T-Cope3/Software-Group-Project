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
    public partial class Class5 : Form
    {
        private Button p12_back;
        private Button p12_home;
        private Button p12_homebutton;
        private Button p12_next;
        private Button p12_orderagain;
        private Button p12_diet;
        private Label p12_bevlabel;
        private Button p12_coke;
        private Button p12_sprite;
        private Button p12_pepsi;
        private Button p12_dr;
        private Button p12_small;
        private Button p12_medium;
        private Button p12_large;

        public Class5()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.p12_back = new System.Windows.Forms.Button();
            this.p12_home = new System.Windows.Forms.Button();
            this.p12_homebutton = new System.Windows.Forms.Button();
            this.p12_next = new System.Windows.Forms.Button();
            this.p12_orderagain = new System.Windows.Forms.Button();
            this.p12_diet = new System.Windows.Forms.Button();
            this.p12_bevlabel = new System.Windows.Forms.Label();
            this.p12_coke = new System.Windows.Forms.Button();
            this.p12_sprite = new System.Windows.Forms.Button();
            this.p12_pepsi = new System.Windows.Forms.Button();
            this.p12_dr = new System.Windows.Forms.Button();
            this.p12_small = new System.Windows.Forms.Button();
            this.p12_medium = new System.Windows.Forms.Button();
            this.p12_large = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p12_back
            // 
            this.p12_back.Location = new System.Drawing.Point(12, 12);
            this.p12_back.Name = "p12_back";
            this.p12_back.Size = new System.Drawing.Size(75, 23);
            this.p12_back.TabIndex = 0;
            this.p12_back.Text = "Back";
            this.p12_back.UseVisualStyleBackColor = true;
            // 
            // p12_home
            // 
            this.p12_home.Location = new System.Drawing.Point(513, 12);
            this.p12_home.Name = "p12_home";
            this.p12_home.Size = new System.Drawing.Size(75, 23);
            this.p12_home.TabIndex = 1;
            this.p12_home.Text = "Home";
            this.p12_home.UseVisualStyleBackColor = true;
            // 
            // p12_homebutton
            // 
            this.p12_homebutton.Location = new System.Drawing.Point(12, 331);
            this.p12_homebutton.Name = "p12_homebutton";
            this.p12_homebutton.Size = new System.Drawing.Size(75, 23);
            this.p12_homebutton.TabIndex = 2;
            this.p12_homebutton.Text = "Home";
            this.p12_homebutton.UseVisualStyleBackColor = true;
            // 
            // p12_next
            // 
            this.p12_next.Location = new System.Drawing.Point(513, 293);
            this.p12_next.Name = "p12_next";
            this.p12_next.Size = new System.Drawing.Size(75, 23);
            this.p12_next.TabIndex = 3;
            this.p12_next.Text = "Next";
            this.p12_next.UseVisualStyleBackColor = true;
            // 
            // p12_orderagain
            // 
            this.p12_orderagain.Location = new System.Drawing.Point(486, 321);
            this.p12_orderagain.Name = "p12_orderagain";
            this.p12_orderagain.Size = new System.Drawing.Size(102, 42);
            this.p12_orderagain.TabIndex = 4;
            this.p12_orderagain.Text = "Order Another";
            this.p12_orderagain.UseVisualStyleBackColor = true;
            // 
            // p12_diet
            // 
            this.p12_diet.Location = new System.Drawing.Point(56, 99);
            this.p12_diet.Name = "p12_diet";
            this.p12_diet.Size = new System.Drawing.Size(84, 51);
            this.p12_diet.TabIndex = 5;
            this.p12_diet.Text = "Diet Coke";
            this.p12_diet.UseVisualStyleBackColor = true;
            // 
            // p12_bevlabel
            // 
            this.p12_bevlabel.AutoSize = true;
            this.p12_bevlabel.Location = new System.Drawing.Point(246, 56);
            this.p12_bevlabel.Name = "p12_bevlabel";
            this.p12_bevlabel.Size = new System.Drawing.Size(101, 13);
            this.p12_bevlabel.TabIndex = 6;
            this.p12_bevlabel.Text = "Choose a Beverage";
            // 
            // p12_coke
            // 
            this.p12_coke.Location = new System.Drawing.Point(156, 100);
            this.p12_coke.Name = "p12_coke";
            this.p12_coke.Size = new System.Drawing.Size(84, 51);
            this.p12_coke.TabIndex = 7;
            this.p12_coke.Text = "Coke";
            this.p12_coke.UseVisualStyleBackColor = true;
            // 
            // p12_sprite
            // 
            this.p12_sprite.Location = new System.Drawing.Point(254, 100);
            this.p12_sprite.Name = "p12_sprite";
            this.p12_sprite.Size = new System.Drawing.Size(84, 51);
            this.p12_sprite.TabIndex = 8;
            this.p12_sprite.Text = "Sprite";
            this.p12_sprite.UseVisualStyleBackColor = true;
            // 
            // p12_pepsi
            // 
            this.p12_pepsi.Location = new System.Drawing.Point(348, 99);
            this.p12_pepsi.Name = "p12_pepsi";
            this.p12_pepsi.Size = new System.Drawing.Size(84, 51);
            this.p12_pepsi.TabIndex = 9;
            this.p12_pepsi.Text = "Pepsi";
            this.p12_pepsi.UseVisualStyleBackColor = true;
            // 
            // p12_dr
            // 
            this.p12_dr.Location = new System.Drawing.Point(451, 100);
            this.p12_dr.Name = "p12_dr";
            this.p12_dr.Size = new System.Drawing.Size(84, 51);
            this.p12_dr.TabIndex = 10;
            this.p12_dr.Text = "Dr. Pepper";
            this.p12_dr.UseVisualStyleBackColor = true;
            // 
            // p12_small
            // 
            this.p12_small.Location = new System.Drawing.Point(152, 195);
            this.p12_small.Name = "p12_small";
            this.p12_small.Size = new System.Drawing.Size(92, 37);
            this.p12_small.TabIndex = 11;
            this.p12_small.Text = "Small ($1.50)";
            this.p12_small.UseVisualStyleBackColor = true;
            // 
            // p12_medium
            // 
            this.p12_medium.Location = new System.Drawing.Point(250, 195);
            this.p12_medium.Name = "p12_medium";
            this.p12_medium.Size = new System.Drawing.Size(92, 37);
            this.p12_medium.TabIndex = 12;
            this.p12_medium.Text = "Medium ($2.00)";
            this.p12_medium.UseVisualStyleBackColor = true;
            // 
            // p12_large
            // 
            this.p12_large.Location = new System.Drawing.Point(348, 195);
            this.p12_large.Name = "p12_large";
            this.p12_large.Size = new System.Drawing.Size(92, 37);
            this.p12_large.TabIndex = 13;
            this.p12_large.Text = "Large ($2.50)";
            this.p12_large.UseVisualStyleBackColor = true;
            // 
            // Class5
            // 
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.p12_large);
            this.Controls.Add(this.p12_medium);
            this.Controls.Add(this.p12_small);
            this.Controls.Add(this.p12_dr);
            this.Controls.Add(this.p12_pepsi);
            this.Controls.Add(this.p12_sprite);
            this.Controls.Add(this.p12_coke);
            this.Controls.Add(this.p12_bevlabel);
            this.Controls.Add(this.p12_diet);
            this.Controls.Add(this.p12_orderagain);
            this.Controls.Add(this.p12_next);
            this.Controls.Add(this.p12_homebutton);
            this.Controls.Add(this.p12_home);
            this.Controls.Add(this.p12_back);
            this.Name = "Class5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}