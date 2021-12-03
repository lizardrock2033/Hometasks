using System;

namespace Calc_if_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());                      // Калькулятор

            char sign = char.Parse(Console.ReadLine());

            if (sign == '*')
            {
                int b = int.Parse(Console.ReadLine());

                int result = a * b;

                Console.WriteLine("Result is: " + result);
            }
            if (sign == '/')
            {
                int b = int.Parse(Console.ReadLine());

                int result = a / b;

                Console.WriteLine("Result is: " + result);
            }
            if (sign == '+')
            {
                int b = int.Parse(Console.ReadLine());

                int result = a + b;

                Console.WriteLine("Result is: " + result);
            }
            if (sign == '-')
            {
                int b = int.Parse(Console.ReadLine());

                int result = a - b;

                Console.WriteLine("Result is: " + result);
            }
        }
    }
}
