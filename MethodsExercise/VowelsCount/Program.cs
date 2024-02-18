namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string singleString = Console.ReadLine();
            int vowelCount = 0;
            vowelCount = vowels(singleString, vowelCount);
            Console.WriteLine(vowelCount);
        }

        private static int vowels(string singleString, int vowelCount)
        {
            int vowelsCount = 0;
            foreach (char c in singleString)
            {

                char lowerChar = char.ToLower(c);


                if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}