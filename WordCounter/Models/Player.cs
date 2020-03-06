using System;

namespace WordCounter.Models
{
    public class Player
    {
        public string Name {get; set;}
        public string Word {get; set;}
        public string Sentence {get; set;}

        public Player(string name)
        {
            Name = name;
        }
    }
}