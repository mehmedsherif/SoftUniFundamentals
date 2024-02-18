namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines=int.Parse(Console.ReadLine());
            int capacity = 255;
            int sum = 0;

            for (int i = 0; i < lines; i++)
            {
                int quantities = int.Parse(Console.ReadLine());

                if(sum+quantities>capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    
                }
                else 
                {
                    sum+= quantities;
                }
            }
            Console.WriteLine(sum);
        }
    }
}