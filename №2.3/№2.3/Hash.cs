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

        private IHashFunction function;

        /// <summary>
        /// hash table
        /// </summary>
        public List[] table { get; set; }

        /// <summary>
        /// describe of hash table
        /// </summary>
        public Hash(IHashFunction function)
        {
            this.function = function;

            table = new List[sizeOfTable];

            for (int i = 0; i < sizeOfTable; i++)
            {
                table[i] = new List();
            }
        }

        /// <summary>
        /// add sample to hash-table
        /// </summary>
        /// <param name="value">sample</param>
        public void Add(string workingString)
        {
            table[function.Function(workingString)].Add(0, workingString);
        }

        /// <summary>
        /// delete element by value
        /// </summary>
        public void Delete(string workingString)
        {
            if (!table[function.Function(workingString)].IsThereValue(workingString))
            {
                throw new ExceptionNonexistentPosition("Value is not found");
            }

            table[function.Function(workingString)].Delete(table[function.Function(workingString)].FindPosition(workingString));
        }

        /// <summary>
        /// check: is there value in table
        /// </summary>
        public bool AreYouHere(string workingString)
        {
            return (table[function.Function(workingString)].IsThereValue(workingString));
        }
    } 
}
