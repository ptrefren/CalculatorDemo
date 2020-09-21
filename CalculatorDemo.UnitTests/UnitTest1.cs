using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorDemo;

namespace CalculatorDemo.UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Test_Add_Method()
        {
            string res;

            Calculator.Add(1, 2, out res);
            Assert.AreEqual("3", res);
        }

        [TestMethod]
        public void Test_Subtract_Method()
        {
            string res;

            Calculator.Subtract(3, 1, out res);
            Assert.AreEqual("2", res);
        }

        [TestMethod]
        public void Test_Multiply_Method()
        {
            string res;

            Calculator.Multiply(2, 5, out res);
            Assert.AreEqual("10", res);
        }

        [TestMethod]
        public void Test_Divide_Method()
        {
            string res;

            Calculator.Divide(9, 3, out res);
            Assert.AreEqual("3", res);
        }

        [TestMethod]
        public void Test_CheckOperand_Method()
        {
            Assert.IsTrue(Calculator.CheckOperand("/"));
            Assert.IsTrue(!Calculator.CheckOperand(""));
            Assert.IsTrue(!Calculator.CheckOperand("A"));

        }

        [TestMethod]
        public void Test_Calculate_Method()
        {

            Calculator calculator = new Calculator("1", "2", "+");
            calculator.Calculate();
            String res = calculator.getResult();
            Assert.AreEqual("3", res);

        }

        [TestMethod]
        public void Test_Refactor_Calculate_Method()
        {
            string res;

            Refactor ref_calculator = new Refactor();
            ref_calculator.Calculate("1+2+4");
            res = ref_calculator.getResult();
            Assert.AreEqual("7", res);

        }

    }
}
