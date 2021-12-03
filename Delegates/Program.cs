using System;

namespace Delegates
{
    delegate string MyDelegate(string str);
    class Program
    {
        static void Main()
        {
            MyDelegate myDel = new(StrReverse);
            string str;
            string dStr = "Same text";

            str = myDel(dStr);
            Console.WriteLine(str);

            myDel = SpReplace;
            str = myDel(dStr);
            Console.WriteLine(str);

            myDel = SpRemove;
            str = myDel(dStr);
            Console.WriteLine(str);

            Console.ReadLine();
        }
        static string StrReverse(string s)
        {
            string nStr = "";
            for (int i = s.Length - 1; i >= 0; i--)
                nStr += s[i];

            return nStr;
        }
        static string SpReplace(string s)
        {
            return s.Replace(' ', '-');
        }
        static string SpRemove(string s)
        {
            string nStr = "";
            for (int i = 0; i < s.Length; i++)
                if (s[i] != ' ') nStr += s[i];
            
            return nStr;
        }
    }
}
