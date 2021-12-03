using System;

namespace Methods_2
{
    class Program                           //Создание рандомного массива и поиск в нем индекса элемента
    {
        static int IndexOf(int[] array, int element)        //Короткая версия
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == element)
                {
                    return i;
                }

            return -1;
        }
        static void FindIndex(int[] array, int element)         //Версия "вручную"
        {
            bool detector = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    Console.WriteLine("The index of your element is: " + i);
                    detector = true;
                    i = array.Length;
                }
            }

            if (detector == false)
                Console.WriteLine("This element is not present in the array.");
        }
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Random random = new Random();

            while (true)
            {
                for (int i = 0; i < array.Length; i++)
                    array[i] = random.Next(5);

                Console.WriteLine("Enter the element to find his index in random array: ");
                int element = int.Parse(Console.ReadLine());

                int result = IndexOf(array, element);
                Console.WriteLine("\n" + result + "\n");

                FindIndex(array, element);

                //for (int i = 0; i < array.Length; i++)
                //    Console.Write(array[i] + " ");

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
