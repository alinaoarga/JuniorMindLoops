using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch
{
    [TestClass]
    public class LunchTests
    {
        [TestMethod]
        public void TrueMeetingTest()
        {
            Assert.AreEqual(true, MeetingOccurrence(12));
        }
        [TestMethod]
        public void FalseMeetingTest()
        {
            Assert.AreEqual(false, MeetingOccurrence(16));
        }
        [TestMethod]
        public void MeetingTest()
        {
            Assert.AreEqual(true, MeetingOccurrence(24));
        }
        bool MeetingOccurrence(int day)
        {
            if (day % 4 == 0 && day % 6 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
