using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    public class Hash
    {
        /// <summary>
        /// size of table
        /// </summary>
        private const int sizeOfTable = 63;

        /// <summary>
        /// hash table
        /// </summary>
        private List[] Table { get; set; }

        /// <summary>
        /// constructer of hash table
        /// </summary>
        public Hash()
        {
            Table = new List[sizeOfTable];

            for (int i = 0; i < sizeOfTable; i++)
            {
                Table[i] = new List();
            }
        }

        /// <summary>
        /// hash function
        /// </summary>
        /// <param name="workingString">string</param>
        /// <returns>result of calculations</returns>
        private int Function(string workingString)
        {
            int result = 0;
            for (int i = 0; i < workingString.Length; i++)
            {
                result = result + workingString[i] * i;
            }

            return Math.Abs(result % sizeOfTable);
        }

        /// <summary>
        /// add sample to hash-table
        /// </summary>
        /// <param name="value">sample</param>
        public void Add(string workingString)
        {
            Table[Function(workingString)].Add(0, workingString);
        }

        /// <summary>
        /// delete element by value
        /// </summary>
        public void Delete(string workingString)
        {
            if (!Table[Function(workingString)].IsThereValue(workingString))
            {
                throw new NonexistentPositionException("Value is not found");
            }

            Table[Function(workingString)].Delete(Table[Function(workingString)].FindPosition(workingString));
        }

        /// <summary>
        /// check: is there value in table
        /// </summary>
        public bool AreYouHere(string workingString)
        {
            return (Table[Function(workingString)].IsThereValue(workingString));
        }
    } 
}
