using System;

namespace ArrayOutRecurs
{
    class Program
    {
        static void ArrayOut(int[] arr, int i)                  //Вывод массива с помощью рекурсии
        {
            if (i >= arr.Length)
                return;

            Console.Write(arr[i] + "\t");
            i++;
            ArrayOut(arr, i);
        }

        static void Main(string[] args)
        {
            int index = 0;
            int[] arr = new int[] { 3, 17, 24, 85, 12, 65, 71 };

            ArrayOut(arr, index);
        }
    }
}
