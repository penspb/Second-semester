using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    /// <summary>
    /// Exception: appeal to nonexistent value
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
