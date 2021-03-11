using System;
using System.Security.Cryptography.X509Certificates;

namespace GamesLibrary
{
    public class DeckOfCards
    {
        //create one Random object to share among deckOfCards objects
        private static Random randomNumbers = new Random();

        private const int NumberOfCards = 52;
        private Card[] deck = new Card[NumberOfCards];
        private int currentCard = 0;

        //constructor fills deck of Cards
        public DeckOfCards()
        {
            string[] faces =
            {
                "Ace", "Deuce", "Three", "Four", "Five", "Six",
                "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"

            };
            string[] suits = {"Hears", "Diamonds", "Clubs", "Spades"};

            //populate deck with Card Objects
            for (int count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }

           
        }
        //shuffle deck of cars with one-pass algorithm
        public void Shuffle()
        {
            //after shuffling, dealing should start at deck[0- again
            currentCard = 0;
            
            //for each Card, pick another random Card and swap them
            for (var first = 0; first < deck.Length; first++)
            {
                //select random number between 0 and 51
                var second = randomNumbers.Next(NumberOfCards);

                //Swap current Card with randomly selected card
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }
        // deal one card
        public Card DealCard()
        {
            // determine whether Cards remain to be dealt
            if (currentCard < deck.Length)
            {
                return deck[currentCard]; // return current Card in array
            }
            else
            {
                return null; // indicate that all Cards were dealt
            }
        }
    }
}