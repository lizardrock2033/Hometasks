using System;
using System.Threading;

namespace Delegates
{
    delegate void NumberHandler(string str);
    class Program
    {
        public event NumberHandler Notify;
        private int Number { set; get; }

        public void Generator()
        {
            while (true)
            {
                Number = new Random().Next(100);
                if (Number < 50) Notify?.Invoke("Get less than 50!: " + Number);

                Thread.Sleep(500);
            }
        }
        static void Main()
        {
            Program pr = new();

            pr.Notify += ConsoleNotify;
            pr.Generator();
        }
        public static void ConsoleNotify(string str)
        {
            Console.WriteLine(str);
        }
    }
}
