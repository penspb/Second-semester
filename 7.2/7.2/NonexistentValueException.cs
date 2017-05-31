using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    /// <summary>
    /// Exception: appeal to nonexistent value of list
    /// </summary>
    [Serializable]
    public class NonexistentValueException : Exception
    {
        public NonexistentValueException() { }
        public NonexistentValueException(string message) : base(message) { }
        public NonexistentValueException(string message, Exception inner) : base(message, inner) { }
        protected NonexistentValueException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
