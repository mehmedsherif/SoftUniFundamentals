namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = RepeatString(text, n);
            Console.WriteLine(result);
        }

        private static string RepeatString(string text, int repetition)
        {
            string newText = "";
            for (int i = 0; i < repetition; i++)
            {
                newText += text;
            }
            return newText;

        }
    }
}