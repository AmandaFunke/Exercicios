using System;

namespace Exercício_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write integers separated by commas and let's find the biggest one!");
            
            string typedAnswer = Console.ReadLine();

            string[] splittedAnswer = typedAnswer.Split(',');
                        
            int bigger = 0;

            for (int i = 0; i < splittedAnswer.Length; i++)
            {
                bool isNumber = int.TryParse(splittedAnswer[i], out int numericAnswer);

                if (isNumber)
                {
                    if (numericAnswer > bigger)
                    {
                        bigger = numericAnswer;
                    }
                }               
            }

            Console.WriteLine("The biggest one is " + bigger);
        }
    }
}
