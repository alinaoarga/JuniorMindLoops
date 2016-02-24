using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class PanagramTests
    {

        [TestMethod]
        public void BoxPangramTest()
        {
            Assert.AreEqual(true, PanagramCheck("Pack my box with five dozen liquor jugs"));
        }

        [TestMethod]
        public void AnaPangramTest()
        {
            Assert.AreEqual(false, PanagramCheck("ana"));
        }
        [TestMethod]
        public void AllPangramTest()
        {
            Assert.AreEqual(true, PanagramCheck(" We promptly judged antique ivory buckles for the next prize"));
        }
        [TestMethod]
        public void FoxPangramTest()
        {
            Assert.AreEqual(true, PanagramCheck("The quick brown fox jumps over the lazy dog"));
        }
        [TestMethod]
        public void JimPangramTest()
        {
            Assert.AreEqual(true, PanagramCheck("Jim quickly realized that the beautiful gowns are expensive"));
        }
        [TestMethod]
        public void JockPangramTest()
        {
            Assert.AreEqual(true, PanagramCheck("Mr. Jock, TV quiz PhD, bags few lynx"));
        }
        [TestMethod]
        public void LongPangramTest()
        {
            Assert.AreEqual(false, PanagramCheck("A pangram is a sentence that contains all letters of the alphabet"));
        }

        bool PanagramCheck(string word)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string lowName = word.ToLower();
            foreach (char letter in alphabet)
              if (!lowName.Contains(letter.ToString()))
                    return false;
            return true;
        }
    }

}



