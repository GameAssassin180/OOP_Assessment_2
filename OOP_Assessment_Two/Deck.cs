using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Two
{
    class Deck
    {
        // below is a list of cards from the card class
        public List<Card> deckList = new List<Card>();
        // The below method will fill this list with 52 differnt cards.
        public void deckFiller()
        {
            // the loop will run 52 times.
            for (int i = 0; i < 52; i++)
            {
                Card.cardType card = (Card.cardType)(Math.Floor((decimal)i / 13)); // this line of code here takes the loop number and divides it by 13, the maths function keeps this number a decimal,
                // this number is then used to index the enum list in the cards class for the cards suite. 
                int val = i % 13 + 1; // sets the number of time 13 can fit into the loop number to a variable. 
                deckList.Add(new Card(val, card));
            }
        }
        public void isEmpty()
        {

        }

        public void shuffle()
        {

        }

        public void deal()
        {

        }
    }
}
