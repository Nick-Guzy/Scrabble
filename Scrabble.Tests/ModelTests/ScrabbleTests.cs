using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System.Collections.Generic;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTests
  {

    [TestMethod]
    public void PointSystemConstructor_CreatesInstanceOfPointSystem_PointSystem()
    {
      PointSystem newPointSystem = new PointSystem("userWord");
      Assert.AreEqual(typeof(PointSystem), newPointSystem.GetType());
    }
    
    [TestMethod]
    public void GetWord_ReturnsWord_Word()
    {
      string word1 = "dog";
      PointSystem newPointSystem = new PointSystem(word1);
      string result = newPointSystem.Word;
      Assert.AreEqual(word1, result);
    }

    [TestMethod]

    public void PointEvaluator_EvaluatesNumberOfPointsFromWord_Int()
    {
      string word2 = "cat";
      PointSystem newPointSystem = new PointSystem(word2);
      int result = newPointSystem.PointEvaluator();
      Assert.AreEqual(typeof(int), result.GetType());
    }

    [TestMethod]

    public void ScoreDictionary_HasPointsAssignedToLetters_Dictionary()
    {
      char letter = 'K';
      PointSystem newPointSystem = new PointSystem("test");
      bool result = newPointSystem.ScoreDictionary.ContainsKey(letter);
      
      Assert.AreEqual(result, true);
    }

    [TestMethod]

    public void PointEvaluator_ReturnsScoreFromWord_Int()
    {
      string word2 = "cat";
      PointSystem newPointSystem = new PointSystem(word2);
      int result = newPointSystem.PointEvaluator();
      int expectedResult = 5;
      Assert.AreEqual(result, expectedResult);
    }
  }
}