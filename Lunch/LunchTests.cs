using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch
{
    [TestClass]
    public class LunchTests
    {
        [TestMethod]
        public void LD1est()
        {
            Assert.AreEqual(2, CalculateLowestDenominator(2, 4));
        }
        [TestMethod]
        public void LD2est()
        {
            Assert.AreEqual(3, CalculateLowestDenominator(33, 75));
        }
        [TestMethod]
        public void LCMTest()
        {
            Assert.AreEqual(6, CalculateLowestCommonMultilpe(2, 3));
        }
        [TestMethod]
        public void LCMT2est()
        {
            Assert.AreEqual(4, CalculateLowestCommonMultilpe(2, 4));
        }

        int CalculateLowestDenominator(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;

                if (b > a)
                    b -= a;
            }
            return a;
        }

        int CalculateLowestCommonMultilpe(int a, int b)
        {
            return (a * b) / CalculateLowestDenominator(a, b);

        }

    }
   /* int MeetingOccurrence(int a, int b)
    {

        while (a % 4 == 0 && b % 6 == 0)
        
            return CalculateLowestCommonMultilpe(a, b);

        
    } */
}

