using System;
using System.Collections.Generic;

namespace Exercício_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's make a number list! Just type the numbers, we sort them for you!");

            var numbers = new List<double>();

            bool keepGoing = true;

            while (keepGoing)
            {
                Console.Write("Write a number to add to list or QUIT to see the list: ");

                string answer = Console.ReadLine();

                bool isNumber = double.TryParse(answer, out double typedNumber);
                if (isNumber)
                {
                    if (numbers.Contains(typedNumber))
                    {
                        continue;
                    }
                    else
                    {
                        numbers.Add(typedNumber);
                    }
                }
                else if (answer.ToUpper() == "QUIT")
                {
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }

            numbers.Sort();  

            Console.WriteLine("That's your sorted list: ");

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
        }
    }
}
