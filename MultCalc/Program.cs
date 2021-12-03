using System;

namespace MultCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int lLimit = 0, hLimit = 0, isEvenSum = 0, isOddSum = 0;            // Программа выводит колличество и подсчитывает
            uint isEven = 0, isOdd = 0;                                         // сумму четных и нечетных чисел в заданном диапазоне

            bool checking;

            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Enter the lowest limit of the range: ");
                    lLimit = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the higher limit of the range: ");
                    hLimit = int.Parse(Console.ReadLine());

                    checking = lLimit < hLimit;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error! Use the correct number area!");
                    Console.ReadLine();
                    continue;
                }
                if (checking)
                {
                    while (lLimit <= hLimit)
                    {
                        if (lLimit % 2 == 0)
                        {
                            isEven++;
                            isEvenSum += lLimit;
                        }
                        else
                        {
                            isOdd++;
                            isOddSum += lLimit;
                        }
                        lLimit++;
                    }
                    Console.WriteLine("There is " + isEven + " even and " + isOdd + " odd numbers in your area.");
                    Console.WriteLine("The summary of even numbers is: " + isEvenSum + "\n" + "The summary of odd numbers is: " + isOddSum);
                }
                else
                    Console.WriteLine("Error! Use the correct number area!");

                Console.ReadLine();
            }
        }
    }
}
