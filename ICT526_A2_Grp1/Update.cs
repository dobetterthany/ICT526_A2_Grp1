using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ICT526_A2_Grp1
{
    /*  
  *  ID: 1814686
  *  Author: Gyeongjae Kim
  *  Description:   There was many situation to update Inventory Text file. 
  *                 So I have decided to make a class to use whenever I want to update Inventory file with new items in the each list. 
  *                 I put all lists as arguments.
    */
    class Update
    {
        public void textfileupdate(List<string> A, List<string> B, List<string> C, List<string> D, List<string> E, List<string> F)
        {

            StreamWriter tw = new StreamWriter(@".\Inventory.txt");//"Inventory.txt"

            for (int i = 0; i < B.Count; i++)
            {
                tw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", A[i], B[i], C[i], D[i], E[i], F[i]);
            }
            tw.Close();
        }

    }
}
