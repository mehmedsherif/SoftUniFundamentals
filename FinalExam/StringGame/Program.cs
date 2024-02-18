namespace StringGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] currCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (currCommand[0])
                {
                    case "Change":
                        char charachter = char.Parse(currCommand[1]);
                        char replacement = char.Parse(currCommand[2]);
                        if (text.Contains(charachter))
                        {
                            text = text.Replace(charachter, replacement);
                            Console.WriteLine(text);
                        }
                        else
                        {
                            Console.WriteLine(text);


                        }
                        break;
                    case "Includes":
                        string substring = currCommand[1];
                        if (text.Contains(substring))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "End":
                        string endSubstring = currCommand[1];
                        int startIndex = text.IndexOf(endSubstring);
                        int endIndex = startIndex + endSubstring.Length - 1;
                        if (text[endIndex] == text[text.Length - 1])
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Uppercase":
                        text = text.ToUpper();
                        Console.WriteLine(text);
                        break;
                    case "FindIndex":
                        char charToFind = char.Parse(currCommand[1]);
                        int index = text.IndexOf(charToFind);
                        Console.WriteLine(index);
                        break;
                    case "Cut":
                        int startIndexToCut = int.Parse(currCommand[1]);
                        if (startIndexToCut >= 0 && startIndexToCut < text.Length)
                        {
                            int count = int.Parse(currCommand[2]);
                            string cut = text.Substring(startIndexToCut, count);
                            text = cut;
                            Console.WriteLine(text);
                        }
                        break;

                }
            }
        }
    }
}
