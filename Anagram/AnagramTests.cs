using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagram
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void AnagramForTwoTest()
        {
            Assert.AreEqual(2, CalculateAnagram("ab"));
        }
        [TestMethod]
        public void AnagramForThreeTest()
        {
            Assert.AreEqual(6, CalculateAnagram("abc"));
        }
        [TestMethod]
        public void AnagramForFourTest()
        {
            Assert.AreEqual(24, CalculateAnagram("abcd"));
        }
        int CalculateAnagram(string word)
        {
            int number = word.Length;
            int total = 0;
            while (number > 0)
            {
                for (int i = 0; i <= number; i++)
                {
                    number *= number * i;
                    number++;
                    total += 1;
                    total++;
                }

            }
            return total;
        }
    }
}
