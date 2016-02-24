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
        public void AnagramRepeatTest()
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
            Assert.AreEqual(60, CalculateAnagram("alina"));
        }
        [TestMethod]
        public void AnagramAndreiTest()
        {
            Assert.AreEqual(720, CalculateAnagram("Andrei"));
        }
        [TestMethod]
        public void UniqueABCTest()
        {
            Assert.AreEqual("abc", GetUniqueCharacters("aabbbcc"));
        }
        [TestMethod]
        public void UniqueAlinaTest()
        {
            Assert.AreEqual("Alina", GetUniqueCharacters("AAlinaaa"));
        }
        [TestMethod]
        public void UniqueABCDTest()
        {
            Assert.AreEqual("abcd", GetUniqueCharacters("aaaabbbccccdddddd"));
        }
        [TestMethod]
        public void CountATest()
        {
            Assert.AreEqual(4, CountOccurrence("aaaabbbccccdddddd", 'a'));
        }
        [TestMethod]
        public void CountBTest()
        {
            Assert.AreEqual(3, CountOccurrence("aaaabbbccccdddddd", 'b'));
        }
        [TestMethod]
        public void CountCTest()
        {
            Assert.AreEqual(5, CountOccurrence("aaaabbbcccccdddddd", 'c'));
        }
        [TestMethod]
        public void CountAlinasTest()
        {
            Assert.AreEqual(3, CountOccurrence("aalina", 'a'));
        }
        [TestMethod]
        public void AnagramAndreeaTest()
        {
            Assert.AreEqual(1260, CalculateAnagram("andreea"));
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
        int CountOccurrence(string word, char character)
        {
            int i = 0;
            int count = 0;

            while ((i = word.IndexOf(character, i)) != -1)
            {

                count++;
                i++;
            }

            return count;
        }
        string GetUniqueCharacters(string word)
        {

            string unique = "";
            foreach (char letter in word)
            {
                if (unique.IndexOf(letter) == -1)
                {
                    unique += letter;
                }

            }
            return unique;
        }
        int CalculateAnagram(string word)
          {

              
              int prod = 1;
              
              foreach (char letter in GetUniqueCharacters(word))
              {
                   int count = CountOccurrence(word, letter);
                      prod *= CalculateFactorial(count);
              
              }
              return CalculateFactorial(word.Length) / prod;
          } 
     
    }
}
