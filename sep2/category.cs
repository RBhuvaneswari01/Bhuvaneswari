using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSLibrary
{
    public class Category
    {
        int catid;
        string catname;
        string catdescription;
        public int Categoryid
        {
            get { return catid; }   
            set { catid = value; }  
        }
        public string Categoryname
        {
            get { return catname; } 
            set { catname = value; }    
        }
        public string Categorydescription
        {
            get { return catdescription; ; }
            set { catdescription = value; }
        }
        private List<Category> _catlist;

        public List<Category> Catproducts
        {
            get { return _catlist; }
            set { _catlist = value; }
        }




    }
    
}
