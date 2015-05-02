using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryOfGetNODMethods;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsNod32and16Equals16Evclide()
        {
            int expected = 16;
            int actual = NODGetting.GetNODWithEvclide(32, 16);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyTestMethod1()
        {
            int expected = 12;
            int actual = NODGetting.GetNODWithEvclide(32, 16);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MyTestMethod2()
        {
            int actual = NODGetting.GetNODWithEvclide(32); 
        }

        [TestMethod]
        public void MyTestMethod3()
        {
            int expected = 16;
            int actual = NODGetting.GetNODWithEvclide(-32, -16);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyTestMethod4()
        {
            int expected = 9;
            int actual = NODGetting.GetNODWithEvclide(-54, 9);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyTestMethod5()
        {
            int expected = 3;
            int actual = NODGetting.GetNODWithEvclide(54, 9, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyTestMethod6()
        {
            int expected = 2;
            int actual = NODGetting.GetNODWithEvclide(2, 4, -6, 8);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsNod32and16Equals16Stain()
        {
            int expected = 16;
            int actual = NODGetting.GetNODWithStain(32, 16);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyTestMethod1Stain()
        {
            int expected = 12;
            int actual = NODGetting.GetNODWithStain(32, 16);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MyTestMethod2Stein()
        {
            int actual = NODGetting.GetNODWithStain(32);
        }

        [TestMethod]
        public void MyTestMethod3Stain()
        {
            int expected = 16;
            int actual = NODGetting.GetNODWithStain(-32, -16);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyTestMethod4Stain()
        {
            int expected = 9;
            int actual = NODGetting.GetNODWithStain(-54, 9);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyTestMethod5Stain()
        {
            int expected = 3;
            int actual = NODGetting.GetNODWithStain(54, 9, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MyTestMethod6Stain()
        {
            int expected = 2;
            int actual = NODGetting.GetNODWithStain(2, 4, -6, 8);
            Assert.AreEqual(expected, actual);
        }




    }
}
