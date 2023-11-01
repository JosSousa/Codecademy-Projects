using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      
      Console.WriteLine("Enter an amount to convert to coins: ");
      string value = Console.ReadLine();
      double newValue = Convert.ToDouble(value);
      Console.WriteLine($"{newValue} is equal to...");
      double goldCoin = 10;
      double silverCoin = 5;

      double goldCoins = newValue / goldCoin;
      goldCoins = Math.Floor(goldCoins);
      Console.WriteLine($"Gold Coins {goldCoins}");
      double remainder = newValue % goldCoins;
      Console.WriteLine(remainder);
      double silverCoins = remainder / silverCoin;
      silverCoins = Math.Floor(silverCoins);
      remainder = remainder % silverCoins;
      Console.WriteLine(remainder);
    }
  }
}
