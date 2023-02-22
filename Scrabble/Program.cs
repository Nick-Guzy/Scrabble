using System;
using Scrabble.Models;

namespace Scrabble

{
  class Program
  {
    static void Main()
    {
      PointSystem newQuery = new PointSystem("cat");
      Console.WriteLine(newQuery.PointEvaluator());
    }

  }
}
