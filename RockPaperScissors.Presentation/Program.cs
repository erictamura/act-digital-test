using System;
using RockPaperScissors.Application;

namespace RockPaperScissors.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var random = new Random();
            var moves = new[] { "rock", "paper", "scissors" };

            while (true)
            {
                Console.WriteLine("Enter your move (rock, paper, scissors) or type 'exit' to quit the game:");
                var playerMove = Console.ReadLine().ToLower();

                if (playerMove == "exit")
                {
                    break;
                }

                if (Array.Exists(moves, move => move == playerMove))
                {
                    var computerMove = moves[random.Next(moves.Length)];
                    Console.WriteLine($"Computer chose: {computerMove}");
                    Console.WriteLine(Game.Play(playerMove, computerMove));
                }
                else
                {
                    Console.WriteLine("Invalid move. Valid optins: rock, paper, scissors.");
                }
            }
        }
    }
}
