using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPredictionGame3.Class
{
  class UserGuess
  {
    public static bool tahminDogruMu(int[] pcSayi, int userTahmin,ref int positive,ref int negative)
    {
      StringBuilder sb = new StringBuilder();
      //toCharArray
      int[] tahmin = new int[] { userTahmin / 1000, userTahmin % 1000 / 100, userTahmin % 1000 % 100 / 10, userTahmin % 1000 % 100 % 10 };

      for (int i = 0; i < pcSayi.Length; i++)//4 kere döner
      {
        if (pcSayi[i] == tahmin[i])
        {
          positive++;
        }
        else
        {
          for (int k = 0; k < 4; k++)
          {
            if (tahmin[k] == pcSayi[i])
            {
              negative++;
              break;
            }
          }
        }
      }
      if (positive == 4)
      {
        //Console.WriteLine("TEBRİKLER :)");
        return true;
      }
      else if (positive > 0)
      {
        //sb.AppendLine("+" + positive + "");
        //if (negative > 0)
        //  sb.AppendLine("-" + negative + "");
        //Console.WriteLine("ipucu:\n" + sb.ToString());
        return false;
      }
      else if (negative > 0)
      {
        //sb.AppendLine("-" + negative + "");
        //Console.WriteLine("ipucu:\n" + sb.ToString());
        return false;
      }
      else
      {
        //Console.WriteLine("Bilemedin.. Tekrar tahmin et !");
        return false;
      }
    }
    public static void sayilariKar(ref int[] array)
    {
      System.Random random = new System.Random();
      for (int i = 0; i < array.Length; i++)
      {
        int j = 0;
        do
        {
          j = random.Next(array.Length);
          var temp = array[i];
          array[i] = array[j];
          array[j] = temp;
        } while (array[0] == 0);
      }
    }


  }
}
