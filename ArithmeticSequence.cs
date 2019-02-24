using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            int sum = 0;

            if(count <= 0)
            {
                throw new ArgumentOutOfRangeException("The Count Of Elements Of The Sequence Cannot Be Less Or Equals Zero.");
            }
            
            if(number == int.MaxValue)
            {
                throw new ArgumentOutOfRangeException("The Obtained Result Out Of Range Of Integer Values"); 
            }

            if(number == int.MinValue)
            {
                throw new ArgumentOutOfRangeException("The Obtained Result Out Of Range Of Integer Values."); 
            }

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
