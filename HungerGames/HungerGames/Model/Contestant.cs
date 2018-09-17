using System;
using System.Collections.Generic;
using System.Text;
using HungerGames.model;
using HungerGames.Model;

namespace HungerGames.model
{
    public class Contestant
    {
        public int numberOfContestants = 24;
        public int attackLevel = 10;
        public int defenseLevel = 10;
        public int healthLevel = 10;
        public int chance = 10;

        public int id { get; set; }
        private Gender Gender { get; set; }

        public int GetattackLevel()
        {
            return attackLevel;
        }

        public void SetattackLevel(int value)
        {
            attackLevel = value;
        }

        public int GetdefenseLevel()
        {
            return defenseLevel;
        }

        public void SetdefenseLevel(int value)
        {
            defenseLevel = value;
        }

        public int GethealthLevel()
        {
            return healthLevel;
        }

        public void SethealthLevel(int value)
        {
            healthLevel = value;
        }

        public int Getchance()
        {
            return chance;
        }

        public void Setchance(int value)
        {
            chance = value;
        }

        private Contestant(Gender gender){
            this.Gender = gender;
        }
        
        public Contestant(int id, Gender gender){
            this.id = id;
            this.Gender = gender;
        }
    }
}