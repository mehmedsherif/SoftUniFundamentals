using System.Xml.XPath;

namespace Calculations
{
    internal class Program
    {
        private static int result;

        static void Main(string[] args)
        {
            string command=Console.ReadLine();
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());

            if(command =="add")
            {
                Add(a,b);
            }
            else if(command =="multiply")
            {
                Multiply(a,b);
            }
            else if( command =="subtract")
            {
                Subtract(a,b);
            }
            else if(command=="divide")
            {
                Divide(a,b);
            }
        }
        static void Add(int a, int b) 
        {
            result = 0;
              result=a + b;
            Console.WriteLine(result);

        }
        static void Multiply(int a, int b)
        {
            result=a * b;
            Console.WriteLine(result);
        }
        static void Subtract(int a, int b)
        {
            result=a - b;
            Console.WriteLine(result);
        }
        static void Divide(int a, int b)
        {
            result = a / b;
            Console.WriteLine(result);
        }
    }
}