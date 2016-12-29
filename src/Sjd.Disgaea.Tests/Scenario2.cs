namespace Sjd.Disgaea.Tests
{
    using Xunit;
    using Sjd.Disgaea.Runner.Models;
    public class Scenario2
    {
        [Fact]
        public void BoardClears()
        {
            // Given a board with two colours and one block
            Board board = new Board(
                new Panel(Colour.Red),
                new Panel(Colour.Green, Colour.Blue, Colour.Clear),
                new Panel(Colour.Yellow, Colour.Green, Colour.Red),
                new Panel(Colour.Blue)
            );

            // When the block is broken
            board.Break(Colour.Green);

            // Then no blocks remain and one panel
            Assert.Equal(0, board.PanelCount);
            Assert.Equal(0, board.BlockCount);
        }
    }
}