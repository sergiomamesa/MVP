using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    internal class Basketball : ISportable
    {
        public IEnumerable<Points> GetRatingPoints()
        {
            yield return new BasketballPoints(new TeamPosition("Guard", 'G'), 2, 3, 1);
            yield return new BasketballPoints(new TeamPosition("Forward", 'F'), 2, 2, 2);
            yield return new BasketballPoints(new TeamPosition("Center", 'C'), 2, 1, 3);
        }

        public int CalculatePoints(PlayerGameInfo playerInfo)
        {
            var playerRating = GetRatingPoints().First(i => i.TeamPosition == playerInfo.TeamPosition);

            var ratingPoints = (BasketballPoints)playerRating;
            var playerPoints = (BasketballPoints)playerInfo.Points;

            var scoredPoints = ratingPoints.ScoredPoints * playerPoints.ScoredPoints;
            var reboundPoints = ratingPoints.Rebound * playerPoints.Rebound;
            var assistsPoints = ratingPoints.Assist * playerPoints.Assist;

            var result = scoredPoints + reboundPoints + assistsPoints;
            return result;
        }
    }
}
