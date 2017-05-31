using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    /// <summary>
    /// Class stack
    /// </summary>
    public class Stack<T>
    {
        /// <summary>
        /// Stack description
        /// </summary>
        private class StackElement
        {
            public StackElement Next { get; private set; }
            public T Value { get; private set; }
            public StackElement(StackElement next, T value)
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
        public void Push(T value)
        {
            StackElement newElement = new StackElement(head, value);
            head = newElement;
        }

        /// <summary>
        /// Remove first element from stack
        /// </summary>
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new ListIsEmptyException("Stack is empty. There is nothing to look for.");
            }

            T valueFromHead = head.Value;
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
