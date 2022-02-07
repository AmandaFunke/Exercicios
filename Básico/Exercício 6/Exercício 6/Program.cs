using System;
using System.Collections.Generic;

namespace Exercício_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding numbers!");

            float initialValue = 0;

            while (true)
            {
                Console.WriteLine("Type a number to sum, or OK to finish");

                string typedAnswer = Console.ReadLine();

                bool isNumber = float.TryParse(typedAnswer, out float answerToNumber);
                
                if (isNumber)
                {
                    float currentValue = initialValue + answerToNumber;

                    Console.WriteLine("The sum so far is: " + currentValue);

                    initialValue = currentValue;
                }
                else if (typedAnswer == "OK" || typedAnswer == "ok")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }           
            }
        }
    }
}
