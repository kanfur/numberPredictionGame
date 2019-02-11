using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPredictionGame3.Class
{
  class PcGuess
  {
    public static IEnumerable<string> Permutations(int size)
    {
      if (size > 0)
      {
        foreach (string s in Permutations(size - 1))
          foreach (char n in "1234567890")
            if (!s.Contains(n))
              yield return s + n;
      }
      else
        yield return "";
    }
    public static IEnumerable<T> Shuffle<T>(IEnumerable<T> source)
    {
      Random random = new Random();
      List<T> list = source.ToList();
      while (list.Count > 0)
      {
        int ix = random.Next(list.Count);
        yield return list[ix];
        list.RemoveAt(ix);
      }
    }
    public static List<string> answers(int ANSWER_SIZE)
    {
      List<string> answers = Shuffle(Permutations(ANSWER_SIZE)).ToList();
      return answers;
    }
    public static string guess(List<string> answers)
    {
      int i = 0;
      string guess;
      try
      {
        do //binler basamağına 0 rakamı gelemez
        {
          guess = answers[i];
          i++;
          if (i > 10)
            return "error:i="+i;
        } while (int.Parse(guess)<1000);
        return guess;
      }
      catch (Exception e)
      {
        return "Error !Impossible answer for the clues you gave. ";
      }
      
    }
    public static void pcGuess(int userPositive,int userNegative,ref List<string> answers,string guess,int ANSWER_SIZE)
    {
      if (answers.Count > 1)
      {
        for (int ans = answers.Count - 1; ans >= 0; ans--)
        {
          int pos = 0, neg = 0;
          for (int x = 0; x < ANSWER_SIZE; x++)
            if (answers[ans][x] == guess[x])
              pos++;
            else if (answers[ans].Contains(guess[x]))
              neg++;
          if ((pos != userPositive) || (neg != userNegative))
          {
            answers.RemoveAt(ans);
          }
        }
      }
    }

  }
}
