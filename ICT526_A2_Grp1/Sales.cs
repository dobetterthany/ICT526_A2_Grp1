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
    public partial class Sales : Form
    {
        double sum;
        double GST;
        double subTotal;
        Checkout Sales1 = new Checkout();
        double TotalPrice;
        Update Textf = new Update();

        List<string> ProductName;
        List<string> ProductCode;
        List<string> QuantityAvailable;
        List<string> Color;
        List<string> Price;
        List<string> Discount;


        public Sales()
        {
            InitializeComponent();
            ProductName = Sales1.ProductName;
            ProductCode = Sales1.Code;
            QuantityAvailable = Sales1.Quantity;
            Color = Sales1.Color;
            Price = Sales1.Price;
            Discount = Sales1.Discount;

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            listViewNa.View = View.Details;
            Sales1.InventorySet();
        }

        private void Add_btn_Na_Click(object sender, EventArgs e)
        {
            bool contain = Sales1.Code.Contains(codeNa.Text);

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
                int Index = Array.IndexOf(Sales1.Code.ToArray(), codeNa.Text);
                double Discount = double.Parse(Sales1.Discount[Index]);
                TotalPrice = int.Parse(Sales1.Price[Index]) * int.Parse(quantityNa.Text) * (1 - Discount / 100.0);
                double subtotal = (int.Parse(Sales1.Price[Index]) * int.Parse(quantityNa.Text)) * ((100 - Discount) / 100.0);
                sum = Math.Round(sum);
                sum = TotalPrice + sum;

                listViewNa.Items.Add(new ListViewItem(new string[] { Sales1.Code[Index], Sales1.ProductName[Index], quantityNa.Text, Sales1.Price[Index], Sales1.Discount[Index] }));
                //Add items on the listview. 

                TotalNa.Text = "$ " + Convert.ToString(sum); //put values inside of the each textboxes.
                GST = Convert.ToDouble(Math.Round(sum * 3 / 23, 2));
                GSTNa.Text = "$ " + GST;
                subTotal = Convert.ToDouble(sum - Math.Round(sum * 3 / 23, 2));
                subtotalNa.Text = "$ " + subTotal;

                listViewNa.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); // Auto-size fit to the column header and contents.
                listViewNa.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                
            }
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
                foreach (string code1 in Sales1.Code)//Read line by line in the list and update quantity by subtracting from the quantity of the item in the inventory.
                {
                    for (int i = 0; i < listViewNa.Items.Count; i++)
                    {
                        if (listViewNa.Items[i].SubItems[0].Text == code1)
                        {
                            int newnum = int.Parse(Sales1.Quantity[Array.IndexOf(Sales1.Code.ToArray(), code1)]) - int.Parse(listViewNa.Items[i].SubItems[2].Text);
                            Sales1.Quantity[Array.IndexOf(Sales1.Code.ToArray(), code1)] = Convert.ToString(newnum);
                        }
                    }
                }
                for (int i = 0; i < listViewNa.Items.Count; i++)//Get each item in the each line in the listview, and put them in the method as arguments.
                {
                    Invoice.setlist(Convert.ToString(TotalPrice), listViewNa.Items[i].SubItems[1].Text, listViewNa.Items[i].SubItems[2].Text, Sales1.Color[i + 1], listViewNa.Items[i].SubItems[3].Text, ((int.Parse(listViewNa.Items[i].SubItems[4].Text)) / 100.0).ToString());
                }

                try//Erase all texts in the text file and update with the new contents in the lists.
                {
                    Textf.textfileupdate(ProductName, ProductCode, QuantityAvailable, Color, Price, Discount);

                }//Throw exception message if program cannot connect to the text file.
                catch (Exception h)
                {
                    MessageBox.Show(h.Message);
                }//Show Invoice form

                Invoice.ShowDialog();//Show Invoice form

            }
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
