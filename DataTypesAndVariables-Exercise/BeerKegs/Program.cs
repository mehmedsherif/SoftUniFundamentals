namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegsCount=int.Parse(Console.ReadLine());
            string biggestKegModel="";
            decimal biggestKegVolume = 0;
            

            for (int i = 0; i < kegsCount; i++)
            {
                string kegModel = Console.ReadLine();
                decimal kegRadius=decimal.Parse(Console.ReadLine());
                decimal kegHeight=decimal.Parse(Console.ReadLine());

                decimal volume=(decimal)Math.PI*(kegRadius*kegRadius)*kegHeight;

                if (volume>biggestKegVolume) 
                {
                    biggestKegVolume = volume;
                    biggestKegModel = kegModel;

                }

            }
            Console.WriteLine(biggestKegModel);
        }
    }
}