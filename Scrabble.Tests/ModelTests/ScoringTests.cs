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
    public void GetUserInput_ReturnsUserInput_String()
    {
        string word = "cat";
        Scoring newScoring = new(word);
        string result = newScoring.UserInput;
        Assert.AreEqual(word, result);
    }
    [TestMethod]
    public void SetUserInput_SetsValueOfUserInput_Void()
    {
      string word = "cat";
      Scoring newScoring = new(word);
      string newInput = "dog";
      newScoring.UserInput = newInput;
      Assert.AreEqual(newInput, newScoring.UserInput);
    }

    [TestMethod]
    public void Listify_ConvertsStringToList_List()
    {
    Scoring newScoring = new("cat");
    List<char> charList = newScoring.Listify();
    List<char> expected = new() {'C', 'A','T'};
    CollectionAssert.AreEqual(charList, expected);
    }
    [TestMethod]
    public void GetScore_ConvertCharListToIntList_List()
    {
      Scoring newScoring = new("cat");
      List<char> charList = newScoring.Listify();
      List<int> intList = newScoring.GetScore(charList);
      List<int> expected = new() {3, 1, 1};
      CollectionAssert.AreEqual(intList, expected);
    }
  }
}