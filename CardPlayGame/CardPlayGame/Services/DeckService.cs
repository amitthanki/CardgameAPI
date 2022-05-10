using CardPlayGame.Interfaces;
using CardPlayGame.Models;
using System.Linq;

namespace CardPlayGame.Services
{
    public class DeckService : ICard
    {
        private List<string> deck;
        public DeckService()
        {
            deck = new List<string>();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    deck.Add(new Card(value, suit).getAllCards());
                }
            }
        }
        public List<String> GetRandomCard()
        {

            var list = Shuffle(deck.ToList());
            return list.ToList();
        }

        public List<string> GetSortedResult(List<string> str)
        {
            try
            {
                List<string> newHand = new List<string>();
                SortedList<string, string> clubs = new SortedList<string, string>();
                SortedList<string, string> diamonds = new SortedList<string, string>();
                SortedList<string, string> spades = new SortedList<string, string>();
                SortedList<string, string> hearts = new SortedList<string, string>();
                //  while (str.Count() > 0)
                // {
                for (int i = 0; i < str.Count(); i++)
                {
                    string SuitName = str[i].Split()[2];
                    string SuitName1 = str[i].Split()[0];
                    switch (SuitName)
                    {
                        case "Diamonds":
                            diamonds.Add(getValueAsString1(SuitName1), str[i]);
                            break;
                        case "Spades":
                            spades.Add(getValueAsString1(SuitName1), str[i]);
                            break;
                        case "Clubs":
                            clubs.Add(getValueAsString1(SuitName1), str[i]);
                            break;
                        case "Hearts":
                            hearts.Add(getValueAsString1(SuitName1), str[i]);
                            break;
                    }
                }

                var finallistl = newHand.Concat(diamonds.Values).Concat(spades.Values).Concat(clubs.Values).Concat(hearts.Values);
                return finallistl.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string getValueAsString1(string value)
        {
            switch (value)
            {
                case "2":
                    return "1";
                    break;
                case "3":
                    return "2";
                    break;
                case "4":
                    return "3";
                    break;
                case "5":
                    return "4";
                    break;
                case "6":
                    return "5";
                    break;
                case "7":
                    return "6";
                    break;
                case "8":
                    return "7";
                    break;
                case "9":
                    return "8";
                    break;
                case "10":
                    return "9";
                    break;
                case "Ace":
                    return "Ace";
                    break;
                case "Jack":
                    return "Jack";
                    break;
                case "Queen":
                    return "Queen";
                    break;
                case "King":
                    return "King";
                    break;
            }
            return "";
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
    }
}
