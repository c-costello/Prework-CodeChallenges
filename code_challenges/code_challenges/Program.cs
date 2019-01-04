﻿using System;

namespace code_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            challengeOne();

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
    }
}