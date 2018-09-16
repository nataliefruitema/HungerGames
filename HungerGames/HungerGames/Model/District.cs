using System;
using System.Collections.Generic;
using System.Text;
using HungerGames.model;

namespace HungerGames.Model
{
    class District
    {
      
      Random random = new Random();

      
        public int MIN_ATTACK_BONUS = 1;
        public int MAX_ATTACK_BONUS = 10;
        public int MIN_DEFENSE_BONUS = 1;
        public int MAX_DEFENSE_BONUS = 15;
        private int district;

        public District(int district)
        {
            this.district = district;
        }

        // private Contestant DistrictContestant(int i)
        //     {
        //                 return new District(random.Next(MIN_DEFENSE_BONUS))
        //     }

    }
}

