using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            int sum = 0;

            int sumNumbers = number * count;

            int sumRemainder = 0; 

            for(int i = 0; i <= count - 1; i++)
            {
                sumRemainder += add * i; 
            }

            sum = sumNumbers + sumRemainder; 

            return sum; 
        }
    }
}
