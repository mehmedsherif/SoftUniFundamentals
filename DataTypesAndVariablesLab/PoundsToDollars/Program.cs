namespace PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double britishP=double.Parse(Console.ReadLine());
            double usD = 1.31;
            double convert = britishP * usD;
            Console.WriteLine(string.Format("{0:f3}",convert));
        }
    }
}