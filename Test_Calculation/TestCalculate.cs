using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_Calculation
{
    [TestClass]
    public class TestCalculate
    {
        [TestMethod]
        [TestCategory("Addition")]
        // This Test method checks whether adding two positive number returns a positive result or not
        public void TestingAddingPositiveNumbersReturnPositiveResult()
        {
            double left = 3;
            double right = 2;
            double result = Calculator_ClassLibrary.LibCalculator.add(left, right);
            Assert.AreEqual(5d, result);
        }

        [TestMethod]
        [TestCategory("Addition")]
        // This Test method check whether adding numbers having double datatypes returns double or not
        public void TestAddingDoubleReturnsDouble()
        {
            double left = 3;
            double right = 2;
            object result = Calculator_ClassLibrary.LibCalculator.add(left, right);
            Assert.IsInstanceOfType(result, typeof(double));
        }

        [TestMethod]
        [TestCategory("Addition")]
        // This Test method check whether adding two negative numbers returns negative result or not 
        public void TestAddingNegativeNumbersReturnNegative()
        {
            double left = -3;
            double right = -2;
            double result = Calculator_ClassLibrary.LibCalculator.add(left, right);
            Assert.IsTrue(result < 0);
        }

        [TestMethod]
        [TestCategory("Addition")]
        // This Test method check result should not depend upon numbers order
        public void TestGetsSameResultEvenAfterOrderChanged()
        {
            double left = 3;
            double right = 2;
            double result = Calculator_ClassLibrary.LibCalculator.add(left, right);
            double result1 = Calculator_ClassLibrary.LibCalculator.add(right, left);
            Assert.IsTrue(result == result1);
        }

        [TestMethod]
        [TestCategory("Subtraction")]
        // This Test method check big number subtracts from small number returns negative result
        public void TestLargerNumberSubtractedFromSmallerRetrunNegative()
        {
            double left = 2;
            double right = 3;
            double result = Calculator_ClassLibrary.LibCalculator.sub(left, right);

            Assert.AreEqual(-1, result);
        }


        [TestMethod]
        [TestCategory("Subtraction")]
        // This Test method check small number subtracts from big number returns positive result
        public void TestSmallerNumberSubtractedFromLargerRetrunPositive()
        {
            double left = 3;
            double right = 2;
            double result = Calculator_ClassLibrary.LibCalculator.sub(left, right);

            Assert.AreEqual(1, result);
        }


        [TestMethod]
        [TestCategory("Subtraction")]
        // This Test method check when Similar numbers Subtract then result is zero
        public void TestResultShouldBeZaroIfNumbersAreSimilar()
        {
            double left = 3;
            double right = 3;
            double result = Calculator_ClassLibrary.LibCalculator.sub(left, right);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [TestCategory("Subtraction")]
        // Returns Zero if Both Numbers are zero
        public void TestRsultShouldBeZeroIfBothNumbersAreZero()
        {
            double left = 0;
            double right = 0;
            double result = Calculator_ClassLibrary.LibCalculator.sub(left, right);

            Assert.AreEqual(0, result);
        }


        [TestMethod]
        [TestCategory("Division")]
        // This Test method check whether number divided by zero gives exception or not
        public void DivdingByZaroResultException()
        {
            double left = 3;
            double right = 0;

            Assert.ThrowsException<DivideByZeroException>(() => Calculator_ClassLibrary.LibCalculator.div(left, right));

        }



        [TestMethod]
        [TestCategory("Division")]
        // This Test method check output is differnt if order of the numbers changed
        public void TestOutputDependsOnNumbersOrder()
        {
            double left = 20;
            double right = 2;

            double result = Calculator_ClassLibrary.LibCalculator.div(left, right);
            double result1 = Calculator_ClassLibrary.LibCalculator.add(right, left);
            Assert.IsTrue(result != result1);
        }

        [TestMethod]
        [TestCategory("Multiplication")]
        // This Test method checks that output is zero if one of the number is zero
        public void TestOutputShouldBeZeroIfOneValueIsZero()
        {
            double left = 20;
            double right = 0;

            double result = Calculator_ClassLibrary.LibCalculator.mul(left, right);

            Assert.AreEqual(0, result);
        }


        [TestMethod]
        [TestCategory("Multiplication")]
        // This Test method checks that if numbers are positive then it should returns positive result
        public void TestMultiplyingPositiveNumberShouldReturnPositiveResult()
        {
            double left = 20;
            double right = 10;

            double result = Calculator_ClassLibrary.LibCalculator.mul(left, right);

            Assert.AreEqual(200, result);
        }

        [TestMethod]
        [TestCategory("Multiplication")]
        // This Test method check output would not be differnt if order of the numbers changed
        public void TestOutputDoesNotDependOnNumbersOrder()
        {
            double left = 20;
            double right = 10;

            double result = Calculator_ClassLibrary.LibCalculator.mul(left, right);
            double result1 = Calculator_ClassLibrary.LibCalculator.mul(right, left);
            Assert.IsTrue(result == result1);
        }

    }
}
