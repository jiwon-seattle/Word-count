namespace WordCounter.Models
{
  public class Word
  {

    public string PlayerName {get; set;}
    public string InputWord {get; set;}
    public string InputSentence {get; set;}
    public string[] SentenceCheck { get; set;}
    public int ResultNumber {get; set;}
    
    public Word(string playerName)
    {
      PlayerName = playerName;;
    }

    public void AssignWordSentence(string inputword, string inputSentence)
    {
      InputWord = inputword;
      InputSentence = inputSentence;
      SentenceCheck = inputSentence.Split(' ');
    }
    public int CheckWordCounter()
    {
      ResultNumber = 0;
      for (int i = 0; i < SentenceCheck.Length; i ++)
      {
        if(InputWord == SentenceCheck[i])
        {
          ResultNumber ++;
        }
      } return ResultNumber;
    }
  }

}