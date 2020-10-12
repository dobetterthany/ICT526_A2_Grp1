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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            password_Na.PasswordChar = '*';
        }
        List<string> UserName = new List<string>();
        List<string> Password = new List<string>();
        List<string> Position = new List<string>();

        private void btn_login_Na_Click(object sender, EventArgs e)
        {
            StreamReader Aaron = new StreamReader("A1.Txt");
            string line = "";

            while((line = Aaron.ReadLine()) != null)
            {
                string[] UserList = line.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                UserName.Add(UserList[0]);
                Password.Add(UserList[1]);
                Position.Add(UserList[2]);
            }

            int indexOfUserName = Array.IndexOf(UserName.ToArray(), userName_Na.Text);
            int indexOfPassword = Array.IndexOf(Password.ToArray(), password_Na.Text);
            if (UserName.Contains(userName_Na.Text) && Password.Contains(password_Na.Text) && indexOfUserName == indexOfPassword)
            {

                if (Position[indexOfUserName] == "Sales")
                {
                    Sales SALES = new Sales();
                    SALES.ShowDialog();
                } else
                {
                    Admin ADMIN = new Admin();
                    ADMIN.ShowDialog();
                }
            } else
            {
                MessageBox.Show("Please try again.");
            }
        }
    }
}
