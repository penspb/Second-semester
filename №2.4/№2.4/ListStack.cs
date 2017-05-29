using System;

namespace _2._4
{
    /// <summary>
    /// Class stack
    /// </summary>
    public class ListStack : IStack
    {
        /// <summary>
        /// Stack description
        /// </summary>
        private class StackElement
        {
            public StackElement Next { get; private set; }
            public int Value { get; private set; }
            public StackElement(StackElement next, int value)
            {
                this.Next = next;
                this.Value = value;
            }
        }

        /// <summary>
        /// Create stack
        /// </summary>
        private StackElement head;

        /// <summary>
        /// Add new element to stack
        /// </summary>
        public void Push(int value)
        {
            StackElement newElement = new StackElement(head, value);
            head = newElement;
        }

        /// <summary>
        /// Remove element from stack
        /// </summary>
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new StackIsEmptyException("Stack is empty. There is nothing to look for.");
            }

            int valueFromHead = head.Value;
            head = head.Next;

            return valueFromHead;
        }

        /// <summary>
        /// Checking emptiness of the project
        /// </summary>
        public bool IsEmpty()
        {
            return (head == null);
        }
    }
}