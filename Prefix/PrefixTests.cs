using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefix
{
    [TestClass]
    public class PrefixTests
    {
        [TestMethod]
        public void ThreeCompareTest()
        {
            Assert.AreEqual("aaa", ComparePrefix("aaabbcbcbc", "aaajfjfjfjf"));
        }
        [TestMethod]
        public void FourCompareTest()
        {
            Assert.AreEqual("aaab", ComparePrefix("aaabbcbcbc", "aaabjfjfjfjf"));
        }
        [TestMethod]
        public void PrefixCompareTest()
        {
            Assert.AreEqual("tele", ComparePrefix("telefon", "televizor"));
        }
        string ComparePrefix(string firstString, string secondString)
        {
            int prefixLenght = 0;
            for (int i = 0; i < Math.Min(firstString.Length, secondString.Length); i++)
            {
                if (firstString[i] != secondString[i])
                    break;
                prefixLenght++;
            }
            return firstString.Substring(0, prefixLenght);
        }
    }
}

