using System;
namespace RPSLS
{
    public class Player:Game
    {
        // member variables (HAS A)
        public string roundWinner;
        public int Numbers;

        // constructor
        public Player()
        {
            roundWinner = "Pending";
        }

        // member methods (CAN DO)
        static void MainMenu() //Begins the game when player selects an option
        {
            Console.WriteLine("Play Rock, Paper, Scissors, Lizard Spock");
            Console.ReadLine();

            Console.WriteLine("Type (1) to start a 1-Player game.");
            Console.WriteLine("Type (2) to start a 2-Player game.");
            int Numbers = Convert.ToInt32(Console.ReadLine());

            if (Numbers == 1)
            {
                Console.WriteLine("Human vs. Computer");
                Console.ReadLine();
            }
            else if (Numbers == 2)
            {
                Console.WriteLine("Human vs. Human");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Whoops! Try again!");
            }

            }
        }

    }

