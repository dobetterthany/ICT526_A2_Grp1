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
        List<string> Position = new List<string>();//Create Lists for each contents

        private void btn_login_Na_Click(object sender, EventArgs e)
        {
            StreamReader Gavin = new StreamReader("A1.Txt");//Read Text file
            string line = "";

            while((line = Gavin.ReadLine()) != null)//Read lines in the text file until there is no line
            {
                string[] UserList = line.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);//While reading lines, split by '|' and put string in the array 'UserList'
                UserName.Add(UserList[0]);
                Password.Add(UserList[1]);
                Position.Add(UserList[2]);//Put items in the UserList into the each List based on their indexes.
            }

            int indexOfUserName = Array.IndexOf(UserName.ToArray(), userName_Na.Text);
            int indexOfPassword = Array.IndexOf(Password.ToArray(), password_Na.Text);
            if (UserName.Contains(userName_Na.Text) && Password.Contains(password_Na.Text) && indexOfUserName == indexOfPassword)
                //If the text in the Username textbox is in the List and the text in the password textbox is in the list, and index of both are same(which means they are on the same line in the text file), then go to the next step
            {

                if (Position[indexOfUserName] == "Sales")//If the position is Sales, then go ahead.
                {
                    Identification IdSales = new Salesman(userName_Na.Text, password_Na.Text, "Sales");
                    ((Salesman)IdSales).OpenSales();//Open Sales checkout form

                }
                else if ((Position[indexOfUserName] == "Admin"))//If the position is not sales but it is admin then read here.
                {
                    Identification IdAdmin = new Administrator(userName_Na.Text, password_Na.Text, "Admin");
                    ((Administrator)IdAdmin).OpenAdmin();//Open Admin checkout form
                }
            } else
            {
                MessageBox.Show("Please try again.");//Show warning message if username and password does not match, and username of password is not in the list.
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
