using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    /// <summary>
    /// Exception: appeal to nonexistent position of list
    /// </summary>
    [Serializable]
    public class ExceptionNonexistentValue : Exception
    {
        public ExceptionNonexistentValue() { }
        public ExceptionNonexistentValue(string message) : base(message) { }
        public ExceptionNonexistentValue(string message, Exception inner) : base(message, inner) { }
        protected ExceptionNonexistentValue(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
