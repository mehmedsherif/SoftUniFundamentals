namespace TheBiscuitFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBiscuits=int.Parse(Console.ReadLine());
            int countOfTheWorkers=int.Parse(Console.ReadLine());
            int competingFactoryProduce=int.Parse(Console.ReadLine());

            int totalBiscuits = 0;

            for (int day = 1; day <= 30; day++)
            {
                int dailyProduction = numberOfBiscuits * countOfTheWorkers;

                if (day%3==0)
                {
                    dailyProduction =(int)(dailyProduction*0.75);
                    
                }
                totalBiscuits += dailyProduction;
                
            }
            double percentageDifference = ((double)totalBiscuits - competingFactoryProduce) / competingFactoryProduce * 100;
            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");
            if (totalBiscuits > competingFactoryProduce)
            {
                Console.WriteLine($"You produce {percentageDifference:F2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {Math.Abs(percentageDifference):F2} percent less biscuits.");
            }

        }
    }
}