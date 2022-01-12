using System;

namespace Sale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total, price, tax;
            double taxRate = 0.05;//5%

            Console.WriteLine("What's the price?");
            price = double.Parse(Console.ReadLine());
            total = Math.Round(price * (taxRate+1),2);
            tax = Math.Round(price * (taxRate),2);

            Console.WriteLine($"Price:{price}");
            Console.WriteLine($"Tax:{tax}");
            Console.WriteLine($"Total:{total}");
        }
    }
}
