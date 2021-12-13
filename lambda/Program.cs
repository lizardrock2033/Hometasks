using System;

namespace lambda
{
    class Program
    {
        delegate bool IsEqual(int x);
        static void Main()
        {
            IsEqual num1 = x => x < 5;

            int number = new Random().Next(10);
            Console.WriteLine(num1(number));
        }
    }
}
