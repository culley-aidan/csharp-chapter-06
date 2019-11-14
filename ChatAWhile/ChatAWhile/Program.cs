using System;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] areaCodes = new int[] { 262, 414, 608, 715, 815, 920 };
            double[] areaRates = new double[] { 0.07D, 0.10D, 0.05D, 0.16, 0.24, 0.14 };
            Console.Write("Enter an area code: ");
            int.TryParse(Console.ReadLine(), out int userAreaCode);
            Console.Write("Enter minutes: ");
            double.TryParse(Console.ReadLine(), out double userMinutes);
            int index = Array.IndexOf(areaCodes, userAreaCode);
            string message = index switch
            {
                -1 => "Your area code was not found, Please try again.",
                _ => string.Format("Area code ({0}) has a fee of ({1}) per minute. The price for {2} minute(s) is {3:C}", areaCodes[index], areaRates[index], userMinutes, MinCalculation(areaRates[index], userMinutes))
            };
            Console.WriteLine(message);
        }

        static double MinCalculation (double rate, double minutes)
        {
            return rate * minutes;
        }
    }
}
