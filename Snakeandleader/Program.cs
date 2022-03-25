using System;

namespace Snakeandleader
{
    internal class Program
    {
        public static void UC1()
        {
            Console.WriteLine("Welcome to UC1");
            Console.WriteLine("Snake and ladder game played with singel player start at 0");
            int start = 0;

        }
        public static void UC2()
        {
            Console.WriteLine("Welcome to UC2");

            Random random = new Random();
            int dice1 = random.Next(1, 7);
            Console.WriteLine("The Random Dice number is :" +dice1);
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            Program.UC1();
            Program.UC2();
        }
    }
}
