﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoC_17_RestOf;

namespace AoC_17_RestOf_Test
{
    [TestClass]
    public class UnitTest52
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = @"0
3
0
1
-3";
            int solution = PuzzleSolver.Solve52(input);
            Assert.AreEqual(solution, 10);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = @"0
0
0
0
0";
            int solution = PuzzleSolver.Solve52(input);
            Assert.AreEqual(solution, 10);
        }

    }
}
