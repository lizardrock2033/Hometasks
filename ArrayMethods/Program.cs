using System;

namespace ArrayMethods
{
    class Program
    {
        static bool Resize(ref int[] arr, int value)                //Изменение размера массива
        {
            int newLength = arr.Length + value;

            try
            {
                int[] tempArray = new int[newLength];

                for (int i = 0; i < arr.Length && i < tempArray.Length; i++)
                {
                    tempArray[i] = arr[i];
                }
                arr = tempArray;
            }
            catch (Exception)
            {
                Console.WriteLine("The number of elements in the array can't be less than 0" + "\n");
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 2, 12, 85, 0, 6 };

            Console.WriteLine("There is some elements in the array now: " + myArray.Length);

            Console.WriteLine("Enter the value you want to change the array (you can use '-' before the value to reduce the length of array): ");
            int value = int.Parse(Console.ReadLine());

            if (Resize(ref myArray, value))
            {
                Console.WriteLine("Now the number of elements in the array is: " + myArray.Length);

                for (int i = 0; i < myArray.Length; i++)
                    Console.Write(myArray[i] + "\t");
            }
            Console.ReadLine();
        }
    }
}
