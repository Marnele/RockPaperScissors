using System;
namespace RPSLS
{
    public class Human
    {
        // member variables (HAS A)
        public Player playerOne;
        public Player playerTwo;
        public Game gameWinner;
        public string roundWinner;
       


            static void MainMenu() //Allows player input
            {
                Console.WriteLine("Type (Paper) for 'Paper'");
                Console.WriteLine("Type (Rock) for 'Rock'");
                Console.WriteLine("Type (Scissors) for 'Scissors'");
                Console.WriteLine("Type (Spock) for 'Spock'");
                Console.WriteLine("Type (Lizard) for 'Lizard'");

                string playerInput = Console.ReadLine();

                switch (playerInput)
                {
                    case "Paper":
                        Console.ReadLine();
                        break;

                    case "Rock":
                        Console.ReadLine();
                        break;

                    case "Scissors":
                        Console.ReadLine();
                        break;

                    case "Spock":
                        Console.ReadLine();
                        break;

                    case "Lizard":
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid entry. Try again");
                        break;
                }
               MainMenu();
            }
        }
    }
