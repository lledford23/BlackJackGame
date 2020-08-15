using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJackGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to BlackJack! What's your name?");
            var playerOne = Console.ReadLine();

            Console.WriteLine($"Nice to meet you, {playerOne}!");

            var deck = new List<string>();
            var suitList = new List<string>() { "Clubs", "Spades", "Diamonds", "Hearts" };
            var rankList = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "King", "Queen", "Jack" };


            for (var indexOfSuitList = 0; indexOfSuitList < suitList.Count(); indexOfSuitList++)
            {

                var suit = suitList[indexOfSuitList];

                for (var indexOfRankList = 0; indexOfRankList < rankList.Count(); indexOfRankList++)
                {

                    var rank = rankList[indexOfRankList];


                    deck.Add($"{rank} of {suit}");

                }
            }
        }
    }
}
