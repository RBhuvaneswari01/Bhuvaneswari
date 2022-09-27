using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disconnected_BLL
{
    public class BLL_class
    {
        private int _stud_id;

        public int studid
        {
            get { return _stud_id; }
            set { _stud_id = value; }
        }

        private string _name;

        public string name
        {
            
            get { return _name; }
            set { _name = value; }
        }
        private int _crsid;

        public int crsid
        {
            
            get { return _crsid; }
            set { _crsid = value; }
        }





    }
}
