using System;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            string str = "apple a day keeps a doctor away";
            string subStr = "apple";

            bool isSubStr = str.Contains(subStr);
            if (isSubStr)
            {
                Console.WriteLine("word captured");
            }
            else
            {
                Console.WriteLine("word lost");
            }

            string[] words = str.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            string[] newStr = new string[words.Length];

            for (int i = words.Length - 1, j = 0; i >= 0; i--, j++)
            {
                newStr[j] = words[i];
            }

            Console.WriteLine();
            foreach (string s in newStr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
