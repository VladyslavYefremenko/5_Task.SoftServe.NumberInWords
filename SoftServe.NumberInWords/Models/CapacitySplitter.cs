using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.NumberInWords
{
    class CapacitySplitter
    {
        public static IEnumerable<string> Split(string number)
        {
            number = number.PadLeft(number.Length + 3 - number.Length % 3, '0');

            return Enumerable.Range(0, number.Length / 3).Select(i => number.Substring(i * 3, 3));
        }
    }
}
