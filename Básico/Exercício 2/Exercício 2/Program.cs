using System;

namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's compare two numbers! \nType the first number:");

            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the second number:");

            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber + " is bigger!");
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine("The numbers are the same!");
            }
            else
            {
                Console.WriteLine(secondNumber + " is bigger!");
            }
        }
    }
}
