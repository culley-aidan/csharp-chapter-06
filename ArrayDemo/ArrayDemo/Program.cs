using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            while (choice != 4)
            {
                Console.Write("1) View list in order of first to last position{0}2) View list in order of last to first position{0}3) View a position");
                int.TryParse(Console.ReadLine(), out choice);
            }
        }
        static void displayArray(int[] arr)
        {
            for(int x =0; x < arr.Length; ++x)
            {
                Console.Write("{0, 6}", arr[x]);
            }
        }
    }
}
