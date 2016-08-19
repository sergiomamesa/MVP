using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    internal class PlayerCalculatedPoints
    {
        public Player Player { get; set; }
        public int TotalPoints { get; set; }

        public PlayerCalculatedPoints(Player player, int totalPoints)
        {
            Player = player;
            TotalPoints = totalPoints;
        }
    }
}
