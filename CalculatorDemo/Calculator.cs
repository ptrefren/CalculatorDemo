using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    public class Calculator
    {

        private string Left;
        private string Right;
        private string Operand;
        private string[] Results = new String[11];
        private int Index = -1;

        public Calculator(string left, string right, string operand)
        {
            setLeft(left);
            setRight(right);
            setOperand(operand);
        }

        public void setLeft(string left)
        {
            Left = left;
        }

        public void setRight(string right)
        {
            Right = right;
        }

        public void setOperand(string operand)
        {
            Operand = operand;
        }

        private int NextIndex()
        {
            if (Index >= Results.Length - 1)
                Index = 0;
            else
                ++Index;

            return Index;
        }

        public static bool Add(decimal left, decimal right, out string result)
        {
            decimal temp;

            try
            {
                temp = left + right;
                result = temp.ToString();
                return true;
            }
            catch (OverflowException)
            {
                // overflow error
                result = "Error: overflow";
                return false;
            }

        }

        public static bool Subtract(decimal left, decimal right, out string result)
        {
            decimal temp;

            try
            {
                temp = left - right;
                result = temp.ToString();
                return true;
            }
            catch (OverflowException)
            {
                // overflow error
                result = "Error: overflow";
                return false;
            }

        }

        public static bool Multiply(decimal left, decimal right, out string result)
        {
            decimal temp;

            try
            {
                temp = left * right;
                result = temp.ToString();
                return true;
            }
            catch (OverflowException)
            {
                // overflow error
                result = "Error: overflow";
                return false;
            }


        }

        public static bool Divide(decimal left, decimal right, out string result)
        {
            decimal temp;

            if (right == 0)
            {
                result = "Error: Divide by Zero";
                return false;

            }

            try
            {
                temp = left / right;
                result = temp.ToString();
                return true;
            }
            catch (OverflowException)
            {
                // overflow error
                result = "Error: overflow";
                return false;
            }
        }

        public void Calculate()
        {

            decimal parsedLeft;
            decimal parsedRight;
            string result = "";

            // Convert left to decimal
            if (!decimal.TryParse(Left, out parsedLeft))
            {
                Results[NextIndex()] = "Error: Invalid Left Number";
                return;
            }

            // Convert right to decimal
            if (!decimal.TryParse(Right, out parsedRight))
            {
                Results[NextIndex()] = "Error: Invalid Right Number";
                return;
            }

            // Check valid operand
            if (!CheckOperand(Operand))
            {
                Results[NextIndex()] = "Error: Invalid Operand";
                return;
            }

            // Perform calculation
            switch (Operand)
            {
                case "+":
                    Add(parsedLeft, parsedRight, out result);
                    break;
                case "-":
                    Subtract(parsedLeft, parsedRight, out result);
                    break;
                case "*":
                    Multiply(parsedLeft, parsedRight, out result);
                    break;
                case "/":
                    Divide(parsedLeft, parsedRight, out result);
                    break;
            }

            // Store result
            Results[NextIndex()] = result;

        }

        public static bool CheckOperand(string operand)
        {
            if (operand == "+" || operand == "-" || operand == "*" || operand == "/")
                return true;
            else 
                return false;

        }

        public string getResult()
        {
            if (Index > -1)
                return Results[Index];

            return "No Calculations Performed";

        }

        public string getPreviousResult(int x)
        {
            // check for allowable value
            if ((x < 1) || (x > Results.Length - 1))
            {
                int temp = Results.Length - 1;
                return "Error: Index must between 1 and " + temp.ToString();
            }

            // calculate the index
            int pos = Index - x;
            if (pos < 0)
                pos = Results.Length - Math.Abs(pos);

            // check for empty buffer value
            if (Results[pos] is null)
                return "Error: Not enough calculations performed";

            // return result
            return Results[pos];

        }
    }
}
