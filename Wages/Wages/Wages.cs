using System;

namespace Wages
{
    internal class Wages
    {
        static void Main(string[] args)
        {
            double normalWages, overtimeWages, totalWages;
            double normalPay, overtimePay;
            double normalHours, overtimeHours;

            Console.WriteLine("What's your normal pay?");
            normalPay = double.Parse(Console.ReadLine());
            Console.WriteLine("What were you non-overtime hours?");
            normalHours = double.Parse(Console.ReadLine());

            normalWages = normalPay * normalHours;


            Console.WriteLine("What's your Overtime pay?");
            overtimePay = double.Parse(Console.ReadLine());
            Console.WriteLine("What were you Overtime hours?");
            overtimeHours = double.Parse(Console.ReadLine());

            overtimeWages = overtimePay * overtimeHours;

            totalWages = overtimeWages + normalWages;

            Console.WriteLine($"{"Normal Pay:",-15} {"$"+normalWages,5}");
            Console.WriteLine($"{"Overtime Pay:",-15} {"$" + overtimeWages,5}");
            Console.WriteLine($"{"Total Pay:",-15} {"$" + totalWages,5}");

        }
    }
}
