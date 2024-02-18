namespace PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney=double.Parse(Console.ReadLine());
            int countOfStudents=int.Parse(Console.ReadLine());
            double priceOfLightsabers=double.Parse(Console.ReadLine());
            double priceOfRobes=double.Parse(Console.ReadLine());
            double priceOfBelts=double.Parse(Console.ReadLine());

            double priceForAllLightsabers = Math.Ceiling(countOfStudents*1.1) * priceOfLightsabers;
            double priceForAllRobes = countOfStudents * priceOfRobes;

            int freeBelts = countOfStudents / 6;

            double priceForAllBelts = (countOfStudents-freeBelts) * priceOfBelts;

            double finalPrice = priceForAllLightsabers + priceForAllRobes + priceForAllBelts;

            if(finalPrice<=amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {finalPrice:F2}lv.");
            }
            else
            {
                double neededMoney = finalPrice - amountOfMoney;
                Console.WriteLine($"John will need {neededMoney:F2}lv more.");
            }
        }
    }
}