using System;

namespace _2._4
{
    /// <summary>
    /// stack based on array
    /// </summary>
    public class ArrayStack : IStack
    {
        /// <summary>
        /// max size of array
        /// </summary>
        private const int maxLength = 127;

        /// <summary>
        /// real length of array
        /// </summary>
        private int length = 0;
        
        /// <summary>
        /// working array
        /// </summary>
        private int[] workingArray = new int[maxLength];

        /// <summary>
        /// add new value to stack
        /// </summary>
        /// <param name="value">value</param>
        public void Push(int value)
        {
            if (length + 1 >= maxLength)
            {
                throw new StackOverFlowException("Stack overflow");
            }

            workingArray[length] = value;
            length++;
        }

        /// <summary>
        /// Remove element from stack
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (length <= 0)
            {
                throw new StackIsEmptyException("Stack is empty. There is nothing to look for.");
            }

            length--;
            return workingArray[length];
        }

        /// <summary>
        /// Checking emptiness of the list
        /// </summary>
        public bool IsEmpty => length == 0;
    }
}
