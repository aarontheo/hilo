# hilo
A C# terminal implementation of the card game 'High-Low'.
## Gameplay
The deck consists of 13 cards, with values ranging from 1-13, and is shuffled before each round.
A round is 13 draws.
In the first round, a card is dealt from the deck and revealed to the player.
The player predicts whether the next card dealt will be **higher** or **lower** than the current card.
If the prediction is correct, the player is awarded 100 points.
If the prediction is incorrect, the player is deducted 75 points.
The previous card is re-shuffled into the deck, and the process repeats.

The round ends either: After 13 iterations of drawing/predicting (win) **OR** if the player's score goes below 0. (Game Over)
At the end of a successful round, the player is prompted to either end the game, or continue with another round.
