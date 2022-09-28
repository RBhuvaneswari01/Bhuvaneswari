using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Library;

namespace BAL_Library
{
    public class studentoperations
    {
        public void Insertstudent(BLL_Class bal)
        {
            InstituteManagementSystemEntities context = new InstituteManagementSystemEntities();
            student s = new student();
            s.studid = bal.studid;
            s.name = bal.name;
            s.crsid = bal.crsid;
            context.students.Add(s);
            context.SaveChanges();

        }

        public void Updatestudent(BLL_Class bal)
        {
            InstituteManagementSystemEntities context = new InstituteManagementSystemEntities();
            List<student> students = context.students.ToList();
            student obj = students.Find(student => student.studid == bal.studid);
            obj.name = bal.name;
            obj.crsid = bal.crsid;
            context.SaveChanges();

        }

        public void Deletestudent(BLL_Class bal)
        {
            InstituteManagementSystemEntities context = new InstituteManagementSystemEntities();
            List<student> students = context.students.ToList();
            student obj = students.Find(student => student.studid == bal.studid);
            //obj.name = bal.name;
            //obj.crsid = bal.crsid;
            context.SaveChanges();

        }



    }
}
