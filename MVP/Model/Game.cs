using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    internal partial class Game
    {
        private const int ADDITIONALPOINTSWINNER = 10;

        public ISportable Sport { get; set; }
        public List<Team> Teams { get; set; }

        public Team WinnerTeam { get { return GetWinnerTeam(); } }
        public IEnumerable<PlayerCalculatedPoints> PlayerCalculatedPoints { get { return GetPlayerCalculatedPoints(); } }

        public Game(ISportable sport)
        {
            Sport = sport;
            Teams = new List<Team>();
        }

        private IEnumerable<PlayerCalculatedPoints> GetPlayerCalculatedPoints()
        {
            return Teams.SelectMany(team =>
                    {
                        if (team == WinnerTeam)
                            return team.CalculatePoints(ADDITIONALPOINTSWINNER);

                        return team.CalculatePoints();
                    }
                );
        }

        private Team GetWinnerTeam()
        {
            var result = Teams.OrderByDescending(i => i.TotalPoints).First();
            return result;
        }
    }
}
