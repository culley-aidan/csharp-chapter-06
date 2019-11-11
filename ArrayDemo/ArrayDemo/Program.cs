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
                Console.Write("{0}1) View list in order of first to last position{0}2) View list in order of last to first position{0}3) View a position{0}4) Exit{0}{0}Enter your choice: ", Environment.NewLine);
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        displayArray(intArray);
                        break;
                    case 2:
                        displayArray(reverseArray(intArray));
                        break;
                    case 3:
                        viewPosition(intArray);
                        break;
                    default:
                        break;
                }
            }
        }

        static int[] reverseArray(int[] arr)
        {
            int[] reversedArray = (int[])arr.Clone();
            Array.Reverse(reversedArray);
            return reversedArray;
        }

        static void displayArray(int[] arr)
        {
            Console.WriteLine();
            for(int x = 0; x < arr.Length; ++x)
            {
                Console.Write("{0, 6}", arr[x]);
            }
            Console.WriteLine();
        }

        static void viewPosition(int[] arr)
        {
            Console.WriteLine();
            bool validInput = false;
            int validIndex = 0;
            while (!validInput)
            {
                Console.Write("\tEnter an index (0-7): ");
                int.TryParse(Console.ReadLine(), out validIndex);
                validInput = (validIndex <= 7 && validIndex >= 0);
            }
            Console.WriteLine(Environment.NewLine + string.Format("{0, 6}", arr[validIndex]));
        }
    }
}
