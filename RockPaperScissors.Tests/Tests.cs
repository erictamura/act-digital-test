using Xunit;
using RockPaperScissors.Application;

namespace RockPaperScissors.Tests
{
    public class Tests
    {
        private Game _game;

        public Tests()
        {
            _game = new Game();
        }

        [Fact]
        public void RockBeatsScissors()
        {
            Assert.Equal("Player wins!", Game.Play("rock", "scissors"));
        }

        [Fact]
        public void ScissorsBeatsPaper()
        {
            Assert.Equal("Player wins!", Game.Play("scissors", "paper"));
        }

        [Fact]
        public void PaperBeatsRock()
        {
            Assert.Equal("Player wins!", Game.Play("paper", "rock"));
        }

        [Fact]
        public void SameMoveResultsInTie()
        {
            Assert.Equal("It's a tie!", Game.Play("rock", "rock"));
            Assert.Equal("It's a tie!", Game.Play("paper", "paper"));
            Assert.Equal("It's a tie!", Game.Play("scissors", "scissors"));
        }
    }
}
