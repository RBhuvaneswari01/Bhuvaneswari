using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //int b;
            //int max;
            //int min;
            //Console.WriteLine("enter first number");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter second number");
            //b = Convert.ToInt32(Console.ReadLine());
            //if (a>b)
            //{
            //    max = a;
            //}
            //else
            //    max = b;
            //if (a < b)
            //    min = a;
            //else
            //    min = b;
            //Console.WriteLine("max number={0}", max);
            //Console.WriteLine("min number={0}", min);



            //2
            //int a;
            //int b;
            //int c;
            //Console.WriteLine("enter first number");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter second number");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter third number");
            //c = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //    if (a > c)
            //        Console.WriteLine("the largest among three is={0}", a);
            //else
            //        Console.WriteLine("the largest among three is={0}", c);
            //else if(b>c)
            //    Console.WriteLine("the largest among three is={0}", b);
            //else
            //    Console.WriteLine("the largest among three is={0}", c);



            //3
            //char c1;
            //char c2;
            //Console.WriteLine("enter the char first:");
            //c1 = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("enter the char second:");
            //c2 = Convert.ToChar(Console.ReadLine());
            //if (c1 == c2)
            //    Console.WriteLine("both are equal");
            //else
            //    Console.WriteLine("both are not equal");





            //4
            //string s1;
            //string s2;
            //Console.WriteLine("enter the string first:");
            //s1 = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("enter the string second:");
            //s2 = Convert.ToString(Console.ReadLine());
            //if (s1 == s2)
            //    Console.WriteLine("both are equal");
            //else
            //    Console.WriteLine("both are not equal");



            //5
            //int a;
            //int b;
            //int big;

            //Console.WriteLine("enter first number");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter second number");
            //b = Convert.ToInt32(Console.ReadLine());
            //if (a>b)
            //{
            //    big = a;
            //}
            //else
            //    big = b;
            //Console.WriteLine("big number among two:={0}", big);



            //6
            //int year;
            //Console.Write("Input an year : ");
            //year = Convert.ToInt32(Console.ReadLine());

            //if ((year % 400) == 0)
            //    Console.WriteLine("{it is a leap year={0}", year);
            //else if ((year % 100) == 0)
            //    Console.WriteLine("it is not a leap year={0}", year);
            //else if ((year % 4) == 0)
            //    Console.WriteLine("it is a leap year={0}", year);
            //else
            //    Console.WriteLine("it is not a leap year={0}", year);




            //7
            //int math, social, eng, total;
            //float per;
            //Console.WriteLine("enter first math marks");
            //math = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter social marks");
            //social = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter english marks");
            //eng = Convert.ToInt32(Console.ReadLine());
            //total = math + social + eng;
            //Console.WriteLine("total marks={0}", total);
            //per = total / 3;
            //Console.WriteLine("per={0}",per);
            //if (per < 35)
            //    Console.WriteLine("fail");
            //if (per > 35 && per < 45)
            //    Console.WriteLine("third");
            //else
            //    if(per>45&&per<60)
            //    Console.WriteLine("second");
            //else
            //    if(per>60)
            //    Console.WriteLine("first");



            //8
            //for (int i = 1; i<=5; i++)
            //{
            //    for (int j = 1; j<=i; j++)
            //    {
            //        Console.Write(" *");

            //    }
            //    Console.WriteLine();
            //}




            //9
            //int i, n, sum = 0;

            //Console.Write("Input numbers: ");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("The odd numbers are :");
            //for (i = 1; i <= n; i++)
            //{
            //    Console.Write("{0} ", 2 * i - 1);
            //    sum += 2 * i - 1;
            //}
            //Console.Write("The Sum of odd Natural Number upto {0} terms : {1} ", n, sum);



            //10
            //int n, reverse = 0, rem;
            //Console.Write("Enter a number: ");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (n != 0)
            //{
            //    rem = n % 10;
            //    reverse = reverse * 10 + rem;
            //    n /= 10;
            //}
            //Console.Write("Reversed Number: " + reverse);



            //11
            //int i, sum = 0;


            //for (i = 101; i < 200; i++)
            //{
            //    sum += i;
            //}
            //Console.Write("\n The sum of numbers between 100 and 200 : {0}", sum);





            //12
            int i, sum = 0;

            Console.Write("Numbers between 100 and 200, divisible by 9 : \n");
            for (i = 101; i < 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.Write("{0}  ", i);
                    sum += i;
                }
            }
            Console.Write("\nThe sum : {0} \n", sum);
            Console.ReadLine();
        }
    }
}
