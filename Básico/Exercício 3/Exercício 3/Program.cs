using System;

namespace Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's find out if the image is landscape or portrait! \nType the image height:");

            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Type the image width:");

            float width = float.Parse(Console.ReadLine());

            if (height == width)
            {
                Console.WriteLine("That's an square image!");
            }
            else if (height > width)
            {
                Console.WriteLine("That's an portrait image!");
            }
            else
            {
                Console.WriteLine("That's an landscape image!");
            }
        }
    }
}
