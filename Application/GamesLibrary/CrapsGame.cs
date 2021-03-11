using System;

namespace GamesLibrary
{
    public class CrapsGame
    {
        //make a random number generator for use in method RollDice
        private static Random _randomNumbers = new Random();

        //enum with constants that represent the game status
        private enum Status { Continue, Won, Lost}

        private enum DiceName
        {
            SnakeEyes = 2,
            Trey = 3, 
            Seven = 7,
            ElevenYo = 11,
            BoxCars = 12
        }

        static int RollDice()
        {
            //pick the random two die values
            int die1 = _randomNumbers.Next(1, 7); // first die roll
            int die2 = _randomNumbers.Next(1, 7); // second die roll

            //sum of the die values
            int sum = die1 + die2;

            //return the results of this roll
            return 0;
        }

    }
}