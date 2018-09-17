
using System;
using System.Collections.Generic;
using System.Text;
using HungerGames.model;
using HungerGames.Model;

namespace HungerGames.Controller
{
    class ArenaController
    {

    private List<Contestant> contestant = new List<Contestant>();

        // for(int i = 0; i < 24; i ++){                    
                // contestant.Add(new Contestant());

        public void start(){
        Console.WriteLine("Welcome, it is a new day!");
        Console.ReadLine();
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

    Random random = new Random();
        private Contestant GetContestant()
        {
            int randomNumber = random.Next(0, 24);
            if(randomNumber < 18 )
            {
                return GetDistrict(randomNumber);
            }
            else
            {
                return GetCareer(randomNumber);
            }
        }

        // 3/4 of the Contestants are in the district
        private Contestant GetDistrict(int i)
        {
            return new District(random.Next(), GetGender(i));
        }

         // 1/4 of the Contestants are in the district
        private Contestant GetCareer(int i)
        {
            return new Career(random.Next(), GetGender(i));
        }
    }
}