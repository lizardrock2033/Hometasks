using System;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the size of triangles: ");
            uint heightTriangle = uint.Parse(Console.ReadLine());
            Console.Clear();

            uint count = 1;
            uint spaceCount = heightTriangle;

            while (count < heightTriangle)              // Выводим первый треугольник
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write("+");
                }
                count++;
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            while (count == heightTriangle)             // Второй треугольник, но перевернутый
            {
                while (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write("+");
                    }
                    count--;
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n\n");

            while (count < heightTriangle)              // Третий треугольник, зеркальный
            {
                for (int i = 1; i < spaceCount; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i <= count; i++)
                {
                    Console.Write("+");
                }
                spaceCount--;
                count++;
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            while (count == heightTriangle)             // Четвертый треугольник, зеркальный и перевернутый
            {
                while (count > 0)
                {
                    for (int i = 0; i < spaceCount; i++)
                    {
                        Console.Write(" ");
                    }
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write("+");
                    }
                    spaceCount++;
                    count--;
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
