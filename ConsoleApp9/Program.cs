using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Increment(int i)
        {
            i = i + 1;
        }
        static void Main()
        {
            int x = 1;
            Increment( x);
            Console.WriteLine("The value of x is: " + x);
        }
    }
}
