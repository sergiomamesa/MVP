using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    internal class Tournament
    {
        public List<Game> Games { get; set; }

        public Player MvpPlayer { get { return GetMvpPlayer(); } }

        private Player GetMvpPlayer()
        {
            var playersCalculatedPoints = Games.SelectMany(i => i.PlayerCalculatedPoints);
            var poinstGroupedByPlayer = playersCalculatedPoints.GroupBy(i => i.Player);

            var pointsSumByPlayer = poinstGroupedByPlayer.Select(i =>
                    new { Player = i.Key, TotalPoints = i.Sum(p => p.TotalPoints) }
                  );

            var result = pointsSumByPlayer.OrderByDescending(i => i.TotalPoints).First();
            return result.Player;
        }
    }
}
