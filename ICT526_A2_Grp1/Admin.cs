using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT526_A2_Grp1
{
    public partial class Admin: Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            AdminCheckOut Checkout_Admin = new AdminCheckOut();
            Checkout_Admin.ShowDialog();//show admin checkout form
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            InventoryView InvenV = new InventoryView();
            InvenV.ShowDialog();//show inventory form
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
