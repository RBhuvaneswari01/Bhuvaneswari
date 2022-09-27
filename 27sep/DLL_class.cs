using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Disconnected_BLL;


namespace Disconnected_DAL
{
    public class DLL_class
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public DLL_class()
        {
            ds = new DataSet();
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["imsCnStr"].ConnectionString);
        }

        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from  student", cn);

            
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "student");
            DataTable dt_studdata = ds.Tables["student"];
            return dt_studdata;
        }

        public bool InsertEmployee(BLL_class student)
        {
            DataTable dt_studdata = Connect();

            DataRow drow = ds.Tables["student"].NewRow();
          
            drow["studid"] = student.studid;
            drow["name"] = student.name;
            drow["crsid"] = student.crsid;


            ds.Tables["student"].Rows.Add(drow);

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["student"]);
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }
        public BLL_class Findstudent(int studid)
        {
            DataTable dt_studdata = Connect();
            DataRow drow = ds.Tables["student"].Rows.Find(studid);
            BLL_class stud = new BLL_class();
            stud.studid = Convert.ToInt32(drow["studid"]);
            stud.name = drow["name"].ToString();
            stud.crsid = Convert.ToInt32(drow["crsid"]);
            
            return stud;



        }
        public bool Updatestudent(int studid, BLL_class student)
        {
            DataTable dt_empdata = Connect();
            DataRow drow = ds.Tables["student"].Rows.Find(studid);
            drow["studid"] = student.studid;
            drow["name"] = student.name;
            drow["crsid"] = student.crsid;



            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["student"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;
        }
        public bool DeleteStudent(int studid)
        {

            DataTable dt_stddata = Connect();
            DataRow drow = ds.Tables["student"].Rows.Find(studid);
            drow.Delete();

            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            int i = da.Update(ds.Tables["student"]);//record added to the (original)database table
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            return status;


        }
        public List<BLL_class> ShowAllstudents()
        {
            DataTable dt_studdata = Connect();
            List<BLL_class> slist = new List<BLL_class>();
            for (int i = 0; i < dt_studdata.Rows.Count; i++)
            {
                DataRow drow = dt_studdata.Rows[i];
                BLL_class s = new BLL_class();
                s.studid = Convert.ToInt32(drow["studid"]);
                s.name = drow["name"].ToString();
                s.crsid = Convert.ToInt32(drow["crsid"]);
                slist.Add(s);

            }
            return slist;


        }

    }
}
