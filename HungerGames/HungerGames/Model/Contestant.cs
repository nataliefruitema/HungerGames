using System;
using System.Collections.Generic;
using System.Text;
using HungerGames.model;
using HungerGames.Model;

namespace HungerGames.model
{
    public class Contestant
    {
        Random random = new Random();
        
        public int NR_CONTESTANTS = 24;
        public int id { get; set; }
        private Gender Gender { get; set; }

        public int attackLevel { get; set; }
        public int defenseLevel { get; set; }
        public int healthLevel { get; set; }
        public int chance { get; set; }

        private Contestant(Gender gender){
            this.Gender = gender;
        }

        private BattleItem battleItem { get; set; }
        
        public Contestant(int id, Gender gender){
            this.id = id;
            this.Gender = gender;
        }
    }
}