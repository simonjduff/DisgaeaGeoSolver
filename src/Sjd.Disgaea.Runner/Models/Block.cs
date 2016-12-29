namespace Sjd.Disgaea.Runner.Models
{
    public class Block
    {
        public Block(Colour blockColour)
        {
            BlockColour = blockColour;
        }

        public Colour BlockColour{get;}
        public bool QueuedToBreak{get; set;}
    }
}