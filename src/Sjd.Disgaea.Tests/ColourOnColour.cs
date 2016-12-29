namespace Sjd.Disgaea.Tests
{
    using Xunit;
    using Sjd.Disgaea.Runner.Models;
    public class ColourOnColour
    {
        [Fact]
        public void Resolves()
        {
            // Given a board with one colour and one block
            Board board = new Board(new Panel(Colour.Red, Colour.Red));

            // When the block is broken
            board.Break(Colour.Red);

            // Then no blocks remain
            Assert.Equal(0, board.PanelCount);
            Assert.Equal(0, board.BlockCount);
        }
    }
}