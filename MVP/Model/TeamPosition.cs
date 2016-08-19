using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    internal class TeamPosition
    {
        public string Name { get; set; }
        public char ShortName { get; set; }

        public TeamPosition (string name, char shortName)
	    {
            Name = name;
            ShortName = shortName;
	    }
    }

}
