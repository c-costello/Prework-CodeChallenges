using System;

namespace code_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            int [] testArr = { 2, 2, 4, 5, 7 };
            Console.WriteLine("testArr: " + String.Join(',', testArr));
            Console.Write("Select a number between 1 and 10");
            string inputStr = Console.ReadLine();
            int input = Convert.ToInt32(inputStr);
            Console.WriteLine("Your Number: " + input);
            Console.WriteLine("Your Score is: " +findScore(testArr, input));
            Console.ReadLine();

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

    }
}
