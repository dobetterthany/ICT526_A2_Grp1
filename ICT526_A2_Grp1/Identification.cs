using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT526_A2_Grp1
{
    /*
        ID : 1813309
        Author : Qiru Gao  
        Description : 
                     1.Import data from file A1.txt(username, password, position)
                     2.Compare the data from A1.txt with the data rntered by the user
                     3.If it is the same, judge whether the user's position is Sales or Admin. If it is not same ,show the massage "Please try again"
                     4.if the position is sales, open the sales form,else open the Admin form
    */

    public abstract class Identification
    {
        string user;
        string password;
        string status;
        public Identification(string U, string P, string S)
        {
            user = U;
            password = P;
            status = S;
        }
    }
    public class Administrator : Identification
    {
        public Administrator(string U, string P, string S) : base(U, P, S)
        {
            
        }
        public void OpenAdmin()
        {
            Admin ADMIN = new Admin();
            ADMIN.ShowDialog();
        }
    }
    public class Salesman : Identification
    {
        public Salesman(string U, string P, string S) : base(U, P, S)
        {

        }
        public void OpenSales()
        {
            Sales SALES = new Sales();
            SALES.ShowDialog();
        }
    }

}
