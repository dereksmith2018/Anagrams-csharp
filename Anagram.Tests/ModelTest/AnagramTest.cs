using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;
using System;
namespace Anagram.Tests
{
  [TestClass]
  public class WordsTest
  {
    [TestMethod]
    public void FunctionRan_WhatYouWantYourFunctionToDo_WhatDataYouExpectToReceive()
    {
    //Arrange
    string wordsTest = "Anagrams";
    Words newWords = new Words(words);
    //Act
    string result = newWords.FunctionRan();
    //Assert
    Assert.AreEqual("Anagrams", result);
    }
  }
}
