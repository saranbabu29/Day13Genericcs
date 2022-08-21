using System;
using GenericExample;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[] { 100, 254, 935, 414, 567, 760 };

            GenericMaximum<int> generic = new GenericMaximum<int>(Array);
            generic.PrintMaxValue();

        }
        public static void toPrint<T>(T[] inputArray1)
        {
            foreach (var element in inputArray1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------------------");
        }
    }
}
