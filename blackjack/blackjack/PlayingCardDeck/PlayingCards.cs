namespace blackjack;



public enum CardSuits {
    Clubs,
    Diamonds,
    Hearts,
    Spades
}
public class PlayingCards {
    public PlayingCards(CardValue value, CardSuits suit) {
        Value = value;
        Suit = suit;
    }

    public CardSuits Suit { get; private set; }
    public CardValue Value { get; private set; }

    public override string ToString() {
        return $"{Value} of {Suit}";
    }
}