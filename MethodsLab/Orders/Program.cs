
namespace Orders
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double totalPrice=TotalPrice(product, quantity);
            string formattedTotalPrice=totalPrice.ToString("f2");
            Console.WriteLine(formattedTotalPrice);

        }
        static double TotalPrice(string product, int quantity)
        {
            double coffeePrice = 1.50;
            double waterPrice = 1.00;
            double cokePrice = 1.40;
            double snacksPrice = 2.00;
            double totalPrice = 0.0;

            switch (product)
            {
                case "coffee":
                    totalPrice = coffeePrice * quantity;
                    break;
                case "water":
                    totalPrice = waterPrice * quantity;
                    break;
                case "coke":
                    totalPrice = cokePrice * quantity;
                    break;
                case "snacks":
                    totalPrice = snacksPrice * quantity;
                    break;
            }
            return Math.Round(totalPrice, 2);
        }





    }



}