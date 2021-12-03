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
    public partial class Class9 : Form
    {
        private Label p16_mamajaon;
        private Label p16_wait;
        private Label p15_count;
        private Button p16_trackorder;
        private Button p16_contact;
        private PictureBox p16_mamama;

        public Class9()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class9));
            this.p16_mamajaon = new System.Windows.Forms.Label();
            this.p16_wait = new System.Windows.Forms.Label();
            this.p15_count = new System.Windows.Forms.Label();
            this.p16_trackorder = new System.Windows.Forms.Button();
            this.p16_contact = new System.Windows.Forms.Button();
            this.p16_mamama = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p16_mamama)).BeginInit();
            this.SuspendLayout();
            // 
            // p16_mamajaon
            // 
            this.p16_mamajaon.AutoSize = true;
            this.p16_mamajaon.Location = new System.Drawing.Point(394, 52);
            this.p16_mamajaon.Name = "p16_mamajaon";
            this.p16_mamajaon.Size = new System.Drawing.Size(226, 16);
            this.p16_mamajaon.TabIndex = 0;
            this.p16_mamajaon.Text = "MAMA JOAN is preparing your pizza!";
            // 
            // p16_wait
            // 
            this.p16_wait.AutoSize = true;
            this.p16_wait.Location = new System.Drawing.Point(413, 244);
            this.p16_wait.Name = "p16_wait";
            this.p16_wait.Size = new System.Drawing.Size(134, 16);
            this.p16_wait.TabIndex = 1;
            this.p16_wait.Text = "Estimated Wait Time:";
            this.p16_wait.Click += new System.EventHandler(this.p16_wait_Click);
            // 
            // p15_count
            // 
            this.p15_count.AutoSize = true;
            this.p15_count.Location = new System.Drawing.Point(537, 244);
            this.p15_count.Name = "p15_count";
            this.p15_count.Size = new System.Drawing.Size(14, 16);
            this.p15_count.TabIndex = 2;
            this.p15_count.Text = "0";
            // 
            // p16_trackorder
            // 
            this.p16_trackorder.Location = new System.Drawing.Point(486, 306);
            this.p16_trackorder.Name = "p16_trackorder";
            this.p16_trackorder.Size = new System.Drawing.Size(102, 23);
            this.p16_trackorder.TabIndex = 3;
            this.p16_trackorder.Text = "Track My Order";
            this.p16_trackorder.UseVisualStyleBackColor = true;
            // 
            // p16_contact
            // 
            this.p16_contact.Location = new System.Drawing.Point(486, 335);
            this.p16_contact.Name = "p16_contact";
            this.p16_contact.Size = new System.Drawing.Size(102, 23);
            this.p16_contact.TabIndex = 4;
            this.p16_contact.Text = "Contact Us!";
            this.p16_contact.UseVisualStyleBackColor = true;
            // 
            // p16_mamama
            // 
            this.p16_mamama.Image = ((System.Drawing.Image)(resources.GetObject("p16_mamama.Image")));
            this.p16_mamama.Location = new System.Drawing.Point(-1, 28);
            this.p16_mamama.Name = "p16_mamama";
            this.p16_mamama.Size = new System.Drawing.Size(370, 343);
            this.p16_mamama.TabIndex = 5;
            this.p16_mamama.TabStop = false;
            // 
            // Class9
            // 
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.p16_mamama);
            this.Controls.Add(this.p16_contact);
            this.Controls.Add(this.p16_trackorder);
            this.Controls.Add(this.p15_count);
            this.Controls.Add(this.p16_wait);
            this.Controls.Add(this.p16_mamajaon);
            this.Name = "Class9";
            ((System.ComponentModel.ISupportInitialize)(this.p16_mamama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void p16_wait_Click(object sender, EventArgs e)
        {

        }
    }
}