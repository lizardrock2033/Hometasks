using System;

namespace Methods
{
    class Program
    {
        static void printLine(char sign,int value)          //Вывод символа в заданном колличестве
        {
            for (int i = 0; i < value; i++)
            {
                Console.Write(sign + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the sign for print: ");
            char sign = Console.ReadKey().KeyChar;

            Console.WriteLine("\nChoose the number of iterations: ");
            int value = int.Parse(Console.ReadLine());

            printLine(sign, value);

            Console.ReadLine();
        }
    }
}
