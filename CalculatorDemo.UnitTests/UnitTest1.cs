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
        public void Test_Calculator_Calculate_Method()
        {

            // working test
            Calculator calculator = new Calculator("1", "2", "+");
            calculator.Calculate();
            String res = calculator.getResult();
            Assert.AreEqual("3", res);

            // invalid left number
            calculator.setLeft("");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("Error: Invalid Left Number", res);

            // invalid operand
            calculator.setLeft("2");
            calculator.setOperand("");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("Error: Invalid Operand", res);

            // invalid right number
            calculator.setOperand("+");
            calculator.setRight("");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("Error: Invalid Right Number", res);

            // overflow conditions

            string x = decimal.MaxValue.ToString();

            // addition overflow check
            calculator.setLeft(x);
            calculator.setRight("1");
            calculator.setOperand("+");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("Error: overflow", res);

            // multiplication overflow check
            calculator.setLeft(x);
            calculator.setRight("2");
            calculator.setOperand("*");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("Error: overflow", res);

            // subtraction overflow check
            calculator.setLeft(x);
            calculator.setRight("-1");
            calculator.setOperand("-");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("Error: overflow", res);

            // divide by zero check
            calculator.setLeft("2");
            calculator.setRight("0");
            calculator.setOperand("/");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("Error: Divide by Zero", res);

        }

        [TestMethod]
        public void Test_Refactor_Calculate_Method()
        {
            string res;

            // working test
            Refactor ref_calculator = new Refactor();
            ref_calculator.Calculate("1+2+4");
            res = ref_calculator.getResult();
            Assert.AreEqual("7", res);

            // invalid equations
            ref_calculator.Calculate("1+2+x");
            res = ref_calculator.getResult();
            Assert.AreEqual("Error: Invalid Right Number", res);

            ref_calculator.Calculate("1{2+4");
            res = ref_calculator.getResult();
            Assert.AreEqual("Error: Invalid Operand", res);

            // divide by zero
            ref_calculator.Calculate("1/0+4");
            res = ref_calculator.getResult();
            Assert.AreEqual("Error: Divide by Zero", res);

        }

        [TestMethod]
        public void Test_Get_Previous_Result()
        {
            string res;

            // fill buffer

            // 0
            Calculator calculator = new Calculator("5", "4", "+");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("9", res);

            // 1
            calculator.setLeft("3");
            calculator.setRight("2");
            calculator.setOperand("-");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("1", res);


            // 2
            calculator.setLeft("8");
            calculator.setRight("5");
            calculator.setOperand("*");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("40", res);


            // 3
            calculator.setLeft("4");
            calculator.setRight("2");
            calculator.setOperand("/");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("2", res);


            // 4
            calculator.setLeft("9");
            calculator.setRight("6");
            calculator.setOperand("-");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("3", res);

            // 5
            calculator.setLeft("5");
            calculator.setRight("8");
            calculator.setOperand("+");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("13", res);

            // 6
            calculator.setLeft("14");
            calculator.setRight("7");
            calculator.setOperand("/");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("2", res);

            // 7
            calculator.setLeft("5");
            calculator.setRight("4");
            calculator.setOperand("-");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("1", res);

            // 8
            calculator.setLeft("3");
            calculator.setRight("8");
            calculator.setOperand("+");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("11", res);

            // 9
            calculator.setLeft("5");
            calculator.setRight("1");
            calculator.setOperand("+");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("6", res);

            // 10
            calculator.setLeft("100");
            calculator.setRight("50");
            calculator.setOperand("-");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("50", res);


            // check buffer
            res = calculator.getPreviousResult(1);
            Assert.AreEqual("6", res);

            res = calculator.getPreviousResult(10);
            Assert.AreEqual("9", res);

            // check of buffer will loop
            calculator.setLeft("10");
            calculator.setRight("2");
            calculator.setOperand("+");
            calculator.Calculate();
            res = calculator.getResult();
            Assert.AreEqual("12", res);

            res = calculator.getPreviousResult(1);
            Assert.AreEqual("50", res);

            res = calculator.getPreviousResult(10);
            Assert.AreEqual("1", res);



        }

    }
}
