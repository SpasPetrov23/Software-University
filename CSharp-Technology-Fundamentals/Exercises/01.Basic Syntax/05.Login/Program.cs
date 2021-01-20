using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int length = username.Length;
            string password = "";
            for (int i = length; i > 0; i--)
            {
                password = password + username.Substring((i - 1), 1);
            }
            string input = Console.ReadLine();
            int failedAttempts = 0;

            while (input != password)
            {
                failedAttempts += 1;
                if (failedAttempts == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
