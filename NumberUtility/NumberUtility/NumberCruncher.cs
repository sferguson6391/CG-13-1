using System;
using System.Collections.Generic;

namespace NumberUtility
{
        public static class NumberCruncher
        {
            public static int EvenNumbers(List<int> numberList)
            {
            int sum = 0;
                foreach (int number in numberList)
                {
                if (number % 2 == 0)
                    sum += number;
                }
            return sum;
            }
        }
}
