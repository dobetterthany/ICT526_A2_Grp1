namespace ICT526_A2_Grp1
{
    partial class Sales_Checkout_Form
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
            this.lbProductCode = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.tbProductCode = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.lbGST = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lbSubTotalValue = new System.Windows.Forms.Label();
            this.lbGSTValue = new System.Windows.Forms.Label();
            this.lbTotalValue = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbProductCode
            // 
            this.lbProductCode.AutoSize = true;
            this.lbProductCode.Location = new System.Drawing.Point(66, 40);
            this.lbProductCode.Name = "lbProductCode";
            this.lbProductCode.Size = new System.Drawing.Size(113, 15);
            this.lbProductCode.TabIndex = 0;
            this.lbProductCode.Text = "Product Code : ";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(315, 40);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(77, 15);
            this.lbQuantity.TabIndex = 1;
            this.lbQuantity.Text = "Quantity : ";
            // 
            // tbProductCode
            // 
            this.tbProductCode.Location = new System.Drawing.Point(195, 30);
            this.tbProductCode.Name = "tbProductCode";
            this.tbProductCode.Size = new System.Drawing.Size(100, 25);
            this.tbProductCode.TabIndex = 2;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(404, 30);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(100, 25);
            this.tbQuantity.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(571, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Location = new System.Drawing.Point(597, 219);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(75, 15);
            this.lbSubTotal.TabIndex = 5;
            this.lbSubTotal.Text = "SubTotal :";
            // 
            // lbGST
            // 
            this.lbGST.AutoSize = true;
            this.lbGST.Location = new System.Drawing.Point(597, 251);
            this.lbGST.Name = "lbGST";
            this.lbGST.Size = new System.Drawing.Size(46, 15);
            this.lbGST.TabIndex = 6;
            this.lbGST.Text = "GST :";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(597, 282);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(49, 15);
            this.lbTotal.TabIndex = 7;
            this.lbTotal.Text = "Total :";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(597, 340);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 8;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // lbSubTotalValue
            // 
            this.lbSubTotalValue.AutoSize = true;
            this.lbSubTotalValue.Location = new System.Drawing.Point(688, 219);
            this.lbSubTotalValue.Name = "lbSubTotalValue";
            this.lbSubTotalValue.Size = new System.Drawing.Size(0, 15);
            this.lbSubTotalValue.TabIndex = 9;
            // 
            // lbGSTValue
            // 
            this.lbGSTValue.AutoSize = true;
            this.lbGSTValue.Location = new System.Drawing.Point(688, 251);
            this.lbGSTValue.Name = "lbGSTValue";
            this.lbGSTValue.Size = new System.Drawing.Size(0, 15);
            this.lbGSTValue.TabIndex = 10;
            // 
            // lbTotalValue
            // 
            this.lbTotalValue.AutoSize = true;
            this.lbTotalValue.Location = new System.Drawing.Point(688, 282);
            this.lbTotalValue.Name = "lbTotalValue";
            this.lbTotalValue.Size = new System.Drawing.Size(0, 15);
            this.lbTotalValue.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(44, 109);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(513, 293);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Sales_Checkout_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbTotalValue);
            this.Controls.Add(this.lbGSTValue);
            this.Controls.Add(this.lbSubTotalValue);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbGST);
            this.Controls.Add(this.lbSubTotal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbProductCode);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbProductCode);
            this.Name = "Sales_Checkout_Form";
            this.Text = "Logged In As Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProductCode;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox tbProductCode;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label lbGST;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lbSubTotalValue;
        private System.Windows.Forms.Label lbGSTValue;
        private System.Windows.Forms.Label lbTotalValue;
        private System.Windows.Forms.ListView listView1;
    }
}