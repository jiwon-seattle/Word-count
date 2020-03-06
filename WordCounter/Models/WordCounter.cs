namespace WordCounter.Models
{
  public class Word
  {

    public Player Player {get; set;}
    public string[] SentenceCheck { get; set;}
    public int ResultNumber {get; set;}
    
    public Word(string name)
    {
      Player = new Player(name);
    }

    public void AssignWordSentence(string word, string sentence)
    {
      Player.Word = word;
      Player.Sentence = sentence;
      SentenceCheck = sentence.Split(' ');
    }
    public int CheckWordCounter()
    {
      ResultNumber = 0;
      for (int i = 0; i < SentenceCheck.Length; i ++)
      {
        if(Player.Word == SentenceCheck[i])
        {
          ResultNumber ++;
        }
      } return ResultNumber;
    }
  }

}