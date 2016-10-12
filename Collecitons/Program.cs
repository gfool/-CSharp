using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collecitons
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "First", "Second", "Third" };

            Console.WriteLine("This array has {0} items.", strArray.Length);

            foreach(string s in strArray)
            {
                Console.WriteLine("Array Entry: {0}.", s);
            }
            Console.WriteLine();

            // 颠倒数组
            Array.Reverse(strArray);

            foreach(string s in strArray)
            {
                Console.WriteLine("Array Entry: {0}.", s);
            }

            Console.ReadLine();
        }
    }
}
