using System;

namespace OOP_Assessment_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int cardPull = 1;
            Deck deck = new Deck();
            deck.deckFiller();
            deck.shuffle();
            while(true)
            {
                Console.WriteLine("\nPress Enter to draw a card");
                string keypress = Console.ReadLine();
                if (keypress == "")
                {
                    deck.deal();
                    cardPull++;
                    if(cardPull == 52)
                    {
                        deck.isEmpty();
                    }
                }
                else
                {
                    Console.WriteLine("invalid entry please try again");
                    continue;
                }
            }
        }
    }
}
