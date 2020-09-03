using System;

namespace Money_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneyMaker();
        }

        static void MoneyMaker()
        {
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("Enter an amount of change");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{amount} is equal to about...");

            int goldVal = 10;
            int silverVal = 5;

            //gold
            double gold = Math.Floor(amount / goldVal);
            double remander = amount % goldVal;

            //silver
            double silver = Math.Floor(remander / silverVal);
            remander = remander % silverVal;

            //results
            Console.WriteLine($"{gold} gold coins");
            Console.WriteLine($"{silver} silver coins");
            Console.WriteLine($"{remander} bronze coins");
        }
    }
}
