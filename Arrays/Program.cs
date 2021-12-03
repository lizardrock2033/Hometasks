using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Select the size of the array:");
            uint j = uint.Parse(Console.ReadLine());
            int[] array = new int[j];

            Console.WriteLine("Fill the array with elements:");

            for (int i = 0; i < array.Length; i++)          // Заполнение массива через консоль
                array[i] = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 0; i < array.Length; i++)          // Вывод полученных данных
                Console.Write(array[i] + "\t");

            Console.WriteLine();

            for (int i = array.Length - 1; i >= 0; i--)       // Вывод массива в обратном порядке
                Console.Write(array[i] + "\t");

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)              // Подсчет суммы всех четных чисел в массиве
            {
                if (array[i] % 2 == 0)
                    sum += array[i];
            }
            Console.WriteLine("The sum of all multiple numbers in array: " + sum);

            for (int i = 0; i < array.Length; i++)              // Сортировка массива и вывод наименьшего элемента
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[i] > array[k])
                    {
                        int temp = array[i];
                        array[i] = array[k];
                        array[k] = temp;
                    }
                }
            }
            Console.WriteLine("The lowest element in the array is: " + array[0]);

            int minValue = array[0];                               // Второй вариант поиска и вывода наименьшего элемента
            for (int i = 1; i < array.Length; i++)
            {
                if (minValue > array[i])
                {
                    minValue = array[i];
                }
            }
            Console.WriteLine("V2 The lowest element in the array is: " + minValue);

            Console.ReadLine();
        }
    }
}
