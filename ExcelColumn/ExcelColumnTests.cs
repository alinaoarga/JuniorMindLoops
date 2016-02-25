using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumn
{
    [TestClass]
    public class ExcelColumnTests
    {
        [TestMethod]
        public void NumberToCTest()
        {
            Assert.AreEqual("C", ColumnNumberToColumnLetter(3));
        }
        [TestMethod]
        public void NumberToOTest()
        {
            Assert.AreEqual("O", ColumnNumberToColumnLetter(15));
        }
        [TestMethod]
        public void NumberToAATest()
        {
            Assert.AreEqual("AA", ColumnNumberToColumnLetter(27));
        }
        [TestMethod]
        public void NumberToAZTest()
        {
            Assert.AreEqual("AZ", ColumnNumberToColumnLetter(52));
        }
        [TestMethod]
        public void NumberToBATest()
        {
            Assert.AreEqual("BA", ColumnNumberToColumnLetter(53));
        }
        string ColumnNumberToColumnLetter(int columnNumber)
        {
            string columnLetter = String.Empty;
            int number = 0;
            while (columnNumber > 0)
            {
                number = (columnNumber - 1) % 26;
                columnNumber = (columnNumber - 1) / 26;
                columnLetter = Convert.ToChar(65 + number).ToString() + columnLetter;
            }
            return columnLetter;
        }
    }
}
