using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack S = new Stack(5);

            S.push(10);
            S.push(20);
            S.push(30);
            S.push(40);
            S.push(50);

            Console.WriteLine("Items are : ");
            S.PrintAll();

            S.pop();
            S.pop();
            S.pop();
            S.PrintAll();
        }
        public class Stack
        {
            private int[] element;
            private int top;
            private int max;
            public Stack(int size)
            {
                element = new int[size];
                top = -1;
                max = size;

            }
            public void push(int item)
            {
                if(top == max -1)
                {
                    Console.WriteLine( "overflow");
                }
                element[++top] = item;
            }
            public int pop()
            {
                if(top == -1)
                {
                    Console.WriteLine("undeflow");
                }
                return element[top--]; 
            }
            public void PrintAll()
            {
                if(top == -1)
                {
                    Console.WriteLine("empty");
                }
                else
                {
                    for(int i = 0; i<top; i++)
                    {
                        Console.WriteLine("Item[" + (i + 1) + "]: " + element[i]);
                    }
                }
            }




        }
    }
}
