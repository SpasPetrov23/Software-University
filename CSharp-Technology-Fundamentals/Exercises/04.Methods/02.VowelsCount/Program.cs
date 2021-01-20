using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(VowelsCount(input));
        }

        private static int VowelsCount(string input)
        {
            int vowelsCount = 0;
            string inputToLower = input.ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                if (inputToLower[i] == 'a' ||
                    inputToLower[i] == 'e' ||
                    inputToLower[i] == 'i' ||
                    inputToLower[i] == 'u' ||
                    inputToLower[i] == 'o' ||
                    inputToLower[i] == 'y')

                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
