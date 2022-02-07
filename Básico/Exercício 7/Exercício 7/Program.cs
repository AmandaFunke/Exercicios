using System;

namespace Exercício_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial Calculator! \nType a number:");

            int typedNumber = int.Parse(Console.ReadLine());

            int initialValue = 1;

            int calculatedValue = 0;

            for (int i = typedNumber; i >= 1; i--)
            {
                calculatedValue = initialValue * i;

                initialValue = calculatedValue;
            }

            Console.WriteLine(typedNumber + "! = " + calculatedValue);
        }
    }
}
