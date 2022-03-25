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
            Console.WriteLine("The Random Dice number is : "+dice1);
            

        }
        

    

        public static void UC3()
        {
            int ladder = 1, ldice;
            int snake = 2, sdice;
            Console.WriteLine("Welcome to UC3");
            Random random = new Random();
            int randomCheck = random.Next(3);

            switch (randomCheck)
            {
                case 1:
                    {
                        Random rnd = new Random();
                        ldice = rnd.Next(1, 7);
                        Console.WriteLine("Got Ladder");
                        break;
                    }
                case 2:
                    {
                        Random sran = new Random();
                        sdice = sran.Next(1, 7);
                        Console.WriteLine("Got snake");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("No play, Stay at base");
                        break;
                    }
            }


        }

        static void Main(string[] args)
        {
            Program.UC1();
            Program.UC2();
            Program.UC3();
        }
    }
}
