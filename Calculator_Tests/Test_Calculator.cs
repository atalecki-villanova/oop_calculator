using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Tests
{
    [TestClass]
    public class Test_Calculator
    {
        [TestMethod]
        public void Test_Addition()
        {
            double lhs = 3.1;
            double rhs = 2.9;
            Logic_Interfaces.IBinaryOperation addition = new Logic.Addition();
            double result = addition.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(6.0, result);
        }

        [TestMethod]
        public void Test_Divide()
        {
            double lhs = 12.0;
            double rhs = 3.0;
            Logic_Interfaces.IBinaryOperation division = new Logic.Division();
            double result = division.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(4.0, result);
        }

        [TestMethod]
        public void Test_Subtraction()
        {
            double lhs = 100.00;
            double rhs = 50.0;
            Logic_Interfaces.IBinaryOperation subtraction = new Logic.Subtraction();
            double result = subtraction.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(50.0, result);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            double lhs = 12.0;
            double rhs = 12.0;
            Logic_Interfaces.IBinaryOperation multiply = new Logic.Multiplication();
            double result = multiply.Perform_binary_calculation(lhs, rhs);
            Assert.AreEqual(144.0, result);
        }

        [TestMethod]
        public void Test_Sqrt()
        {
            double input = 64.00;
            Logic_Interfaces.IBinaryOperation sqrt = new Logic.SqareRoot();
            double result = sqrt.Perform_binary_calculation(input, 0.0);
            Assert.AreEqual(8.0, result);
        }

        [TestMethod]
        public void Test_Recipricol()
        {
            double input = 5.0;
            Logic_Interfaces.IBinaryOperation recip = new Logic.Reciprocal();
            double result = recip.Perform_binary_calculation(input, 0.0);
            Assert.AreEqual(.2, result);
        }
    }
}
