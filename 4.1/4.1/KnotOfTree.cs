using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    /// <summary>
    /// class knot of tree
    /// </summary>
    abstract class KnotOfTree
    {
        /// <summary>
        /// left son of knot
        /// </summary>
        public KnotOfTree LeftSon { get; set; }

        /// <summary>
        /// right son of knot
        /// </summary>
        public KnotOfTree RightSon { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public KnotOfTree()
        {

        }

        /// <summary>
        /// function: count the reult of expression
        /// </summary>
        /// <returns>result</returns>
        public abstract int Count();

        /// <summary>
        /// function: print expression
        /// </summary>
        /// <returns>string</returns>
        public abstract string Print(); 
    }
}
