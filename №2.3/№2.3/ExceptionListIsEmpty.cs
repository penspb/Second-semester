using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    /// <summary>
    /// Exception: appeal to empty list
    /// </summary>
    [Serializable]
    public class ExceptionListIsEmpty : Exception
    {
        public ExceptionListIsEmpty() { }
        public ExceptionListIsEmpty(string message) : base(message) { }
        public ExceptionListIsEmpty(string message, Exception inner) : base(message, inner) { }
        protected ExceptionListIsEmpty(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

