using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    internal class Operator : KnotOfTree
    {
        /// <summary>
        /// sign of operator
        /// </summary>
        private char TypeOfOperator;

        /// <summary>
        /// constructor of operstor
        /// </summary>
        /// <param name="sign"></param>
        public Operator(char sign)
        {
            TypeOfOperator = sign;
        }

        /// <summary>
        /// function: count the reult of expression
        /// </summary>
        /// <returns>result</returns>
        public override int Count()
        {
            int value0 = LeftSon.Count();
            int value1 = RightSon.Count();

            switch (TypeOfOperator)
            {
                case '+':
                    return value0 + value1;

                case '*':
                    return value0 * value1;

                case '-':
                    return value0 - value1;

                case '/':
                    if (value1 == 0)
                    {
                        throw new DivisionByZeroException("Division by zero");
                    }
                    return value0 / value1;

                default:
                    throw new IncorrectException("Incorrect expression");
            }
        }

        public override string Print()
        {
            return ("(" + TypeOfOperator + LeftSon.Print() + RightSon.Print() + ")");
        }
    }
}
