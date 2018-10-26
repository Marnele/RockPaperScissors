using System;
namespace RockPaperScissorsGame
{
    public class Game
    {
        // member variables (HAS A)
        public int score;
        public Game roundWinner;
        public Player gameWinner;
        public int playerOneWins;
        public int playerTwoWins;
        public Player player1;
        public Player player2;
        public Gesture gesture;


        // constructor(RESPAWN)
        public Game Winner() //Upadates RoundWinner 
        {
            roundWinner = new Game();
            return roundWinner;
        }

        public void GameWinner() //Determines winner calculating best 3 Rounds 
        {
            if(playerOneWins > 3){
                gameWinner = player1;
            }
            else if (playerTwoWins > 3){
                gameWinner = player2;
            }
        }

        public void RunGame()
        {

        }
        // member methods (CAN DO)
        public void NumberofPlayers()
        {
            string NumberOfPlayers = Console.ReadLine();
            if (NumberOfPlayers == "1")

            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if (NumberOfPlayers == "2")

            {
                player1 = new Human();
                player2 =  new Human();
            }
        }

        public void DisplayWinner() //Campares and defines winner
        {
            if (player1 == player2)
            {
                roundWinner = Console.WriteLine("It's a tie!");
            }
            else if (player1 == "Rock" && player2 == "Scissors" || player1 == "Paper" && player2 == "Rock" || player1 == "Scissors" && player2 == "Paper" || player1 == "lizard" && player2 == "spock")
            {
                roundWinner = Console.WriteLine("Player 1 Wins!");
            }
            else
            {
                roundWinner = Console.WriteLine("Player 2 Wins!");
            }
        }

    }
}