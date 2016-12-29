namespace ConsoleApplication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Sjd.Disgaea.Runner.Models;
    public class Program
    {
        public static void Main(string[] args)
        {
            Board board = new Board(
                new Panel(Colour.Red),
                new Panel(Colour.Green, Colour.Blue, Colour.Clear),
                new Panel(Colour.Yellow, Colour.Green, Colour.Red),
                new Panel(Colour.Blue)
            );

            List<string> messages = new List<string>();
            board.Log = (message) => messages.Add(message);

            // When the block is broken
            board.Break(Colour.Green);

            foreach (var message in messages)
            {
                Console.WriteLine(message);
            }

            Console.WriteLine($"Remaining: {string.Join(" ", board.PanelsRemaining.Select(q => q.Colour))}");
        }
    }
}
