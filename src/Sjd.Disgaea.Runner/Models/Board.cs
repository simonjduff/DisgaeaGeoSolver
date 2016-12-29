namespace Sjd.Disgaea.Runner.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Board
    {
        private List<Panel> _panels;

        public Board(params Panel[] panels)
        {
            _panels =  panels.ToList();
        }

        public void Break(Colour colour)
        {
            var breakingPanel = _panels.Single(q => q.ContainsBlock(colour));
            var matchingPanel = _panels.SingleOrDefault(q => q.Colour == colour);

            breakingPanel.BreakBlock(colour, matchingPanel);

            if (!breakingPanel.Empty)
            {
                throw new Exception("Broke the panel but it still has blocks");
            }

            _panels.Remove(breakingPanel);

            var nextBlock = matchingPanel?.BlocksToBreak.FirstOrDefault();
            if (nextBlock != null)
            {
                Break(nextBlock.BlockColour);
            }
        }

        public int PanelCount => _panels.Count();
        public IEnumerable<Panel> PanelsRemaining => _panels;
        public int BlockCount => _panels.SelectMany(q => q.Blocks).Count();
    }
}