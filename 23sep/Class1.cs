using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary
{
    public class BL_products
    {
        private int _productid;
        public int productid
        {
            get
            {
                return _productid;
            }
            set
            {

                if  (value > 77)
                {
                    throw new Exception("product id not valid");

                }
                else
                {
                    _productid = value;
                }
            }
        }



        private string _productname;

        public string ProductName
        {
            get { return _productname; }
            set
            {
                if ((value.Length > 40) || string.IsNullOrEmpty(value))
                {
                    throw new Exception("Not valid Title.... Please check");
                }
                else
                {
                    _productname = value;
                }

            }
        }



        //private string _supplierid;

        //public string SupplierId
        //{
        //    get { return _supplierid; }
        //    set
        //    {
        //        if (value.Length > 4)
        //        {
        //            throw new Exception("Length of pubid cannot be more than 4 chars/numbers");
        //        }
        //        else
        //        {
        //            _supplierid = value;
        //        }

        //    }
        //}
        //private string _categoryid;

        //public string CategoryId
        //{
        //    get { return _categoryid; }
        //    set
        //    {
        //        if (value.Length > 4)
        //        {
        //            throw new Exception("Length of pubid cannot be more than 4 chars/numbers");
        //        }
        //        else
        //        {
        //            _categoryid = value;
        //        }

        //    }
        //}

        //private string _quantityperunit;

        //public string Quantityperunit
        //{
        //    get { return _quantityperunit; }
        //    set
        //    {
        //        if (value.Length > 4)
        //        {
        //            throw new Exception("Length of pubid cannot be more than 4 chars/numbers");
        //        }
        //        else
        //        {
        //            _quantityperunit = value;
        //        }

        //    }
        //}
        //private string _unitprice;

        //public string Unitprice
        //{
        //    get { return _unitprice; }
        //    set
        //    {
        //        if (value.Length > 8)
        //        {
        //            throw new Exception("Length of pubid cannot be more than 8 chars/numbers");
        //        }
        //        else
        //        {
        //            _unitprice = value;
        //        }

        //    }
        //}
        //private string _unitsinstock;

        //public string Unitsinstock
        //{
        //    get { return _unitsinstock; }
        //    set
        //    {
        //        if (value.Length > 2)
        //        {
        //            throw new Exception("Length of pubid cannot be more than 2 chars/numbers");
        //        }
        //        else
        //        {
        //            _unitsinstock = value;
        //        }

        //    }
        //}
        //private string _unitsonorder;

        //public string Unitsonorder
        //{
        //    get { return _unitsonorder; }
        //    set
        //    {
        //        if (value.Length > 2)
        //        {
        //            throw new Exception("Length of pubid cannot be more than 2 chars/numbers");
        //        }
        //        else
        //        {
        //            _unitsonorder = value;
        //        }

        //    }
        //}
        //private string _discontinued;

        //public string Discontinued
        //{
        //    get { return _discontinued; }
        //    set
        //    {
        //        if (value.Length > 1)
        //        {
        //            throw new Exception("Length of supplierid cannot be more than 1 chars/numbers");
        //        }
        //        else
        //        {
        //            _discontinued = value;
        //        }

        //    }



        //}
        //private string _reorderlevel;

        //public string ReorderLevel
        //{
        //    get { return _reorderlevel; }
        //    set
        //    {
        //        if (value.Length > 2)
        //        {
        //            throw new Exception("Length of supplierid cannot be more than 2 chars/numbers");
        //        }
        //        else
        //        {
        //            _reorderlevel = value;
        //        }

        //    }
        //}
    }
}
