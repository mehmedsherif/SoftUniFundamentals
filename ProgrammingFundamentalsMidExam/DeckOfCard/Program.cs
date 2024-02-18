using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> cardDeck = Console.ReadLine()
                .Split(", ")
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(", ");
                string action = command[0];

                if (action == "Add")
                {
                    string cardName = command[1];
                    if (cardDeck.Contains(cardName))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        cardDeck.Add(cardName);
                        Console.WriteLine("Card successfully added");
                    }
                }
                else if (action == "Remove")
                {
                    string cardName = command[1];
                    if (cardDeck.Contains(cardName))
                    {
                        cardDeck.Remove(cardName);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (action == "Remove At")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index >= cardDeck.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        cardDeck.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string cardName = command[2];
                    if (index < 0 || index > cardDeck.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else if (cardDeck.Contains(cardName))
                    {
                        Console.WriteLine("Card is already added");
                    }
                    else
                    {
                        cardDeck.Insert(index, cardName);
                        Console.WriteLine("Card successfully added");
                    }
                }
            }

            Console.WriteLine(string.Join(", ", cardDeck));
        }
    }
}
