namespace Software_Group_Project
{
    partial class Form3
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
            this.submit_Button3 = new System.Windows.Forms.Button();
            this.home_Button3 = new System.Windows.Forms.Button();
            this.back_Button3 = new System.Windows.Forms.Button();
            this.phone_Number_txt = new System.Windows.Forms.Label();
            this.phoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.passwordEnter = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.help_Button3 = new System.Windows.Forms.Button();
            this.noAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // submit_Button3
            // 
            this.submit_Button3.Location = new System.Drawing.Point(345, 289);
            this.submit_Button3.Name = "submit_Button3";
            this.submit_Button3.Size = new System.Drawing.Size(75, 23);
            this.submit_Button3.TabIndex = 1;
            this.submit_Button3.Text = "Submit";
            this.submit_Button3.UseVisualStyleBackColor = true;
            this.submit_Button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // home_Button3
            // 
            this.home_Button3.Location = new System.Drawing.Point(713, 12);
            this.home_Button3.Name = "home_Button3";
            this.home_Button3.Size = new System.Drawing.Size(75, 23);
            this.home_Button3.TabIndex = 2;
            this.home_Button3.Text = "Home";
            this.home_Button3.UseVisualStyleBackColor = true;
            this.home_Button3.Click += new System.EventHandler(this.home_Button3_Click);
            // 
            // back_Button3
            // 
            this.back_Button3.Location = new System.Drawing.Point(12, 12);
            this.back_Button3.Name = "back_Button3";
            this.back_Button3.Size = new System.Drawing.Size(75, 23);
            this.back_Button3.TabIndex = 3;
            this.back_Button3.Text = "Back";
            this.back_Button3.UseVisualStyleBackColor = true;
            this.back_Button3.Click += new System.EventHandler(this.back_Button3_Click);
            // 
            // phone_Number_txt
            // 
            this.phone_Number_txt.AutoSize = true;
            this.phone_Number_txt.Location = new System.Drawing.Point(192, 115);
            this.phone_Number_txt.Name = "phone_Number_txt";
            this.phone_Number_txt.Size = new System.Drawing.Size(100, 16);
            this.phone_Number_txt.TabIndex = 4;
            this.phone_Number_txt.Text = "Phone Number:";
            // 
            // phoneNumber_textBox
            // 
            this.phoneNumber_textBox.Location = new System.Drawing.Point(320, 115);
            this.phoneNumber_textBox.Name = "phoneNumber_textBox";
            this.phoneNumber_textBox.Size = new System.Drawing.Size(251, 22);
            this.phoneNumber_textBox.TabIndex = 5;
            this.phoneNumber_textBox.TextChanged += new System.EventHandler(this.phoneNumber_textBox_TextChanged);
            // 
            // passwordEnter
            // 
            this.passwordEnter.AutoSize = true;
            this.passwordEnter.Location = new System.Drawing.Point(192, 199);
            this.passwordEnter.Name = "passwordEnter";
            this.passwordEnter.Size = new System.Drawing.Size(70, 16);
            this.passwordEnter.TabIndex = 6;
            this.passwordEnter.Text = "Password:";
            this.passwordEnter.Click += new System.EventHandler(this.label2_Click);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(320, 199);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(251, 22);
            this.password_textBox.TabIndex = 7;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            // 
            // help_Button3
            // 
            this.help_Button3.Location = new System.Drawing.Point(12, 415);
            this.help_Button3.Name = "help_Button3";
            this.help_Button3.Size = new System.Drawing.Size(75, 23);
            this.help_Button3.TabIndex = 8;
            this.help_Button3.Text = "Help*";
            this.help_Button3.UseVisualStyleBackColor = true;
            this.help_Button3.Click += new System.EventHandler(this.help_Button3_Click);
            // 
            // noAccount
            // 
            this.noAccount.Location = new System.Drawing.Point(294, 329);
            this.noAccount.Name = "noAccount";
            this.noAccount.Size = new System.Drawing.Size(186, 23);
            this.noAccount.TabIndex = 9;
            this.noAccount.Text = "Don\'t Have An Account?";
            this.noAccount.UseVisualStyleBackColor = true;
            this.noAccount.Click += new System.EventHandler(this.noAccount_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noAccount);
            this.Controls.Add(this.help_Button3);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.passwordEnter);
            this.Controls.Add(this.phoneNumber_textBox);
            this.Controls.Add(this.phone_Number_txt);
            this.Controls.Add(this.back_Button3);
            this.Controls.Add(this.home_Button3);
            this.Controls.Add(this.submit_Button3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit_Button3;
        private System.Windows.Forms.Button home_Button3;
        private System.Windows.Forms.Button back_Button3;
        private System.Windows.Forms.Label phone_Number_txt;
        private System.Windows.Forms.TextBox phoneNumber_textBox;
        private System.Windows.Forms.Label passwordEnter;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button help_Button3;
        private System.Windows.Forms.Button noAccount;
    }
}