using System;
namespace RockPaperScissorsGame
{
    class Gesture
    {
        // member variables (HAS A)
        public Gesture gesture;

       
        // constructor(RESPAWN)
        public Gesture()
        {
            gesture = new Gesture;
        }

        // member methods (CAN DO)
        public string gesture()
       {
            string[] arr = new string[];
            arr[0] = "paper";
            arr[1] = "rock";
            arr[2] = "scissors";
            arr[3] = "spock";
            arr[4] = "lizard";
        }
}
}
}
