using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void AssignWordSentence_CreateArrayofUserInput_WordsInArray()
    {
      Word word = new Word("Jiwon");
      string userword = "good";
      string userSentence = "Today is a good sunny day";
      word.AssignWordSentence(userword.ToLower(), userSentence.ToLower());
      string[] test = {"today", "is", "a", "good", "sunny", "day"};
      Assert.AreEqual(word.SentenceCheck[5], test[5]);
    }

    [TestMethod]
    public void CheckWordCounter_CheckWordInTheSentence_NumberOfNumbers()
    {
      Word word = new Word("Jiwon");
      string userWord = "good";
      string userSentence = "Today is a good sunny day";
      word.AssignWordSentence(userWord, userSentence);
      int TestResult = word.CheckWordCounter();
      Assert.AreEqual(TestResult, 1);
    }
  }
}