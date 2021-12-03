using System;

namespace ArrayMethods_5
{
    class Program
    {
        static void deleteInBeginning(ref int[] arr)            //Удаление первого элемента массива
        {
            int[] tempArray = new int[arr.Length - 1];

            for (int i = 1; i < arr.Length; i++)
                tempArray[i - 1] = arr[i];

            arr = null;
            arr = tempArray;
        }
            static void Main(string[] args)
        {
            int[] myArray = new int[] { 5, 16, 24, 48, 11 };

            Console.WriteLine("Текущий вид массива: ");
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + "\t");

            deleteInBeginning(ref myArray);

            Console.WriteLine("\nТекущий вид массива с удалением первого элемента: ");
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + "\t");

            Console.ReadLine();
        }
    }
}
