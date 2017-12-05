using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoC_17_RestOf;

namespace AoC_17_RestOf_Test
{
    [TestClass]
    public class UnitTest51
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = @"0
3
0
1
-3";
            int solution = PuzzleSolver.Solve51(input);
            Assert.AreEqual(solution, 5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = @"0
0
0
0
0";
            int solution = PuzzleSolver.Solve51(input);
            Assert.AreEqual(solution, 10);
        }
       
    }
}
