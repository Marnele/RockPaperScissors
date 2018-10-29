using System;
namespace RPSLS
{
    public class Game
    {
        // member variables (HAS A)
        public Player playerOne;
        public Player playerTwo;
        public Game gameWinner;
        public string roundWinner;


        // constructor
        public void Player()
        {
            playerOne = new PlayerOne();
            playerTwo = new PlayerTwo();
            gameWinner = new GameWinner();
            roundWinner = new RoundWinner("Pending"); 
        }

        public void BeginGame()
        {
            Console.WriteLine("The winner of this round is: " + roundWinner + ".");
        }
    
    }
}
