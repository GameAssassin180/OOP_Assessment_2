using System;

namespace OOP_Assessment_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int cardPull = 1; // creates a variable that counts how many cards are drawn. 
            Deck deck = new Deck();// creates a new deck.
            deck.deckFiller(); // fills the deck
            deck.shuffle(); // shuffles the deck 
            while(true)// starts a loop that will continue till the user is finished or the deck is empty.
            {
                Console.WriteLine("\nPress Enter to draw a card");
                string keypress = Console.ReadLine();
                if (keypress == "")
                {
                    deck.deal(); // deals one cards 
                    cardPull++; // adds one to the card counter 
                    if(cardPull == 52)
                    {
                        deck.isEmpty(); // stops the prgram.
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry please try again"); // catches the uesrs invalid input.
                    continue;
                }
            }
        }
    }
}
