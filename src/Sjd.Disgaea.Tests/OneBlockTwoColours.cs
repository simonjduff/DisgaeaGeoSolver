namespace Sjd.Disgaea.Tests
{
    using Sjd.Disgaea.Runner.Models;
    using Xunit;
    public class OneBlockTwoColours
    {
        [Fact]
        public void OnePanelNoBlocksRemain()
        {
            // Given a board with two colours and one block
            Board board = new Board(
                new Panel(Colour.Red, Colour.Clear),
                new Panel(Colour.Blue)
            );

            // When the block is broken
            board.Break(Colour.Clear);

            // Then no blocks remain and one panel
            Assert.Equal(1, board.PanelCount);
            Assert.Equal(0, board.BlockCount);
        }
    }
}