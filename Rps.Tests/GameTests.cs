using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace Rps.Tests
{
    public class GameTests
    {
        public void RockBeatsScissors()
        {
			Tool playerOneTool = Tool.Rock;
			Tool playerTwoTool = Tool.Scissors;

            PlayerOneShouldWin(playerOneTool, playerTwoTool);
        }

        public void PaperBeatsRock()
        {
            Tool playerOneTool = Tool.Paper;
            Tool playerTwoTool = Tool.Rock;

            PlayerOneShouldWin(playerOneTool, playerTwoTool);
        }

        public void ScissorsBeatsPaper()
        {
            Tool playerOneTool = Tool.Scissors;
            Tool playerTwoTool = Tool.Paper;

            PlayerOneShouldWin(playerOneTool, playerTwoTool);
        }

        public void AcBeatsPaper()
        {
            Tool playerOneTool = Tool.Ac;
            Tool playerTwoTool = Tool.Paper;

            PlayerOneShouldWin(playerOneTool, playerTwoTool);
        }


        private void PlayerOneShouldWin(Tool playerOneTool, Tool playerTwoTool)
        {   
           Game game = new Game();
           ResultType winnerPlayer = game.Challange(playerOneTool, playerTwoTool);
           winnerPlayer.ShouldBe(ResultType.PlayerOne);
        }

        public void ScissorsIsBeatenByRock()
        {
            Tool playerOneTool = Tool.Scissors;
            Tool playerTwoTool = Tool.Rock;

            PlayerTwoShouldWin(playerOneTool, playerTwoTool);
        }

        public void AcIsBeatenByRock()
        {
            Tool playerOneTool = Tool.Ac;
            Tool playerTwoTool = Tool.Rock;
            PlayerTwoShouldWin(playerOneTool, playerTwoTool);
        }

        public void RockIsBeatenByPaper()
        {
            Tool playerOneTool = Tool.Rock;
            Tool playerTwoTool = Tool.Paper;

            PlayerTwoShouldWin(playerOneTool, playerTwoTool);
        }

        public void PaperIsBeatenByScissors()
        {
            Tool playerOneTool = Tool.Paper;
            Tool playerTwoTool = Tool.Scissors;

            PlayerTwoShouldWin(playerOneTool, playerTwoTool);
        }

         void PlayerTwoShouldWin(Tool playerOneTool, Tool playerTwoTool)
        {
            Game game = new Game();

            ResultType winnerPlayer = game.Challange(playerOneTool, playerTwoTool);

            winnerPlayer.ShouldBe(ResultType.PlayerTwo);
        }

         public void AreSame()
         {
             Tool sameTool = Tool.Paper;

             Game game = new Game();
             ResultType result = game.Challange(sameTool, sameTool);

             result.ShouldBe(ResultType.Draw);
         }
		
    }
}
