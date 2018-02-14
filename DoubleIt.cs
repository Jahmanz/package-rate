using System;

class Shipping
  {
    static void Main()
    {
      Console.WriteLine("What is the weight of your package?");
      string package = Console.ReadLine();

      int packageWeight = int.Parse(package);

      Console.WriteLine("How far is your package going?");
      string distance = Console.ReadLine();

      int packageDistance = int.Parse(distance);

      int priceModifier = 10;

      int myPackageRate = (packageWeight / 10) + (packageDistance / 5) * priceModifier;

      Console.WriteLine("Your package deliver costs are " + " " + myPackageRate);

    }
  }
