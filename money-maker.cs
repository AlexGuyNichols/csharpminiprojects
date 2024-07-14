// Purpose: This program converts an amount of cents into the number of gold, silver, and bronze coins that it is equal to.

using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int goldValue = 10;
            int silverValue = 5;

            Console.WriteLine("Welcome to Money Maker!");
            Console.Write("Enter an amount to convert to coins: ");
            string amount = Console.ReadLine();
            double amountAsDouble = Convert.ToDouble(amount);

            Console.WriteLine($"{amount} cents is equal to...");

            double goldCoins = Math.Floor(amountAsDouble / goldValue);
            double remainder = amountAsDouble % goldValue;
            double silverCoins = Math.Floor(remainder / silverValue);
            remainder = remainder % silverValue;

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");


        }
    }
}