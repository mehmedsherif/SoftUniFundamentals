using System;

namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharacter(input);
        }

        private static void PrintMiddleCharacter(string input)
        {
            int length = input.Length;
            if (length % 2 == 0)
            {
                int middle1 = length / 2 - 1;
                int middle2 = length / 2;

                
                string middleCharacters = input[middle1].ToString() + input[middle2];
                Console.WriteLine(middleCharacters);
            }
            else
            {
                int middle = length / 2;

                
                Console.WriteLine(input[middle]);
            }
        }
    }
}
