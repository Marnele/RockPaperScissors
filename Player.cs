using System;
namespace RockPaperScissorsGame
{
    class Player
    {
            // member variables(HAS A)
            public Player1 player1;
            public Player2 player2;
            public Winner winner;

            // constructor(RESPAWN)

      



            // member methods (CAN DO)

            public void MainMenu() //Begins the game when player selects an option
            {
                Console.WriteLine("Type (1) to start a 1-Player game.");
                Console.WriteLine("Type (2) to start a 2-Player game.");

                string NumberOfPlayers = Console.ReadLine();

                switch (NumberOfPlayers)
                {
                    case "1":
                        Human.BeginGame();
                        break;
                }

            }

            public Player() //Passes info to Game.cs about players
            {
                public void gamePlayers()
                {
                    if (NumberOfPlayers == "1")

                    {
                        player1 = Human();
                        player2 = Computer();
                    }
                    else if (NumberOfPlayers == "2")

                    {
                        player1 = Human();
                        player2 = Human();
                    }
                }

            public void DisplayWinner() //Campares and defines winner
            {
                if (player1 == player2)
                {
                   winner = Console.WriteLine("It's a tie!");
                }
                else if (player1 == "Rock" && player2 == "Scissors" || player1 == "Paper" && player2 == "Rock" || player1 == "Scissors" && player2 == "Paper" || player1 == "lizard" && player2 == "spock")
                {
                    winner = Console.WriteLine("Player 1 Wins!");
                }
                else
                {
                    winner = Console.WriteLine("Player 2 Wins!");
                }
            }


        }
    }
}