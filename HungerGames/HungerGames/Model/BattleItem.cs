using System;
using System.Collections.Generic;
using System.Text;

namespace HungerGames.Model
{
    class BattleItem
    {
        public int AttackBonus { get; set; }

        public int DefenseBonus { get; set; }
    
        public int MIN_ATTACK_BONUS = 1;
        public int MAX_ATTACK_BONUS = 10;
        public int MIN_DEFENSE_BONUS = 1;
        public int MAX_DEFENSE_BONUS = 15;
    }
}
