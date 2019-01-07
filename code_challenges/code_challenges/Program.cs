using System;

namespace code_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //challengeOne();
            //challengeTwo();
            //int[] sequence = { 1, -2, 3 };
            //challengeThree(sequence);
            challengeFour();
            

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
        private static void challengeThree(int[] perfectSequense)
        {
            Console.WriteLine("Array: " + String.Join(',', perfectSequense));
            int sum = 0;
            int product = 1;
            foreach ( var number in perfectSequense)
            {
                sum += number;
                product *= number;
            }
            if (sum == product)
            {
                Console.WriteLine(String.Join(',', perfectSequense) + " is a perfect sequence");
            } else
            {
                Console.WriteLine(String.Join(',', perfectSequense) + " is not a perfect sequense");
            }
            Console.ReadLine();
        }
        private static void challengeFour()
        {
            Console.Write("Please select number of columns (1-10) : ");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please select number of rows (1-10) : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int[,] myArr = new int[columns, rows];
            for (int i = 0; i < columns; i++)
            {
                Console.Write("Column " + i + ": ");
                for (int j = 0; j < rows; j++)
                {
                    Random r = new Random();
                    myArr[i, j] = r.Next(0, 10);
                    Console.Write(myArr[i, j] + ", ");
                }
                Console.WriteLine();
            }



            //int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };


            int[] totalArr = new int[myArr.GetLength(0)];
            for (int i = 0; i < myArr.GetLength(0); i++)
            {
                for (int j = 0; j < myArr.GetLength(1); j++)
                {
                    totalArr[i] += myArr[i, j];
                }
            }
            for (int k = 0; k < myArr.GetLength(0); k++)
            {
            }

            Console.WriteLine("Row totals: " + String.Join(',', totalArr));
            Console.ReadLine();
        }
    }
}
