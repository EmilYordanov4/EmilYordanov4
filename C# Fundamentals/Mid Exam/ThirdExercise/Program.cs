using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allCards = Console.ReadLine().Split(":").ToList();
            List<string> finalDeck = new List<string>();

            string[] input = Console.ReadLine().Split(" ");
            while (input[0] != "Ready")
            {
                string command = input[0];

                if (command == "Add")
                {
                    AddingCards(allCards, finalDeck, input);
                }
                else if (command == "Insert")
                {
                    string cardName = input[1];
                    int index = int.Parse(input[2]);
                    //index > / >= ??
                    if (index < 0 || index >= finalDeck.Count)
                    {
                        Console.WriteLine($"Error!");
                        input = Console.ReadLine().Split(" ");
                        continue;
                    }
                    bool isCardHere = false;
                    for (int i = 0; i < allCards.Count; i++)
                    {
                        if (allCards[i] == cardName)
                        {
                            isCardHere = true;
                            break;
                        }
                    }
                    if (isCardHere == true)
                    {
                        finalDeck.Insert(index, cardName);
                    }
                    else
                    {
                        Console.WriteLine($"Error!");
                    }
                }
                else if (command == "Remove")
                {
                    RemovingCards(finalDeck, input);
                }
                else if (command == "Swap")
                {
                    SwappingCards(finalDeck, input);
                }
                else if (command == "Shuffle")
                {
                    ShuffleCards(finalDeck);
                }


                input = Console.ReadLine().Split(" ");
            }
            Console.WriteLine(string.Join(" ", finalDeck));

        }

        private static void ShuffleCards(List<string> finalDeck)
        {
            for (int i = 0; i < finalDeck.Count / 2; i++)
            {
                string firstCardName = finalDeck[i];
                string lastCardName = finalDeck[finalDeck.Count - 1 - i];

                finalDeck.RemoveAt(i);
                finalDeck.Insert(i, lastCardName);
                finalDeck.RemoveAt(finalDeck.Count - 1 - i);
                finalDeck.Insert(finalDeck.Count - i, firstCardName);
            }
        }

        private static void SwappingCards(List<string> finalDeck, string[] input)
        {
            string firstCardName = input[1];
            string secondCardName = input[2];

            int firstIndex = 0;
            int secondIndex = 0;

            for (int i = 0; i < finalDeck.Count; i++)
            {
                if (finalDeck[i] == firstCardName)
                {
                    firstIndex = i;
                }
                if (finalDeck[i] == secondCardName)
                {
                    secondIndex = i;
                }
            }
            finalDeck.Remove(firstCardName);
            finalDeck.Insert(firstIndex, secondCardName);
            finalDeck.Remove(secondCardName);
            finalDeck.Insert(secondIndex, firstCardName);
        }

        private static void RemovingCards(List<string> finalDeck, string[] input)
        {
            string cardName = input[1];
            bool isCardHere = false;
            for (int i = 0; i < finalDeck.Count; i++)
            {
                if (finalDeck[i] == cardName)
                {
                    isCardHere = true;
                    break;
                }
            }
            if (isCardHere == true)
            {
                finalDeck.Remove(cardName);
            }
            else
            {
                Console.WriteLine($"Card not found.");
            }
        }

        

        private static void AddingCards(List<string> allCards, List<string> finalDeck, string[] input)
        {
            string cardName = input[1];
            bool isCardHere = false;
            for (int i = 0; i < allCards.Count; i++)
            {
                if (allCards[i] == cardName)
                {
                    isCardHere = true;
                    break;
                }
            }
            if (isCardHere == true)
            {
                finalDeck.Add(cardName);
            }
            else
            {
                Console.WriteLine($"Card not found.");
            }
        }
    }
}
