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
      Assert.AreEqual(typeof(Scoring), newScoring.GetType()); //string
    }
  }
}