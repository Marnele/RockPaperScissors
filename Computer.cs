using System;
namespace RPSLS
{
    public class Computer
    {
        // member variables (HAS A)
        public void ComputerInput()

        {
            RandomNumber(0, 5);
        }

        static void RandomNumber(int min, int max)
        {
            Random random = new Random();
            Console.WriteLine(random.Next(min, max));
            Console.ReadLine();
        }
    }
}

