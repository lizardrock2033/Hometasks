using System;

namespace ArrayMethods_2
{
    class Program
    {
        static void AddInBeginning(ref int[] arr, int elem)                 //Добавление элемента в начало массива
        {
            int newLength = arr.Length + 1;

            int[] tempArray = new int[newLength];
            tempArray[0] = elem;

            for (int i = 0; i < arr.Length; i++)
                tempArray[i + 1] = arr[i];

            arr = null;
            arr = tempArray;

            //arr = new int[newLength];                        //Куда уж мудрёнее

            //for (int i = 0; i < tempArray.Length; i++)
            //    arr[i] = tempArray[i];
        }
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 5, 16, 24, 48, 11 };

            Console.WriteLine("Текущий вид массива: ");
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + "\t");

            Console.WriteLine("\nВведите элемент для добавления его в начало массива: ");
            int elem = int.Parse(Console.ReadLine());

            AddInBeginning(ref myArray, elem);

            Console.WriteLine("Текущий вид массива с добавлением элемента: ");
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray[i] + "\t");

            Console.ReadLine();
        }
    }
}
