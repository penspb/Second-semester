using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    public class Set<T>
    {
        private List<T> list;

        public Set() => list = new List<T>();

        /// <summary>
        /// add element to set
        /// </summary>
        /// <param name="value">value</param>
        public void Add(T value) => list.Push(value);

        /// <summary>
        /// delete value from set
        /// </summary>
        /// <param name="value">value</param>
        public void DeleteValue(T value) => list.Delete(value);

        /// <summary>
        /// check: is value in set
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>true or false</returns>
        public bool IsValueHere(T value) => list.IsThereValue(value);

        /// <summary>
        /// create association of two sets
        /// </summary>
        /// <param name="zero">firs set</param>
        /// <param name="first">zero set</param>
        /// <returns>result set</returns>
        public Set<T> Association(Set<T> zero, Set<T> first)
        {
            Set<T> result = new Set<T>();

            foreach (var i in zero.list)
            {
                result.Add(i);
            }

            foreach (var i in first.list)
            {
                if (!result.IsValueHere(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }

        public Set<T> Intersection(Set<T> zero, Set<T> first)
        {
            Set<T> result = new Set<T>();

            foreach (var i in first.list)
            {
                if (!zero.IsValueHere(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }

    }
}
