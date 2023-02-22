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
  
  }

}

