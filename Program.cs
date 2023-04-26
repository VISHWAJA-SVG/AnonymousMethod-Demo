using System;

namespace AnonymousMethodDemo
{
    class Program
    {
        public delegate void sum(int x, int y);
        static void Main(string[] args)
        {
            sum s = delegate (int x, int y)
            {
                Console.WriteLine("Inside Anonymous method");
                Console.WriteLine("Sum = {0}", x + y);
            };
            s(7, 12);
        }
    }
}

