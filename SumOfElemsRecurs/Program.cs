using System;

namespace SumOfElemsRecurs
{
    class Program
    {
        static void SumOfArray (int[] arr, int i, int c)            //Нахождение суммы элементов массива с помощью рекурсии
        {
            if (i >= arr.Length)
            {
                Console.WriteLine("Сумма элементов массива равна = " + c);
                return;
            }

            c += arr[i];
            i++;

            SumOfArray(arr, i, c);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 57, 16, 4, 1 };

            SumOfArray(arr, 0, 0);
        }
    }
}
