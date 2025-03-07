namespace RockPaperScissors.Core
{
    public class Paper : IMove
    {
        public string Name => "Paper";

        public bool Beats(IMove other)
        {
            return other is Rock;
        }
    }
}
