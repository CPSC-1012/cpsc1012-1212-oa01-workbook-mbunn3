/* Purpose: Takes in a Price and calculates Total using stored Tax
 * Inputs: price in dollars and cents
 * Outputs: sales total
 * 
 * Algoritm: 
 *  Step 1) Read price
 *  Step 2) Total = price*(1+taxRate)
 *  Step 3) Display all Data
 *  
 *  Last modified:      2022-01-12
*/
using System;

namespace Sale
{
    internal class Sale
    {
        static void Main(string[] args)
        {
            double total, price, tax;
            double taxRate = 0.05;//5%

            Console.WriteLine("What's the price?");
            price = double.Parse(Console.ReadLine());
            tax = Math.Round(price * (taxRate), 2);
            total = price + tax;
            

            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Total: {total}");
        }
    }
}
