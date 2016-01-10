using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class PanagramTests
    {

        [TestMethod]
        public void FirstPangramTest()
        {
            Assert.AreEqual(true, PanagramCheck("Pack my box with five dozen liquor jugs"));
        }
        [TestMethod]
        public void SecondPangramTest()
        {
            Assert.AreEqual(false, PanagramCheck("bla bla"));
        }
        [TestMethod]
        public void ThirdPangramTest()
        {
            Assert.AreEqual(false, PanagramCheck("shfkjasjddvjdjjdjdjfjfjfjfjfjfjfjfjf"));
        }
        [TestMethod]
        public void AllPangramTest()
        {
            Assert.AreEqual(true, PanagramCheck("abcde fghijklmnopq rstuvwxyz"));
        }
        [TestMethod]
        public void FoxPangramTest()
        {
            Assert.AreEqual(true, PanagramCheck("The quick brown fox jumps over the lazy dog"));
        }
        bool PanagramCheck(string name)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < alphabet.Length; i++)
            {
                int index = name.IndexOf(alphabet[i]);
                if (index > alphabet.Length)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
