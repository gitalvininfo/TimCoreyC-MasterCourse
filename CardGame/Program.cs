namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            BlackJack deck = new BlackJack();

            var hand = deck.DealCards();

            foreach(var card in hand)
            {
                Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()}");
            }
            
            Console.ReadLine();

        }

    }

    public abstract class Deck
    {
        protected List<PlayingCard> Fulldeck = new List<PlayingCard>();
        protected List<PlayingCard> DrawPile = new List<PlayingCard>();
        protected List<PlayingCard> DiscardPile = new List<PlayingCard>();


        protected void CreateDeck()
        {
            Fulldeck.Clear();

            for(int suit = 0; suit < 4; suit++ )
            {
                for(int val = 0; val < 13; val++)
                {
                    Fulldeck.Add(new PlayingCard { Suit = (CardSuit)suit, Value = (CardValue)val });
                }
            }
        }

        public virtual void ShuffleDeck()
        {
            var rand = new Random();
            DrawPile = Fulldeck.OrderBy(x => rand.Next()).ToList();
        }

        public abstract List<PlayingCard> DealCards();

        protected virtual PlayingCard DrawOneCard()
        {
            PlayingCard output = DrawPile.Take(1).First();
            DrawPile.Remove(output);
            return output;
        }
    }

    public class PokerDeck : Deck
    {
        public PokerDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCard> DealCards()
        {
            List<PlayingCard> output = new List<PlayingCard>();
            for(int i = 0; i < 5; i++)
            {
                output.Add(DrawOneCard());
            }

            return output;
        }

        public List<PlayingCard> RequestCards(List<PlayingCard> cardsToDiscard)
        {
            List<PlayingCard> output = new List<PlayingCard>();


            foreach(var card in cardsToDiscard)
            {
                output.Add(DrawOneCard());
                DiscardPile.Add(card);
            }

            return output;
        }
    }

    public class BlackJack : Deck
    {
        public BlackJack()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCard> DealCards()
        {
            List<PlayingCard> output = new List<PlayingCard>();
            for (int i = 0; i < 2; i++)
            {
                output.Add(DrawOneCard());
            }

            return output;
        }

        public PlayingCard RequestCard()
        {
            return DrawOneCard();
        }
    }
}
