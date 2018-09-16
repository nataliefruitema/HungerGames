
using System;
using System.Collections.Generic;
using System.Text;
using HungerGames.model;

namespace HungerGames.Controller
{
    class ArenaController
    {
        Random random = new Random();
        private List<Contestant> contestant = new List<Contestant>();

        int days = 1;

        public void start(){

        Console.WriteLine("Welcome, it is a new day!");

    }

        public Gender GetGender(int i){
            if((i%2) == 0)
            {
                return Gender.Male;
            }
            else
            {
                return Gender.Female;
            }
        }

        protected Contestant GetContestant(int number){
            Contestant contestant = new Contestant(1, Gender.Male){

        
            for (int i = 0; i < 24; i ++){
    
            }
        }
    }
}