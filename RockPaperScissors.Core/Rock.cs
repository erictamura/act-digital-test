namespace RockPaperScissors.Core
{
    public class Rock : IMove
    {
        public string Name => "Rock";

        public bool Beats(IMove other)
        {
            return other is Scissors;
        }
    }
}
