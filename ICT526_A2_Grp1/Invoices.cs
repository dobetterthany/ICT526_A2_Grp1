using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ICT526_A2_Grp1.Sales;

namespace ICT526_A2_Grp1
{
    public partial class Invoices : Form
    {

        public Invoices(double sum, double GST, double subTotal)
        {
            InitializeComponent();
            lbTotal.Text = "$ " + Convert.ToString(sum);
            lbTotalBalanceDue.Text = "$ " + Convert.ToString(sum);
            lbTotalGST.Text = "$ " + Convert.ToString(GST);
            lbSubtotal.Text = "$ " + Convert.ToString(subTotal);
        }
        public void setlist(string Total, string Pname, string PQuantity, string PColor, string Price, string Discount)
        {
            string UpdatedTotal = Convert.ToString(int.Parse(Price) * (int.Parse(PQuantity)));
            string UpdatedDiscount = Convert.ToString(double.Parse(Discount) * (int.Parse(PQuantity))*(double.Parse(Price)));
            
            ItemListView.Items.Add(new ListViewItem(new string[] { string.Format("{0}, {1}",Pname, PColor), PQuantity, Price, string.Format("$"+"{0}"+" - "+"$"+"{1}", UpdatedTotal, UpdatedDiscount) })); // Add the following items into the item list view with correct orders.
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbTime.Text = DateTime.Now.ToString("hh : mm tt");

            ItemListView.View = View.Details;
            ItemListView.Columns.Add("Product");
            ItemListView.Columns.Add("Qty");
            ItemListView.Columns.Add("Price");
            ItemListView.Columns.Add("Total");

            ItemListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); // Auto-resize columns following the column contents.
            ItemListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);  //Auto-resize columns following the column header.
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
