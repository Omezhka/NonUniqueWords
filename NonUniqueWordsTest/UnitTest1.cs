using NonUniqueWords;
using NUnit.Framework;

namespace NonUniqueWordsTest
{
    public class Tests
    {        
        [Test]
        public void NonUniqueWordCount_CorrectString_ReturnsWordAndCountOfWords()
        {
            string expected = "London: 4\nGreat: 2\nBritain: 2\ncapital: 2\n";
            string actual = NonUniqueWord.NonUniqueWordCount("London Great is a Britain capital London of Great capital Britain London London");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void NonUniqueWordCount_Null_ReturnsEmptyString()
        {
            string expected = "";
            string actual = NonUniqueWord.NonUniqueWordCount(null);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void NonUniqueWordCount_EmptyString_ReturnsEmptyString()
        {
            string expected = "";
            string actual = NonUniqueWord.NonUniqueWordCount("");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void NonUniqueWordCount_WhiteSpace_ReturnsEmptyString()
        {
            string expected = "";
            string actual = NonUniqueWord.NonUniqueWordCount(" ");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void NonUniqueWordCount_OneWordString_ReturnsEmptyString()
        {
            string expected = "";
            string actual = NonUniqueWord.NonUniqueWordCount("London");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void NonUniqueWordCount_AllUniqueWord_ReturnsEmptyString()
        {
            string expected = "";
            string actual = NonUniqueWord.NonUniqueWordCount("London is a capital of Great Britain");

            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}