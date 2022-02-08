using System;

namespace Exercício_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! What's your name?");

            string name = Console.ReadLine();

            char[] nameChars = name.ToCharArray();

            string reversedName = "";

            for (int i = (name.Length - 1); i >= 0; i--)
            {
                string revertingName = reversedName + nameChars[i];

                reversedName = revertingName;                
            }

            Console.WriteLine("Your reversed name is " + reversedName.ToUpper());
        }
    }
}
