using System;

namespace Exmaple9._01._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Power2(x);
            Console.WriteLine($"power 2 of your number is {x}");
        }
        private static void Power2(int i)
        {
            i = i * 2;

        }
    }
}
