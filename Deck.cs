using System;
using System.Collections.Generic;

namespace hilo
{
    public class Deck
    {
        public List<Card> cards { get; set; }
        public static Random rng = new Random();
        public Deck()
        {
            cards = new List<Card>();
        }

        public void Add(Card card, int pos = 0)
        //adds a card to the deck at the given index, use -1 to add to the bottom (defaults to top of the deck)
        //optionally, a negative pos value will add the card to the bottom of the deck.
        {
            if (pos < 0)
            {
                Console.Write("inserting a new card");
                this.cards.Insert(this.cards.Count, card);
            }
            else
            {
                this.cards.Insert(pos, card);
            }
        }

        public Card draw()
        //draws a card from the top of the deck.
        //Returns the Card and removes it from the deck.
        //Analogous to pop()
        {
            Card card = this.cards[0];
            this.cards.RemoveAt(0);
            return card;
        }
        ///<summary>populates the Deck object with a number of Card objects, 13 in this case.
        public void Populate()
        {
            for (int i = 0; i < 13; i++)
            {
                this.Add(new Card(i+1));
            }
        }
        public void Shuffle()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                //destination index
                var dest = rng.Next(this.cards.Count);
                var temp = this.cards[dest];
                this.cards[dest] = this.cards[i];
                this.cards[i] = temp;
            }
        }

        public void PrintNames()
        {
            foreach (Card card in this.cards)
            {
                card.PrintName();
            }
        }

        public void PrintNums()
        {
            foreach (Card card in this.cards)
            {
                card.PrintNum();
            }
        }
    }
}
