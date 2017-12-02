using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoC_17_2;

namespace AoC_17_2_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = @"5	1	9	5
7	5	3
2	4	6	8";
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 18);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = @"1236	741
                             2134	106";
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 2523);
        }

    }
}
