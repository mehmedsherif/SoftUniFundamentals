using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            var phones=Console.ReadLine();
            var phoneMatches = Regex.Matches(phones, pattern);

            Console.WriteLine(string.Join(", ", phoneMatches));
        }   
    }
}