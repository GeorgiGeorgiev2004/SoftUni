using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public  class Hero
    {
        public virtual int Level { get; set; }
        public virtual string Username { get; set; }
        public Hero(string username,int level)
        {
            Level = level;
            Username = username;
        }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
