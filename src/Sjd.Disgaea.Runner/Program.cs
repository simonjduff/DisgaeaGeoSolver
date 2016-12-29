namespace ConsoleApplication
{
    using System;
    using System.Linq;
    using Sjd.Disgaea.Runner.Models;
    public class Program
    {
        public static void Main(string[] args)
        {
            Board board = new Board(
                new Panel(Colour.Red, Colour.Clear, Colour.Blue),
                new Panel(Colour.Blue)
            );

            // When the block is broken
            board.Break(Colour.Blue);

            Console.WriteLine($"Remaining: {string.Join(" ", board.PanelsRemaining.Select(q => q.Colour))}");
        }
    }
}
