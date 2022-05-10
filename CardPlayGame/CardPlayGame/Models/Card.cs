
namespace CardPlayGame.Models
{
    public class Card
    {
        public int SPADES = 1;
        public int HEARTS = 3;
        public int DIAMONDS = 0;
        public int CLUBS = 2;
        public int JOKER = 4;

        public int ACE = 1;
        public int JACK = 11;
        public int QUEEN = 12;
        public int KING = 13;


        private int suit;


        private int value;

        /**
         * Creates a Joker, with 1 as the associated value.  (Note that
         * "new Card()" is equivalent to "new Card(1,Card.JOKER)".)
         */
        public Card()
        {
            suit = JOKER;
            value = 1;
        }
        public Card(int theValue, int theSuit)
        {
            if (theSuit != SPADES && theSuit != HEARTS && theSuit != DIAMONDS &&
                  theSuit != CLUBS && theSuit != JOKER)
                throw new ArgumentNullException("Illegal playing card suit");
            if (theSuit != JOKER && (theValue < 1 || theValue > 13))
                throw new ArgumentNullException("Illegal playing card value");
            value = theValue;
            suit = theSuit;
        }


        public int getSuit()
        {
            return suit;
        }


        public int getValue()
        {
            return value;
        }

        public string getSuitAsString()
        {
            switch (suit)
            {
                case 1: return "Spades";
                case 3: return "Hearts";
                case 0: return "Diamonds";
                case 2: return "Clubs";
                default: return "Joker";
            }
        }

        public string getValueAsString()
        {
            if (suit == JOKER)
                return "" + value;
            else
            {
                switch (value)
                {
                    case 1: return "Ace";
                    case 2: return "2";
                    case 3: return "3";
                    case 4: return "4";
                    case 5: return "5";
                    case 6: return "6";
                    case 7: return "7";
                    case 8: return "8";
                    case 9: return "9";
                    case 10: return "10";
                    case 11: return "Jack";
                    case 12: return "Queen";
                    default: return "King";
                }
            }
        }

        public string getAllCards()
        {
            if (suit == JOKER)
            {
                if (value == 1)
                    return "Joker";
                else
                    return "Joker #" + value;
            }
            else
                return getValueAsString() + " of " + getSuitAsString();
        }

        //public Task<IEnumerable<string>> GetRandomCard()
        //{
        //    for (int suit = 0; suit <= 3; suit++)
        //    {
        //        for (int value = 1; value <= 13; value++)
        //        {
        //            deck[cardCt] = new Card(value, suit);
        //            cardCt++;
        //        }
        //    }

        //}
    } // end class Card
}
