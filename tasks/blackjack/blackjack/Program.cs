using blackjack;

CardDeck deck = new();

Console.WriteLine($"Number of cards is: {deck.DrawPile.Count}");
foreach (PlayingCards cards in deck.DrawPile) {
    Console.WriteLine(cards);

    if (cards.Value == CardValue.Ace && cards.Suit == CardSuits.Spades) {
        
    }
}