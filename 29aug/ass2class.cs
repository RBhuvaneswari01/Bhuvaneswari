using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10assesment2
{
    internal class Queue
    {
        internal static readonly int max = 1000;
        internal int[] queue = new int[max];
        int front, rear, capacity;
        public Queue(int c)
        {
            front = rear = 0;
            capacity =c;

        }

        internal void Enqueue(int data)
        {
            if (capacity==rear)
            {
                Console.WriteLine("\n queue is full");
                return;
            }
            else
            {
                queue[++rear] = data;

            }
        }
       internal void Dequeue()
        {

            if (front == rear)
            {
                Console.Write("\n Queue is empty");
                return;
            }
            else
            {
                for (int i = 0; i < rear - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }

              
                if (rear < capacity)
                    queue[rear] = 0;

               
                rear--;
            }
            return;
        }

        internal void Display()
        {
            int i;
            if (front == rear)
            {
                Console.Write("\n Queue is Empty");
                return;
            }
            for (i = front; i < rear; i++)
            {
                Console.Write(" {0} ", queue[i]);
            }
            return;
        }
        

       
    }
}
