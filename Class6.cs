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
    public partial class Class6 : Form
    {
        private Button p13_back;
        private Button p13_home;
        private Label p13_reviewlabel;
        private Label p13_items;
        private Label p13_pizza2desc;
        private Label p13_pizza3desc;
        private Button p13_addmore;
        private Button p13_proceed;
        private Label p13_remove;
        private Button p13_removepizza1;
        private Button p13_removepizza2;
        private Button p13_removepizza3;
        private Label p13_modify;
        private Button p13_modpizza1;
        private Button p13_modpizza2;
        private Button p13_modpizza3;
        private Label p13_pizza1desc;

        public Class6()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.p13_back = new System.Windows.Forms.Button();
            this.p13_home = new System.Windows.Forms.Button();
            this.p13_reviewlabel = new System.Windows.Forms.Label();
            this.p13_items = new System.Windows.Forms.Label();
            this.p13_pizza1desc = new System.Windows.Forms.Label();
            this.p13_pizza2desc = new System.Windows.Forms.Label();
            this.p13_pizza3desc = new System.Windows.Forms.Label();
            this.p13_addmore = new System.Windows.Forms.Button();
            this.p13_proceed = new System.Windows.Forms.Button();
            this.p13_remove = new System.Windows.Forms.Label();
            this.p13_removepizza1 = new System.Windows.Forms.Button();
            this.p13_removepizza2 = new System.Windows.Forms.Button();
            this.p13_removepizza3 = new System.Windows.Forms.Button();
            this.p13_modify = new System.Windows.Forms.Label();
            this.p13_modpizza1 = new System.Windows.Forms.Button();
            this.p13_modpizza2 = new System.Windows.Forms.Button();
            this.p13_modpizza3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p13_back
            // 
            this.p13_back.Location = new System.Drawing.Point(12, 12);
            this.p13_back.Name = "p13_back";
            this.p13_back.Size = new System.Drawing.Size(75, 23);
            this.p13_back.TabIndex = 0;
            this.p13_back.Text = "Back";
            this.p13_back.UseVisualStyleBackColor = true;
            // 
            // p13_home
            // 
            this.p13_home.Location = new System.Drawing.Point(513, 12);
            this.p13_home.Name = "p13_home";
            this.p13_home.Size = new System.Drawing.Size(75, 23);
            this.p13_home.TabIndex = 1;
            this.p13_home.Text = "Home";
            this.p13_home.UseVisualStyleBackColor = true;
            // 
            // p13_reviewlabel
            // 
            this.p13_reviewlabel.AutoSize = true;
            this.p13_reviewlabel.Location = new System.Drawing.Point(275, 17);
            this.p13_reviewlabel.Name = "p13_reviewlabel";
            this.p13_reviewlabel.Size = new System.Drawing.Size(72, 13);
            this.p13_reviewlabel.TabIndex = 2;
            this.p13_reviewlabel.Text = "Review Order";
            // 
            // p13_items
            // 
            this.p13_items.AutoSize = true;
            this.p13_items.Location = new System.Drawing.Point(86, 79);
            this.p13_items.Name = "p13_items";
            this.p13_items.Size = new System.Drawing.Size(32, 13);
            this.p13_items.TabIndex = 3;
            this.p13_items.Text = "Items";
            // 
            // p13_pizza1desc
            // 
            this.p13_pizza1desc.AutoSize = true;
            this.p13_pizza1desc.Location = new System.Drawing.Point(83, 128);
            this.p13_pizza1desc.Name = "p13_pizza1desc";
            this.p13_pizza1desc.Size = new System.Drawing.Size(35, 13);
            this.p13_pizza1desc.TabIndex = 4;
            this.p13_pizza1desc.Text = "label1";
            // 
            // p13_pizza2desc
            // 
            this.p13_pizza2desc.AutoSize = true;
            this.p13_pizza2desc.Location = new System.Drawing.Point(83, 187);
            this.p13_pizza2desc.Name = "p13_pizza2desc";
            this.p13_pizza2desc.Size = new System.Drawing.Size(35, 13);
            this.p13_pizza2desc.TabIndex = 5;
            this.p13_pizza2desc.Text = "label2";
            // 
            // p13_pizza3desc
            // 
            this.p13_pizza3desc.AutoSize = true;
            this.p13_pizza3desc.Location = new System.Drawing.Point(86, 243);
            this.p13_pizza3desc.Name = "p13_pizza3desc";
            this.p13_pizza3desc.Size = new System.Drawing.Size(35, 13);
            this.p13_pizza3desc.TabIndex = 6;
            this.p13_pizza3desc.Text = "label3";
            // 
            // p13_addmore
            // 
            this.p13_addmore.Location = new System.Drawing.Point(488, 288);
            this.p13_addmore.Name = "p13_addmore";
            this.p13_addmore.Size = new System.Drawing.Size(100, 29);
            this.p13_addmore.TabIndex = 7;
            this.p13_addmore.Text = "Add More Items";
            this.p13_addmore.UseVisualStyleBackColor = true;
            // 
            // p13_proceed
            // 
            this.p13_proceed.Location = new System.Drawing.Point(423, 323);
            this.p13_proceed.Name = "p13_proceed";
            this.p13_proceed.Size = new System.Drawing.Size(165, 40);
            this.p13_proceed.TabIndex = 8;
            this.p13_proceed.Text = "Proceed to Payment";
            this.p13_proceed.UseVisualStyleBackColor = true;
            this.p13_proceed.Click += new System.EventHandler(this.button1_Click);
            // 
            // p13_remove
            // 
            this.p13_remove.AutoSize = true;
            this.p13_remove.Location = new System.Drawing.Point(275, 79);
            this.p13_remove.Name = "p13_remove";
            this.p13_remove.Size = new System.Drawing.Size(47, 13);
            this.p13_remove.TabIndex = 9;
            this.p13_remove.Text = "Remove";
            // 
            // p13_removepizza1
            // 
            this.p13_removepizza1.Location = new System.Drawing.Point(278, 128);
            this.p13_removepizza1.Name = "p13_removepizza1";
            this.p13_removepizza1.Size = new System.Drawing.Size(24, 18);
            this.p13_removepizza1.TabIndex = 10;
            this.p13_removepizza1.UseVisualStyleBackColor = true;
            // 
            // p13_removepizza2
            // 
            this.p13_removepizza2.Location = new System.Drawing.Point(278, 187);
            this.p13_removepizza2.Name = "p13_removepizza2";
            this.p13_removepizza2.Size = new System.Drawing.Size(24, 18);
            this.p13_removepizza2.TabIndex = 11;
            this.p13_removepizza2.UseVisualStyleBackColor = true;
            // 
            // p13_removepizza3
            // 
            this.p13_removepizza3.Location = new System.Drawing.Point(278, 240);
            this.p13_removepizza3.Name = "p13_removepizza3";
            this.p13_removepizza3.Size = new System.Drawing.Size(24, 18);
            this.p13_removepizza3.TabIndex = 12;
            this.p13_removepizza3.UseVisualStyleBackColor = true;
            // 
            // p13_modify
            // 
            this.p13_modify.AutoSize = true;
            this.p13_modify.Location = new System.Drawing.Point(414, 79);
            this.p13_modify.Name = "p13_modify";
            this.p13_modify.Size = new System.Drawing.Size(38, 13);
            this.p13_modify.TabIndex = 13;
            this.p13_modify.Text = "Modify";
            // 
            // p13_modpizza1
            // 
            this.p13_modpizza1.Location = new System.Drawing.Point(417, 128);
            this.p13_modpizza1.Name = "p13_modpizza1";
            this.p13_modpizza1.Size = new System.Drawing.Size(24, 18);
            this.p13_modpizza1.TabIndex = 14;
            this.p13_modpizza1.UseVisualStyleBackColor = true;
            // 
            // p13_modpizza2
            // 
            this.p13_modpizza2.Location = new System.Drawing.Point(414, 187);
            this.p13_modpizza2.Name = "p13_modpizza2";
            this.p13_modpizza2.Size = new System.Drawing.Size(24, 18);
            this.p13_modpizza2.TabIndex = 15;
            this.p13_modpizza2.UseVisualStyleBackColor = true;
            // 
            // p13_modpizza3
            // 
            this.p13_modpizza3.Location = new System.Drawing.Point(414, 243);
            this.p13_modpizza3.Name = "p13_modpizza3";
            this.p13_modpizza3.Size = new System.Drawing.Size(24, 18);
            this.p13_modpizza3.TabIndex = 16;
            this.p13_modpizza3.UseVisualStyleBackColor = true;
            // 
            // Class6
            // 
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.p13_modpizza3);
            this.Controls.Add(this.p13_modpizza2);
            this.Controls.Add(this.p13_modpizza1);
            this.Controls.Add(this.p13_modify);
            this.Controls.Add(this.p13_removepizza3);
            this.Controls.Add(this.p13_removepizza2);
            this.Controls.Add(this.p13_removepizza1);
            this.Controls.Add(this.p13_remove);
            this.Controls.Add(this.p13_proceed);
            this.Controls.Add(this.p13_addmore);
            this.Controls.Add(this.p13_pizza3desc);
            this.Controls.Add(this.p13_pizza2desc);
            this.Controls.Add(this.p13_pizza1desc);
            this.Controls.Add(this.p13_items);
            this.Controls.Add(this.p13_reviewlabel);
            this.Controls.Add(this.p13_home);
            this.Controls.Add(this.p13_back);
            this.Name = "Class6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}