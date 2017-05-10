using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    /// <summary>
    /// Exception: appeal to empty stack
    /// </summary>
    [Serializable]
    public class ExceptionIfStackIsEmpty : Exception
    {
        public ExceptionIfStackIsEmpty() { }
        public ExceptionIfStackIsEmpty(string message) : base(message) { }
        public ExceptionIfStackIsEmpty(string message, Exception inner) : base(message, inner) { }
        protected ExceptionIfStackIsEmpty(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
