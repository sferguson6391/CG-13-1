using System;
using System.Collections.Generic;
using NumberUtility;

namespace CG_13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 2, 3, 4 };
            Console.Write(NumberCruncher.EvenNumbers(numberList));
            Console.ReadLine();
        }
    }
}
