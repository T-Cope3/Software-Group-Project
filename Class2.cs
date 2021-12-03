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
    public partial class Class2 : Form
    {
        private Label p9_pizzasauce;
        private Button p9_home;
        private Button p9_back;
        private Button p9_regular;
        private Button p9_alfredo;
        private Button p9_bbq;
        private Button p9_none;
        private Button p9_help;
        private Button p9_next;

        public Class2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.p9_pizzasauce = new System.Windows.Forms.Label();
            this.p9_home = new System.Windows.Forms.Button();
            this.p9_back = new System.Windows.Forms.Button();
            this.p9_regular = new System.Windows.Forms.Button();
            this.p9_alfredo = new System.Windows.Forms.Button();
            this.p9_bbq = new System.Windows.Forms.Button();
            this.p9_none = new System.Windows.Forms.Button();
            this.p9_help = new System.Windows.Forms.Button();
            this.p9_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p9_pizzasauce
            // 
            this.p9_pizzasauce.AutoSize = true;
            this.p9_pizzasauce.Location = new System.Drawing.Point(264, 51);
            this.p9_pizzasauce.Name = "p9_pizzasauce";
            this.p9_pizzasauce.Size = new System.Drawing.Size(86, 13);
            this.p9_pizzasauce.TabIndex = 0;
            this.p9_pizzasauce.Text = "Choose a Sauce";
            // 
            // p9_home
            // 
            this.p9_home.Location = new System.Drawing.Point(513, 12);
            this.p9_home.Name = "p9_home";
            this.p9_home.Size = new System.Drawing.Size(75, 23);
            this.p9_home.TabIndex = 1;
            this.p9_home.Text = "Home";
            this.p9_home.UseVisualStyleBackColor = true;
            // 
            // p9_back
            // 
            this.p9_back.Location = new System.Drawing.Point(12, 12);
            this.p9_back.Name = "p9_back";
            this.p9_back.Size = new System.Drawing.Size(75, 23);
            this.p9_back.TabIndex = 2;
            this.p9_back.Text = "Back";
            this.p9_back.UseVisualStyleBackColor = true;
            // 
            // p9_regular
            // 
            this.p9_regular.Location = new System.Drawing.Point(136, 120);
            this.p9_regular.Name = "p9_regular";
            this.p9_regular.Size = new System.Drawing.Size(106, 47);
            this.p9_regular.TabIndex = 3;
            this.p9_regular.Text = "Regular";
            this.p9_regular.UseVisualStyleBackColor = true;
            // 
            // p9_alfredo
            // 
            this.p9_alfredo.Location = new System.Drawing.Point(256, 119);
            this.p9_alfredo.Name = "p9_alfredo";
            this.p9_alfredo.Size = new System.Drawing.Size(106, 47);
            this.p9_alfredo.TabIndex = 4;
            this.p9_alfredo.Text = "Alfredo";
            this.p9_alfredo.UseVisualStyleBackColor = true;
            // 
            // p9_bbq
            // 
            this.p9_bbq.Location = new System.Drawing.Point(374, 119);
            this.p9_bbq.Name = "p9_bbq";
            this.p9_bbq.Size = new System.Drawing.Size(106, 47);
            this.p9_bbq.TabIndex = 5;
            this.p9_bbq.Text = "BBQ";
            this.p9_bbq.UseVisualStyleBackColor = true;
            // 
            // p9_none
            // 
            this.p9_none.Location = new System.Drawing.Point(256, 202);
            this.p9_none.Name = "p9_none";
            this.p9_none.Size = new System.Drawing.Size(106, 48);
            this.p9_none.TabIndex = 6;
            this.p9_none.Text = "No Sauce";
            this.p9_none.UseVisualStyleBackColor = true;
            // 
            // p9_help
            // 
            this.p9_help.Location = new System.Drawing.Point(12, 331);
            this.p9_help.Name = "p9_help";
            this.p9_help.Size = new System.Drawing.Size(75, 23);
            this.p9_help.TabIndex = 7;
            this.p9_help.Text = "Help";
            this.p9_help.UseVisualStyleBackColor = true;
            // 
            // p9_next
            // 
            this.p9_next.Location = new System.Drawing.Point(513, 331);
            this.p9_next.Name = "p9_next";
            this.p9_next.Size = new System.Drawing.Size(75, 23);
            this.p9_next.TabIndex = 8;
            this.p9_next.Text = "Next";
            this.p9_next.UseVisualStyleBackColor = true;
            // 
            // Class2
            // 
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.p9_next);
            this.Controls.Add(this.p9_help);
            this.Controls.Add(this.p9_none);
            this.Controls.Add(this.p9_bbq);
            this.Controls.Add(this.p9_alfredo);
            this.Controls.Add(this.p9_regular);
            this.Controls.Add(this.p9_back);
            this.Controls.Add(this.p9_home);
            this.Controls.Add(this.p9_pizzasauce);
            this.Name = "Class2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}