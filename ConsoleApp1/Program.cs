using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[] intArray = new int[] { 74, 55, 1, 34, 47, 6, 1, 52, 3, 74, 111, 78 };
            int temp;

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = 0; j < intArray.Length; j++)
                {
                    if (intArray[i] < intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }

            foreach (int i in intArray)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine();

            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] != intArray[i - 1])
                {
                    Console.WriteLine($"Второе по величине число в массиве: {intArray[i]}");
                    break;
                }
            }
        }
    }
}
