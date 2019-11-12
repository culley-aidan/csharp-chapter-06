using System;

namespace DeliveryChanges
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] zipCodes = new uint[] { 73013, 73003, 73012, 73134, 73131, 73049, 73007, 73025, 73142, 73120 };
            double[] zipPrice = new double[] { .75D, 1.25D, 1.10D, .95D, .80D, .97D, .89D, .50D, .34D, .45D };
            Console.Write("Enter your zipcode: ");
            uint.TryParse(Console.ReadLine(), out uint userZip);
            bool deliverable = false;
            int i = 0;
            for (i = 0; i < 10; ++i)
            {
                if (userZip == zipCodes[i])
                {
                    deliverable = true;
                    break;
                }
            }
            string message = deliverable switch
            {
                true => string.Format("You can be delivered to, however your fee is {0:C}", zipPrice[i]),
                false => "You can't be delivered to."
            };
            Console.WriteLine(message + Environment.NewLine);

            Console.Write("Zip Codes in our database: ");
            for (int k = 0; k < 10; ++k)
            {
                Console.Write("{0,10}", string.Format("Code: {0} Fee: {1:C}, ", zipCodes[k], zipPrice[k]));
            }
            Console.WriteLine();
        }
    }
}
