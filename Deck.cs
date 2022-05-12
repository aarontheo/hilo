using System;
using System.Collections.Generic;

namespace hilo
{
    public class Deck
    {
        public List<Card> cards;
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
    }
}
