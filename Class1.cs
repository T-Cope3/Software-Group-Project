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
    public partial class Class1 : Form
    {
        private Button p8_back;
        private Button p8_home;
        private Label p8_choosesize;
        private Button p8_small;
        private Button p8_medium;
        private Button p8_large;
        private Button p8_crusade;
        private Button p8_help;
        private Button p8_next;

        public Class1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.p8_back = new System.Windows.Forms.Button();
            this.p8_home = new System.Windows.Forms.Button();
            this.p8_choosesize = new System.Windows.Forms.Label();
            this.p8_small = new System.Windows.Forms.Button();
            this.p8_medium = new System.Windows.Forms.Button();
            this.p8_large = new System.Windows.Forms.Button();
            this.p8_crusade = new System.Windows.Forms.Button();
            this.p8_help = new System.Windows.Forms.Button();
            this.p8_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p8_back
            // 
            this.p8_back.Location = new System.Drawing.Point(13, 13);
            this.p8_back.Name = "p8_back";
            this.p8_back.Size = new System.Drawing.Size(75, 23);
            this.p8_back.TabIndex = 0;
            this.p8_back.Text = "Back";
            this.p8_back.UseVisualStyleBackColor = true;
            this.p8_back.Click += new System.EventHandler(this.p8_back_Click);
            // 
            // p8_home
            // 
            this.p8_home.Location = new System.Drawing.Point(507, 12);
            this.p8_home.Name = "p8_home";
            this.p8_home.Size = new System.Drawing.Size(75, 23);
            this.p8_home.TabIndex = 1;
            this.p8_home.Text = "Home";
            this.p8_home.UseVisualStyleBackColor = true;
            // 
            // p8_choosesize
            // 
            this.p8_choosesize.AutoSize = true;
            this.p8_choosesize.Location = new System.Drawing.Point(247, 75);
            this.p8_choosesize.Name = "p8_choosesize";
            this.p8_choosesize.Size = new System.Drawing.Size(94, 13);
            this.p8_choosesize.TabIndex = 2;
            this.p8_choosesize.Text = "Choose Pizza Size";
            // 
            // p8_small
            // 
            this.p8_small.Location = new System.Drawing.Point(107, 133);
            this.p8_small.Name = "p8_small";
            this.p8_small.Size = new System.Drawing.Size(90, 60);
            this.p8_small.TabIndex = 3;
            this.p8_small.Text = "Small ($8.99)";
            this.p8_small.UseVisualStyleBackColor = true;
            // 
            // p8_medium
            // 
            this.p8_medium.Location = new System.Drawing.Point(250, 133);
            this.p8_medium.Name = "p8_medium";
            this.p8_medium.Size = new System.Drawing.Size(91, 60);
            this.p8_medium.TabIndex = 4;
            this.p8_medium.Text = "Medium ($10.99)";
            this.p8_medium.UseVisualStyleBackColor = true;
            // 
            // p8_large
            // 
            this.p8_large.Location = new System.Drawing.Point(383, 133);
            this.p8_large.Name = "p8_large";
            this.p8_large.Size = new System.Drawing.Size(91, 60);
            this.p8_large.TabIndex = 5;
            this.p8_large.Text = "Large ($12.99)";
            this.p8_large.UseVisualStyleBackColor = true;
            // 
            // p8_crusade
            // 
            this.p8_crusade.Location = new System.Drawing.Point(224, 225);
            this.p8_crusade.Name = "p8_crusade";
            this.p8_crusade.Size = new System.Drawing.Size(138, 77);
            this.p8_crusade.TabIndex = 6;
            this.p8_crusade.Text = "Crusade Size ($17.99)";
            this.p8_crusade.UseVisualStyleBackColor = true;
            // 
            // p8_help
            // 
            this.p8_help.Location = new System.Drawing.Point(13, 331);
            this.p8_help.Name = "p8_help";
            this.p8_help.Size = new System.Drawing.Size(75, 23);
            this.p8_help.TabIndex = 7;
            this.p8_help.Text = "Help";
            this.p8_help.UseVisualStyleBackColor = true;
            // 
            // p8_next
            // 
            this.p8_next.Location = new System.Drawing.Point(507, 331);
            this.p8_next.Name = "p8_next";
            this.p8_next.Size = new System.Drawing.Size(75, 23);
            this.p8_next.TabIndex = 8;
            this.p8_next.Text = "Next";
            this.p8_next.UseVisualStyleBackColor = true;
            // 
            // Class1
            // 
            this.ClientSize = new System.Drawing.Size(594, 366);
            this.Controls.Add(this.p8_next);
            this.Controls.Add(this.p8_help);
            this.Controls.Add(this.p8_crusade);
            this.Controls.Add(this.p8_large);
            this.Controls.Add(this.p8_medium);
            this.Controls.Add(this.p8_small);
            this.Controls.Add(this.p8_choosesize);
            this.Controls.Add(this.p8_home);
            this.Controls.Add(this.p8_back);
            this.Name = "Class1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void p8_back_Click(object sender, EventArgs e)
        {
            
        }
    }
}