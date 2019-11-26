using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Moomoo_Client
{
    class Servers
    {
        public string mm_prod;
        public MoomooGame[] servers;
    }
    class MoomooGame
    {
        public string ip;
        public string scheme;
        public int region;
        public int index;
        public Game[] games;
        public string toIdentifier()
        {
            return this.region+":"+this.index+":"+"0";
        }
        public bool matchAgainst(string i)
        {
            return toIdentifier() == i;
        }
        public bool matchAgainst(int region, int sIndex)
        {
            return this.region == region && this.index == sIndex;
        }
    }
    class Game
    {
        public bool isPrivate;
        public int playerCount;
    }
}
