using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oct19
{
    public enum CourseName
    {
        AIML,DOTNET,JAVA
    }
    public class Student
    {
        public string name { get; set; }
        public int rollno { get; set; }
        public CourseName CourseName { get; set; }         
    }
}
