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
    public partial class Class3 : Form
    {
        private Button p10_back;
        private Label p10_choosecrust;
        private Button p10_thin;
        private Button p10_reg;
        private Button p10_stuff;
        private Button p10_help;
        private Button p10_next;
        private Button p10_home;

        public Class3()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.p10_back = new System.Windows.Forms.Button();
            this.p10_home = new System.Windows.Forms.Button();
            this.p10_choosecrust = new System.Windows.Forms.Label();
            this.p10_thin = new System.Windows.Forms.Button();
            this.p10_reg = new System.Windows.Forms.Button();
            this.p10_stuff = new System.Windows.Forms.Button();
            this.p10_help = new System.Windows.Forms.Button();
            this.p10_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p10_back
            // 
            this.p10_back.Location = new System.Drawing.Point(12, 12);
            this.p10_back.Name = "p10_back";
            this.p10_back.Size = new System.Drawing.Size(75, 23);
            this.p10_back.TabIndex = 0;
            this.p10_back.Text = "Back";
            this.p10_back.UseVisualStyleBackColor = true;
            this.p10_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // p10_home
            // 
            this.p10_home.Location = new System.Drawing.Point(513, 12);
            this.p10_home.Name = "p10_home";
            this.p10_home.Size = new System.Drawing.Size(75, 23);
            this.p10_home.TabIndex = 1;
            this.p10_home.Text = "Home";
            this.p10_home.UseVisualStyleBackColor = true;
            // 
            // p10_choosecrust
            // 
            this.p10_choosecrust.AutoSize = true;
            this.p10_choosecrust.Location = new System.Drawing.Point(268, 74);
            this.p10_choosecrust.Name = "p10_choosecrust";
            this.p10_choosecrust.Size = new System.Drawing.Size(70, 13);
            this.p10_choosecrust.TabIndex = 2;
            this.p10_choosecrust.Text = "Choose Crust";
            // 
            // p10_thin
            // 
            this.p10_thin.Location = new System.Drawing.Point(138, 133);
            this.p10_thin.Name = "p10_thin";
            this.p10_thin.Size = new System.Drawing.Size(98, 64);
            this.p10_thin.TabIndex = 3;
            this.p10_thin.Text = "Thin";
            this.p10_thin.UseVisualStyleBackColor = true;
            // 
            // p10_reg
            // 
            this.p10_reg.Location = new System.Drawing.Point(255, 133);
            this.p10_reg.Name = "p10_reg";
            this.p10_reg.Size = new System.Drawing.Size(98, 64);
            this.p10_reg.TabIndex = 4;
            this.p10_reg.Text = "Regular";
            this.p10_reg.UseVisualStyleBackColor = true;
            // 
            // p10_stuff
            // 
            this.p10_stuff.Location = new System.Drawing.Point(364, 133);
            this.p10_stuff.Name = "p10_stuff";
            this.p10_stuff.Size = new System.Drawing.Size(98, 64);
            this.p10_stuff.TabIndex = 5;
            this.p10_stuff.Text = "Stuffed";
            this.p10_stuff.UseVisualStyleBackColor = true;
            // 
            // p10_help
            // 
            this.p10_help.Location = new System.Drawing.Point(12, 331);
            this.p10_help.Name = "p10_help";
            this.p10_help.Size = new System.Drawing.Size(75, 23);
            this.p10_help.TabIndex = 6;
            this.p10_help.Text = "Help";
            this.p10_help.UseVisualStyleBackColor = true;
            // 
            // p10_next
            // 
            this.p10_next.Location = new System.Drawing.Point(513, 331);
            this.p10_next.Name = "p10_next";
            this.p10_next.Size = new System.Drawing.Size(75, 23);
            this.p10_next.TabIndex = 7;
            this.p10_next.Text = "Next";
            this.p10_next.UseVisualStyleBackColor = true;
            // 
            // Class3
            // 
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.p10_next);
            this.Controls.Add(this.p10_help);
            this.Controls.Add(this.p10_stuff);
            this.Controls.Add(this.p10_reg);
            this.Controls.Add(this.p10_thin);
            this.Controls.Add(this.p10_choosecrust);
            this.Controls.Add(this.p10_home);
            this.Controls.Add(this.p10_back);
            this.Name = "Class3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}