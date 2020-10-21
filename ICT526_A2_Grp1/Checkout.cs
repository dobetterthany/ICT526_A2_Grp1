using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ICT526_A2_Grp1
{
    /*
          ID : 1814729
          Author : Hyunmoon Na
          Description : Firstly, make some lists for the product information. And then, read a textfile from selected folder.
                        while reading the text file, add the text into the list that i've just created.
                        So, this Class can extract the product information from the text file and add to the list function.
                        This class is essential to run this programme. Cuz we put all the product information into the list.
    */
    public class Checkout
    {
        public List<string> ProductName = new List<string>();
        public List<string> Code = new List<string>();
        public List<string> Quantity = new List<string>();
        public List<string> Color = new List<string>();
        public List<string> Price = new List<string>();
        public List<string> Discount = new List<string>();

        public void InventorySet()
        {
            StreamReader file = new StreamReader(@".\Inventory.txt");

            while (!file.EndOfStream)
            {

                string line = file.ReadLine();
                string[] UserList = line.Split("|".ToCharArray());

                    ProductName.Add(UserList[0]);
                    Code.Add(UserList[1]);
                    Quantity.Add(UserList[2]);
                    Color.Add(UserList[3]);
                    Price.Add(UserList[4]);
                    Discount.Add(UserList[5]);
            }
            file.Close();
        }

    }
}