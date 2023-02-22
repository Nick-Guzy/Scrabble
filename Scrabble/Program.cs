using System;
using Scrabble.Models;

namespace Scrabble

{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
      Console.WriteLine("welcome to your local scrabble word counter");
      Console.WriteLine("enter a word, and ill tell you how many points it is worth");
      Console.WriteLine("ready?");
      string word = Console.ReadLine();
      PointSystem newQuery = new PointSystem(word);
      Console.WriteLine($"you word: {newQuery.Word}, is worth {newQuery.PointEvaluator()}");
      Console.WriteLine("have another word? want to go again?");
      Console.WriteLine("enter y/n");
      string choice = Console.ReadLine();
      if (choice == "y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("so long, friend");
      }


    }

  }
}
