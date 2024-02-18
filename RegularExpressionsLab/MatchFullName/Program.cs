using System.Text.RegularExpressions;


namespace MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string regexFullName = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            
            MatchCollection matches = Regex.Matches(text, regexFullName);

            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }
        }
    }
}