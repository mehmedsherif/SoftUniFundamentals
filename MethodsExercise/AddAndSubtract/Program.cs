using System.Runtime.ExceptionServices;

namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int result = Sum(first, second);
            result=Substarct(result,third);

            Console.WriteLine(result);

        }

        private static int Sum(int first, int second)
        {
            return first + second;
        }
        static int Substarct(int result,int third)
        {
            return result-third;
        }
    }
}