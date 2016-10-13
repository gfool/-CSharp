using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collecitons
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleBoxUnboxOperation();

            WorkWithArrayList();

            Console.ReadLine();
        }

        // 类型转换：装箱/拆箱操作
        static void SimpleBoxUnboxOperation()
        {
            Console.WriteLine("*****Box Unbox*****");
            int myInt = 25;

            // 装箱
            object boxedInt = myInt;

            // 拆箱
            int unboxedInt = (int)boxedInt;

            Console.WriteLine("boxedInt:{0}, unboxedInt:{1}.", boxedInt, unboxedInt);
            
            // 类型安全问题
            try
            {
                long unboxedLong = (long)boxedInt;
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // 非泛型集合性能问题（装箱/拆箱）
        static void WorkWithArrayList()
        {
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);

            int i = (int)myInts[0];

            Console.WriteLine("Value of your int:{0}", i);
        }

        // 非泛型集合的类型安全问题
        static void ArrayListOfRandomObject()
        {
            // ArrayList可以保存任何类型
            ArrayList allMyObjects = new ArrayList();
            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.Win32NT, new Version(10, 0)));
            allMyObjects.Add(66);
            allMyObjects.Add(3.14);
        }
    }
}
