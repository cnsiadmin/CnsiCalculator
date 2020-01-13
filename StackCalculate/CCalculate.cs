using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace StackCalculate
{
    
    public class CCalculate
    {
        string m_exceptionClassName = "CCalculate / ";
        /*
            string m_exceptionClassName = "~~ / ";
            try
            {
            }
            catch (Exception _ex)
            {
                Console.WriteLine(m_exceptionClassName + MethodBase.GetCurrentMethod().Name + _ex);
            }

         */
        Stack<string> pre_fix = new Stack<string>();

        public void convertPrefix(string _expression)
        {
            try
            {
                string[] expressionArray = expressionSplit(_expression);
                int openBracket = 0;
                string _exp = "";
                string currentString = "";
                for (int index = 0; index < expressionArray.Length; index++)
                {
                    switch (expressionArray[index])
                    {
                        case "(":
                            openBracket++;
                            pre_fix.Push(expressionArray[index]);
                            break;
                        case ")":
                            openBracket--;
                            while (pre_fix.Peek() != "(")
                            {
                                currentString = pre_fix.Pop();
                                if (currentString != "")
                                    _exp += currentString + "~";
                            }
                            pre_fix.Pop(); //"("제거
                            break;
                        case "*":
                        case "/":
                            
                                while (pre_fix.Count > 0 && (pre_fix.Peek() == "*" || pre_fix.Peek() == "/"))
                                {
                                    currentString = pre_fix.Pop();
                                    if (currentString != "")
                                        _exp += currentString + "~";
                                }
                            
                            pre_fix.Push(expressionArray[index]);
                            break;
                        case "+":
                        case "-":
                            if (pre_fix.Count > 0)
                            {
                                if (openBracket > 0)
                                {
                                    while (pre_fix.Peek() != "(")
                                    {
                                        currentString = pre_fix.Pop();
                                        if (currentString != "")
                                            _exp += currentString + "~";
                                    }
                                }
                                else
                                {
                                    while (pre_fix.Count > 0)
                                    {
                                        currentString = pre_fix.Pop();
                                        if (currentString != "")
                                            _exp += currentString + "~";


                                    }
                                }
                            }
                            
                            pre_fix.Push(expressionArray[index]);
                            break;
                        case "":
                            break;
                        default:
                            if (expressionArray[index] != "")
                                _exp += expressionArray[index] + "~";
                            break;
                    }

                }

                while(pre_fix.Count > 0)
                {
                    currentString = pre_fix.Pop();
                    if (currentString != "")
                        _exp += currentString + "~";
                }
                Console.WriteLine(_exp);
                expression_calculate(_exp);
            }
            catch (Exception _ex)
            {
                Console.WriteLine(m_exceptionClassName + MethodBase.GetCurrentMethod().Name + _ex);
            }
        } 
        string[] expressionSplit(string _expression)
        {
            try
            {
                int length = _expression.Length;
                List<string> expressionArray = new List<string>();
                string number = "";
                for (int index = 0;index < length; index++)
                {
                    string temp = _expression.Substring(index, 1);
                    if(temp == "+" || temp == "-"|| temp == "*"|| temp == "/" || temp == "(" || temp == ")")
                    {
                        expressionArray.Add(number);
                        number = "";
                        expressionArray.Add(temp);
                    }
                    else
                    {
                        number += temp;
                    }
                }
                if(number != "")
                    expressionArray.Add(number);
                return expressionArray.ToArray();
            }
            catch (Exception _ex)
            {
                Console.WriteLine(m_exceptionClassName + MethodBase.GetCurrentMethod().Name + _ex);
            }
            return null;
        }

        public double expression_calculate(string _expression)
        {
            double answer = 0.0;
            try
            {
                string[] splitExp = _expression.Split('~');
                Stack<string> expArray = new Stack<string>();
                double num1;
                double num2;
                for (int index = 0; index < splitExp.Length; index++)
                {
                    if(splitExp[index] == "+")
                    {
                        num2 = double.Parse(expArray.Pop());
                        num1 = double.Parse(expArray.Pop());
                        expArray.Push((num1 + num2).ToString());
                    }
                    else if(splitExp[index] == "-")
                    {
                        num2 = double.Parse(expArray.Pop());
                        num1 = double.Parse(expArray.Pop());
                        expArray.Push((num1 - num2).ToString());
                    }
                    else if (splitExp[index] == "*")
                    {
                        num2 = double.Parse(expArray.Pop());
                        num1 = double.Parse(expArray.Pop());
                        expArray.Push((num1 * num2).ToString());
                    }
                    else if (splitExp[index] == "/")
                    {
                        num2 = double.Parse(expArray.Pop());
                        num1 = double.Parse(expArray.Pop());
                        expArray.Push((num1 / num2).ToString());
                    }
                    else
                    {
                        expArray.Push(splitExp[index]);
                    }
                }
                while (expArray.Count > 0)
                {
                    string s = expArray.Pop();
                    if (s != "")
                        Console.WriteLine(s);
                }

                return answer;
            }
            catch (Exception _ex)
            {
                return 0.0;
                Console.WriteLine(m_exceptionClassName + MethodBase.GetCurrentMethod().Name + _ex);
            }
            return 0.0;

        }
    }
}
