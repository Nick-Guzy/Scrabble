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
      PointSystem newPointSystem = new PointSystem();
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
    
  }
}