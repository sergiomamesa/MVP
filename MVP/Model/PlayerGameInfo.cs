using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVP
{
    internal class PlayerGameInfo
    {
        public Player Player { get; set; }
        public TeamPosition TeamPosition { get; set; }
        public Points Points { get; set; }

        public PlayerGameInfo(Player player, TeamPosition teamPosition, Points points)
        {
            Player = player;
            TeamPosition = teamPosition;
            Points = points;
        }
    }
}
