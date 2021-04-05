using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.NumberInWords
{
    class SecondNumberGetter
    {
        public static string Get(char ch1, char ch2)
        {
            string result = string.Empty;

            if (ch1 != '0')
            {
                if (ch1 == '1')
                {
                    foreach ( int i in Enum.GetValues(typeof(Teens)))
                    {
                        int ch2Num = ch2 - '0';

                        if (i == ch2Num)
                        {
                            result = Enum.GetName(typeof(Teens), i);
                            break;
                        }
                    }
                }
                else
                {
                    foreach (int i in Enum.GetValues(typeof(Units)))
                    {
                        int ch1Num = ch1 - '0';

                        if (i == ch1Num)
                        {
                            result += Enum.GetName(typeof(Tens), i);
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}
