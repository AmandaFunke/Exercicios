using System;

namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Type a number between 1 and 10, then press enter:");

            int typedNumber = int.Parse(Console.ReadLine());

            if (typedNumber >= 1 && typedNumber <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
