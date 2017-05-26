using System;

namespace _2._4
{
    public class Calculator
    {
        private IStack stack;

        /// <summary>
        /// create calculator stack
        /// </summary>
        public Calculator(IStack stack)
        {
            this.stack = stack;
        }

        /// <summary>
        /// analisis of operator
        /// </summary>
        /// <param name="workingOperator">symbol</param>
        public void Operate(char workingOperator)
        {
            int value1 = stack.Pop();
            int value0 = stack.Pop();

            switch (workingOperator)
            {
                case '+':
                    {
                        stack.Push(value0 + value1);
                        break;
                    }

                case '-':
                    {
                        stack.Push(value0 - value1);
                        break;
                    }

                case '*':
                    {
                        stack.Push(value0 * value1);
                        break;
                    }

                case '/':
                    {
                        stack.Push(value0 / value1);
                        break;
                    }

                default:
                    break;
            }
        }

        /// <summary>
        /// calculate the result
        /// </summary>
        /// <param name="workingString">inpute line</param>
        /// <returns>result</returns>
        public int Result(string workingString)
        {
            int number = 0;
            bool check = false;
            int i = 0;
            while (i < workingString.Length)
            {
                if ((workingString[i] == '/') || (workingString[i] == '*') || (workingString[i] == '-') || (workingString[i] == '+'))
                {
                    Operate(workingString[i]);
                    i++;
                }
                else
                {
                    if ((workingString[i] >= '0') && (workingString[i] <= '9'))
                    {
                        while (workingString[i] != ' ')
                        {
                            number = number * 10 + Convert.ToInt32(workingString[i] - '0');
                            i++;
                        }

                        check = true;
                    }
                    else
                    {
                        if (check)
                        {
                            stack.Push(number);
                            check = false;
                            number = 0;
                        }

                        i++;
                    }
                }
            }

            return stack.Pop();
        }
    }
}
