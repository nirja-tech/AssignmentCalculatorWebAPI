using Microsoft.VisualStudio.TestTools.UnitTesting;

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


    }
}
