namespace RockPaperScissors.Core
{
    public class Scissors : IMove
    {
        public string Name => "Scissors";

        public bool Beats(IMove other)
        {
            return other is Paper;
        }
    }
}
