using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    internal abstract class Points
    {
        public TeamPosition TeamPosition { get; set; }

        public Points(TeamPosition teamPosition)
        {
            TeamPosition = teamPosition;
        }
    }
}
