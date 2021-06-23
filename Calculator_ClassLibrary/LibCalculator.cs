using System;

namespace Calculator_ClassLibrary
{
    public class LibCalculator
    {
        static public double add(double leftNumber, double rightNumber)
        {
            return leftNumber + rightNumber;
        }

        static public double sub(double leftNumber, double rightNumber)
        {
            return leftNumber - rightNumber;
        }

        static public double mul(double leftNumber, double rightNumber)
        {
            return leftNumber * rightNumber;
        }

        static public double div(double leftNumber, double rightNumber)
        {
            // check if right number can not be zero or grater then zero
            if (rightNumber > 0)
                return leftNumber / rightNumber;
            throw new DivideByZeroException("Number can not be zero");
        }
    }

}
