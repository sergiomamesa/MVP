using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    internal partial class Team
    {
        public ISportable Sport { get; set; }
        public string Name { get; set; }
        public IEnumerable<PlayerGameInfo> PlayerInfo { get; set; }
        public IEnumerable<Player> Players { get; set; }

        public int TotalPoints { get { return GetTotalPoints(); }}

        private int GetTotalPoints()
        {
            return CalculatePoints().Sum(i => i.TotalPoints);
        }

        public IEnumerable<PlayerCalculatedPoints> CalculatePoints(int extraPoints = 0)
        {
            foreach (var player in Players)
            {
                var playerInfo = PlayerInfo.First(i => i.Player == player);
                var totalPoints = Sport.CalculatePoints(playerInfo);

                yield return new PlayerCalculatedPoints(player, totalPoints + extraPoints);
            }
        }
    }
}
