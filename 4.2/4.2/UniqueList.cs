using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    /// <summary>
    /// Class List
    /// </summary>
    public class UniqueList
    {
        /// <summary>
        /// List description
        /// </summary>
        private class ListElement
        {
            public ListElement Next { get; set; }
            public int Value { get; private set; }

            /// <summary>
            /// Constructor for ListElement
            /// </summary>
            /// <param name="next">next element</param>
            /// <param name="value">value</param>
            public ListElement(ListElement next, int value)
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
        public void Add(int position, int value)
        {
            if ((position > Length) || (position < 0))
            {
                throw new NonexistentPositionException("There isn't this position");
            }

            if (IsThereValue(value))
            {
                throw new ValueUnfortunatelyIsHere("Problem with unique");
            }

            if (position == 0)
            {
                ListElement newElement = new ListElement(head, value);
                head = newElement;
                Length++;
            }
            else
            {
                ListElement zero = head;
                int i = 0;
                while (position - 1 > i)
                {
                    zero = zero.Next;
                    i++;
                }

                ListElement newElement = new ListElement(zero.Next, value);

                zero.Next = newElement;

                Length++;
            }
        }

        /// <summary>
        /// Delete element from list
        /// </summary>
        /// <param name="position">which one of element to delete</param>
        /// <returns>value of delete element</returns>
        public int Delete(int position)
        {
            if (head == null)
            {
                throw new ListIsEmptyException("List is empty");
            }

            if ((position > Length) || (position < 0))
            {
                throw new NonexistentPositionException("There isn't this position");
            }

            int value = 0;
            if (position == 0)
            {
                value = head.Value;
                head = head.Next;
                Length--;
                return value;
            }

            ListElement zero = head;

            int i = 0;
            while (position - 1 > i)
            {
                zero = zero.Next;
                i++;
            }

            value = zero.Next.Value;
            zero.Next = zero.Next.Next;

            Length--;
            return value;
        }

        /// <summary>
        /// Get value from list
        /// </summary>
        /// <param name="position">position of search value</param>
        /// <returns>value</returns>
        public int Get(int position)
        {
            if (head == null)
            {
                throw new ListIsEmptyException("List is empty");
            }

            if ((position > Length) || (position < 0))
            {
                throw new NonexistentPositionException("There isn't this position");
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
        public bool IsThereValue(int value)
        {
            ListElement zero = head;

            if (zero == null)
            {
                return false;
            }

            while ((zero.Value != value) && (zero != null))
            {
                zero = zero.Next;
            }

            return (zero.Value == value);
        }
    }
}
