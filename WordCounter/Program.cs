using System;
using WordCounter.Models;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter 
{
    class Program
    {   
        public static string userName;
        public static string userWord;
        public static string userSentence;
        public 
        static void Main()
        {
            Console.WriteLine("Hello User. :) ");
            Console.WriteLine("This application will check how many words in sentence provided appears!");
            Console.WriteLine("A result will show a number that the words appears in the sentence.");
            PlayQuestion();
            
        }
        static void PlayQuestion()
        {
            Console.WriteLine("Would you like to play? Provide answer with format [Y for Yes / N for No]");
            string playerAnswer = Console.ReadLine().ToLower();
            if (playerAnswer == "y")
            {
                WordSentenceInput();
            }
            else if (playerAnswer =="n")
            {
                Console.WriteLine("Good bye!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please provide right answer.");
                PlayQuestion();
            }
        }
        static void WordSentenceInput()
        {
            Console.WriteLine("What id your name, user?");
            userName = Console.ReadLine();
            Console.WriteLine("Enter a word that you want to check!");
            userWord = Console.ReadLine().ToLower();
            Console.WriteLine("Enter a sentnece in which you want to see how frequently the word includes");
            userSentence = Console.ReadLine().ToLower();
            Result();
            
        }
        static void Result()
        {
            Word word = new Word(userName);
            word.AssignWordSentence(userWord, userSentence);
            Console.WriteLine($"{word.Player.Name}, the word '{word.Player.Word}' matches {word.CheckWordCounter()} times in the sentence '{word.Player.Sentence}'.");
        }
    
    }
}