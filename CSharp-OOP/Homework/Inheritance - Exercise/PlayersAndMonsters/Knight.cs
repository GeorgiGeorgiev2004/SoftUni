using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Knight:Hero
    {
        public Knight(string username, int level) : base(username, level)
        {

        }
        public override string Username { get; set; }
        public override int Level { get; set; }
    }
}
