using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    internal interface ISportable
    {
        IEnumerable<Points> GetRatingPoints();

        int CalculatePoints(PlayerGameInfo playerInfo);
    }

}
