using NUnit.Framework;
using static PadawansTask2.ArithmeticSequence;

namespace PadawansTask2.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [TestCase(2, 3, 5, ExpectedResult = 40)]
        [TestCase(3, 2, 1, ExpectedResult = 3)]
        [TestCase(-1, -2, 2, ExpectedResult = -4)]
        public int CalculateTests(int number, int add, int count)
            => Calculate(number, add, count);
    }
}
