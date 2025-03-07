namespace RockPaperScissors.Core
{
    public interface IMove
    {
        string Name { get; }
        bool Beats(IMove other);
    }
}
