using System;

namespace Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            int countNumber = 0;

            while (number <= 100)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine(number);
                    countNumber++;
                }
                number++;
            }

            Console.WriteLine("There are " + countNumber + " numbers divisible by 3 between 1 and 100");
        }
    }
}
