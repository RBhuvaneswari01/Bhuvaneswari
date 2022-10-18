using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1
{
    public class Cal
    {
        public bool Login(string uid, string pwd)
        {

            if (pwd == "Test@123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Addtocart(string prodname, int qty)
        {

            if (prodname != null && qty > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
