using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace day19ass
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\git assignments\day19ass\caluculatorlibrary\bin\Debug\caluculatorlibrary.dll";

            Assembly asm = Assembly.LoadFrom(path);
           
            Type[] types = asm.GetTypes();
            Type t = null;

            foreach (var item in types)
            {
                Console.WriteLine("name= " + item.Name);
                Console.WriteLine("Full Name= " + item.FullName);

                Console.WriteLine("IS Class=" + item.IsClass);
                Console.WriteLine("IS Absatract=" + item.IsAbstract);
                Console.WriteLine("Whether public " + item.IsPublic);


                Console.WriteLine("-----------------");
                MemberInfo[] minfo = item.GetMembers();

                foreach (var minfoitem in minfo)
                {

                    Console.WriteLine("Member Info Name= " + minfoitem.Name);

                    Console.WriteLine("Declaring type=" + minfoitem.DeclaringType);
                }
                Console.WriteLine("---------------------");
                MethodInfo[] methodInfos = item.GetMethods();
                foreach (var methodInfosItem in methodInfos)
                {

                    Console.WriteLine("name=" + methodInfosItem.Name);
                    Console.WriteLine("IS PUBLIC=" + methodInfosItem.IsPublic);
                    Console.WriteLine("IS STATIC =" + methodInfosItem.IsStatic);

                    ParameterInfo[] pinfo = methodInfosItem.GetParameters();
                    Console.WriteLine("---Add method Parameters----");


                    foreach (var par in pinfo)
                    {
                        Console.WriteLine(par.Name);
                        Console.WriteLine(par.Position);
                        Console.WriteLine(par.ParameterType);


                    }



                }


                t = asm.GetType(item.FullName);

                object obj = Activator.CreateInstance(t);

                double ans = (double)item.InvokeMember("cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[] { 25 });
                Console.WriteLine(ans);
                double ans1 = (double)item.InvokeMember("sqrt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[] { 2 });
                
                Console.WriteLine(ans1);

                break;





            }



            Console.ReadLine();


        }
    }
}


