using System;

namespace ArrayMethods_4
{
    class Program
    {
        static void addInIndex(ref int[] arr, int elem, int index)            //Добавление элемента по указанному индексу
        {
            int newLength = arr.Length + 1;

            int[] tempArray = new int[newLength];
            tempArray[index] = elem;

            for (int i = 0; i < arr.Length; i++)
                if (i < index)
                    tempArray[i] = arr[i];
                else
                    tempArray[i + 1] = arr[i];

            arr = null;
            arr = tempArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 5, 16, 24, 48, 11 };

            Console.WriteLine("Текущий вид массива: ");
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + "\t");

            Console.WriteLine("\nВведите элемент для добавления его в массив: ");
            int elem = int.Parse(Console.ReadLine());

            Console.WriteLine("\nУкажите индекс массива, в который необходимо поместить элемент: ");
            int index = int.Parse(Console.ReadLine());

            addInIndex(ref myArray, elem, index);

            Console.WriteLine("Текущий вид массива с добавлением элемента: ");
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + "\t");

            Console.ReadLine();
        }
    }
}
