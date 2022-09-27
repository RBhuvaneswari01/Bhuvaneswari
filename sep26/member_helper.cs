using balLibrary;
using dalLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helperLibrary
{
    public class member_helper
    {
        member_DAL dal = null;
        public member_helper()
        {
            dal = new member_DAL();
        }


        public bool AddMember(member_BAL member)
        {
            return dal.InsertMember(member);



        }
        public bool EditMember(member_BAL member)
        {
            return dal.UpdateMember(member);



        }
    }
}

