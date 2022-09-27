using Disconnected_BLL;
using Disconnected_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disconnected_helper
{
    public class helper_class
    {
        DLL_class dal = null;
        public helper_class()
        {
            dal = new DLL_class();
        }

        public bool AddNewEmployee(BLL_class employee)
        {
            return dal.InsertEmployee(employee);
        }
        public BLL_class Locatestudent(int empid)
        {
            return dal.Findstudent(empid);
        }
        public bool EditstudentData(int studid, BLL_class student)
        {
            return dal.Updatestudent(studid, student);
        }
        public bool RemoveStudentData(int studid)
        {
            return dal.DeleteStudent(studid);
        }
        public List<BLL_class> studentList()
        {
            return dal.ShowAllstudents();
        }

    }
}
