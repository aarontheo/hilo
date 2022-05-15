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
        int score = 300;
        Deck deck = new Deck();
        Card currentCard;
        deck.Populate();
        char guess;
        bool success = false;
        Console.WriteLine($@"
Welcome to High/Low!
--------------------
    you start the game with {score} points.
    there are 13 cards, 
    and each turn you will draw a card and guess 
    whether the next card is higher or lower than 
    the current one.
    If you are correct, you gain 100 points.
    If you are wrong, your lose 75 points.
    If your points go below 0, you lose.
    Good luck!
");
        newround:
            //do the actions 13 times
            for (int i = 0; i < 13; i++)
            {
                deck.Shuffle();
                Console.WriteLine($"score: {score}");
                //take the first card from the deck and draw it from the deck into currentCard
                currentCard = deck.draw();
                Card nextCard = deck.cards[0];
                //display the current card
                Console.WriteLine($"Current card: {currentCard.name}\nValue: {currentCard.num}");
            //prompt user to input higher or lower as a guess
            prompt:
                Console.Write("Higher (h) or Lower (l)? ");
                guess = Console.ReadLine()[0];
                if (guess == 'h')
                {
                    if (nextCard.num > currentCard.num)
                    {
                        success = true;
                    }
                }
                else if (guess == 'l')
                {
                    if (nextCard.num < currentCard.num)
                    {
                        success = true;
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid input! try 'h' or 'l'.");
                    goto prompt;
                }
                if (success)
                {
                    Console.WriteLine("Correct! +100 points.");
                    score += 100;
                }
                else
                {
                    Console.WriteLine("Incorrect. -75 points.");
                    score -= 75;
                }
                Console.WriteLine($"Next card was {nextCard.name}.\n");
                if (score < 0)
                {
                    Console.WriteLine("You lose... :/ Better luck next time.");
                    break;
                }
                success = false;
                deck.Add(currentCard);
            }
            Console.WriteLine($"Your final score is {score} points.");
            if (score > 0)
            {
                Console.Write("Would you like to start another round? (y/n): ");
                prompt:
                guess = Console.ReadLine()[0];
                if (guess == 'y')
                {
                    goto newround;
                }
                else if (guess == 'n')
                {
                    
                }else{
                    Console.WriteLine("Please enter (y/n): ");
                }
            }
            //if the user has points left, prompt a new round
            //else, declare their winnings and thank them for playing
            Console.WriteLine("Thanks for playing!");
        }
    }
}
