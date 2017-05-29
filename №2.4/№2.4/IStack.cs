using System;

namespace _2._4
{
    public interface IStack
    {
        /// <summary>
        /// add new value to stack
        /// </summary>
        /// <param name="value">value</param>
        void Push(int value);

        /// <summary>
        /// Remove element from stack
        /// </summary>
        int Pop();

        /// <summary>
        /// Checking emptiness of the list
        /// </summary>
        bool IsEmpty();
    }
}
