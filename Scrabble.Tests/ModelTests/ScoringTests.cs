using Scrabble.Models;

namespace Scrabble.Tests 
{
  [TestClass]
  public class ScoringTests
  {
    [TestMethod]
    public void ScoringConstructor_CreatesInstanceOfStringInput_Scoring()
    {
      Scoring newScoring = new Scoring("cat");
      Assert.AreEqual(typeof(Scoring), newScoring.GetType()); 
    }

    [TestMethod]
    public void GetUserInpit_ReturnsUserInput_String()
    {
        string word = "cat";
        Scoring newScoring = new(word);
        string result = newScoring.UserInput;
        Assert.AreEqual(word, result);
    }
  }
}