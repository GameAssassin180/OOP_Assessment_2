using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assessment_Two
{
    class Card
    {
        public string[] suite = { "Diamond", "Spade", "Heart", "Clubs" };

        public int Value
        {
            get;
            set;
        }

        public string pictureCards
        {
            get
            {
                string name = string.Empty;
                switch (Value)
                {
                    case (1):
                        name = "Ace";
                        break;
                    case (11):
                        name = "Jack";
                        break;
                    case (12):
                        name = "Queen";
                        break;
                    case (13):
                        name = "King";
                        break;
                    default:
                        name = Value.ToString();
                        break;
                }
                return name;
            }
        }

        public string cardName
        {
            get
            {
                return pictureCards + " of " + suite.ToString();
            }
        }

        public Card(int Value, string[] suite)
        {
            this.Value = Value;
            this.suite = suite;
        }
    }
}
