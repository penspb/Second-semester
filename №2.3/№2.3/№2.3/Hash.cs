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
        List[] table;

        /// <summary>
        /// constructor of hash table
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
            table[Math.Abs(function.Function(workingString)) % sizeOfTable].Add(0, workingString);
        }

        /// <summary>
        /// delete element by value
        /// </summary>
        public void Delete(string workingString)
        {
            if (!table[Math.Abs(function.Function(workingString)) % sizeOfTable].IsThereValue(workingString))
            {
                throw new NonexistentPositionException("Value is not found");
            }

            table[Math.Abs(function.Function(workingString)) % sizeOfTable].Delete(table[Math.Abs(function.Function(workingString)) % sizeOfTable].FindPosition(workingString));
        }

        /// <summary>
        /// check: is there value in table
        /// </summary>
        public bool AreYouHere(string workingString)
        {
            return (table[Math.Abs(function.Function(workingString)) % sizeOfTable].IsThereValue(workingString));
        }
    }
}