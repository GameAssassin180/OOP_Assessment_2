using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Two
{
    class Deck
    {
        // below is a list of cards from the card class
        public List<Card> deckList = new List<Card>();
        public List<int> shuffledList = new List<int>();
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
            Console.WriteLine("The deck is empty, the program will close in 5 senconds.");
            System.Threading.Thread.Sleep(5000);
            System.Environment.Exit(0);
        }

        public void shuffle()
        {
            Random rnd = new Random();
            while(shuffledList.Count<52)
            {
                int randomNumber = rnd.Next(0, 52);
                if (shuffledList.Contains(randomNumber)==true)
                {
                    continue;
                }
                else if (shuffledList.Contains(randomNumber) == false)
                {
                    shuffledList.Add(randomNumber);
                }
            }
        }

        public void deal()
        {
            Card oneCard = deckList[shuffledList[0]];
            Console.WriteLine(oneCard.cardName);
            shuffledList.RemoveAt(0);
        }
    }
}
