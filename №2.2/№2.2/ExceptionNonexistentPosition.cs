using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    /// <summary>
    /// Exception: appeal to nonexistent position of list
    /// </summary>
    [Serializable]
    public class ExceptionNonexistentPosition : Exception
    {
        public ExceptionNonexistentPosition() { }
        public ExceptionNonexistentPosition(string message) : base(message) { }
        public ExceptionNonexistentPosition(string message, Exception inner) : base(message, inner) { }
        protected ExceptionNonexistentPosition(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
