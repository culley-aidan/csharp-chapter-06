using System;

namespace WhippetBus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter trip distance: ");
            double.TryParse(Console.ReadLine(), out double miles);
            double price = miles switch
            {
                double x when (x <= 0) => 0,
                double x when (x <= 99) => 25.00,
                double x when (x <= 299) => 40.00,
                double x when (x <= 499) => 55.00,
                _ => 70.00
            };
            Console.WriteLine("The trip distance of {0} will cost {1:C}", miles, price);
        }
    }
}
