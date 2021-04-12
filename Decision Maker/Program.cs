using System;

namespace Decision_Maker
{
    class Program
    {
        private static int input;
        private static object ans;
        private static object y;

        static void Main(string[] args)

        {
            Console.WriteLine("Hello! What is your name? ");
            string name = Console.ReadLine();

            do
            {
                Console.WriteLine("Please enter a number between 1 and 100");

                input = int.Parse(s: Console.ReadLine());
                if (input % 2 == 1)
                {
                    Console.WriteLine($"{name}, {input} is odd.");
                }
                else if ((input % 2 == 0) && (input >= 2) && (input <= 25))
                {
                    Console.WriteLine($"{name}, that is even and less than 25.");
                }
                else if ((input % 2 == 0) && (input >= 26) && (input <= 60))
                {
                    Console.WriteLine($"That is even, {name}.");
                }
                else if ((input % 2 == 0) && (input > 60))
                {
                    Console.WriteLine($"{input} is even.");
                }
                //Following will currently return same response as first if statement, but added line as requested in case it will be utilized later.
                else if ((input % 2 == 1) && (input > 60))
                {
                    Console.WriteLine($"{name}, {input} is odd.");
                }
                Console.WriteLine($"Would you like to continue, {name}? y/n");
                Console.ReadLine();
            } while (ans != y);
            Console.WriteLine($"Thank you for playing, {name}!");    
        }
    }
}
