namespace Sjd.Disgaea.Tests
{
    using Sjd.Disgaea.Runner.Models;
    using Xunit;

    public class OneBlockOneColour
    {
        [Fact]
        public void OneBlockBreaks() 
        {
            // Given a board with one colour and one block
            Board board = new Board(new Panel(Colour.Red, Colour.Clear));

            // When the block is broken
            board.Break(Colour.Clear);

            // Then no blocks remain
            Assert.Equal(0, board.PanelCount);
        }
    }
}
