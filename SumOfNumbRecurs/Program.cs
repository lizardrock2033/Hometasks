using System;

namespace SumOfNumbRecurs
{
    class Program
    {
        static void SumOfNymb (int numb, int sum)
        {
            if (numb == 0)
            {
                Console.WriteLine(sum);
                return;
            }

            sum += numb % 10;
            numb = numb / 10;

            SumOfNymb(numb, sum);
        }
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());

            SumOfNymb(numb, 0);
        }
    }
}
