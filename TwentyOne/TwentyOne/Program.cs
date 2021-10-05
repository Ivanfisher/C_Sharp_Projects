using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.WriteLine("{0} | {1} | {2} | {3}", exception.Id, exception.ExceptionType, exception.ExceptionMessage, exception.TimeStamp);
                }
                return;
            }


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
                    catch(FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");
                        UpdateDbWithException(ex);
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
        private static void UpdateDbWithException(Exception ex)
        {
            // The connection to the database
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            // The query string
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            //
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Creating sql query command
                SqlCommand command = new SqlCommand(queryString, connection);
                // Adding parameter data types
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);
                // Adding parameter values
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;
                // Opening connectin, executing command, and then closing connection
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            string queryString = @"SELECT Id, ExceptionType, ExceptionMessage, TimeStamp FROM Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}
