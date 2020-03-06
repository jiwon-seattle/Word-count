using System;

namespace WordCounter.Models
{
    public class Player
    {
        public static string Name {get; set;}
        public static string Word {get; set;}
        public static string Sentence {get; set;}

        public Player(string name)
        {
            Name = name;
        }
    }
}