using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ICT526_A2_Grp1
{
    public partial class InventoryView : Form
    {
        Update Textf = new Update();
        readonly Checkout Sales = new Checkout();
        public InventoryView()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int INDEX = Array.IndexOf(Sales.Code.ToArray(), tbSearch.Text);
            if (Sales.Code.Contains(tbSearch.Text))//if search textbox text is contained in the list of product codes, they show all the items below.
            {
                tbCode.Text = Sales.Code[INDEX];
                tbName.Text = Sales.ProductName[INDEX];
                tbQuantity.Text = Sales.Quantity[INDEX];
                tbColor.Text = Sales.Color[INDEX];
                tbPrice.Text = Sales.Price[INDEX];
                tbDiscount.Text = Sales.Discount[INDEX];
            } else//If text is not included then show this message.
            {
                MessageBox.Show("No item identified");
            }
        }

        private void InventoryView_Load(object sender, EventArgs e)
        {
            Sales.InventorySet();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int INDEX = Array.IndexOf(Sales.Code.ToArray(), tbCode.Text);
            if (Sales.Code.Contains(tbCode.Text))//if product code list contains code textbox text, then update the values in the each lists below.
            {
                Sales.Code[INDEX] = tbCode.Text;
                Sales.ProductName[INDEX] = tbName.Text;
                Sales.Quantity[INDEX] = tbQuantity.Text;
                Sales.Color[INDEX] = tbColor.Text;
                Sales.Price[INDEX] = tbPrice.Text;
                Sales.Discount[INDEX] = tbDiscount.Text;
                
            }
            else // if the product code that does not exists in the inventory, then add a new product.
            {
                Sales.Code.Add(tbCode.Text);
                Sales.ProductName.Add(tbName.Text);
                Sales.Quantity.Add(tbQuantity.Text);
                Sales.Color.Add(tbColor.Text);
                Sales.Price.Add(tbPrice.Text);
                Sales.Discount.Add(tbDiscount.Text);

            }
            Textf.textfileupdate(Sales.ProductName, Sales.Code, Sales.Quantity, Sales.Color, Sales.Price, Sales.Discount);
            MessageBox.Show("Item Successfully Updated!!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
