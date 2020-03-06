using System;

namespace WordCounter.Models
{
    public class Player
    {
        public static string Name {get; set;}

        public Player(string name)
        {
            Name = name;
        }
    }
}