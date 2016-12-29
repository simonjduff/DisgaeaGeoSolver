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
            Console.WriteLine($"Breaking {colour}");
            var breakingPanel = _panels.Single(q => q.ContainsBlock(colour));
            var matchingPanel = _panels.SingleOrDefault(q => q.Colour == colour);

            breakingPanel.MoveBlocksToPanel(matchingPanel);

            if (!breakingPanel.Empty)
            {
                throw new Exception("Broke the panel but it still has blocks");
            }

            _panels.Remove(breakingPanel);
        }

        public int PanelCount => _panels.Count(q => !q.Empty);
        public IEnumerable<Panel> PanelsRemaining => _panels.Where(q => !q.Empty);
    }
}