﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    internal class Player
    {
        public string Name { get; set; }
        public string NickName { get; set; }

        public Player(string name, string nickName)
        {
            Name = name;
            nickName = NickName;
        }
    }
}
