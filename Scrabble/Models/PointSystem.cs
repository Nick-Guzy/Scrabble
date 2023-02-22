using System;
using System.Collections.Generic;

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
      char[] charedWord = _word.ToUpper().ToCharArray();
      
      int score = 0;

      foreach (char letter in charedWord)
      {
        score += ScoreDictionary[letter];
      }
      Console.WriteLine($"the score is: {score}");
      return score;
    }
    
    public Dictionary<char, int> ScoreDictionary = new Dictionary<char, int>()
    {
    {'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1}, {'D', 2}, {'G', 2}, {'B', 3}, {'C', 3}, {'M', 3}, {'P', 3}, {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4}, {'K', 5}, {'J', 8}, {'X', 8}, {'Q', 10}, {'Z', 10} 
    };

  }

}

