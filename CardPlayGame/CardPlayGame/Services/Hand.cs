using System.Collections.Generic;

namespace CardPlayGame.Services
{
    public class Hand
    {

        private List<Card> hand;   // The cards in the hand.

        /**
         * Create a hand that is initially empty.
         */
        public Hand()
        {
            hand = new List<Card>();
        }

        /**
         * Remove all cards from the hand, leaving it empty.
         */
        public void clear()
        {
            hand.Clear();
        }

        /**
         * Add a card to the hand.  It is added at the end of the current hand.
         * @param c the non-null card to be added.
         * @throws NullPointerException if the parameter c is null.
         */
        public void addCard(Card c)
        {
            if (c == null)
                throw new ArgumentNullException("Can't add a null card to a hand.");
            hand.Add(c);
        }
        public void removeCard(Card c)
        {
            hand.Remove(c);
        }

        
        public void removeCard(int position)
        {
            if (position < 0 || position >= hand.Count())
                throw new ArgumentNullException("Position does not exist in hand: "
                        + position);
            hand.RemoveAt(position);
        }

      
        public int getCardCount()
        {
            return hand.Count();
        }

       
        public Card getCard(int position)
        {
            if (position < 0 || position >= hand.Count())
                throw new ArgumentNullException("Position does not exist in hand: "
                        + position);
            return hand[position];
        }

       
        public void sortBySuit()
        {
            List<Card> newHand = new List<Card>();
            while (hand.Count() > 0)
            {
                int pos = 0;  // Position of minimal card.
                Card c = hand[0];  // Minimal card.
                for (int i = 1; i < hand.Count(); i++)
                {
                    Card c1 = hand[i];
                    if (c1.getSuit() < c.getSuit() ||
                            (c1.getSuit() == c.getSuit() && c1.getValue() < c.getValue()))
                    {
                        pos = i;
                        c = c1;
                    }
                }
                hand.RemoveAt(pos);
                newHand.Add(c);
            }
            hand = newHand;
        }
        public void sortByValue()
        {
            List<Card> newHand = new List<Card>();
            while (hand.Count() > 0)
            {
                int pos = 0;  // Position of minimal card.
                Card c = hand[0];  // Minimal card.
                for (int i = 1; i < hand.Count(); i++)
                {
                    Card c1 = hand[i];
                    if (c1.getValue() < c.getValue() ||
                            (c1.getValue() == c.getValue() && c1.getSuit() < c.getSuit()))
                    {
                        pos = i;
                        c = c1;
                    }
                }
                hand.RemoveAt(pos);
                newHand.Add(c);
            }
            hand = newHand;
        }

    }
}
