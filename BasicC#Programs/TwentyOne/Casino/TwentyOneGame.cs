using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        // Method plays 21 game
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();

            foreach (Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
                }
                if (bet < 0) throw new FraudException();
                // Bet(bet) method checks if player's balance is large enough to bet that amount
                bool successfullyBet = player.Bet(bet);
                // Return to main method if player tries to bet more than player has
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                // Dealing each player a card
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    // When player has two cards, check to see if player has blackjack
                    if (i == 1)
                    {
                        // CheckForBlackJack is a method in TwentyOneRules that checks for blackjack
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            // PlayAgain asks player if player wants to play another round
                            TwentyOneGame.PlayAgain(player);
                            return;
                        }
                    }
                }
                Console.WriteLine("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        foreach (Player player in Players)
                        {
                            TwentyOneGame.PlayAgain(player);
                            return;
                        }
                    }
                }
            }
            foreach (Player player in Players)
            {
                // Do this loop as long as player is not staying
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    // Method isBusted checks if player's hand value has exceeded 21
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} busted! You lose your bet of {1}.", player.Name, Bets[player]);
                        TwentyOneGame.PlayAgain(player);
                        return;
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            // ShouldDealerStay is a method that checks if dealer should stay or hit (stay if hand value is greater than 16 and less than 22, hit if value is 16 or less)
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            // Keep giving dealer cards until dealer either busts or stays
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                foreach (Player player in Players)
                {
                    TwentyOneGame.PlayAgain(player);
                    return;
                }
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                TwentyOneGame.PlayAgain(player);
                return;
            }
        }


        public override void ListPlayers()
        {
            Console.WriteLine("21 players: ");
            base.ListPlayers();
        }


        // Method checks if player wants to play again
        public static void PlayAgain(Player player)
        {
            Console.WriteLine("Your balance is {0}. \nDo you want to play again?", player.Balance);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "yea")
            {
                player.isActivelyPlaying = true;
                return;
            }
            else
            {
                player.isActivelyPlaying = false;
                return;
            }
        }

        public void WalkAway(Player player)
        {

        }
    }
}
