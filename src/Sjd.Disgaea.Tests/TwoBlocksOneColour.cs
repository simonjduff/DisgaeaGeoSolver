namespace Sjd.Disgaea.Tests
{
    using Xunit;
    using Sjd.Disgaea.Runner.Models;
    public class TwoBlocksOneColour
    {
        [Fact]
        public void TwoBlocksOneColourNothingLeft()
        {
            // Given a board with two colours and one block
            Board board = new Board(
                new Panel(Colour.Red, Colour.Clear, Colour.Blue)
            );

            // When the block is broken
            board.Break(Colour.Clear);

            // Then no blocks remain and one panel
            Assert.Equal(0, board.PanelCount);
            Assert.Equal(0, board.BlockCount);
        }
    }
}