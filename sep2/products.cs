using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSLibrary
{
    internal class products
    {
        public class Products
        {
            int productsid;
            string productname;
            int qtysold;
            double unitprice;
            int unitofmeasurement;
            int qtyinhand;
            int reorderlevel;

            public int Productsid
            {
                get { return productsid; }
                set { productsid = value; }
            }
            public string Productname
            {
                get { return productname; }
                set { productname = value; }
            }
            public int Qtysold
            {
                get { return qtysold; }
                set { qtysold = value; }
            }
            public double Unitprice
            {
                get { return unitprice; }
                set { unitprice = value; }
            }
            public int Unitofmeasurement
            {
                get { return unitofmeasurement; }
                set
                { unitofmeasurement = value; }
            }
            public bool Qtyinhand
            {
                get { return Qtyinhand; }
                set
                {
                    Qtyinhand = value;
                }
            }
            public int Reorderlevel
            {
                get { return reorderlevel; }
                set
                {
                    reorderlevel = value;
                }
            }
            private List<Products> _prolist;

            public List<Products> Catproducts
            {
                get { return _prolist; }
                set { _prolist = value; }
            }





        }
    }
}
