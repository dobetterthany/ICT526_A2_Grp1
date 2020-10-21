namespace ICT526_A2_Grp1
{
    partial class Sales
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
            this.codeNa = new System.Windows.Forms.TextBox();
            this.Add_btn_Na = new System.Windows.Forms.Button();
            this.quantityNa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewNa = new System.Windows.Forms.ListView();
            this.Product_CodeNa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductNa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity_Na = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceNa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiscountNa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Confirm_btn_Na = new System.Windows.Forms.Button();
            this.TotalNa = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GSTNa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.subtotalNa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.codeNa);
            this.groupBox1.Controls.Add(this.Add_btn_Na);
            this.groupBox1.Controls.Add(this.quantityNa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory";
            // 
            // codeNa
            // 
            this.codeNa.Location = new System.Drawing.Point(104, 42);
            this.codeNa.Name = "codeNa";
            this.codeNa.Size = new System.Drawing.Size(128, 26);
            this.codeNa.TabIndex = 5;
            // 
            // Add_btn_Na
            // 
            this.Add_btn_Na.Location = new System.Drawing.Point(591, 26);
            this.Add_btn_Na.Name = "Add_btn_Na";
            this.Add_btn_Na.Size = new System.Drawing.Size(127, 42);
            this.Add_btn_Na.TabIndex = 4;
            this.Add_btn_Na.Text = "Add";
            this.Add_btn_Na.UseVisualStyleBackColor = true;
            this.Add_btn_Na.Click += new System.EventHandler(this.Add_btn_Na_Click);
            // 
            // quantityNa
            // 
            this.quantityNa.Location = new System.Drawing.Point(375, 42);
            this.quantityNa.Name = "quantityNa";
            this.quantityNa.Size = new System.Drawing.Size(100, 26);
            this.quantityNa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewNa);
            this.groupBox2.Controls.Add(this.Confirm_btn_Na);
            this.groupBox2.Controls.Add(this.TotalNa);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.GSTNa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.subtotalNa);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 364);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item List";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // listViewNa
            // 
            this.listViewNa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product_CodeNa,
            this.ProductNa,
            this.Quantity_Na,
            this.PriceNa,
            this.DiscountNa});
            this.listViewNa.GridLines = true;
            this.listViewNa.HideSelection = false;
            this.listViewNa.Location = new System.Drawing.Point(7, 26);
            this.listViewNa.Name = "listViewNa";
            this.listViewNa.Size = new System.Drawing.Size(600, 332);
            this.listViewNa.TabIndex = 16;
            this.listViewNa.UseCompatibleStateImageBehavior = false;
            this.listViewNa.View = System.Windows.Forms.View.Details;
            // 
            // Product_CodeNa
            // 
            this.Product_CodeNa.Tag = "1";
            this.Product_CodeNa.Text = "Code";
            this.Product_CodeNa.Width = 93;
            // 
            // ProductNa
            // 
            this.ProductNa.Text = "Product";
            this.ProductNa.Width = 231;
            // 
            // Quantity_Na
            // 
            this.Quantity_Na.Text = "Quantity";
            this.Quantity_Na.Width = 91;
            // 
            // PriceNa
            // 
            this.PriceNa.Text = "Price";
            this.PriceNa.Width = 79;
            // 
            // DiscountNa
            // 
            this.DiscountNa.Text = "Discount";
            this.DiscountNa.Width = 102;
            // 
            // Confirm_btn_Na
            // 
            this.Confirm_btn_Na.Location = new System.Drawing.Point(700, 261);
            this.Confirm_btn_Na.Name = "Confirm_btn_Na";
            this.Confirm_btn_Na.Size = new System.Drawing.Size(178, 68);
            this.Confirm_btn_Na.TabIndex = 15;
            this.Confirm_btn_Na.Text = "Confirm to Pay";
            this.Confirm_btn_Na.UseVisualStyleBackColor = true;
            this.Confirm_btn_Na.Click += new System.EventHandler(this.Confirm_btn_Na_Click);
            // 
            // TotalNa
            // 
            this.TotalNa.AutoSize = true;
            this.TotalNa.Location = new System.Drawing.Point(790, 213);
            this.TotalNa.Name = "TotalNa";
            this.TotalNa.Size = new System.Drawing.Size(18, 20);
            this.TotalNa.TabIndex = 14;
            this.TotalNa.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(714, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total :";
            // 
            // GSTNa
            // 
            this.GSTNa.AutoSize = true;
            this.GSTNa.Location = new System.Drawing.Point(790, 193);
            this.GSTNa.Name = "GSTNa";
            this.GSTNa.Size = new System.Drawing.Size(18, 20);
            this.GSTNa.TabIndex = 12;
            this.GSTNa.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(714, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "G.S.T. :";
            // 
            // subtotalNa
            // 
            this.subtotalNa.AutoSize = true;
            this.subtotalNa.Location = new System.Drawing.Point(790, 173);
            this.subtotalNa.Name = "subtotalNa";
            this.subtotalNa.Size = new System.Drawing.Size(18, 20);
            this.subtotalNa.TabIndex = 10;
            this.subtotalNa.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(714, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Subtotal :";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add_btn_Na;
        private System.Windows.Forms.TextBox quantityNa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewNa;
        private System.Windows.Forms.Button Confirm_btn_Na;
        private System.Windows.Forms.Label TotalNa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label GSTNa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label subtotalNa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codeNa;
        private System.Windows.Forms.ColumnHeader Product_CodeNa;
        private System.Windows.Forms.ColumnHeader ProductNa;
        private System.Windows.Forms.ColumnHeader Quantity_Na;
        private System.Windows.Forms.ColumnHeader PriceNa;
        private System.Windows.Forms.ColumnHeader DiscountNa;
    }
}