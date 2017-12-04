﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoC_17_3;

namespace AoC_17_3_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int input = 1;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 0);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int input = 12;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 3);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int input = 23;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 2);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int input = 1024;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 31);
        }


        [TestMethod]
        public void TestMethod5()
        {
            int input = 29;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 4);
        }



        [TestMethod]
        public void TestMethod6()
        {
            int input = 36;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 5);
        }



        [TestMethod]
        public void TestMethod7()
        {
            int input = 43;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 6);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int input = 50;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 7);
        }

        [TestMethod]
        public void TestMethod9()
        {
            int input = 55;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 6);
        }

        [TestMethod]
        public void TestMethod10()
        {
            int input = 57;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 8);
        }

        [TestMethod]
        public void TestMethod11()
        {
            int input = 63;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 6);
        }


        [TestMethod]
        public void TestMethod12()
        {
            int input = 65;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 8);
        }


        [TestMethod]
        public void TestMethod13()
        {
            int input = 67;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 6);
        }


        [TestMethod]
        public void TestMethod14()
        {
            int input = 73;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 8);
        }

        [TestMethod]
        public void TestMethod15()
        {
            int input = 75;
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 6);
        }
    }
}
