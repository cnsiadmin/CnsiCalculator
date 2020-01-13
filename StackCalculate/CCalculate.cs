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
                                Console.Write(pre_fix.Pop()+" ");
                            }
                            pre_fix.Pop(); //"("제거
                            break;
                        case "*":
                        case "/":
                            pre_fix.Push(expressionArray[index]);
                            break;
                        case "+":
                        case "-":
                            if(pre_fix.Count > 0)
                            if(openBracket > 0)
                            {
                                while(pre_fix.Peek() != "(")
                                {
                                    Console.Write(pre_fix.Pop() + " ");
                                }
                            }
                            else
                            {
                                while (pre_fix.Count > 0)
                                {
                                    Console.Write(pre_fix.Pop() + " ");

                                }
                            }
                            pre_fix.Push(expressionArray[index]);
                            break;
                        case "":
                            break;
                        default:
                            Console.Write(expressionArray[index] + " ");
                            break;
                    }

                }

                while(pre_fix.Count > 0)
                {
                       Console.Write(pre_fix.Pop());
                }
                Console.WriteLine();
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
                return expressionArray.ToArray();
            }
            catch (Exception _ex)
            {
                Console.WriteLine(m_exceptionClassName + MethodBase.GetCurrentMethod().Name + _ex);
            }
            return null;
        }
    }
}
