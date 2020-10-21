namespace ICT526_A2_Grp1
{
    partial class Invoices
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotalBalanceDue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTotalGST = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.ItemListView = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAX Invoice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "The Comfort Zone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wellington Branch";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(270, 145);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(52, 20);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "DATE";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(479, 145);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(43, 20);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Balance Due";
            // 
            // lbTotalBalanceDue
            // 
            this.lbTotalBalanceDue.AutoSize = true;
            this.lbTotalBalanceDue.Location = new System.Drawing.Point(664, 391);
            this.lbTotalBalanceDue.Name = "lbTotalBalanceDue";
            this.lbTotalBalanceDue.Size = new System.Drawing.Size(31, 20);
            this.lbTotalBalanceDue.TabIndex = 6;
            this.lbTotalBalanceDue.Text = "$ 0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sub Total :";
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Location = new System.Drawing.Point(543, 448);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(31, 20);
            this.lbSubtotal.TabIndex = 8;
            this.lbSubtotal.Text = "$ 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 497);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total GST (15%) :";
            // 
            // lbTotalGST
            // 
            this.lbTotalGST.AutoSize = true;
            this.lbTotalGST.Location = new System.Drawing.Point(543, 497);
            this.lbTotalGST.Name = "lbTotalGST";
            this.lbTotalGST.Size = new System.Drawing.Size(31, 20);
            this.lbTotalGST.TabIndex = 10;
            this.lbTotalGST.Text = "$ 0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(199, 548);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Total";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(543, 548);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(31, 20);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "$ 0";
            // 
            // ItemListView
            // 
            this.ItemListView.HideSelection = false;
            this.ItemListView.Location = new System.Drawing.Point(13, 180);
            this.ItemListView.Name = "ItemListView";
            this.ItemListView.Size = new System.Drawing.Size(761, 196);
            this.ItemListView.TabIndex = 13;
            this.ItemListView.UseCompatibleStateImageBehavior = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(619, 544);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 42);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ItemListView);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbTotalGST);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbSubtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTotalBalanceDue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalBalanceDue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTotalGST;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ListView ItemListView;
        private System.Windows.Forms.Button btnClose;
    }
}