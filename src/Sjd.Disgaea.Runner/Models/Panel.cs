namespace Sjd.Disgaea.Runner.Models
{
    using System.Collections.Generic;
    using System.Linq;
    public class Panel
    {
        public Panel(Colour colour, params Colour[] blocks)
        {
            Colour = colour;
            _blocks = blocks.Select(q => new Block(q)).ToList();
        }

        private readonly List<Block> _blocks;
        public Colour Colour{get;}
        public IEnumerable<Colour> BlockColours => _blocks.Select(q => q.BlockColour);
        public IEnumerable<Block> Blocks => _blocks;
        public void AddBlocks(IEnumerable<Block> blocks)
        {
            _blocks.AddRange(blocks);
        }
        public void MoveBlocksToPanel(Panel panel)
        {
            if (panel != null)
            {
                panel.AddBlocks(Blocks);
            }

            _blocks.Clear();
        }

        public bool ContainsBlock(Colour colour)
        {
            return _blocks.Any(q => q.BlockColour == colour);
        }

        public bool Empty => !_blocks.Any();
    }
}