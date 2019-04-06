using NUnit.Framework;

namespace FilePartReaderWithNUnit.Tests
{
    [TestFixture]
    class FilePartReaderTest
    {
        FilePartReader FilePartReader;

        [SetUp]
        public void TestSetUp()
        {
            FilePartReader = new FilePartReader();
            FilePartReader.Setup(@"C:\Users\Gery\source\repos\AdvanceSI\DotNet\SI_Assignments\SI3Assignments\Test.txt", 1, 1);
        }

        [Test]
        public void ShouldReadFileFromStartTillEnd()
        {
            string expectedResult = FilePartReader.Read();
            Assert.That(expectedResult, Is.EqualTo("Something Changed\r\nMama\r\nPapa\r\nChocolate Vanilla\r\nSas\r\nChocoPops\r\nAnna"));
        }

        [Test]
        public void ShouldReadFileFirstLine()
        {
            FilePartReader.FromLine = 1;
            FilePartReader.ToLine = 1;
            string expectedResult = FilePartReader.ReadLines();

            Assert.That(expectedResult, Is.EqualTo("Something Changed"));
        }

        [Test]
        public void ShouldReadFileSecondLine()
        {
            FilePartReader.FromLine = 2;
            FilePartReader.ToLine = 2;
            string expectedResult = FilePartReader.ReadLines();

            Assert.That(expectedResult, Is.EqualTo("Mama"));
        }

        [Test]
        public void ShouldReadFileSecondToThirdLine()
        {
            FilePartReader.FromLine = 2;
            FilePartReader.ToLine = 3;
            string expectedResult = FilePartReader.ReadLines();

            Assert.That(expectedResult, Is.EqualTo("Mama Papa"));
        }

        [Test]
        public void ShouldReadFileSecondToFourthLine()
        {
            FilePartReader.FromLine = 2;
            FilePartReader.ToLine = 4;
            string expectedResult = FilePartReader.ReadLines();

            Assert.That(expectedResult, Is.EqualTo("Mama Papa Chocolate Vanilla"));
        }
    }
}
