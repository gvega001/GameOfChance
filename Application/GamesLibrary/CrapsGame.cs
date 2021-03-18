using System;

namespace GamesLibrary
{
    public class CrapsGame
    {
        public Random RandomNumbers { get; set; }
        public Enum Dice { get; set; }
        public Enum GameStatus { get; set; }
        public int DiceRoll1 { get; set; }
        public int DiceRoll2  { get; set; }
        public int SumOfDice { get; set; }
        public CrapsGame()
        {

        }

        public CrapsGame(Random randomNumbers, Enum dice, Enum gameStatus, int diceRoll1, int diceRoll2)
        {
            RandomNumbers = randomNumbers;
            Dice = dice;
            GameStatus = gameStatus;
            DiceRoll1 = diceRoll1;
            DiceRoll2 = diceRoll2;
            SumOfDice = RollDice();
        }
     
        
        //make a random number generator for use in method RollDice
        private static Random _randomNumbers = new Random();

        //enum with constants that represent the game status
        public enum Status { Continue, Won, Lost}

        public enum DiceName
        {
            SnakeEyes = 2,
            Trey = 3, 
            Seven = 7,
            ElevenYo = 11,
            BoxCars = 12
        }

        public int GetSumOfDice()
        {
           return SumOfDice = RollDice();
        }
        public int RollDice()
        {
            //pick the random two die values
            DiceRoll1 = _randomNumbers.Next(1, 7); // first die roll
            DiceRoll2 = _randomNumbers.Next(1, 7); // second die roll

            //sum of the die values
            int sum = DiceRoll1 + DiceRoll2;

            //return the results of this roll
            return sum;
        }

    }
}