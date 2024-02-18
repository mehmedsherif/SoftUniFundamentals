using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] cards = Console.ReadLine().Split(',');
        foreach (string card in cards)
        {
            cardDeck.Add(card.Trim());
        }

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split(',');
            string action = command[0].Trim();
            string cardName = command[1].Trim();

            if (action == "Add")
            {
                if (!cardDeck.Contains(cardName))
                {
                    cardDeck.Add(cardName);
                    Console.WriteLine("Card successfully added");
                }
                else
                {
                    Console.WriteLine("Card is already in the deck");
                }
            }
            else if (action == "Remove")
            {
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
                int index = int.Parse(cardName);
                if (index >= 0 && index < cardDeck.Count)
                {
                    cardDeck.RemoveAt(index);
                    Console.WriteLine("Card successfully removed");
                }
                else
                {
                    Console.WriteLine("Index out of range");
                }
            }
            else if (action == "Insert")
            {
                int index = int.Parse(command[1].Trim());
                if (index >= 0 && index <= cardDeck.Count)
                {
                    if (!cardDeck.Contains(cardName))
                    {
                        cardDeck.Insert(index, cardName);
                        Console.WriteLine("Card successfully added");
                    }
                    else
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                }
                else
                {
                    Console.WriteLine("Index out of range");
                }
            }
        }

        
        Console.WriteLine(string.Join(", ", cardDeck));
    }
}
