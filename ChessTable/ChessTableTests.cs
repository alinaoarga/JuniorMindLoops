using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTable
{
    [TestClass]
    public class ChessTableTests
    {
        [TestMethod]
        public void TwoSquaresTest()
        {
            Assert.AreEqual(5, CalculateSquares(2));
        }
        [TestMethod]
        public void ThreeSquaresTest()
        {
            Assert.AreEqual(14, CalculateSquares(3));
        }
        [TestMethod]
        public void EightSquaresTest()
        {
            Assert.AreEqual(204, CalculateSquares(8));
        }
        int CalculateSquares(int number)
        {
            int total = 0;
            for (int i = 1; i <= number; i++)
            {
                total += i * i;
            }
            return total;
        }
    }
}
