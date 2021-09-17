using System;
using System.Collections.Generic;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join in a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            // Determining if player wants to play
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "yea")
            {
                // Creating an instance of Player
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\ivanf\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                // Creating an instance of TwentyOneGame
                Game game = new TwentyOneGame();
                // Adding player to game
                game += player;
                player.isActivelyPlaying = true;
                // Execute code inside while loop as long as isActivelyPlaying is true and balance is greater than 0
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch(FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out!");
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                if (player.isActivelyPlaying && player.Balance <= 0)
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
