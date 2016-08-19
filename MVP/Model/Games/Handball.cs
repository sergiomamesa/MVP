using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    internal class Handball : ISportable
    {
        public IEnumerable<Points> GetRatingPoints()
        {
            yield return new HandballPoints(new TeamPosition("Goalkeeper", 'G'), 50, 5, -2);
            yield return new HandballPoints(new TeamPosition("Field player", 'F'), 20, 1, -1);
        }

        public int CalculatePoints(PlayerGameInfo playerInfo)
        {
            var playerRating = GetRatingPoints().First(i => i.TeamPosition == playerInfo.TeamPosition);

            var ratingPoints = (HandballPoints)playerRating;
            var playerPoints = (HandballPoints)playerInfo.Points;

            var initialRatingPoints = ratingPoints.InitialPoints;
            var goalsMadePoints = ratingPoints.GoalsMade * playerPoints.GoalsMade;
            var goalsReceivedPoints = ratingPoints.GoalsReceived * playerPoints.GoalsReceived;

            var result = initialRatingPoints + goalsMadePoints - goalsReceivedPoints;
            return result;
        }
    }
}
