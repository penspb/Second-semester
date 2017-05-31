using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    /// <summary>
    /// parse tree
    /// </summary>
    public class Parse
    {
        /// <summary>
        /// root of tree;
        /// </summary>
        private Operator root;
         
        /// <summary>
        /// create new string based on pair of brackes
        /// </summary>
        /// <param name="workingString">previos string</param>
        /// <param name="i">position of (</param>
        /// <returns>new string</returns>
        private string CreateNewString(string workingString, ref int i)
        {
            int quantityOpenBrackets = 1;
            string newString = "(";
            int j = i + 1;

            while (quantityOpenBrackets != 0)
            {
                if (workingString[j] == '(')
                {
                    quantityOpenBrackets++;
                }

                if (workingString[j] == ')')
                {
                    quantityOpenBrackets--;
                }

                newString += workingString[j];
                j++;
            }

            i = j;
            return newString;
        }

        /// <summary>
        /// parse tree
        /// </summary>
        /// <param name="workingString">expression</param>
        private Operator Build(string workingString)
        {
            if (workingString[0] != '(')
            {
                throw new IncorrectException("Incorrect expression");
            }

            KnotOfTree leftSon = null;
            KnotOfTree rightSon = null;

            int i = 0;

            if (workingString[i] == ' ')
            {
                i++;
            }
            
            if (workingString[i] == '(')
            {
                workingString = workingString.Substring(1, workingString.Length - 2);
            }

            char sign = workingString[i];
            i++;

            if (workingString[i] == ' ')
            {
                i++;
            }

            if (workingString[i] == '(')
            {
                leftSon = Build(CreateNewString(workingString, ref i));
            }
            else
            {
                if (workingString[i] >= '0' && workingString[i] <= '9')
                {
                    leftSon = new Operand(Convert.ToInt32(workingString[i]) - Convert.ToInt32('0'));
                }

                i++;
            }

            if (workingString[i] == ' ')
            {
                i++;
            }

            if (workingString[i] == '(')
            {
                rightSon = Build(CreateNewString(workingString, ref i));
            }
            else
            {
                if (workingString[i] >= '0' && workingString[i] <= '9')
                {
                    rightSon = new Operand(Convert.ToInt32(workingString[i]) - Convert.ToInt32('0'));
                }

                i++;
            }

            var newOperator = new Operator(sign);
            newOperator.LeftSon = leftSon;
            newOperator.RightSon = rightSon;

            return newOperator;
        }

        /// <summary>
        /// build parse tree
        /// </summary>
        /// <param name="workingString">expression</param>
        public void RealizeBuild(string workingString) => this.root = Build(workingString);

        /// <summary>
        /// calculate tree
        /// </summary>
        public int Calculate(string expression)
        {
            RealizeBuild(expression);
            return root.Count();
        }

        /// <summary>
        /// print tree
        /// </summary>
        public string PrintTree() => root.Print();
    }
}