using System;

namespace hilo
{
    public enum Suit
    {
        Spades, Clubs, Hearts, Diamonds
    }
    public enum Rank
    {
        Joker, Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }
    public class Card
    {
        public Suit suit { get; set; }
        public Rank rank { get; set; }
        public Boolean faceUp { get; set; }
        public Card(Rank rank, Suit suit = Suit.Spades,bool faceUp = false)
        {
            this.rank = rank;
            this.suit = suit;
            this.faceUp = faceUp;
        }

        public Card(int rank, Suit suit = Suit.Spades,bool faceUp = false)
        {
            this.rank = (Rank)rank;
            this.suit = suit;
            this.faceUp = faceUp;
        }
    }
}