using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            int high = 100;
            int low = 1;
            bool goOn = true;
            while (goOn == true)
            {
                Console.WriteLine("May I have your name?");
                string name = Console.ReadLine();

                Console.WriteLine($"{name}, Please enter a number between 1 and 100: ");
                string input = Console.ReadLine();
                int i = int.Parse(input);

                if (i > high)
                {
                    Console.WriteLine($"{name}, Please enter a number between 1 and 100: ");
                }
                else if (i > low)
                {
                    Console.WriteLine($"{name}, Please enter a number between 1 and 100: ");
                }
                else if (i % 2 == 1)
                {
                    Console.WriteLine("Odd.");
                }
                else if (i % 2 == 0 && i >= 2 && i <= 25)
                {
                    Console.WriteLine("Even and less than 25.");
                }
                else if (i % 2 == 0 && i >= 26 && i <= 60)
                {
                    Console.WriteLine("Even.");
                }
                else if (i % 2 == 0 && i > 60)
                {
                    Console.WriteLine($"{i}, Even.");
                }
                else if (i % 2 == 1 && i > 60)
                {
                    Console.WriteLine($"{i}, Odd.");
                }
                goOn = GetContinue();
            }
            static bool GetContinue()
            {
                Console.WriteLine("Would you like to continue? (y/n)");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    return true;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Goodbye!");
                    return false;
                }
                else
                {
                    Console.WriteLine("I didn't understand that, please try again");
                    return GetContinue();
                }
            }
        }
    }
}