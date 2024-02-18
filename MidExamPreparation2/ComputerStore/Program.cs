﻿namespace ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal totalPrice = 0;
            string input;
            while (true) 
            {
              input = Console.ReadLine();
                if(input=="special" ||  input=="regular")
                {
                    break;
                }
                decimal price=decimal.Parse(input);
                if(price < 0 ) 
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                totalPrice += price;

            }
            if(totalPrice==0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                decimal taxes = totalPrice * (20m / 100m);
                decimal totalPriceWithTaxes = totalPrice + taxes;

                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                
                if(input=="special")
                {
                    totalPriceWithTaxes -= (totalPriceWithTaxes*10m)/100m;
                }
                Console.WriteLine($"Total price: {totalPriceWithTaxes:F2}$");
            }
        }
    }
}