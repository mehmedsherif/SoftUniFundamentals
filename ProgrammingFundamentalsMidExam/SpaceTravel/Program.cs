namespace SpaceTravel

{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> travelRouteToTitan = Console.ReadLine()
                .Split("||")
                .ToList();

            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());
           

            for (int i = 0; i < travelRouteToTitan.Count; i++)
            {
                List<string> command = travelRouteToTitan[i].Split().ToList();
                string currentCommand = command[0];

                switch (currentCommand)
                {
                    case "Travel":
                        int distance = int.Parse(command[1]);
                        fuel -= distance;
                        if (fuel >= 0)
                        {
                            Console.WriteLine($"The spaceship travelled {distance} light-years.");
                        }
                        else
                        {
                            Console.WriteLine($"Mission failed.");
                            return;
                            
                        }
                        break;

                    case "Enemy":
                        int enemyArmor = int.Parse(command[1]);
                        if (ammunition >= enemyArmor)
                        {
                            ammunition -= enemyArmor;
                            Console.WriteLine($"An enemy with {enemyArmor} armour is defeated.");

                        }
                        else
                        {
                            fuel -= enemyArmor * 2;

                            if (fuel >= 0)
                            {
                                Console.WriteLine($"An enemy with {enemyArmor} armour is outmaneuvered.");
                            }
                            else
                            {
                                Console.WriteLine($"Mission failed.");
                                return;

                                
                            }
                        }
                        break;
                
                    case "Repair":
                        int addFuel = int.Parse(command[1]);

                        int addAmmunitions = addFuel * 2;

                        fuel += addFuel;
                        ammunition += addAmmunitions;

                        Console.WriteLine($"Ammunitions added: {addAmmunitions}.");
                        Console.WriteLine($"Fuel added: {addFuel}.");
                        break;

                    case "Titan":
                        Console.WriteLine("You have reached Titan, all passengers are safe.");
                        return;

                    
                }



            }
        }
    }
}