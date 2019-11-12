using System;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] zipCodes = new uint[] { 73013, 73003, 73012, 73134, 73131, 73049, 73007, 73025, 73142, 73120 };
            Console.Write("Enter your zipcode: ");
            uint.TryParse(Console.ReadLine(), out uint userZip);
            bool deliverable = false;
            for (int i = 0; i < 10; ++i)
            {
                if (userZip == zipCodes[i])
                {
                    deliverable = true;
                    break;
                }
            }
            string message = deliverable switch
            {
                true => "You can be delivered to.",
                false => "You can't be delivered to."
            };
            Console.WriteLine(message + Environment.NewLine);

            Console.Write("Zip Codes in our database: ");
            foreach (uint zip in zipCodes)
            {
                Console.Write("{0,6}", zip);
            }
            Console.WriteLine();
        }
    }
}
