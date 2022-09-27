using balLibrary;
using dalLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helperLibrary
{
 
        public class shopping_helper
        {
            shopping_dal dal = null;
            public shopping_helper()
            {
                dal = new shopping_dal();
            }


            public bool AddBook(shopping_bal Book)
            {
                return dal.InsertBook(Book);

            }

        }
    
}
