namespace Scrabble.Models
{
  public class Scoring
  {
    private static Dictionary<char, int> _scoring = new()
        {
            {'A', 1},
            {'E', 1},
            {'I', 1},
            {'O', 1},
            {'U', 1},
            {'L', 1},
            {'N', 1},
            {'R', 1},
            {'S', 1},
            {'T', 1},
            {'D', 2},
            {'G', 2},
            {'B', 3},
            {'C', 3},
            {'M', 3},
            {'P', 3},
            {'F', 4},
            {'H', 4},
            {'V', 4},
            {'W', 4},
            {'Y', 4},
            {'K', 5},
            {'J', 8},
            {'X', 8},
            {'Q', 10},
            {'Z', 10}
        };

    public string UserInput { get; set; }
    private static List<int> _instances = new() {};
    public Scoring(string word)
    {
      UserInput = word;
      _instances.Add(Scoring.GetScore(this.Listify()));
    }

    public static List<int> GetAll()
        {
            return _instances;
        }
    public List<char> Listify()
    {
      string UpperCased = UserInput.ToUpper();
      return UpperCased.ToList();
    }
    public static int GetScore(List<char> charList)
    {
      List<int> intList = new() { };
      for (int i = 0; i < charList.Count; i++)
      {
        intList.Add(_scoring[charList[i]]);
      }
      return intList.Aggregate((sum, x) => sum + x);
    }

  }
}