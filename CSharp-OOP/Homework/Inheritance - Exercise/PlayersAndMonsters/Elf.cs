using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Elf:Hero
    {
        public Elf(string username,int level):base(username,level)
        {

        }
        public override string Username { get ; set ; }
        public override int Level { get; set; }
    }
}
