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
            System.Collections.ArrayList strArray = new System.Collections.ArrayList();
            strArray.AddRange(new string[] { "First", "Second", "Third" });

            Console.WriteLine("This array has {0} items.", strArray.Count);

            foreach(string s in strArray)
            {
                Console.WriteLine("Array Entry: {0}.", s);
            }
            Console.WriteLine();

            // 增加
            strArray.Add("Fourth");
            Console.WriteLine("This array has {0} items.", strArray.Count);

            foreach(string s in strArray)
            {
                Console.WriteLine("Array Entry: {0}.", s);
            }

            Console.ReadLine();
        }
    }
}
