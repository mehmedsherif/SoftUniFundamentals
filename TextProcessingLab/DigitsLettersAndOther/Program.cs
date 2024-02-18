using System;
using System.Linq;

namespace DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(new string(text.Where(x => char.IsDigit(x)).ToArray()));
            Console.WriteLine(new string(text.Where(x => char.IsLetter(x)).ToArray()));
            Console.WriteLine(new string(text.Where(x => !char.IsDigit(x) && !char.IsLetter(x)).ToArray()));
        }
    }
}
