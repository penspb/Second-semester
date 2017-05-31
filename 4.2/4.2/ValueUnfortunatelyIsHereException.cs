using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    /// <summary>
    /// exception: value is here
    /// </summary>
    [Serializable]
    public class ValueUnfortunatelyIsHere : Exception
    {
        public ValueUnfortunatelyIsHere() { }
        public ValueUnfortunatelyIsHere(string message) : base(message) { }
        public ValueUnfortunatelyIsHere(string message, Exception inner) : base(message, inner) { }
        protected ValueUnfortunatelyIsHere(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
