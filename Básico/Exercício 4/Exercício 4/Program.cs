using System;

namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speed camera! \nWhats the speed limit?");

            float speedLimit = float.Parse(Console.ReadLine());

            Console.WriteLine("Whats the car speed?");

            float carSpeed = float.Parse(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok!");
            }
            else
            {
                float speedDifference = carSpeed - speedLimit;

                float demerit = speedDifference / 5;

                if (demerit >= 12)
                {
                    Console.WriteLine("License Suspended!");
                }
                else
                {
                    Console.WriteLine("Demerit points: " + demerit);
                }
            }
        }
    }
}
