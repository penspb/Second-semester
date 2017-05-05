using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    /// <summary>
    /// Exception if input data are negative
    /// </summary>
    [Serializable]
    public class NegativeReferenceException : Exception
    {
        public NegativeReferenceException() { }
        public NegativeReferenceException(string message) : base(message) { }
        public NegativeReferenceException(string message, Exception inner) : base(message, inner) { }
        protected NegativeReferenceException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
