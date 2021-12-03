using System;

namespace ArrayMethods_3
{
    class Program
    {
        static void addInEnding(ref int[] arr, int elem)            //Добавление элемента в конец массива
        {
            int newLength = arr.Length + 1;

            int[] tempArray = new int[newLength];
            tempArray[newLength - 1] = elem;

            for (int i = 0; i < arr.Length; i++)
                tempArray[i] = arr[i];

            arr = null;
            arr = tempArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 5, 16, 24, 48, 11 };

            Console.WriteLine("Текущий вид массива: ");
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + "\t");

            Console.WriteLine("\nВведите элемент для добавления его в конец массива: ");
            int elem = int.Parse(Console.ReadLine());

            addInEnding(ref myArray, elem);

            Console.WriteLine("Текущий вид массива с добавлением элемента: ");
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + "\t");

            Console.ReadLine();
        }
    }
}
