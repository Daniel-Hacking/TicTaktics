using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTakticsForTheGame
{
    public class Player
    {
        private int playerId;
        private string name;
        private bool isX;

        public Player () { }

        public Player(string playerName)
        {
            this.Name = playerName;
        }

        public int PlayerId
        {
            get { return playerId; }
            set { playerId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool IsX
        {
            get { return isX; }
            set { isX = value; }
        }
    }

    
}
