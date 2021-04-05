using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.NumberInWords
{
    class ThirdNumberGetter
    {
        public static string Get(char ch1, char ch2, int countdown)
        {
            string result = string.Empty;

            if (ch1 != '1')
            {
                foreach (int i in Enum.GetValues(typeof(Units)))
                {
                    if (ch2 - '0' == i)
                    {
                        result = Enum.GetName(typeof(Units), i);
                        break;
                    }
                }
            }
            else
            {
                result = "";
            }

            return result;
        }
    }
}
