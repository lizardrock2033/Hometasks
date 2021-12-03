using System;

namespace WordsCalc
{
    class Program
    {
        static void Main()
        {
            string str = "If you’re going to San Francisco, " +
                "Be sure to wear some flowers in your hair, " +
                "If you’re going to San Francisco, " +
                "You’re gonna meet some gentle people there";
            
            str = str.ToLower();
            str = str.Replace(",", "");

            string[] strArray = str.Split(new char[] { ' ' });

            for (int i = 0; i < strArray.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < strArray.Length; j++)
                {
                    if (strArray[i] == strArray[j])
                    {
                        count++;
                        strArray[j] = null;
                    }
                }
                if (strArray[i] != null)
                    Console.WriteLine("Колличество слов {0} в тексте: {1}", strArray[i], count);
            }
        }
    }
}
