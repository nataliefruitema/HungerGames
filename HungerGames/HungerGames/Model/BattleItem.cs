using System;
using System.Collections.Generic;
using System.Text;

namespace HungerGames.Model
{
    class BattleItem
    {
        // create battleItems

        private int attackBonus;

        public int GetAttackBonus()
        {
            return attackBonus;
        }

        public void SetAttackBonus(int value)
        {
            attackBonus = value;
        }

        private int defenseBonus;

        public int GetDefenseBonus()
        {
            return defenseBonus;
        }

        public void SetDefenseBonus(int value)
        {
            defenseBonus = value;
        }
    }
}