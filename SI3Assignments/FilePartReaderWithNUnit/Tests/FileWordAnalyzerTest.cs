using NUnit.Framework;
using System.Collections.Generic;

namespace FilePartReaderWithNUnit.Tests
{
    [TestFixture]
    class FileWordAnalyzerTest
    {

        FileWordAnalyzer FileWordAnalyzer;
        FilePartReader FilePartReader;

        [SetUp]
        public void TestSetUp()
        {
            FilePartReader = new FilePartReader();
            FilePartReader.Setup(@"C:\Users\Gery\source\repos\AdvanceSI\DotNet\SI_Assignments\SI3Assignments\Test.txt", 1, 7);

            FileWordAnalyzer = new FileWordAnalyzer(FilePartReader);
        }

        [Test]
        public void ListShouldBeAlpahbetical()
        {
            var expectedResult = FileWordAnalyzer.WordsByABC();

            Assert.That(expectedResult, Is.EqualTo(new List<string>() { "Anna", "Changed", "Chocolate", "ChocoPops", "Mama", "Papa", "Sas", "Something", "Vanilla"}));
        }

        [Test]
        public void ListShouldContainSubStrings()
        {
            var expectedResult = FileWordAnalyzer.WordsContainingSubstring("Choco");

            Assert.That(expectedResult, Is.EqualTo(new List<string>() { "Chocolate", "ChocoPops" }));
        }

        [Test]
        public void ListShouldContainPalindromeWords()
        {
            var expectedResult = FileWordAnalyzer.WordsArePalindrome();

            Assert.That(expectedResult, Is.EqualTo(new List<string>() { "Sas", "Anna" }));
        }
    }
}
