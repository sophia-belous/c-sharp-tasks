using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorAndPolinomLibrary;

namespace task_5_test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestReturnCoordinates()
        {
            Vector vector = new Vector(1, 2, 3);

            double[] actual = vector.Сoordinates;
            double[] expected = { 1, 2, 3 };
            bool tOrF = true;

            if (actual.Length == expected.Length)
            {
                for (int i = 0; i < actual.Length; i++)
                {
                    if (actual[i] != expected[i])
                    {
                        tOrF = false;
                        break;
                    }
                }
            }
            else
                tOrF = false;

            Assert.IsTrue(tOrF);
        }

        [TestMethod]
        public void TestReturnCoordinatesIsFalse()
        {
            Vector vector = new Vector(1, 2, 3);

            double[] actual = vector.Сoordinates;
            double[] expected = { 1, 2, 2 };
            bool tOrF = true;

            if (actual.Length == expected.Length)
            {
                for (int i = 0; i < actual.Length; i++)
                {
                    if (actual[i] != expected[i])
                    {
                        tOrF = false;
                        break;
                    }
                }
            }
            else
                tOrF = false;

            Assert.IsFalse(tOrF);
        }

        [TestMethod]
        public void TestCoordinatesLenthIsFalse()
        {
            Vector vector = new Vector(1, 2, 3);

            double[] actual = vector.Сoordinates;
            double[] expected = { 1, 2 };
            bool tOrF = true;

            if (actual.Length == expected.Length)
            {
                for (int i = 0; i < actual.Length; i++)
                {
                    if (actual[i] != expected[i])
                    {
                        tOrF = false;
                        break;
                    }
                }
            }
            else
                tOrF = false;

            Assert.IsFalse(tOrF);
        }

        [TestMethod]
        public void TestIsTrueEqualOfTwoVectors()
        {
            Vector firstV = new Vector(1, 2, 3);
            Vector secondV = new Vector(1, 2, 3);

            Assert.IsTrue(firstV == secondV);
        }

        [TestMethod]
        public void TestIsTrueEqualOfTwoPolinoms()
        {
            Polinomial firstP = new Polinomial(1, 2, 3);
            Polinomial secondP = new Polinomial(1, 2, 3);

            Assert.IsTrue(firstP == secondP);
        }

        [TestMethod]
        public void TestIsEqualOfTwoPolinoms()
        {
            Polinomial firstP = new Polinomial(1, 2, 3);
            Polinomial secondP = new Polinomial(1, 2, 3);

            Assert.IsTrue(firstP.Equals(secondP));
        }

        [TestMethod]
        public void TestExplisitOfPolinom()
        {
            Polinomial polinom = new Polinomial(1, 2, 3);
            string actual = (string)polinom;
            string expected = "1x^2 + 2x^1 + 3";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestIsNotEqualOfTwoPolinoms()
        {
            Polinomial firstP = new Polinomial(1, 2, 3);
            Polinomial secondP = new Polinomial(1, 2, 1);

            Assert.IsFalse(firstP.Equals(secondP));
        }

        [TestMethod]
        public void TestIsFalseEqualOfTwoVectors()
        {
            Vector firstV = new Vector(1, 2, 3);
            Vector secondV = new Vector(1, 2, 2);

            Assert.IsFalse(firstV == secondV);
        }

        [TestMethod]
        public void TestIsFalseEqualOfTwoPolinoms()
        {
            Polinomial firstP = new Polinomial(1, 2, 3);
            Polinomial secondP = new Polinomial(1, 2, 2);

            Assert.IsFalse(firstP == secondP);
        }

        [TestMethod]
        public void TestIsTrueIneEqualOfTwoVectors()
        {
            Vector firstV = new Vector(1, 2, 3);
            Vector secondV = new Vector(1, 2, 2);

            Assert.IsTrue(firstV != secondV);
        }

        [TestMethod]
        public void TestIsFalseIneEqualOfTwoVectors()
        {
            Vector firstV = new Vector(1, 2, 3);
            Vector secondV = new Vector(1, 2, 3);

            Assert.IsFalse(firstV != secondV);
        }

        [TestMethod]
        public void TestIsTrueIneEqualOfTwoPolinoms()
        {
            Polinomial firstP = new Polinomial(1, 2, 3);
            Polinomial secondP = new Polinomial(1, 2, 2);

            Assert.IsTrue(firstP != secondP);
        }

        [TestMethod]
        public void TestIsFalseIneEqualOfTwoPolinoms()
        {
            Polinomial firstP = new Polinomial(1, 2, 3);
            Polinomial secondP = new Polinomial(1, 2, 3);

            Assert.IsFalse(firstP != secondP);
        }

        [TestMethod]
        public void TestIsGetNumWithIndexCoord()
        {
            Vector vector = new Vector(1, 2, 3);
            double actual = vector.Сoordinates[1];
            double expected = 2;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestIsGetNumWithIndexCoordNotEqual()
        {
            Vector vector = new Vector(1, 2, 3);
            double actual = vector.Сoordinates[1];
            double expected = 0;
            Assert.AreNotEqual(actual, expected);
        }

        [TestMethod]
        public void TestIsGetNumWithIndexCoefsPol()
        {
            Polinomial vector = new Polinomial(1, 2, 3);
            double actual = vector.Coeffs[1];
            double expected = 2;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestIsGetNumWithIndexCoefsPolNotEqual()
        {
            Polinomial vector = new Polinomial(1, 2, 3);
            double actual = vector.Coeffs[1];
            double expected = 0;
            Assert.AreNotEqual(actual, expected);
        }

        [TestMethod]
        public void TestIsSetNumWithIndexCoord()
        {
            Vector vector = new Vector(1, 2, 3);
            vector.Сoordinates[1] = 5;
            double actual = vector.Сoordinates[1];
            double expected = 5;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestIsSetNumWithIndexCoordNotEqual()
        {
            Vector vector = new Vector(1, 2, 3);
            vector.Сoordinates[1] = 5;
            double actual = vector.Сoordinates[1];
            double expected = 2;
            Assert.AreNotEqual(actual, expected);
        }

        [TestMethod]
        public void TestIsEqualSumOperation()
        {
            Vector firstV = new Vector(1, 2, 3);
            Vector secondV = new Vector(2, 3, 4);
            double[] sum = new double[] { 3, 5, 7 };

            Vector actual = firstV + secondV;
            Vector expected = new Vector(sum);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsNotEqualSumOperation()
        {
            Vector firstV = new Vector(1, 2, 3);
            Vector secondV = new Vector(2, 3, 4);
            double[] sum = new double[] { 2, 2, 2 };

            Vector expected = new Vector(sum);
            Vector actual = firstV + secondV;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsEqualDiffOperation()
        {
            Vector firstV = new Vector(2, 3, 4);
            Vector secondV = new Vector(1, 2, 3);
            double[] sum = new double[] { 1, 1, 1 };

            Vector expected = new Vector(sum);
            Vector actual = firstV - secondV;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsNotEqualDiffOperation()
        {
            Vector firstV = new Vector(2, 3, 4);
            Vector secondV = new Vector(1, 2, 3);
            double[] sum = new double[] { 2, 2, 2 };

            Vector expected = new Vector(sum);
            Vector actual = firstV - secondV;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsEqualProdfOperation()
        {
            Vector firstV = new Vector(2, 3, 4);
            Vector secondV = new Vector(1, 2, 3);

            double expected = 20;
            double actual = firstV * secondV;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsNotEqualProdOperation()
        {
            Vector firstV = new Vector(2, 3, 4);
            Vector secondV = new Vector(1, 2, 3);

            double expected = 2;
            double actual = firstV * secondV;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsEqualMethodAngle()
        {
            Vector firstV = new Vector(2, 3, 4);
            Vector secondV = new Vector(1, 2, 3);

            double expected = 0.12186756768575456;
            double actual = Vector.GetAngleBetweenVectors(firstV, secondV);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsNotEqualMethodAngle()
        {
            Vector firstV = new Vector(2, 3, 4);
            Vector secondV = new Vector(1, 2, 3);

            double expected = 0.25;
            double actual = Vector.GetAngleBetweenVectors(firstV, secondV);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsEqualVectorToString()
        {
            Vector vector = new Vector(1, 2, 3);

            string expected = "123";
            string actual = vector.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsNotEqualVectorToString()
        {
            Vector vector = new Vector(1, 2, 3);

            string expected = "1 2 3";
            string actual = vector.ToString();
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TestEqualWithNullVector()
        {
            Vector firstV = new Vector(1, 2, 3);

            bool EqualResult = firstV.Equals(null);
            Assert.IsFalse(EqualResult);
        }

        [TestMethod]
        public void TestEqualWithNullPolinom()
        {
            Polinomial polinom = new Polinomial(1, 2, 3);

            bool EqualResult = polinom.Equals(null);
            Assert.IsFalse(EqualResult);
        }

        [TestMethod]
        public void TestGettingVectorHashCode()
        {
            Vector firstV = new Vector(1, 2, 3);
            Vector secondV = new Vector(1, 2, 3);
            secondV = firstV;
            int actaul = firstV.GetHashCode();
            int expected = secondV.GetHashCode();

            Assert.AreEqual(actaul, expected);
        }

        [TestMethod]
        public void TestGettingPolinomHashCode()
        {
            Vector firstP = new Vector(1, 2, 3);
            Vector secondP = new Vector(1, 2, 3);
            secondP = firstP;
            int actaul = firstP.GetHashCode();
            int expected = secondP.GetHashCode();

            Assert.AreEqual(actaul, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectOfSetNullCoordinates()
        {
            Vector vector = new Vector(1, 2, 3);
            vector.Сoordinates = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectOfCreatVector()
        {
            Vector vector = new Vector(1);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ExpectOfGetNegativeIndexOfCoordinates()
        {
            Vector vector = new Vector(1, 2, 3);
            double negative = vector.Сoordinates[-1];
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ExpectOfGetIndexLenthOfCoordinates()
        {
            Vector vector = new Vector(1, 2, 3);
            double negative = vector.Сoordinates[3];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectOfCreatNullVector()
        {
            Vector vector = new Vector(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectOfSumMethod()
        {
            Vector firstV = new Vector(2, 3, 4);
            Vector secondV = new Vector(1, 2);

            Vector sum = firstV + secondV;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExpectOfNull()
        {
            Polinomial pol = null;
            string str = (string)pol;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectOfDiffMethod()
        {
            Vector firstV = new Vector(2, 3, 4);
            Vector secondV = new Vector(1, 2);

            Vector dif = firstV - secondV;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectOfProdfMethod()
        {
            Vector firstV = new Vector(2, 3, 4);
            Vector secondV = new Vector(1, 2);

            double prod = firstV * secondV;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectOfAnglefMethod()
        {
            Vector firstV = null;
            Vector secondV = new Vector(1, 2);

            double angle = Vector.GetAngleBetweenVectors(firstV, secondV);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectOfCreatPolinom()
        {
            Polinomial polinom = new Polinomial();
        }

        [TestMethod]
        public void TestIsEqualPolinomToString()
        {
            Polinomial vector = new Polinomial(1, 2, 3);

            string expected = "1x^2 + 2x^1 + 3";
            string actual = vector.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsNotEqualPolinomToString()
        {
            Polinomial vector = new Polinomial(1, 2, 3);

            string expected = "123";
            string actual = vector.ToString();
            Assert.AreNotEqual(expected, actual);
        }

    }
}
