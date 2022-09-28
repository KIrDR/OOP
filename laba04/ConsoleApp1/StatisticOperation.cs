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
        public static int Mmax(ArrayN x)
        {
            int maxValue =  x.oneArray.Max();
            return maxValue;
        }

        public static int Mmin(ArrayN x)
        {
            int minValue = x.oneArray.Min();
            return minValue;
        }

        public static int Ssum(ArrayN x)
        {
            return x.oneArray.Sum();
        }

        public static int KolVo(ArrayN x)
        {
            return (x.oneArray.Length);
        }

        public static string DeleteAllVowel(string userInput)
        {
            Regax.Replace(userInput, "(?i)[бвгджзйклмнпрстфхцчшщ]", "");
        }
    }
}
