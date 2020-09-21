using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CalculatorDemo
{
    public class Refactor
    {

        private string[] Results = new String[10];
        private int Index = -1;

        public Refactor()
        {
        }

        private int NextIndex()
        {
            if (Index >= 9)
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

        public void Calculate(string equation)
        {
            string total = "";
            string rightNumber = "";
            decimal totalVal;
            decimal rightVal;
            string operand = "";
            int currIndex = 0;
            string result = "";

            if (equation is null)
            {
                Results[NextIndex()] = "Error: Equation is null";
                return;
            }

            if (equation  == "")
            {
                Results[NextIndex()] = "Error: Equation is empty string";
                return;

            }

            // parse first nummber
            total = getNumber(equation, ref currIndex);

            // parse first operand
            operand = getOperand(equation, ref currIndex);

            // parse second number
            rightNumber = getNumber(equation, ref currIndex);

            bool done = false;
            while (currIndex < equation.Length || !done)
            {

                // Convert left to decimal
                if (!decimal.TryParse(total, out totalVal))
                {
                    Results[NextIndex()] = "Error: Invalid Left Number";
                    return;
                }

                // Convert right to decimal
                if (!decimal.TryParse(rightNumber, out rightVal))
                {
                    Results[NextIndex()] = "Error: Invalid Right Number";
                    return;
                }

                // Check valid operand
                if (!CheckOperand(operand))
                {
                    Results[NextIndex()] = "Error: Invalid Operand";
                    return;
                }

                // Perform calculation
                switch (operand)
                {
                    case "+":
                        Add(totalVal, rightVal, out result);
                        break;
                    case "-":
                        Subtract(totalVal, rightVal, out result);
                        break;
                    case "*":
                        Multiply(totalVal, rightVal, out result);
                        break;
                    case "/":
                        Divide(totalVal, rightVal, out result);
                        break;
                }

                // store result
                Results[NextIndex()] = result;

                // update total
                total = result;

                // parse next operand
                operand = getOperand(equation, ref currIndex);

                // parse next number
                if (operand == "")
                    done = true;
                else
                    rightNumber = getNumber(equation, ref currIndex);


            }

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

        private string getNumber(string equation, ref int index)
        {

            string number = "";
            string nextChar = "";

            if (index < equation.Length)
            {
                number = equation.Substring(index, 1);
                ++index;

            }
            else
            {
                return ""; 
            }


            bool done = false;
            while (index < equation.Length && !done)
            {
                nextChar = equation.Substring(index, 1);
                if (!CheckOperand(nextChar))
                {
                    number += nextChar;
                    ++index;
                }
                else
                {
                    done = true;
                }

            }

            return number;
        }

        private string getOperand(string equation, ref int index)
        {
            string operand;

            if (index < equation.Length)
            {
                operand = equation.Substring(index, 1);
                ++index;

            }
            else
            {
                return "";
            }

            return operand;

        }

        public string getPreviousResult(int x)
        {
            // check for allowable value
            if (x > Results.Length)
            {
                return "Error: Request greater than buffer size";
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
