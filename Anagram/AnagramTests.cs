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
        [TestMethod]
        public void FactorialForThreeTest()
        {
            Assert.AreEqual(6, CalculateFactorial(3));
        }
        [TestMethod]
        public void FactorialForFourTest()
        {
            Assert.AreEqual(24, CalculateFactorial(4));
        }
        [TestMethod]
        public void AnagramRepetTest()
        {
            Assert.AreEqual(3, CalculateAnagram("aab"));
        }
        [TestMethod]
        public void AnagramAlinTest()
        {
            Assert.AreEqual(24, CalculateAnagram("Alin"));
        }
        [TestMethod]
        public void AnagramAlinaTest()
        {
            Assert.AreEqual(60, CalculateAnagram("Alina"));
        }
        [TestMethod]
        public void AnagramAndreiTest()
        {
            Assert.AreEqual(720, CalculateAnagram("Andrei"));
        }
        int CalculateFactorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        int CalculateAnagram(string word)
        {
           
            int common = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].Equals(word[i]))
                    break;
                common++;
            }
            int rez = CalculateFactorial(word.Length) / CalculateFactorial(common); 
            return rez;
        }
    }
}
