using System;
using System.Collections.Generic;

namespace Exercício_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here you can write 5 numbers and we sort them for you!");
            
            var numbers = new List<double>();

            int numbersQuantity = 5;

            for (int i = 0; i < numbersQuantity; i++)
            {
                Console.Write((i + 1) + ". Write a number: ");

                string answer = Console.ReadLine();

                bool isNumber = double.TryParse(answer, out double answerToNumber);
                
                if (isNumber)
                {
                    if (numbers.Contains(answerToNumber))
                    {
                        Console.WriteLine("Invalid Number");
                        i--;
                    }
                    else
                    {
                        numbers.Add(answerToNumber);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Answer");
                    i--;
                }
            }

            numbers.Sort();

            Console.WriteLine("These are your numbers sorted: ");

            foreach (double i in numbers)
            {
                Console.Write(i + " ");
            }
        }
    }
}
