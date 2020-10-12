namespace ICT526_A2_Grp1
{
    partial class Form1
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
            this.tbUserNameKim = new System.Windows.Forms.TextBox();
            this.btnLogInKim = new System.Windows.Forms.Button();
            this.lbUserNameKim = new System.Windows.Forms.Label();
            this.lbPasswordKim = new System.Windows.Forms.Label();
            this.tbPasswordKim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbUserNameKim
            // 
            this.tbUserNameKim.Location = new System.Drawing.Point(195, 69);
            this.tbUserNameKim.Name = "tbUserNameKim";
            this.tbUserNameKim.Size = new System.Drawing.Size(100, 25);
            this.tbUserNameKim.TabIndex = 0;
            // 
            // btnLogInKim
            // 
            this.btnLogInKim.Location = new System.Drawing.Point(144, 264);
            this.btnLogInKim.Name = "btnLogInKim";
            this.btnLogInKim.Size = new System.Drawing.Size(75, 23);
            this.btnLogInKim.TabIndex = 1;
            this.btnLogInKim.Text = "LogIn";
            this.btnLogInKim.UseVisualStyleBackColor = true;
            this.btnLogInKim.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbUserNameKim
            // 
            this.lbUserNameKim.AutoSize = true;
            this.lbUserNameKim.Location = new System.Drawing.Point(93, 79);
            this.lbUserNameKim.Name = "lbUserNameKim";
            this.lbUserNameKim.Size = new System.Drawing.Size(93, 15);
            this.lbUserNameKim.TabIndex = 2;
            this.lbUserNameKim.Text = "User Name : ";
            // 
            // lbPasswordKim
            // 
            this.lbPasswordKim.AutoSize = true;
            this.lbPasswordKim.Location = new System.Drawing.Point(93, 134);
            this.lbPasswordKim.Name = "lbPasswordKim";
            this.lbPasswordKim.Size = new System.Drawing.Size(87, 15);
            this.lbPasswordKim.TabIndex = 3;
            this.lbPasswordKim.Text = "Password : ";
            // 
            // tbPasswordKim
            // 
            this.tbPasswordKim.Location = new System.Drawing.Point(195, 124);
            this.tbPasswordKim.Name = "tbPasswordKim";
            this.tbPasswordKim.Size = new System.Drawing.Size(100, 25);
            this.tbPasswordKim.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 356);
            this.Controls.Add(this.tbPasswordKim);
            this.Controls.Add(this.lbPasswordKim);
            this.Controls.Add(this.lbUserNameKim);
            this.Controls.Add(this.btnLogInKim);
            this.Controls.Add(this.tbUserNameKim);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserNameKim;
        private System.Windows.Forms.Button btnLogInKim;
        private System.Windows.Forms.Label lbUserNameKim;
        private System.Windows.Forms.Label lbPasswordKim;
        private System.Windows.Forms.TextBox tbPasswordKim;
    }
}

