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
        private Button button1;
        private Button p15_change;

        public Class8()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Class8
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Class8";
            this.Load += new System.EventHandler(this.Class8_Load);
            this.ResumeLayout(false);

        }

        private void p15_change_Click(object sender, EventArgs e)
        {

        }

        private void Class8_Load(object sender, EventArgs e)
        {

        }
    }
}