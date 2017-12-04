using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoC_17_4_2;

namespace AoC_17_4_2_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "abcde fghij";
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "abcde xyz ecdab";
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 0);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "a ab abc abd abf abj";
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 1);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = @"iiii oiii ooii oooi oooo";
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 1);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string input = @"oiii ioii iioi iiio";
            int solution = PuzzleSolver.Solve(input);
            Assert.AreEqual(solution, 0);
        }

        //[TestMethod]
        //public void TestMethod5()
        //{
        //    int input = 29;
        //    int solution = PuzzleSolver.Solve(input);
        //    Assert.AreEqual(solution, 4);
        //}



        //[TestMethod]
        //public void TestMethod6()
        //{
        //    int input = 36;
        //    int solution = PuzzleSolver.Solve(input);
        //    Assert.AreEqual(solution, 5);
        //}



        //[TestMethod]
        //public void TestMethod7()
        //{
        //    int input = 43;
        //    int solution = PuzzleSolver.Solve(input);
        //    Assert.AreEqual(solution, 6);
        //}

        //[TestMethod]
        //public void TestMethod8()
        //{
        //    int input = 50;
        //    int solution = PuzzleSolver.Solve(input);
        //    Assert.AreEqual(solution, 7);
        //}

        //[TestMethod]
        //public void TestMethod9()
        //{
        //    int input = 55;
        //    int solution = PuzzleSolver.Solve(input);
        //    Assert.AreEqual(solution, 6);
        //}

        //[TestMethod]
        //public void TestMethod10()
        //{
        //    int input = 57;
        //    int solution = PuzzleSolver.Solve(input);
        //    Assert.AreEqual(solution, 8);
        //}

        //[TestMethod]
        //public void TestMethod11()
        //{
        //    int input = 63;
        //    int solution = PuzzleSolver.Solve(input);
        //    Assert.AreEqual(solution, 6);
        //}


        //[TestMethod]
        //public void TestMethod12()
        //{
        //    int input = 65;
        //    int solution = PuzzleSolver.Solve(input);
        //    Assert.AreEqual(solution, 8);
        //}


        //[TestMethod]
        //public void TestMethod13()
        //{
        //    int input = 67;
        //    int solution = PuzzleSolver.Solve(input);
        //    Assert.AreEqual(solution, 6);
        //}


        //[TestMethod]
        //public void TestMethod14()
        //{
        //    int input = 73;
        //    int solution = PuzzleSolver.Solve(input);
        //    Assert.AreEqual(solution, 8);
        //}

        //[TestMethod]
        //public void TestMethod15()
        //{
        //    int input = 75;
        //    int solution = PuzzleSolver.Solve(input);
        //    Assert.AreEqual(solution, 6);
        //}
    }
}
