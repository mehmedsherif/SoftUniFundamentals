using System.Collections.Generic;

namespace GreaterofTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type=Console.ReadLine();

            if (type =="string")
            {
                string a=Console.ReadLine();
                string b=Console.ReadLine();
                string result=GetMax(a,b);
            }
            else if (type =="int")
            {
                 int a = int.Parse(Console.ReadLine());
                 int b = int.Parse(Console.ReadLine());
                int result=GetMax(a,b);
                Console.WriteLine(result);
            }
            else
            {
                 char a=char.Parse(Console.ReadLine());
                 char b=char.Parse(Console.ReadLine());
                char result=GetMax(a,b);
                Console.WriteLine(result);
            }
        }
        static int GetMax(int a, int b) 
        {
            return a>b ? a : b;
        }
        static char GetMax(char a, char b) 
        {
            return a > b ? a : b;
        }
        static string GetMax(string a, string b) 
        {
            

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return a[i] > b[i] ? a : b;
                }
            }
           

            
            

        }
    }
}