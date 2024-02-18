namespace OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();
            var numberOccurrences=new Dictionary<string, int>();
            for(int i=0; i<words.Length; i++)
            {
                string currentWord = words[i].ToLower();
                if (!numberOccurrences.ContainsKey(currentWord))
                {
                    numberOccurrences.Add(currentWord, 0);
                }
                numberOccurrences[currentWord]++;
            }
            foreach(KeyValuePair<string,int> kvp  in numberOccurrences) 
            
            {
                if (kvp.Value%2==1)
                {
                    Console.Write($"{kvp.Key} ");
                }
            }
        }
    }
}