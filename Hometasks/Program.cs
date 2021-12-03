using System;

namespace Hometasks
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollar, euro, result;                    // Конвертер валют
            string str;
            int a, ch2, ch21;
            
            dollar = 71.83;
            euro = 87.46;

            
            Console.WriteLine("1.Rubles-Dollars" + "\n" + "2.Rubles-Euros" + "\n" + "Choose 1 or 2:");
            str = Console.ReadLine();
            bool ch1 = int.TryParse(str, out a);

            if (ch1)
            {
                if (a == 1)
                {
                    Console.WriteLine("1.Rubles to Dollars" + "\n" + "2.Dollars to Rubles" + "\n" + "Choose 1 or 2:");
                    str = Console.ReadLine();
                    ch2 = Convert.ToInt32(str);

                    if (ch2 == 1)
                    {
                        Console.WriteLine("Enter amount of rubles: ");
                        str = Console.ReadLine();
                        ch21 = Convert.ToInt32(str);
                        result = ch21 / dollar;
                        Console.WriteLine("You have " + result + " dollars");
                    }
                    if (ch2 == 2)
                    {
                        Console.WriteLine("Enter amount of dollars: ");
                        str = Console.ReadLine();
                        ch21 = Convert.ToInt32(str);
                        result = ch21 * dollar;
                        Console.WriteLine("You have " + result + " rubles");
                    }

                }
                if (a == 2)
                {
                    Console.WriteLine("1.Rubles to Euros" + "\n" + "2.Euros to Rubles" + "\n" + "Choose 1 or 2:");
                    str = Console.ReadLine();
                    ch2 = Convert.ToInt32(str);

                    if (ch2 == 1)
                    {
                        Console.WriteLine("Enter amount of rubles: ");
                        str = Console.ReadLine();
                        ch21 = Convert.ToInt32(str);
                        result = ch21 / euro;
                        Console.WriteLine("You have " + result + " euros");
                    }
                    if (ch2 == 2)
                    {
                        Console.WriteLine("Enter amount of euros: ");
                        str = Console.ReadLine();
                        ch21 = Convert.ToInt32(str);
                        result = ch21 * euro;
                        Console.WriteLine("You have " + result + " rubles");
                    }
                    else
                    {
                        Console.WriteLine("Please, enter correct answer!");
                    }

                }
            }
            else
            {
                Console.WriteLine("Please, enter correct answer!");
            }

        }
    }
}
