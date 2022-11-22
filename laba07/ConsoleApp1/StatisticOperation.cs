using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Laba03
{
    static class StatisticOperation
    {

        /*
          public static void MmaxMinusMmin(this ArrayN x)
          {
              int k = x.oneArray.Max() - x.oneArray.Min();
              Console.WriteLine(k);
          }

          public static void Mmax(this ArrayN<T> x)
          {
              int maxValue =  x.oneArray.Max();
              Console.WriteLine(maxValue);
          }

          public static void Mmin(this ArrayN x)
          {
              int minValue = x.oneArray.Min();
              Console.WriteLine(minValue);
          }

          public static void Ssum(this ArrayN x)
          {

              int n = 0;            

              for (int i = 0; i < x.oneArray.Length; i++)
              {
                  n += x.oneArray[i];
              }

              Console.WriteLine(n);
          }

          public static void KolVo(this ArrayN x)
          {
              Console.WriteLine(x.oneArray.Length);
          }

          public static void DeleteAllVowel(this string str)
          {
              var stringBuilder = new StringBuilder();
              var array = new char[] { 'у', 'е', 'а', 'о', 'э', 'я', 'и', 'ю', 'ё', 'ы' };

              foreach(var e in str)
              {
                  var flag = true;
                  foreach(var symbol in array)
                  {
                      if(e == symbol)
                      {
                          flag = false;
                          break;
                      }
                  }

                  if (flag)
                  {
                      stringBuilder.Append(e);
                  }

              }

              str = stringBuilder.ToString();
              Console.WriteLine(str);*/
        /*  string letter = "бвгджзйклмнпрстфхцчшщ";

         for (int i = 0; i < userInput.developer.FullName.Length; i++)
         {
             for (int k = 0; k < letter.Length; ++k)
             {
                 if (userInput.developer.FullName[i] == letter[k])
                 {
                     userInput.developer.FullName = userInput.developer.FullName.Remove(i,1);
                 }
             }
         }
         Console.WriteLine(userInput.developer.FullName);


         Regex.Replace(userInput, "(?i)[бвгджзйклмнпрстфхцчшщ]", "");
         Regex r = new Regex(@"\b[аеёиоуыэюя]\S+\b", RegexOptions.IgnoreCase);
         userInput.developer.FullName = r.Replace(userInput.developer.FullName, "");
         Console.WriteLine(userInput.developer.FullName);
    }*/
    }
}
