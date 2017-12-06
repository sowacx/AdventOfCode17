using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoC_17_1;

namespace AoC_17_1_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "1122";
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 3);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "1111";
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 4);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "1234";
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 0);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "91212129";
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 9);
        }
    }
}
