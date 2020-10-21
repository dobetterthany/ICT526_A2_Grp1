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
    public partial class AdminCheckOut : Form
    {
        double sum;
        double GST;
        double subTotal;
        Checkout Sales = new Checkout();
        double TotalPrice;

        Update Textf = new Update();

        List<string> ProductName;
        List<string> ProductCode;
        List<string> QuantityAvailable;
        List<string> Color;
        List<string> Price;
        List<string> Discount;

        private void AdminCheckOut_Load(object sender, EventArgs e)
        {
            listViewNa.View = View.Details;
            Sales.InventorySet();
        }

        public AdminCheckOut()
        {
            InitializeComponent();
            ProductName = Sales.ProductName;
            ProductCode = Sales.Code;
            QuantityAvailable = Sales.Quantity;
            Color = Sales.Color;
            Price = Sales.Price;
            Discount = Sales.Discount;
        }

        private void Add_btn_Na_Click(object sender, EventArgs e)
        {
            bool contain = Sales.Code.Contains(codeNa.Text);
            if (codeNa.Text == "" || quantityNa.Text == "")
            {
                MessageBox.Show("Please choose an item.");
            }//if product code textbox or quantity textbox are empty, then show this message.
            else if (contain == false)
            {
                MessageBox.Show("Item does not exist in the inventory");
            }//If product code text is not on the product list, show this message.
            else
            {
                int Index = Array.IndexOf(Sales.Code.ToArray(), codeNa.Text);
                double Discount = double.Parse(Sales.Discount[Index]);
                TotalPrice = int.Parse(Sales.Price[Index]) * int.Parse(quantityNa.Text) * (1 - Discount / 100.0);

                if (Sales.Code.Contains(codeNa.Text))
                {

                    double subtotal = (int.Parse(Sales.Price[Index]) * int.Parse(quantityNa.Text)) * ((100 - Discount) / 100.0);
                    sum = Math.Round(sum);
                    sum = TotalPrice + sum;

                    listViewNa.Items.Add(new ListViewItem(new string[] { Sales.Code[Index], Sales.ProductName[Index], quantityNa.Text, Sales.Price[Index], Sales.Discount[Index] }));
                    //Add items on the listview. 

                    TotalNa.Text = "$ " + Convert.ToString(sum);
                    GST = Convert.ToDouble(Math.Round(sum * 3 / 23, 2));
                    GSTNa.Text = "$ " + GST;
                    subTotal = Convert.ToDouble(sum - Math.Round(sum * 3 / 23, 2));
                    subtotalNa.Text = "$ " + subTotal;

                    listViewNa.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); // Auto-resize according to the length of the columns header and contents inside.
                    listViewNa.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                else
                {
                    MessageBox.Show("Item doesn't exists !");
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Confirm_btn_Na_Click(object sender, EventArgs e)
        {
            Invoices Invoice = new Invoices(sum, GST, subTotal);
            if (listViewNa.Items.Count == 0)//If there is no item in the list, read this.
            {
                MessageBox.Show("Please add an item.");
            }
            else//If there is any item in the list read here.
            {
                foreach (string code1 in Sales.Code)
                //Read line by line in the list and update quantity by subtracting from the quantity of the item in the inventory.
                {
                    for (int i = 0; i < listViewNa.Items.Count; i++)
                    {
                        if (listViewNa.Items[i].SubItems[0].Text == code1)
                        {
                            int newnum = int.Parse(Sales.Quantity[Array.IndexOf(Sales.Code.ToArray(), code1)]) - int.Parse(listViewNa.Items[i].SubItems[2].Text);
                            Sales.Quantity[Array.IndexOf(Sales.Code.ToArray(), code1)] = Convert.ToString(newnum);
                        }
                    }
                }
                for (int i = 0; i < listViewNa.Items.Count; i++)//Get each item in the each line in the listview, and put them in the method as arguments.
                {
                    Invoice.setlist(Convert.ToString(TotalPrice), listViewNa.Items[i].SubItems[1].Text, listViewNa.Items[i].SubItems[2].Text, Sales.Color[i + 1], listViewNa.Items[i].SubItems[3].Text, ((int.Parse(listViewNa.Items[i].SubItems[4].Text)) / 100.0).ToString());
                }

                
                try//Erase all texts in the text file and update with the new contents in the lists.
                {
                    Textf.textfileupdate(ProductName, ProductCode, QuantityAvailable, Color, Price, Discount);

                }//Throw exception message if program cannot connect to the text file.
                catch (Exception h)
                {
                    MessageBox.Show(h.Message);
                }//Show Invoice form
                
                Invoice.ShowDialog();
            }
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
