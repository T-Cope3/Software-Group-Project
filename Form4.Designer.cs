namespace Software_Group_Project
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.back_Button4 = new System.Windows.Forms.Button();
            this.home_Button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.currentPassword_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassword_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmNewPassword_textBox = new System.Windows.Forms.TextBox();
            this.help_Button4 = new System.Windows.Forms.Button();
            this.submit4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // back_Button4
            // 
            this.back_Button4.Location = new System.Drawing.Point(12, 12);
            this.back_Button4.Name = "back_Button4";
            this.back_Button4.Size = new System.Drawing.Size(75, 23);
            this.back_Button4.TabIndex = 1;
            this.back_Button4.Text = "Back";
            this.back_Button4.UseVisualStyleBackColor = true;
            this.back_Button4.Click += new System.EventHandler(this.Clicker_Click);
            // 
            // home_Button4
            // 
            this.home_Button4.Location = new System.Drawing.Point(713, 12);
            this.home_Button4.Name = "home_Button4";
            this.home_Button4.Size = new System.Drawing.Size(75, 23);
            this.home_Button4.TabIndex = 2;
            this.home_Button4.Text = "Home";
            this.home_Button4.UseVisualStyleBackColor = true;
            this.home_Button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Password:";
            // 
            // currentPassword_textBox
            // 
            this.currentPassword_textBox.Location = new System.Drawing.Point(328, 144);
            this.currentPassword_textBox.Name = "currentPassword_textBox";
            this.currentPassword_textBox.Size = new System.Drawing.Size(206, 22);
            this.currentPassword_textBox.TabIndex = 4;
            this.currentPassword_textBox.TextChanged += new System.EventHandler(this.currentPassword_textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "New Password:";
            // 
            // newPassword_textBox
            // 
            this.newPassword_textBox.Location = new System.Drawing.Point(328, 211);
            this.newPassword_textBox.Name = "newPassword_textBox";
            this.newPassword_textBox.Size = new System.Drawing.Size(206, 22);
            this.newPassword_textBox.TabIndex = 6;
            this.newPassword_textBox.TextChanged += new System.EventHandler(this.newPassword_textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm New Password:";
            // 
            // confirmNewPassword_textBox
            // 
            this.confirmNewPassword_textBox.Location = new System.Drawing.Point(328, 277);
            this.confirmNewPassword_textBox.Name = "confirmNewPassword_textBox";
            this.confirmNewPassword_textBox.Size = new System.Drawing.Size(206, 22);
            this.confirmNewPassword_textBox.TabIndex = 8;
            this.confirmNewPassword_textBox.TextChanged += new System.EventHandler(this.confirmNewPassword_textBox_TextChanged);
            // 
            // help_Button4
            // 
            this.help_Button4.Location = new System.Drawing.Point(12, 415);
            this.help_Button4.Name = "help_Button4";
            this.help_Button4.Size = new System.Drawing.Size(75, 23);
            this.help_Button4.TabIndex = 9;
            this.help_Button4.Text = "Help";
            this.help_Button4.UseVisualStyleBackColor = true;
            this.help_Button4.Click += new System.EventHandler(this.help_Button4_Click);
            // 
            // submit4
            // 
            this.submit4.Location = new System.Drawing.Point(348, 357);
            this.submit4.Name = "submit4";
            this.submit4.Size = new System.Drawing.Size(75, 23);
            this.submit4.TabIndex = 10;
            this.submit4.Text = "Submit";
            this.submit4.UseVisualStyleBackColor = true;
            this.submit4.Click += new System.EventHandler(this.submit4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit4);
            this.Controls.Add(this.help_Button4);
            this.Controls.Add(this.confirmNewPassword_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newPassword_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentPassword_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.home_Button4);
            this.Controls.Add(this.back_Button4);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_Button4;
        private System.Windows.Forms.Button home_Button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentPassword_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPassword_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmNewPassword_textBox;
        private System.Windows.Forms.Button help_Button4;
        private System.Windows.Forms.Button submit4;
    }
}