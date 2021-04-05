using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.NumberInWords
{
    class InWordsGetter
    {
        public static IEnumerable<string> GetInWords(IEnumerable<string> numbers)
        {
            int i = 0;

            foreach (var num in numbers)
            {
                int countdown = numbers.Count() - i;

                string str1 = num[0] == '0' ? "" : Enum.GetName(typeof(Units), num[0] - '0');
                string str2 = int.Parse(num) <= 100 ? "" : Enum.GetName(typeof(Capacity), 1);
                string str3 = SecondNumberGetter.Get(num[1], num[2]);
                string str4 = ThirdNumberGetter.Get(num[1], num[2], countdown);
                string str5 = num == "000" ? "" : RankNameGetter.getRankName(num, countdown);

                i++;

                yield return String.Format($"{str1} {str2} {str3} {str4} {str5}");
            }
        }
    }
}
