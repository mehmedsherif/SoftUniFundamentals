﻿namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
            .Split(' ')
            .ToList();

            string input;
            int movesCount = 0;
            bool won = false;

            while ((input = Console.ReadLine()) != "end")
            {
                int[] indexes = input
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                int firstIndex = indexes[0];
                int secondIndex = indexes[1];

                movesCount++;
                if (firstIndex == secondIndex ||
                    (firstIndex < 0 || firstIndex >= sequence.Count) ||
                    (secondIndex < 0 || secondIndex >= sequence.Count))
                {
                    int middleIndex = sequence.Count / 2;
                    string newSymbol = $"-{movesCount}a";
                    List<string> newElements = new List<string> { newSymbol, newSymbol };
                    sequence.InsertRange(middleIndex, newElements);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {

                    if (sequence[firstIndex] == sequence[secondIndex])
                    {
                        var value = sequence[firstIndex];
                        Console.WriteLine($"Congrats! You have found matching elements - {value}!");

                        if (firstIndex < secondIndex)
                        {
                            sequence.RemoveAt(firstIndex);
                            sequence.RemoveAt(secondIndex - 1);
                        }
                        else
                        {
                            sequence.RemoveAt(secondIndex);
                            sequence.RemoveAt(firstIndex - 1);
                        }
                    }

                    else if (sequence[firstIndex] != sequence[secondIndex])
                    {
                        Console.WriteLine("Try again!");
                    }


                    if (sequence.Count == 0)
                    {
                        won = true;
                        Console.WriteLine($"You have won in {movesCount} turns!");
                        break;
                    }
                }
            }


            if (!won)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine($"{string.Join(" ", sequence)}");

            }
        }

    }
}
