using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling the Deck() function, which creates a deck of 52 cards, and assigning it to variable deck
            Deck deck = new Deck();

            // Reassingning the var deck with the Shuffle() function. (shuffles a deck of cards)
            deck.Shuffle(3);

            // Writing out the entire deck of cards to the console
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.Read();
        }

    }
}
