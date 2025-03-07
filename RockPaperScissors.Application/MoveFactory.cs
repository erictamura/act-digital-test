using RockPaperScissors.Core;

namespace RockPaperScissors.Application
{
    public static class MoveFactory
    {
        public static IMove MakeMove(string move)
        {
            return move.ToLower() switch
            {
                "rock" => new Rock(),
                "paper" => new Paper(),
                "scissors" => new Scissors(),
                _ => throw new ArgumentException("Invalid move")
            };
        }
    }
}
