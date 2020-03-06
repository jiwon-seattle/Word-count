using System;
using WordCounter.Models;

namespace WordCounter 
{
    class Program
    {   
        public static string userName;
        public static string userWord;
        public static string initialSentence;
        public static string userSentence;
        static void Main()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("                            Hello User. :) ");
            Console.WriteLine("This application will check how many words in sentence provided appears!");
            Console.WriteLine("A result will show a number that the words appears in the sentence.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
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
            initialSentence = Console.ReadLine().ToLower();
            string SecondSenentece = initialSentence.Replace(",", "");
            userSentence = SecondSenentece.Replace(".", "");
            Result();
            
        }
        static void Result()
        {
            Word word = new Word(userName);
            word.AssignWordSentence(userWord, userSentence);
            Console.WriteLine("\n─────────────────────────────────────────────────────────────────────");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"                              {word.Player.Name}!");
            Console.WriteLine($"The word '{userWord}' matches {word.CheckWordCounter()} times in the sentence '{initialSentence}'.");
            Console.WriteLine("\n─────────────────────────────────────────────────────────────────────");
        }
    }
}