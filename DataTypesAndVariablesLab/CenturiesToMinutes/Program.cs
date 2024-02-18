namespace CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            
            int yearsInCentury = 100;
            double daysInYear = 365.2422;
            int hoursInDay = 24;
            int minutesInHour = 60;

            
            int years = centuries * yearsInCentury;
            double days = years * daysInYear;
            double hours = days * hoursInDay;
            double minutes = hours * minutesInHour;

            
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
    }
}