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
        public Suit suit { get; }
        public Rank rank { get; }
        public Boolean faceUp { get; set; }
        public string name { get; }
        public int num { get; }
        public Card(Rank rank, Suit suit = Suit.Spades, bool faceUp = false)
        {
            this.rank = rank;
            this.suit = suit;
            this.faceUp = faceUp;
            this.name = $"{this.rank} of {this.suit}";
            this.num = (int)this.rank;
        }

        public Card(int rank, Suit suit = Suit.Spades, bool faceUp = false)
        {
            this.rank = (Rank)rank;
            this.suit = suit;
            this.faceUp = faceUp;
        }

        public void PrintName()
        {
            Console.WriteLine(this.name);
        }
        public void PrintNum()
        {
            Console.WriteLine(this.num);
        }
    }
}