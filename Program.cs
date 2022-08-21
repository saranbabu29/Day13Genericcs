using System;
using System.Collections.Generic;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = new int[] { 1, 2, 3, 4, 5, 6 };
            double[] Array2 = { 1.1, 1.2, 1.3, 1.4, 1.5, 1.6 };
            char[] Array3 = new char[] { 's', 'h', 'a', 'r', 'a', 'n' };

            Program.toPrint<int>(Array1);
            Program.toPrint<double>(Array2);
            Program.toPrint<Char>(Array3);

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
