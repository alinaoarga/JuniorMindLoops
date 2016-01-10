using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Roman
{
    [TestClass]
    public class RomanNumbers
    {
        string[] roman = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
        int[] arabic = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
        [TestMethod]
        public void OneConvertTest()
        {
            Assert.AreEqual("I", ConvertToRoman(1));
        }
        [TestMethod]
        public void SecondConvertTest()
        {
            Assert.AreEqual("II", ConvertToRoman(2));
        }
        [TestMethod]
        public void ThirdConvertTest()
        {
            Assert.AreEqual("III", ConvertToRoman(3));
        }
        [TestMethod]
        public void TenConvertTest()
        {
            Assert.AreEqual("X", ConvertToRoman(10));
        }
      
        string ConvertToRoman(int number)
        {
            string value = "";
            for (int i = 0; i < roman.Length && number != 0; i++)
            {
                while (number >= arabic[i])
                {
                    number -= arabic[i];
                    value += roman[i];
                }
            }
            return value;
        }
    }
}
