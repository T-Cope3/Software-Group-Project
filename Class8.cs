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
    public partial class Class8 : Form
    {
        private Label p15_translabel;
        private Button p15_home;
        private Button p15_back;
        private Button p15_help;
        private Button p15_signin;
        private Button p15_carddir;
        private Button p15_change;

        public Class8()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.p15_translabel = new System.Windows.Forms.Label();
            this.p15_home = new System.Windows.Forms.Button();
            this.p15_back = new System.Windows.Forms.Button();
            this.p15_help = new System.Windows.Forms.Button();
            this.p15_signin = new System.Windows.Forms.Button();
            this.p15_carddir = new System.Windows.Forms.Button();
            this.p15_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p15_translabel
            // 
            this.p15_translabel.AutoSize = true;
            this.p15_translabel.Location = new System.Drawing.Point(248, 50);
            this.p15_translabel.Name = "p15_translabel";
            this.p15_translabel.Size = new System.Drawing.Size(81, 13);
            this.p15_translabel.TabIndex = 0;
            this.p15_translabel.Text = "Transition Page";
            // 
            // p15_home
            // 
            this.p15_home.Location = new System.Drawing.Point(513, 12);
            this.p15_home.Name = "p15_home";
            this.p15_home.Size = new System.Drawing.Size(75, 23);
            this.p15_home.TabIndex = 1;
            this.p15_home.Text = "Home";
            this.p15_home.UseVisualStyleBackColor = true;
            // 
            // p15_back
            // 
            this.p15_back.Location = new System.Drawing.Point(12, 12);
            this.p15_back.Name = "p15_back";
            this.p15_back.Size = new System.Drawing.Size(75, 23);
            this.p15_back.TabIndex = 2;
            this.p15_back.Text = "Back";
            this.p15_back.UseVisualStyleBackColor = true;
            // 
            // p15_help
            // 
            this.p15_help.Location = new System.Drawing.Point(12, 331);
            this.p15_help.Name = "p15_help";
            this.p15_help.Size = new System.Drawing.Size(75, 23);
            this.p15_help.TabIndex = 3;
            this.p15_help.Text = "Help";
            this.p15_help.UseVisualStyleBackColor = true;
            // 
            // p15_signin
            // 
            this.p15_signin.Location = new System.Drawing.Point(213, 119);
            this.p15_signin.Name = "p15_signin";
            this.p15_signin.Size = new System.Drawing.Size(154, 23);
            this.p15_signin.TabIndex = 4;
            this.p15_signin.Text = "Would you like to sign in?";
            this.p15_signin.UseVisualStyleBackColor = true;
            // 
            // p15_carddir
            // 
            this.p15_carddir.Location = new System.Drawing.Point(190, 168);
            this.p15_carddir.Name = "p15_carddir";
            this.p15_carddir.Size = new System.Drawing.Size(210, 23);
            this.p15_carddir.TabIndex = 5;
            this.p15_carddir.Text = "Or enter card information directly?";
            this.p15_carddir.UseVisualStyleBackColor = true;
            // 
            // p15_change
            // 
            this.p15_change.Location = new System.Drawing.Point(232, 219);
            this.p15_change.Name = "p15_change";
            this.p15_change.Size = new System.Drawing.Size(116, 23);
            this.p15_change.TabIndex = 6;
            this.p15_change.Text = "Change Information?";
            this.p15_change.UseVisualStyleBackColor = true;
            // 
            // Class8
            // 
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.p15_change);
            this.Controls.Add(this.p15_carddir);
            this.Controls.Add(this.p15_signin);
            this.Controls.Add(this.p15_help);
            this.Controls.Add(this.p15_back);
            this.Controls.Add(this.p15_home);
            this.Controls.Add(this.p15_translabel);
            this.Name = "Class8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}