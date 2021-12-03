using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;                         // Нормальный калькулятор
            string action;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the first value: ");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second value: ");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error! Enter correct values!");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Choose the action: '+', '-', '*', '/'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine("Result is: " + (firstValue + secondValue));
                        break;
                    case "-":
                        Console.WriteLine("Result is: " + (firstValue - secondValue));
                        break;
                    case "*":
                        Console.WriteLine("Result is: " + (firstValue * secondValue));
                        break;
                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine("Error! Use the correct divisor!");
                        else
                            Console.WriteLine("Result is: " + (firstValue / secondValue));
                        break;
                    default:
                        Console.WriteLine("Error! Use the correct action!");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
