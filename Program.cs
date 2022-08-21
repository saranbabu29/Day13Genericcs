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

            Program.toPrint(Array1);
            Program.toPrint(Array2);
            Program.toPrint(Array3);

        }
        public static void toPrint(int[] inputArray1)
        {
            foreach (int element in inputArray1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------------------");
        }
        public static void toPrint(double[] inputArray2)
        {
            foreach (double element in inputArray2)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------------------");
        }
        public static void toPrint(char[] inputArray3)
        {
            foreach (char element in inputArray3)
            {
                Console.Write(element);
            }
            Console.WriteLine("");
        }

    }
}
