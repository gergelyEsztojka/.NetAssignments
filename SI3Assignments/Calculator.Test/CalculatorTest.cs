using NUnit.Framework;

namespace Calculator.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        ICalculator sut;

        [SetUp]
        public void TestSetUp()
        {
            sut = new Calculator();
        }

        [Test]
        public void ShouldAddTwoNumbers()
        {
            int expectedResult = sut.Add(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }

        [Test]
        public void ShouldMulTwoNumbers()
        {
            int expectedResult = sut.Mul(7, 8);
            Assert.That(expectedResult, Is.EqualTo(56));
        }

        [Test]
        [Ignore("Coz I say so")]
        public void ShouldNotMulTwoNumbers()
        {
            int expectedResult = sut.Mul(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }

        [TearDown]
        public void TestTearDown()
        {
            sut = null;
        }
    }
}
