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
        public List[] table { get; set; }

        /// <summary>
        /// describe of hash table
        /// </summary>
        public Hash()
        {
            table = new List[sizeOfTable];

            for (int i = 0; i < sizeOfTable; i++)
            {
                table[i] = new List();
            }
        }

        /// <summary>
        /// hash funcion
        /// </summary>
        /// <returns>result of function</returns>
        public int Function(string workingString)
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
            table[Function(workingString)].Add(0, workingString);
        }

        /// <summary>
        /// delete element by value
        /// </summary>
        public void Delete(string workingString)
        {
            if (!table[Function(workingString)].IsThereValue(workingString))
            {
                throw new ExceptionNonexistentPosition("Value is not found");
            }

            table[Function(workingString)].Delete(table[Function(workingString)].FindPosition(workingString));
        }

        /// <summary>
        /// check: is there value in table
        /// </summary>
        public bool AreYouHere(string workingString)
        {
            return (table[Function(workingString)].IsThereValue(workingString));
        }
    } 
}
