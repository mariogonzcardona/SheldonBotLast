using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleEchoBot.Modelo
{
    public class BigBangTheoryClient
    {
        private Dictionary<string, Character> characters = new Dictionary<string, Character>()
        {
             {"leonard", new Character("Leonard Hofstadter", "Experimental Physicist" ," <<insert information text here>>", "<<insert image internet Url here>>")},
             {"penny", new Character("Penny", "Aspiring Actress" , " <<insert information text here>>" , "<<insert image internet Url here>>")},
             {"raj", new Character("Rajesh Koothrappali", "Particle Astrophysicist" , " <<insert information text here>>" , "<<insert image internet Url here>>")},
             {"howard", new Character("Howard Wolowitz", "Aerospace Engineer" , " <<insert information text here>>", "<<insert image internet Url here>>")}
        };

        public Character GetCharacter(string name)
        {
            return characters.ContainsKey(name.ToLower()) ? characters[name.ToLower()] : null;
        }


        private Dictionary<string, string> plans = new Dictionary<string, string>()
        {
            { "monday", "get a Thai takeout!" },
            { "tuesday", "have a cheeseburger at the Cheesecake Factory!" },
            { "wednesday", "play Halo with your friends!" },
            { "thursday", "have a nice slice of pizza!" },
            { "friday", "get a chinese takeaway!" },
            { "saturday", "do some of your laundry!" },
            { "sunday", "relax at home and do some physics!" }
        };

        public string GetPlan(string dayOfWeek)
            => plans.ContainsKey(dayOfWeek.ToLower()) ? plans[dayOfWeek.ToLower()] : null;
    }
}