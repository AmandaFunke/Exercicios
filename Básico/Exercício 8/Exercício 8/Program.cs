using System;

namespace Exercício_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(1, 10);

            int chances = 4;

            Console.WriteLine(randomNumber);

            Console.WriteLine("Try to hit the random number! You have " + chances + " chances...");
                        
            for (int i = 0; i < chances; i++)
            {
                Console.WriteLine("Type a number between 1 and 10:");

                int typedAnswer = int.Parse(Console.ReadLine());

                if (typedAnswer >= 1 && typedAnswer <= 10)
                {
                    if (typedAnswer == randomNumber)
                    {
                        Console.WriteLine("You're right!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This is not the number... You have " + ((chances - 1) - i) + " more chances!");                        
                    }
                }
                else
                {
                    Console.WriteLine("This is not a valid answer");
                    i--;
                }
            }
        }
    }
}
