namespace blackjack; 

public class CardDeck {

    public CardDeck() {
        DrawPile = new();
        for (int i = 0; i < 4; i++) {
            for (int j = 1; j < 14; j++) {
                DrawPile.Add(new ((CardValue) j, (CardSuits) i));
            }

        }

    }

    public List<PlayingCards> DrawPile { get; set; }
    public List<PlayingCards> DiscardPile { get; set; }
    public List<PlayingCards> CardsInHand { get; set; }
}