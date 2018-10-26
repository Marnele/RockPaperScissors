using System;
namespace RockPaperScissorsGame
{
    class Computer : Player
    {
        // member variables (HAS A)
        public Computer computerInput;

        // constructor(RESPAWN)
        public void randomPick()
        {
            computerInput = new computerInput;
        }

        // member methods (CAN DO)
        public Array ComputerGesture
        {
            srand(time(NULL)); //initialize the random seed

            const char gestureArray[5] = { '1', '2', '3', '4','5' };
            int RandIndex = rand() % 6; //generates a random number between 0 and 5
            ComputerInput = Console.WriteLine(string)
    }

  }