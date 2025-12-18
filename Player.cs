using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrol2
{
    internal class Player
    {
        protected int hp;
        protected bool HasAccessCard;
        protected int LastCheckpointId;
        
        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }
        public bool HASAccessCard
        {
            get { return HasAccessCard; }
        }
        public int LASTCheckpoint
        {
            get { return LastCheckpointId; }
            set { LastCheckpointId = value; }
        }
        public Player(int hp, bool HasAccessCard, int LastCheckpointId)
        {
            this.hp = hp;
            this.HasAccessCard = HasAccessCard;
            this.LastCheckpointId = LastCheckpointId;
        }

    }
}
