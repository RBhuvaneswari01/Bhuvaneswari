using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject;

namespace TestingTest
{
    public class SchoolTest
    {
        Student s = new Student();
        Teacher t = new Teacher();
        Subject sub = new Subject();
        public SchoolTest()
        {
            s.FileRead();
        }
        [TestCase("minnu", ExpectedResult = true)]
        [TestCase("honey", ExpectedResult = true)]
        [TestCase("Varun", ExpectedResult = true)]
        [TestCase("varun", ExpectedResult = false)]
        public bool FindStudent(string ans)
        {
            return s.SearchByName(ans);
        }
        [TestCase("bhuvana", ExpectedResult = true)]
        [TestCase("sweety", ExpectedResult = true)]
        [TestCase("Geetha", ExpectedResult = true)]
        [TestCase("Nithya", ExpectedResult = false)]
        public bool FindTeacher(string ans)
        {
            return t.SearchByName(ans);
        }
        [TestCase("Maths", ExpectedResult = true)]
        [TestCase("social", ExpectedResult = false)]
        [TestCase("telugu", ExpectedResult = true)]
        [TestCase("Physics", ExpectedResult = false)]
        public bool FindSubject(string ans)
        {
            return sub.SearchByName(ans);
        }

    }

  }
