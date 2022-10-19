using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oct19;


namespace TestLibrary
{
    [TestFixture]
    public class Class1
    {
        [TestCase]
        public void WhenAIML()
        {
            Student s = new Student();
            s.rollno = 1;
            s.name = "Bhuvana";
            s.CourseName = CourseName.AIML;

            Enroll e = new Enroll();
            e.enrollno = 102;
            e.fees = 0;

            StudentEnroll se = new StudentEnroll();
            se.EnrollStudent(s, e);
            //Assert.AreEqual(order.Amount, 950);

        }
    }
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            StubExtensionManager stub = new StubExtensionManager();
            FileChecker checker = new FileChecker(stub);

            //Action  
            bool IsTrueFile = checker.CheckFile("myFile.whatever");

            //Assert  
            Assert.AreEqual(true, IsTrueFile);
        }
    }
    [TestFixture]
    public class UnitTest2
    {
        [TestCase]
        public void TestMethod1()
        {
            //Act  
            MockExtensionService mockobject = new MockExtensionService();
            //Inject mock object now  
            ExtensionAnalyzer analyzer = new ExtensionAnalyzer(mockobject);
            //Action  
            analyzer.ExtensionCheck("somefile.someextension");

            //Assert  
            Assert.AreEqual(mockobject.ErrorMessage, "Wrong Type");
        }
    }
        [TestFixture]
    public  class Test1
    { 
        int s;
        [SetUp]
        [Test]
        public void Add()
        {
       int x = 10;
        int y = 20;
        s=x+y;
        Console.WriteLine(s);
            Assert.AreEqual(s, 30);
        }
     [Test]
     public void subtract()
     {
        int p = s - 10;
        Console.WriteLine(p);
        Assert.AreEqual(p, 20);
     }
            [Test]
         [TearDown]
          public void Multiply()
          {
              int x = 10;
              int y = 20;
              int result = x * y;
              Console.WriteLine(result);
              Assert.AreEqual(result, 200);
          }

    } 

}