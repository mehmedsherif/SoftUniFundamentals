namespace CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w=double.Parse(Console.ReadLine());
            double h=double.Parse(Console.ReadLine());

            double area = CalculateRectangleArea(w, h);
            Console.WriteLine(area);
        }
        static double CalculateRectangleArea(double w, double h)
        {
            return w * h;
            
        }
    }
}