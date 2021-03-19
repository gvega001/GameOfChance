using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using GamesLibrary;

namespace aspnet_core_dotnet_core.Pages
{
    public class crapsModel : PageModel
    {
        private readonly ILogger<crapsModel> _logger;
        public crapsModel(ILogger<crapsModel> logger)
        {
            _logger = logger;
        }

        private CrapsGame CrapGames = new CrapsGame { DiceRoll1 = 0, DiceRoll2 = 0, GameStatus = CrapsGame.Status.Continue };
        private int  MyPoint { get; set; }
        private int SumOfDice { get; set; }
        public CrapsGame.Status GameStatus { get; set; }
        public CrapsGame.DiceName DiceNames { get; set; }
        public void OnGet()
        {
           
            MyPoint = 0; // point if no win or loss on first roll
            //to determine the dice names

            
            if (SumOfDice ==0)
            {
                Console.WriteLine("Still first roll");
            }

            //determine game status and point based on first roll
            switch ((CrapsGame.DiceName)SumOfDice)
            {
                case CrapsGame.DiceName.Seven: //win with 7 on first roll
                case CrapsGame.DiceName.ElevenYo: //win with 11 on first roll
                    GameStatus = CrapsGame.Status.Won;
                    break;
                case CrapsGame.DiceName.SnakeEyes: //Lose with 2 on the first roll
                case CrapsGame.DiceName.Trey: //Lose with 3 on the first roll
                case CrapsGame.DiceName.BoxCars: //Lose with 12 on the firs roll
                    GameStatus = CrapsGame.Status.Lost;
                    break;
                default:// did not win or lose, so remember point
                    GameStatus = CrapsGame.Status.Continue;  // game not Won or Lost
                    MyPoint = SumOfDice;
                    Console.WriteLine(MyPoint);
                    break;
            }
            // while the game is not complete
            while (GameStatus == CrapsGame.Status.Continue)
            {
                Console.WriteLine("Your number is:" + MyPoint);

                //Every roll after needs an event
                SumOfDice = CrapGames.RollDice();

                //determine game stat
                if(SumOfDice == MyPoint)
                {
                    GameStatus = CrapsGame.Status.Won;
                }
                else if (SumOfDice == (int)CrapsGame.DiceName.Seven)
                {
                    GameStatus = CrapsGame.Status.Lost;
                }

                // display won or lost message
                if (GameStatus == CrapsGame.Status.Won)
                {
                    Console.WriteLine("Player Wins");
                }
                else
                {
                    Console.WriteLine("Player Loses");
                }
            }
        }
    }
}
