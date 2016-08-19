using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    internal class HandballPoints : Points
    {
        public int InitialPoints { get; set; }
        public int GoalsMade { get; set; }
        public int GoalsReceived { get; set; }

        public HandballPoints(TeamPosition teamPostion, int initialPoints, int goalsMade, int goalsReceived)
            : base(teamPostion)
        {
            InitialPoints = initialPoints;
            GoalsMade = goalsMade;
            GoalsReceived = goalsReceived;
        }
    }
}
