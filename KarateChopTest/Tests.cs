using System;
using KarateChop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KarateChopTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestEasyChop()
        {
            TestImplementation(Program.EasyChop);
        }

        [TestMethod]
        public void TestIterativeChop()
        {
            TestImplementation(Program.IterativeChop);
        }
        [TestMethod]
        public void TestRecursiveChop()
        {
            TestImplementation(Program.RecursiveChop);
        }

        private static void TestImplementation(Func<int, int[], int> chop)
        {
            Assert.AreEqual(-1, chop(3, new int[] {}));
            Assert.AreEqual(-1, chop(3, new[] {1}));
            Assert.AreEqual(0, chop(1, new[] {1}));


            Assert.AreEqual(0, chop(1, new[] {1, 3, 5}));
            Assert.AreEqual(1, chop(3, new[] {1, 3, 5}));
            Assert.AreEqual(2, chop(5, new[] {1, 3, 5}));
            Assert.AreEqual(-1, chop(0, new[] {1, 3, 5}));
            Assert.AreEqual(-1, chop(2, new[] {1, 3, 5}));
            Assert.AreEqual(-1, chop(4, new[] {1, 3, 5}));
            Assert.AreEqual(-1, chop(6, new[] {1, 3, 5}));


            Assert.AreEqual(0, chop(1, new[] {1, 3, 5, 7}));
            Assert.AreEqual(1, chop(3, new[] {1, 3, 5, 7}));
            Assert.AreEqual(2, chop(5, new[] {1, 3, 5, 7}));
            Assert.AreEqual(3, chop(7, new[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, chop(0, new[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, chop(2, new[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, chop(4, new[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, chop(6, new[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, chop(8, new[] {1, 3, 5, 7}));
        }
    }
}
