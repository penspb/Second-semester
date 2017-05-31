using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    /// <summary>
    /// Exception: appeal to nonexistent position of list
    /// </summary>
    [Serializable]
    public class NonexistentPositionException : Exception
    {
        public NonexistentPositionException() { }
        public NonexistentPositionException(string message) : base(message) { }
        public NonexistentPositionException(string message, Exception inner) : base(message, inner) { }
        protected NonexistentPositionException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
