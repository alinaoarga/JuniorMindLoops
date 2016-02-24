using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube
{
    [TestClass]
    public class CubeTests
    {
        [TestMethod]
        public void NumberForK1Test()
        {
            Assert.AreEqual(192, DetermineNumber(1));
        }
        [TestMethod]
        public void NumberForK2Test()
        {
            Assert.AreEqual(442, DetermineNumber(2));
        }
        [TestMethod]
        public void NumberForK3Test()
        {
            Assert.AreEqual(692, DetermineNumber(3));
        }
        int DetermineNumber(int k)
        {
            int number = 0;
          if(k >= 0)
            {
                number = 10 * (19 + 25 * (k-1)) + 2;
                k++;
            }
            return number;
        }
      
    }
}
