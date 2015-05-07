using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rps
{
    public class Game
    {
        private Dictionary<Tool, Tool> whoBeats;

        public Game()
        {
            whoBeats = new Dictionary<Tool, Tool>();
            whoBeats.Add(Tool.Scissors, Tool.Rock);
            whoBeats.Add(Tool.Paper, Tool.Scissors);
            whoBeats.Add(Tool.Rock, Tool.Paper);
            whoBeats.Add(Tool.Ac, Tool.Rock);
            whoBeats.Add(Tool.Paper, Tool.Ac);
        }

        public ResultType Challange(Tool playerOneTool, Tool playerTwoTool)
        {
            if (playerOneTool == playerTwoTool)
                return ResultType.Draw;


            if(SecondToolBeatsFirstTool(playerOneTool, playerTwoTool))
                return ResultType.PlayerTwo;
         
            if(SecondToolBeatsFirstTool(playerTwoTool, playerOneTool))
                return ResultType.PlayerOne;


            throw new NotImplementedException();
        }

        private bool SecondToolBeatsFirstTool(Tool playerTool1, Tool playerTool2)
        {
            var whoBeatsPlayerOne = whoBeats[playerTool1];

            return whoBeatsPlayerOne == playerTool2;
        }

        public Tool Tools { get; set; }
    }
}
