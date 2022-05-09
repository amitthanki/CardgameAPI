using CardPlayGame.Interfaces;

namespace CardPlayGame.Services
{
    public class Deck : ICard
    {
    
           
            private List<string> deck;

           
            private int cardsUsed;

       // private Random rng;


        public Deck()
            {
        deck = new List<string>();
            int cardCt = 0; // How many cards have been created so far.
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    deck.Add(new Card(value, suit).getAllCards());
                    cardCt++;
                }
            }
        }

           
            //public Deck(Boolean includeJokers)
            //{
            //    if (includeJokers)
            //        deck = new Card[54];
            //    else
            //        deck = new Card[52];
            //    int cardCt = 0; // How many cards have been created so far.
            //    for (int suit = 0; suit <= 3; suit++)
            //    {
            //        for (int value = 1; value <= 13; value++)
            //        {
            //            deck[cardCt] = new Card(value, suit).getAllCards().ToString();
            //            cardCt++;
            //        }
            //    }
            //    if (includeJokers)
            //    {
            //        deck[52] = new Card(1, 4);
            //        deck[53] = new Card(2, 4);
            //    }
            //    cardsUsed = 0;
            //}

        public List<String> GetRandomCard()
        {

            var list = Shuffle(deck.ToList());
            return list.ToList(); 
        }

        /**
         * Put all the used cards back into the deck (if any), and
         * shuffle the deck into a random order.
         */
        public List<string> Shuffle(List<string> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }
        //public void shuffle()
        //{
        //   // for (int i = deck.Count() - 1; i > 0; i--)
        //   // {
        //        Random rnd = new Random();
        //        int num = rnd.Next(deck.Count());
        //    return deck[num];
        //        //int rand = (int)(num * (i + 1));
        //        //string temp = deck[i];
        //        //deck[i] = deck[rand];
        //       // deck[rand] = temp;
        // //   }
        //  //  cardsUsed = 0;
        //}

        //public int cardsLeft()
        //{
        //    return deck.Length - cardsUsed;
        //}

        //public Card dealCard()
        //{
        //    if (cardsUsed == deck.Length)
        //        throw new ArgumentException("No cards are left in the deck.");
        //    cardsUsed++;
        //    return deck[cardsUsed - 1];
        //}
        //public Boolean hasJokers()
        //{
        //    return (deck.Length == 54);
        //}

    }
    }
