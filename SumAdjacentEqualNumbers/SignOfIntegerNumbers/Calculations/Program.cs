using System.ComponentModel;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine();
            int number=int.Parse(Console.ReadLine());
            int anotherNumber=int.Parse(Console.ReadLine());

            switch (command) 
            {
                case "add":
                     Add(a, b);
                    break;
                        case "multiply":
                    Multiply(a, b);
                    break;
                case "subtract":
                    Subtract(a, b);
                    break;
                case "divide":
                    Divide(a, b);
                    break;
            }

        }
        static int Add(int a, int b) 
        {
            Console.WriteLine(a + b);
        }
        static void Multiply(int a, int b) 
        {
            Console.WriteLine(a * b);
        }
    }
}