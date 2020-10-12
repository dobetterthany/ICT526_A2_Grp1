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
    public partial class Form1 : Form
    {
        

        List<string> Users = new List<string>();
        List<string> Passwords = new List<string>();
        List<string> Credentials = new List<string>();
        public Form1()
        {
            InitializeComponent();
            tbPasswordKim.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            StreamReader sr = new StreamReader("UserInfos.txt");

            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] UserInfo = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                Users.Add(UserInfo[0]);
                Passwords.Add(UserInfo[1]);
                Credentials.Add(UserInfo[2]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indexOfUser = Array.IndexOf(Users.ToArray(), tbUserNameKim.Text);
            int indexOfPassword = Array.IndexOf(Passwords.ToArray(), tbPasswordKim.Text);
            if (Users.Contains(tbUserNameKim.Text) && Passwords.Contains(tbPasswordKim.Text) && indexOfUser == indexOfPassword)
            {
                Sales_Checkout_Form SF1 = new Sales_Checkout_Form();
                Admin_Checkout_form AF1 = new Admin_Checkout_form();

                
                if (Credentials[indexOfUser]=="Admin")
                {
                    AF1.ShowDialog();
                }
                else if(Credentials[indexOfUser]=="Sales")
                {
                    SF1.Show();
                }
            }
            else
            {
                MessageBox.Show("Information Incorrect!");
            }
        }
    }

}
