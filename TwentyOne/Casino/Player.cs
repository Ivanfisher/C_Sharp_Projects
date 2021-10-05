using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        // Creating a constructor
        public Player(string name, int beginningBalance)
        {
            // Assigning Hand a list of cards, Balance the argument beginningBalance, and Name the argument name
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }

        private List<Card> _hand = new List<Card>();
        // Declaring properties for Player
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }

        // Method checks if amount player wants to bet is less than or equal to players total balance
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }    
            else
            {
                Balance -= amount;
                return true;
            }
        }

        // Overloading + operator
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        // Overloading - operator
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
