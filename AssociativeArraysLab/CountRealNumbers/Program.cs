namespace CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            var numberOccurrences=new SortedDictionary<int, int>();
            for (int i=0; i < numbers.Length; i++) 
            {
                int currentNumber = numbers[i];
                if(!numberOccurrences.ContainsKey(currentNumber))
                {
                    numberOccurrences[currentNumber] = 1;
                }
                else
                {
                    numberOccurrences[currentNumber]++;
                }
            }
            foreach(KeyValuePair<int,int> keyValuePair in numberOccurrences)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
        }
    }
}