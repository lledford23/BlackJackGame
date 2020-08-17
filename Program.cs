using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackGame
{
    class BlackJackGame
    {
        static string[] playerCards = new string[11];

        static string playerChoice = "";

        static int playerTotal = 0;
        static int cardCount = 1;
        static int dealerTotal = 0;
        static Random cardRandom = new Random();
        static string playAgain = "Y";

        static void Main(string[] args)
        {

            while (playAgain.ToUpper() == "Y")
            {
                StartGame();

                StartGameLoop();

                Console.WriteLine("Deal? (Y)es or (N)o?");
                PlayAgain();

            }
        }


        static void StartGame()
        {
            dealerTotal = cardRandom.Next(15, 22);
            playerCards[0] = DealCard();
            playerCards[1] = DealCard();
            DisplayWelcomeMessage();

        }
        private static void DisplayWelcomeMessage()
        {
            Console.WriteLine($"Let's play Blackjack! You have two cards already : {0} and {1} ", playerCards[0], playerCards[1]);

            Console.WriteLine("Your hand total is {0}", playerTotal);

        }

        static void StartGameLoop()
        {
            do
            {
                Console.WriteLine("Would you like to (H)it or (S)tay?");
                playerChoice = Console.ReadLine().ToUpper();

            }
            while (!playerChoice.Equals("H") && !playerChoice.Equals("S"));

            if (playerChoice.Equals("H"))
            {
                Hit();
            }

            if (playerChoice.Equals("S"))
            {
                if (playerTotal > dealerTotal && playerTotal <= 21)
                {
                    Console.WriteLine("Hey look at that! You won! the dealer's total was {0}", dealerTotal);
                }
                else if (playerTotal < dealerTotal)
                {
                    Console.WriteLine("Awkward... you lost.. The dealer's total was {0}", dealerTotal);

                }
            }
        }

        static string DealCard()
        {
            int cards = cardRandom.Next(1, 14);
            string Card = GetCardValue(cards);
            return Card;
        }
        class Card
        {

            var deck = new List<string>();
            var suitList = new List<string>() { "Clubs", "Spades", "Diamonds", "Hearts" };
            var rankList = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "King", "Queen", "Jack" };


            for (var indexOfSuitList = 0; indexOfSuitList<suitList.Count(); indexOfSuitList++)
            {

                var suit = suitList[indexOfSuitList];

                for (var indexOfRankList = 0; indexOfRankList<rankList.Count(); indexOfRankList++)
                {

                    var rank = rankList[indexOfRankList];


            deck.Add($"{rank} of {suit}");

                }
    }

    var cardsInDeck = deck.Count;

    var randomNumberGenerator = new Random();

            for (var rightIndex = cardsInDeck - 1; rightIndex > 0; rightIndex--)
            {

                var leftIndex = randomNumberGenerator.Next(rightIndex);


    var leftCard = deck[rightIndex];


    var rightCard = deck[leftIndex];


    deck[rightIndex] = rightCard;


                deck[leftIndex] = leftCard;
            }
        }
}
        static string GetCardValue(int cards)
{
    string Card;

    switch (cards)
    {
        case 1:
            Card = "Two"; playerTotal += 2;
            break;
        case 2:
            Card = "Three"; playerTotal += 3;
            break;
        case 3:
            Card = "Four"; playerTotal += 4;
            break;
        case 4:
            Card = "Five"; playerTotal += 5;
            break;
        case 5:
            Card = "Six"; playerTotal += 6;
            break;
        case 6:
            Card = "Seven"; playerTotal += 7;
            break;
        case 7:
            Card = "Eight"; playerTotal += 8;
            break;
        case 8:
            Card = "Nine"; playerTotal += 9;
            break;
        case 9:
            Card = "Ten"; playerTotal += 10;
            break;
        case 10:
            Card = "Jack"; playerTotal += 10;
            break;
        case 11:
            Card = "Queen"; playerTotal += 10;
            break;
        case 12:
            Card = "King"; playerTotal += 10;
            break;
        case 13:
            Card = "Ace"; playerTotal += 11;
            break;
        default:
            Card = "2"; playerTotal += 2;
            break;

    }
    return Card;

}

static void Hit()
{
    cardCount += 1;
    playerCards[cardCount] = DealCard();
    Console.WriteLine("Your card is {0} and your total is {1}");

    if (playerTotal.Equals(21))
    {
        Console.WriteLine("BlackJack! You got {0}.", dealerTotal);

    }

    else if (playerTotal < dealerTotal || playerTotal <= 21)
    {
        Console.WriteLine("Awkward... you Busted. You got {0}.", dealerTotal);
    }
    else if (playerTotal < dealerTotal)
    {
        do
        {
            Console.WriteLine("Would you like to hit or stay? Type H for hit or S for stay!");
            playerChoice = Console.ReadLine().ToUpper();
        }

        while (!playerChoice.Equals("H") && !playerChoice.Equals("S"));
        if (playerChoice.ToUpper() == "H")
        {
            Hit();
        }
    }
}

static void PlayAgain()
{
    do
    {
        playAgain = Console.ReadLine().ToUpper();
    }
    while (!playAgain.Equals("Y") && !playAgain.Equals("N"));

    if (playAgain.Equals("Y"))
    {
        Console.WriteLine("Let's Deal! Press enter!");
        Console.ReadLine();
        Console.Clear();
        dealerTotal = 0;
        cardCount = 1;
        playerTotal = 0;
    }
    else if (playAgain.Equals("N"))
    {
        if (playAgain.Equals("N"))
            Console.WriteLine("Thanks for playing!");
    }

}
    }
}
