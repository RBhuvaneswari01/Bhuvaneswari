using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10ass1b
{
    internal class Program
    {
        public class GenericNode<s>
        {
            public s data;
            public GenericNode<s> nextNode = null;

            public GenericNode(s data)
            {
                this.data = data;
            }
        }

        public class GenericLinkedList<s>
        {
            private GenericNode<s> head = null;

            public void Add(s newListItem)
            {
                if (head == null)
                {
                    head = new GenericNode<s>(newListItem);
                }
                else
                {
                    GenericNode<s> cur = head;
                    while (cur.nextNode != null)
                    {
                        cur = cur.nextNode;
                    }
                    cur.nextNode = new GenericNode<s>(newListItem);
                }
            }

            public void DisplayNodes()
            {
                GenericNode<s> cur = head;
                while (cur != null)
                {
                    System.Console.WriteLine(cur.data);
                    cur = cur.nextNode;
                }
            }
        }

        class TestGenericLinkedList
        {
            static void Main(string[] args)
            {
                GenericLinkedList<System.Object> a = new GenericLinkedList<System.Object>();
                a.Add(2000);
                a.Add(29.251);
                a.Add("bhuvana");
                a.Add(true);
                a.DisplayNodes();
                Console.ReadLine();
            }
        }
    }
}
