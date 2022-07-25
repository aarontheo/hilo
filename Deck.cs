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
        //hello

        public void Add(Card card)
        //adds a card to the deck at the given index, use -1 to add to the bottom (defaults to top of the deck)
        //optionally, a negative pos value will add the card to the bottom of the deck.
        {
            this.cards.Add(card);
        }

        public Card draw()
        //draws a card from the top of the deck.
        //Returns the Card and removes it from the deck.
        //Analogous to pop()
        {
            Card card = this.cards[0];
            this.cards.Remove(card);
            return card;
        }
        ///<summary>populates the Deck object with a number of Card objects, 13 in this case.
        public void Populate()
        {
            for (int i = 1; i <= 13; i++)
            {
                this.Add(new Card((Rank)i));
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
