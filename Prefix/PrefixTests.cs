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
            Assert.AreEqual("aaa", ComparePrefix("aaabbcbcbc", "aaajfjfjfjf", 3));
        }
        [TestMethod]
        public void FourCompareTest()
        {
            Assert.AreEqual("aaab", ComparePrefix("aaabbcbcbc", "aaabjfjfjfjf", 4));
        }
        string ComparePrefix(string firstString, string secondString, int n)
        {
            string firstPrefix = firstString.Substring(0, n);
            string secondPrefix = secondString.Substring(0, n);
            while (firstString.Length > n && secondString.Length > n)
            {
                if (firstPrefix.Equals(secondPrefix))
                {
                    return firstPrefix;
                }
            }
            return secondPrefix;
        }
    }
}

