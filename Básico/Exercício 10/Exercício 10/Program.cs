using System;
using System.Collections.Generic;

namespace Exercício_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            bool hasAnswer = true;

            while (hasAnswer)
            {
                Console.WriteLine("Write a name:");

                string typedName = Console.ReadLine();
                                               
                if (typedName == "")
                {
                    hasAnswer = false;
                }
                else
                {
                    names.Add(typedName);

                    hasAnswer = true;
                }
            }
            
            if (names.Count == 0)
            {
                Console.WriteLine("You didn't type any name");
            }
            else if (names.Count == 1)
            {
                Console.WriteLine("You wrote the name " + names[0]);
            }
            else if(names.Count == 2)
            {
                Console.WriteLine("You wrote the names " + names[0] + " and " + names[1]);
            }
            else if (names.Count >= 3)
            {
                Console.WriteLine("You wrote the names " + names[0] + ", " + names[1] + " and " + (names.Count - 2) + " more");
            }
        }
    }
}
