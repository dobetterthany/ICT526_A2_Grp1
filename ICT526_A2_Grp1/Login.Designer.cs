namespace ICT526_A2_Grp1
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userName_Na = new System.Windows.Forms.TextBox();
            this.password_Na = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login_Na = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_login_Na);
            this.groupBox1.Controls.Add(this.password_Na);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.userName_Na);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // userName_Na
            // 
            this.userName_Na.Location = new System.Drawing.Point(382, 70);
            this.userName_Na.Multiline = true;
            this.userName_Na.Name = "userName_Na";
            this.userName_Na.Size = new System.Drawing.Size(197, 42);
            this.userName_Na.TabIndex = 1;
            // 
            // password_Na
            // 
            this.password_Na.Location = new System.Drawing.Point(382, 190);
            this.password_Na.Multiline = true;
            this.password_Na.Name = "password_Na";
            this.password_Na.Size = new System.Drawing.Size(197, 47);
            this.password_Na.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // btn_login_Na
            // 
            this.btn_login_Na.Location = new System.Drawing.Point(281, 330);
            this.btn_login_Na.Name = "btn_login_Na";
            this.btn_login_Na.Size = new System.Drawing.Size(134, 47);
            this.btn_login_Na.TabIndex = 4;
            this.btn_login_Na.Text = "Log In";
            this.btn_login_Na.UseVisualStyleBackColor = true;
            this.btn_login_Na.Click += new System.EventHandler(this.btn_login_Na_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_login_Na;
        private System.Windows.Forms.TextBox password_Na;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName_Na;
        private System.Windows.Forms.Label label1;
    }
}

