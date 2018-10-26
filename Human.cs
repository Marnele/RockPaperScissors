using System;
namespace RockPaperScissorsGame
{
    class Human : Player
    {
        // member variables (HAS A)
        public PlayerOneInput playerOneInput;


        // constructor(RESPAWN)
        public playerOneInput() //Receives player input and updates new value
        {
            this.playerOneInput = playerOneInput;
        }


        // member methods (CAN DO)
        public void HumanInput() //Allows player input
        {
            Console.WriteLine("Type (Paper) for 'Paper'");
            Console.WriteLine("Type (Rock) for 'Rock'");
            Console.WriteLine("Type (Scissors) for 'Scissors'");
            Console.WriteLine("Type (Spock) for 'Spock'");
            Console.WriteLine("Type (Lizard) for 'Lizard'");

            playerOneInput = Console.ReadLine();

            switch (playerOneInput)
            {
                case "Paper":
                    Console.ReadLine(playerOneInput);
                    break;

                case "Rock":
                    Console.ReadLine(playerOneInput);
                    break;

                case "Scissors":
                    Console.ReadLine(playerOneInput);
                    break;

                case "Spock":
                    Console.ReadLine(playerOneInput);
                    break;

                case "Lizard":
                    Console.ReadLine(playerOneInput);
                    break;
                default:
                    Console.WriteLine("Invalid entry. Try again");
                    break;
            }
            HumanInput();
        }
    }
}
