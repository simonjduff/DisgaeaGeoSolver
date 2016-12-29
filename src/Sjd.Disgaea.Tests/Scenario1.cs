namespace Sjd.Disgaea.Tests
{
    using Xunit;
    using Sjd.Disgaea.Runner.Models;
    public class Scenario1
    {
        [Fact]
        public void BoardClears()
        {
            // Given Two colours, three blocks
            Board board = new Board(
                new Panel(Colour.Red, Colour.Clear, Colour.Blue),
                new Panel(Colour.Blue)
            );

            // When the block is broken
            board.Break(Colour.Blue);

            // Then no blocks remain and one panel
            Assert.Equal(0, board.PanelCount);
            Assert.Equal(0, board.BlockCount);
        }
    }
}