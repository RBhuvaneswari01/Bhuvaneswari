using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class class2
    {
        public class Student
        {
            private int _rollno;

            public int RollNo
            {
                get { return _rollno; }
                set { _rollno = value; }
            }


            private string _stdname;

            public string StdName
            {
                get { return _stdname; }
                set { _stdname = value; }
            }

            //fully implemented property----do any validations
            private int _deptno;

            public int DeptNo
            {
                get { return _deptno; }
                set
                {
                    try
                    {

                        if (value != 0)
                        {
                            _deptno = value;
                        }
                        else
                        {

                            throw new ArgumentNullException("Deptno cannot be zero or null");
                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }


                }
            }

        }
    }
}

