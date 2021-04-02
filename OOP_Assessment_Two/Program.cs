using System;

namespace OOP_Assessment_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.deckFiller();
            Console.WriteLine(deck.deckList[1]);
        }
    }
}
