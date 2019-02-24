using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            int sum = 0;

            if (count <= 0)
            {
                throw new ArgumentException("The Count Of Elements Of The Sequence Cannot Be Less Or Equals Zero.");
            }

            for (int i = 0; i <= count - 1; i++)
            {
                checked
                {
                    sum += add * i + number;

                }
            }

            return sum;
        }
    }
}
