using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9ass
{
    //class stack1
    //{
    //    internal static readonly int max = 1000;
    //    internal int[] stack = new int[max];
    //    int top;

    //    internal bool isStackEmpty()
    //    {
    //        //bool status = false;
    //        //if (top<0)
    //        //{
    //        //    status = true;
    //        //}
    //        //return status;
    //        return (top < 0);
    //    }

    
    //    public stack1()
    //    {
    //        top = -1;
    //    }

    //    internal void Push(int data)
    //    {
    //        if (top >= max)
    //        {
    //            Console.WriteLine("No space on the stack");
    //            return;
    //        }
    //        else
    //        {
    //            stack[++top] = data;

    //        }
    //    }

    //    internal void Pop()
    //    {
    //        int value = 0;
    //        if (top < 0)
    //        {
    //            Console.WriteLine("No elements on the stack");
    //            return;
    //        }
    //        else
    //        {
    //            value = stack[top--];
    //            Console.WriteLine(value);
    //        }
    //    }
    //    internal void Peek()
    //    {
    //        if (top < 0)
    //        {
    //            Console.WriteLine("No elements on the stack");
    //            return;
    //        }
    //        else
    //        {
    //            int value = stack[top];
    //            Console.WriteLine(value);
    //        }
    //    }

    //    internal void PrintStackElements()
    //    {
    //        if (top < 0)
    //        {
    //            Console.WriteLine("No elements on the stack");
    //            return;
    //        }
    //        else
    //        {
    //            for (int i = top; i >= 0; i--)
    //            {
    //                Console.WriteLine(stack[i]);
    //            }
    //        }
    //    }
    //}
    class UserDataStore<T>
    {
        T[] _data = new T[10];
        public void AddOrEdit(int index, T item)
        {

            if (index >= 0 && index <= 10)
            {
                _data[index] = item;
            }
        }

        public T ReturnData(int index)
        {

            if (index >= 0 && index <= 10)
            {
                return _data[index];
            }
            else
            {

                return default(T);
            }


        }

        public void ShowData(int index)
        {

            Console.WriteLine(_data[index]);
        }


    }
}
