namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                bool isNumberPalindrome = IsPalindrome(input);
                Console.WriteLine(isNumberPalindrome);
            }
        }

        private static bool IsPalindrome(string input)
        {
            
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
