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
    }
}
