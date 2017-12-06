using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoC_17_RestOf;

namespace AoC_17_RestOf_Test
{
    [TestClass]
    public class UnitTest61
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = @"0	2	7	0";
            int solution = PuzzleSolver.Solve61(input);
            Assert.AreEqual(solution, 5);
        }
    }
}
