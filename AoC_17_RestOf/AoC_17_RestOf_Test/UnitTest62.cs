using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoC_17_RestOf;

namespace AoC_17_RestOf_Test
{
    [TestClass]
    public class UnitTest62
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = @"0	2	7	0";
            int solution = PuzzleSolver.Solve62(input);
            Assert.AreEqual(solution, 4);
        }
    }
}
