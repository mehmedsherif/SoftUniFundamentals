namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople=int.Parse(Console.ReadLine());
            int capacityP=int.Parse(Console.ReadLine());

            int numCourses = numOfPeople / capacityP;
            int courses=(int)Math.Ceiling((double)numOfPeople/capacityP);
            Console.WriteLine(courses);
        }
    }
}