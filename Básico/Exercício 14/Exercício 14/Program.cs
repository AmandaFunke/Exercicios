using System;
using System.Collections.Generic;

namespace Exercício_14
{
    internal class Program
    {
        static void Main(string[] args)
        {                        
            Console.WriteLine("Write a list with at least 5 integers numbers separated with comma, we will show you the 3 smallests.");

            string answer = Console.ReadLine();

            var splitAnswer = answer.Split(',');

            var numericAnswers = new List<double>();
                        
            if (splitAnswer.Length < 5)
            {
                Console.WriteLine("Invalid list, write at least 5 integers numbers");
            }
            else
            {
                for (int i = 0; i < splitAnswer.Length; i++)
                {
                    bool isNumber = double.TryParse(splitAnswer[i], out double answerToNumber);

                    if (isNumber)
                    {
                        if (numericAnswers.Contains(answerToNumber))
                        {
                            continue;
                        }
                        else
                        {
                            numericAnswers.Add(answerToNumber);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid List, use just integers numbers separated with comma");

                        numericAnswers.Clear();

                        break;
                    }
                }

                if (numericAnswers.Count >= 5)
                {
                    numericAnswers.Sort();

                    Console.WriteLine("The 3 smallest numbers are " + numericAnswers[0] + ", " + numericAnswers[1] + " and " + numericAnswers[2] + "!");
                }
                else if (numericAnswers.Count > 0 && numericAnswers.Count < 5)
                {
                    Console.WriteLine("Invalid list, write at least 5 different integers numbers");
                }
            }            
        }
    }
}
