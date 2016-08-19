using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    internal class BasketballPoints : Points
    {
        public int ScoredPoints { get; set; }
        public int Rebound { get; set; }
        public int Assist { get; set; }

        public BasketballPoints(TeamPosition teamPostion, int scoredPoints, int rebound, int assist)
            : base(teamPostion)
        {
            ScoredPoints = scoredPoints;
            Rebound = Rebound;
            Assist = assist;
        }
    }
}
