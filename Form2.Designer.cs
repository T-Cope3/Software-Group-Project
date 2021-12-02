namespace Software_Group_Project
{
    partial class Form2
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
            this.change_Login = new System.Windows.Forms.Button();
            this.change_cardInfo = new System.Windows.Forms.Button();
            this.change_checkInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // change_Login
            // 
            this.change_Login.Location = new System.Drawing.Point(282, 142);
            this.change_Login.Name = "change_Login";
            this.change_Login.Size = new System.Drawing.Size(222, 60);
            this.change_Login.TabIndex = 0;
            this.change_Login.Text = "Change Log In";
            this.change_Login.UseVisualStyleBackColor = true;
            this.change_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // change_cardInfo
            // 
            this.change_cardInfo.Location = new System.Drawing.Point(282, 208);
            this.change_cardInfo.Name = "change_cardInfo";
            this.change_cardInfo.Size = new System.Drawing.Size(222, 60);
            this.change_cardInfo.TabIndex = 1;
            this.change_cardInfo.Text = "Change Card Info";
            this.change_cardInfo.UseVisualStyleBackColor = true;
            this.change_cardInfo.Click += new System.EventHandler(this.button2_Click);
            // 
            // change_checkInfo
            // 
            this.change_checkInfo.Location = new System.Drawing.Point(282, 274);
            this.change_checkInfo.Name = "change_checkInfo";
            this.change_checkInfo.Size = new System.Drawing.Size(222, 60);
            this.change_checkInfo.TabIndex = 2;
            this.change_checkInfo.Text = "Change Check Info";
            this.change_checkInfo.UseVisualStyleBackColor = true;
            this.change_checkInfo.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Junction Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.change_checkInfo);
            this.Controls.Add(this.change_cardInfo);
            this.Controls.Add(this.change_Login);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change_Login;
        private System.Windows.Forms.Button change_cardInfo;
        private System.Windows.Forms.Button change_checkInfo;
        private System.Windows.Forms.Label label1;
    }
}