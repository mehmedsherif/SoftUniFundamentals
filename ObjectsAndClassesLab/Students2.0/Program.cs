namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = default;
            List<Student> students = new List<Student>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentTokens = input.Split();
                string firstName = studentTokens[0];
                string lastName = studentTokens[1];
                int age = int.Parse(studentTokens[2]);
                string homeTown = studentTokens[3];

                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.HomeTown = homeTown;
                student.Age = age;

                int index = ValidateStudent(firstName, lastName, students);
               if (index!=-1)
                {
                    students[index].Age = age;
                    students[index].HomeTown = homeTown;
                    continue;
                }

                students.Add(student);
            }
            string cityFilter = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == cityFilter)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static int ValidateStudent(string firstName, string lastName, List<Student> students)
        {
            for(int i=0;i<students.Count;i++)
            {
                if (students[i].FirstName==firstName && students[i].LastName==lastName)
                {
                    return i;
                }
            }
            return -1;
        }
    }
    public class Student
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}