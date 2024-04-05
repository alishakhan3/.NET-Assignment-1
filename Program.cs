// See https://aka.ms/new-console-template for more information
using System;

namespace addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = add(a, b);

            Console.WriteLine($"Sum: {a} + {b} = {sum}");
        }
        static int add(int a, int b)
        {
            return a + b;
        }
    }
}
