using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lottery
{
    [TestClass]
    public class LotteryTests
    {
        [TestMethod]
        public void FactorialTest()
        {
            Assert.AreEqual(608281864034268E+62, CalculateFactorial(49));
        }
        [TestMethod]
        public void CombinatoricsTest()
        {
            Assert.AreEqual(13983816, CalculateComb(6,49));
        }
        [TestMethod]
        public void ProbabilityFor6Test()
        {
            Assert.AreEqual(0.00000007151, CalulateProbability(6, 49, 6));
        }
        [TestMethod]
        public void ProbabilityFor4Test()
        {
            Assert.AreEqual(0.000968, CalulateProbability(6, 49, 4));
        }
        [TestMethod]
        public void ProbabilityFor3Test()
        {
            Assert.AreEqual(0.0175438, CalulateProbability(6, 49, 3));
        }
        [TestMethod]
        public void ProbabilityTest()
        {
            Assert.AreEqual(0.6, CalulateProbability(3, 5, 2));
        }
        double CalculateFactorial(int number)
        {
            double fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        double CalculateComb(int extractNumberOfBalls, int totalNumberOfBalls)
        {
            double combinatorics = CalculateFactorial(totalNumberOfBalls) / (CalculateFactorial(extractNumberOfBalls) * CalculateFactorial(totalNumberOfBalls - extractNumberOfBalls));
            return combinatorics;
        }
        double CalulateProbability(int maxWinningNumberOfBalls, int totalNumberOfBalls, int winningNumberOfBalls)
        {
            double numerator = CalculateComb(winningNumberOfBalls, maxWinningNumberOfBalls) * CalculateComb((maxWinningNumberOfBalls - winningNumberOfBalls), (totalNumberOfBalls - maxWinningNumberOfBalls));
            double denominator = CalculateComb(maxWinningNumberOfBalls, totalNumberOfBalls);
            double probability = numerator / denominator;
            return probability;
        } 
    }
}
