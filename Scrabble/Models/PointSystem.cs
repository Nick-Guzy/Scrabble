using System;

namespace Scrabble.Models
{
  public class PointSystem
  {
  private string _word;
  
  public string Word 
  { 
    get { return _word; }
  }
  public PointSystem(string userWord)
  {
    _word = userWord;
  }
  
  public int PointEvaluator()
  {
    char[] charedWord = _word.ToCharArray();
    
    int score = 0;

    foreach (char letter in charedWord)
    {
      score++;
      Console.WriteLine(letter);
    }
    Console.WriteLine($"the score is: {score}");
    return 5;
  }
  
  }

}

