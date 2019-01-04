using System;

namespace code_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //challengeOne();
            challengeTwo();
            challengeTwo();
            challengeTwo();

        }
        private static int findScore(int[] numbers, int choice)
        {
            int counter = 0;
            foreach (var number in numbers)
            {
                if (number == choice)
                {
                    counter++;
                }
            }
            int result = counter * choice;
            return result;
        }
        private static int[] getArr()
        {
            int[] array = new int[5];
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                array[i] = r.Next(1, 10);
            }
            return array;
        }
        private static void challengeOne()
        {
            Console.WriteLine("Hello, let's play a game:");
            int[] array = getArr();
            Console.WriteLine("array: " + String.Join(',', array));
            Console.Write("Select a number between 1 and 10: ");
            string inputStr = Console.ReadLine();
            int input = Convert.ToInt32(inputStr);
            Console.WriteLine("Your Number: " + input);
            Console.WriteLine("Your Score is: " +findScore(array, input));
            Console.ReadLine();
        }
        private static void challengeTwo()
        {
            Random r = new Random();
            int year = r.Next(0, 3000);
            Console.WriteLine("Is " + year + " a leap year?");
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine(year + " is a leap year");
                    } else
                    {
                        Console.WriteLine(year + " is not a leap year");
                    }
                } else {
                Console.WriteLine(year + " is a leap year");
                }
            } else
            {
                Console.WriteLine(year + " is not a leap year");
            }
            Console.ReadLine();
        }
    }
}
