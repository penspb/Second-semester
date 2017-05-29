using System;

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
        List[] Table { get; set; }

        /// <summary>
        /// constructor of hash table
        /// </summary>
        public Hash(IHashFunction function)
        {
            this.function = function;

            Table = new List[sizeOfTable];

            for (int i = 0; i < sizeOfTable; i++)
            {
                Table[i] = new List();
            }
        }

        /// <summary>
        /// add sample to hash-table
        /// </summary>
        /// <param name="value">sample</param>
        public void Add(string workingString)
        {
            Table[function.Function(workingString) % sizeOfTable].Add(0, workingString);
        }

        /// <summary>
        /// delete element by value
        /// </summary>
        public void Delete(string workingString)
        {
            if (!Table[function.Function(workingString) % sizeOfTable].IsThereValue(workingString))
            {
                throw new NonexistentPositionException("Value is not found");
            }

            Table[function.Function(workingString) % sizeOfTable].Delete(Table[function.Function(workingString)].FindPosition(workingString));
        }

        /// <summary>
        /// check: is there value in table
        /// </summary>
        public bool AreYouHere(string workingString)
        {
            return (Table[function.Function(workingString) % sizeOfTable].IsThereValue(workingString));
        }
    } 
}
