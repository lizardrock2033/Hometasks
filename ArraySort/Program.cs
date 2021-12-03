using System;

namespace ArraySort
{
    class Program
    {
        static void Main()                  //Сортировка массива по возрастранию, вывод второго по величине элемента массива
        {
            int[] array = new int[] {16, 3, 21, 44, 35, 22, 44, 98, 71, 98, 101, 101, 101 };
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + "\t");

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i - 1])
                {
                    Console.WriteLine("\nВторой по величине элемент массива " + array[i]);
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
