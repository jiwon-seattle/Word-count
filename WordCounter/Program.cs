using System;
using WordCounter.Models;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter 
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a word that you want to check!");
            string word = Console.ReadLine().ToLower();
            Console.WriteLine("Enter a sentnece");
            string sentence = Console.ReadLine().ToLower();


            string[] sentenceByWord = sentence.Split(' ');

            for (int i = 0; i <sentenceByWord.Length; i++)
            {
                if(word == sentenceByWord[i])
                {
                    Console.WriteLine("matching!");
                }
                else 
                {
                    Console.WriteLine("dismatch!");
                }
            }


            if (sentence.Contains(word))
            {
                Console.WriteLine("hi");
            }
            else
            {
                Console.WriteLine("Hello");
            }

        }
    }
}