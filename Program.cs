using System;


/*
The player starts the game with 300 points.
Individual cards are represented as a number from 1 to 13.
The current card is displayed.
The player guesses if the next one will be higher or lower.
The the next card is displayed.
The player earns 100 points if they guessed correctly.
The player loses 75 points if they guessed incorrectly.
If a player reaches 0 points the game is over.
If a player has more than 0 points they decide if they want to keep playing.
If a player decides not to play again the game is over.
*/
namespace hilo
{
    class Program
    {
        static void Main(string[] args)
        {
            //goto this point to start a new game
            newgame:
            int score = 300;
            Deck deck = new Deck();
            Card currentCard;
            //Deck discard = new Deck();
            deck.Populate();
            deck.Shuffle();
            deck.PrintNums();
            //Print an introduction for the player on the first run
            currentCard = deck.draw();
            Console.WriteLine(currentCard.name);
            //goto this point to start a new round
            newround:
            for (int i = 0; i<13; i++)
            {
                //take the first card from the deck and draw it from the deck into currentCard
                currentCard = deck.draw();
                //display the current card
                Console.WriteLine($"Current card: {currentCard.name}\nValue: {currentCard.num}");
            }
            //if the user has points left, prompt a new round
            //else, declare their winnings and thank them for playing
        }
    }
}
