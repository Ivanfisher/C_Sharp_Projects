using System;
using System.Collections.Generic;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join in a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            // Determining if player wants to play
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "yea")
            {
                // Creating an instance of Player
                Player player = new Player(playerName, bank);
                // Creating an instance of TwentyOneGame
                Game game = new TwentyOneGame();
                // Adding player to game
                game += player;
                player.isActivelyPlaying = true;
                // Execute code inside while loop as long as isActivelyPlaying is true and balance is greater than 0
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                if (player.Balance <= 0)
                {
                    Console.WriteLine("Sorry, you cannot play without money..");
                }
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }

    }
}
