using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    /// <summary>
    /// Exception if input data are even numbers
    /// </summary>
    [Serializable]
    public class EvenNumberException : Exception
    {
        public EvenNumberException() { }
        public EvenNumberException(string message) : base(message) { }
        public EvenNumberException(string message, Exception inner) : base(message, inner) { }
        protected EvenNumberException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    
}
