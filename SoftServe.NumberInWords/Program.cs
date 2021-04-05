using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.NumberInWords
{
    class Program
    {
        static void Main(string[] args)
        {

            // ToDo: add OOP
            // ToDo: add Validation
            // ToDo: add Instracrion

            string testNum = "666";

            Console.WriteLine(testNum);
            foreach (var s in InWordsGetter.GetInWords(CapacitySplitter.Split(testNum)))
            {
                Console.Write(s.Trim() + " ");
            }

            Console.ReadKey();
        }
    }
}
