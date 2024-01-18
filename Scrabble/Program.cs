using Scrabble.Models;
using Scrabble.UserInterfaceModels;

namespace Scrabble
{
  class Program
  {
    static void Main()
    {
      Console.BackgroundColor = ConsoleColor.DarkRed;
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine(Banners.Welcome);
      Console.WriteLine("Give me a word and I'll compute your Scrabble score...");
      string? response = Console.ReadLine();
      string? word = response;
      Scoring newScoring = new(word);
      Console.WriteLine($"You entered {response}.");
      Console.WriteLine("If the word is incorrect, you can edit it by typing 'e', or enter any other key to continue...");
      string? edit = Console.ReadLine();
      if (edit == "e" || edit == "E")
      {
        Console.WriteLine("Enter the word again...");
        string? newInput = Console.ReadLine();
        newScoring.UserInput = newInput;
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine($"Your word scored {CalculateScore(newScoring)} points!");
        PlayAgain();
      }
      else
      {
        Console.WriteLine("you have reached else statement");
        Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine($"Your word scored {CalculateScore(newScoring)} points!");
        PlayAgain();

      }
    }
    static int CalculateScore(Scoring newScoring)
    {
        List<char> charList = newScoring.Listify();
        int score = Scoring.GetScore(charList);
        return score;
    }
    static void PlayAgain()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Type 'list' for a list of your running word scores.");
      string showList = Console.ReadLine();
      if (showList == "list")
      {
        ShowList();
      }
      else 
      {
        Console.WriteLine("Do you want to play again? 'y' for yes, 'n' for no.");
        string? answer = Console.ReadLine();
        if (answer == "y" || answer == "Y")
        {
          Main();
        }
        else
        {
          Console.WriteLine(Banners.GoodBye);
        }
      }
    static void ShowList()
    {
      List<int> scores = Scoring.GetAll();
        if (scores.Count > 0)
        {
          Console.WriteLine("-----------------------------------------");
          Console.WriteLine($"Here is the list of Scrabble Scores: ");
          Console.WriteLine("-----------------------------------------");
          foreach (int score in scores)
          {
            Console.WriteLine($"Score: {score}");
          //Word: { score.UserInput}
          }
        }
    }
  }
}
}