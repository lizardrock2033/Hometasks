using System;

namespace MultDetecting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number to check:");

            int number = int.Parse(Console.ReadLine()) % 2;

            if (number == 0)                                            // Проверка числа на кратность
            {
                Console.WriteLine("Yor number is multiple.");
            }
            else
            {
                Console.WriteLine("Your number is not a multiple.");
            }
        }
    }
}
