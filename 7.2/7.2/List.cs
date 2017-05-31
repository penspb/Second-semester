using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    public class List<T> : IEnumerable<T>
    {
        /// <summary>
        /// get enumerator
        /// </summary>
        public IEnumerator<T> GetEnumerator() => new ListEnumerator(this);

        /// <summary>
        /// get enumerator
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => new ListEnumerator(this);

        private class ListEnumerator : IEnumerator<T>
        {
            private ListElement currentElement;

            private ListElement head;

            /// <summary>
            /// constructor
            /// </summary>
            /// <param name="list">list</param>
            public ListEnumerator(List<T> list)
            {
                head = list.head;
                currentElement = null;
            }

            /// <summary>
            /// function: return element
            /// </summary>
            public T Current => currentElement.Value;

            /// <summary>
            /// function
            /// </summary>
            object IEnumerator.Current { get => Current; }

            /// <summary>
            /// function: move to next element, if it possible
            /// </summary>
            /// <returns>true or false</returns>
            public bool MoveNext()
            {
                if (currentElement == null)
                {
                    currentElement = head;
                    return true;
                }

                if (currentElement.Next == null)
                {
                    return false;
                }

                currentElement = currentElement.Next;
                return true;
            }

            /// <summary>
            /// function: enumerator back to beginning
            /// </summary>
            public void Reset() => currentElement = null;

            public void Dispose()
            {

            }
        }

        /// <summary>
        /// List description
        /// </summary>
        private class ListElement
        {
            public ListElement Next { get; set; }
            public T Value { get; private set; }

            /// <summary>
            /// Constructor for ListElement
            /// </summary>
            /// <param name="next">next element</param>
            /// <param name="value">value</param>
            public ListElement(ListElement next, T value)
            {
                this.Next = next;
                this.Value = value;
            }
        }

        /// <summary>
        /// Create List
        /// </summary>
        private ListElement head;

        /// <summary>
        /// Length of list
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Add new element
        /// </summary>
        /// <param name="position">position of new element</param>
        /// <param name="value">value of new element</param>
        public void Push(T value)
        {
            ListElement newElement = new ListElement(head, value);
            head = newElement;
        }

        /// <summary>
        /// Delete element from list
        /// </summary>
        /// <param name="position">which one of element to delete</param>
        /// <returns>value of delete element</returns>
        public void Delete(T value)
        {
            if (head == null)
            {
                throw new ListIsEmptyException("List is empty");
            }

            if (!IsThereValue(value))
            {
                throw new NonexistentValueException("There isn't this value");
            }

            ListElement zero = head;

            while ((zero.Next != null) && !(value.Equals(zero.Next.Value)))
            {
                zero.Next = zero.Next.Next;
                
            }

            if (value.Equals(head.Value))
            {
                head = head.Next;
            }
            else
            {
                zero = zero.Next;
            }
        }

        /// <summary>
        /// Get value from list
        /// </summary>
        /// <param name="position">position of search value</param>
        /// <returns>value</returns>
        public T Get(int position)
        {
            if (head == null)
            {
                throw new ListIsEmptyException("List is empty");
            }

            if ((position > Length) || (position < 0))
            {
                throw new NonexistentValueException("There isn't this position");
            }

            ListElement zero = head;

            int i = 0;
            while (position > i)
            {
                i++;
                zero = zero.Next;
            }

            return zero.Value;
        }

        /// <summary>
        /// Is list empty?
        /// </summary>
        public bool IsEmpty()
        {
            return (head == null);
        }

        /// <summary>
        /// check: is there value
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>true or false</returns>
        public bool IsThereValue(T value)
        {
            ListElement zero = head;

            while ((zero != null) && !(value.Equals(zero.Value)))
            {
                zero = zero.Next;
            }

            if (zero == null)
            {
                return false;
            }

            return (value.Equals(zero.Value));
        }
    }
}