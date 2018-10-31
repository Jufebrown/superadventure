using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }

        public Player(int currentHP, int maxHP, int gold, int xP, int level) : base(currentHP, maxHP)
        {
            Gold = gold;
            XP = xP;
            Level = level;
        }
    }
}
