using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.NumberInWords
{
    class RankNameGetter
    {
        public static string getRankName(string s, int ii)
        {
            if (ii == 1) return "";

            int capacity;
            string strCapacity = Enum.GetName(typeof(Capacity), ii);

            foreach (int value in Enum.GetValues(typeof(Capacity)))
            {
                if (value == ii)
                {
                    capacity = value;
                }
            }

            return strCapacity;
        }
    }
}
