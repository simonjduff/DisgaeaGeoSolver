namespace Sjd.Disgaea.Runner.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Panel
    {
        public Panel(Colour colour, params Colour[] blocks)
        {
            Colour = colour;
            _blocks = blocks.Select(q => new Block(q)).ToList();
        }

        public Action<string> Log = (message) => {};

        private readonly List<Block> _blocks;
        public Colour Colour{get;}
        public IEnumerable<Colour> BlockColours => _blocks.Select(q => q.BlockColour);
        public IEnumerable<Block> Blocks => _blocks;
        public void AddBlocks(IEnumerable<Block> blocks)
        {
            blocks.ToList().ForEach(q => q.QueuedToBreak = true);
            _blocks.AddRange(blocks);
        }
        public IEnumerable<Block> BlocksToBreak => _blocks.Where(q => q.QueuedToBreak);
        public void BreakBlock(Colour blockColour, Panel matchingPanel)
        {
            _blocks.Remove(_blocks.Single(q => q.BlockColour == blockColour));

            if (matchingPanel != null)
            {
                Log($"\t[{Colour}] -> [{matchingPanel.Colour}]: {string.Join(" ", Blocks.Select(q => q.BlockColour))}");
                matchingPanel.AddBlocks(Blocks);
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