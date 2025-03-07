using RockPaperScissors.Core;

namespace RockPaperScissors.Application
{
    public class Game
    {
        public static string Play(string playerMove, string computerMove)
        {
            IMove player = MoveFactory.MakeMove(playerMove);
            IMove computer = MoveFactory.MakeMove(computerMove);

            if (player.Beats(computer))
            {
                return "The player wins!";
            }
            else if (computer.Beats(player))
            {
                return "The computer wins!";
            }
            else
            {
                return "Tie!";
            }
        }
    }
}
