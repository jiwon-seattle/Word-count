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
        public static string[] Invalid_characters = new string[] {",", ".", "?", "!", ":", ";", "~", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "[", "]", "{", "}", "\", "|", "`"};
        
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

            bool validAnswer = false;

            while(validAnswer == false)
            {
                Console.WriteLine("Would you like to play? Provide answer with format [Y for Yes / N for No]");
                string playerAnswer = Console.ReadLine().ToLower();

                if (playerAnswer == "y")
                {
                    WordSentenceInput();
                    validAnswer = true;
                }
                else if (playerAnswer == "n")
                {
                    Console.WriteLine("Good bye!");
                    validAnswer = true;
                }
                else 
                {
                    Console.WriteLine("Invalid input. Please provide right answer.");
                    PlayQuestion();
                    validAnswer = false;
                }
            }
        }
        static void WordSentenceInput()
        {
            Console.WriteLine("What id your name, user?");
            userName = Console.ReadLine();
            Console.WriteLine("Enter a word that you want to check!");
            userWord = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Enter a sentnece in which you want to see how frequently the word includes");
            initialSentence = Console.ReadLine().ToLower().Trim();

            userSentence = initialSentence;

            foreach (string invalid_char in Invalid_characters)
            {
                userSentence = userSentence.Replace(invalid_char, "");
            }

            Result();
            
        }
        static void Result()
        {
            Word word = new Word(userName);
            word.AssignWordSentence(userWord, userSentence);
            Console.WriteLine("\n─────────────────────────────────────────────────────────────────────");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"                              {word.PlayerName}!");
            Console.WriteLine($"The word '{userWord}' matches {word.CheckWordCounter()} times in the sentence '{initialSentence}'.");
            Console.WriteLine("\n─────────────────────────────────────────────────────────────────────");
        }
    }
}