using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqueChars;


namespace UniqeCharsTest
{
    [TestFixture]
    public class UniqCharsTesting
    {
        [Test]
        public void TestUniqueCharactersWhenSingleLetter()
        {
            string input = "a";
            var output = new List<char> { 'a' };

            Assert.AreEqual(output, UniqueChars.UniqueChars.UniqueCharacters(input));
        }

        [Test]
        public void TestUniqueCharactersWhenSameLetterMultipleTimes()
        {
            string input = "bbbbb";
            var output = new List<char> { 'b' };

            Assert.AreEqual(output, UniqueChars.UniqueChars.UniqueCharacters(input));
        }

        [Test]
        public void TestUniqueCharactersWhenUniqLettersSingleTime()
        {
            string input = "abc";
            var output = new List<char> { 'a','b','c' };

            Assert.AreEqual(output, UniqueChars.UniqueChars.UniqueCharacters(input));
        }

        [Test]
        public void TestUniqueCharactersWhenUniqLettersMultipleTimes()
        {
            string input = "accabccbbaaacaabba";
            var output = new List<char> { 'a', 'c', 'b' };

            Assert.AreEqual(output, UniqueChars.UniqueChars.UniqueCharacters(input));
        }


        [Test]
        public void TestUniqueCharactersWhenUniqLettersMultipleTimesUpperLowerCases()
        {
            string input = "AccabccbBaaaCaabba";
            var output = new List<char> { 'a', 'c', 'b' };

            Assert.AreEqual(output, UniqueChars.UniqueChars.UniqueCharacters(input));
        }
    }
}
