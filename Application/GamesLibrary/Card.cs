namespace GamesLibrary
{
    public class Card
    {
        private string Face { get; } //Card's face 
        private string Suit { get; } // Card's Suit

        public Card(string face, string suit)
        {
            Face = face; //initial face of card
            Suit = suit; // initial suit of card
        }

        // return string representation of card
        public override string ToString() => $"{Face} of {Suit}";
    }
}