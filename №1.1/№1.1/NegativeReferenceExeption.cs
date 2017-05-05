using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    [Serializable]
    public class NegativeReferenceExeption : Exception
    {
        public NegativeReferenceExeption() { }
        public NegativeReferenceExeption(string message) : base(message) { }
        public NegativeReferenceExeption(string message, Exception inner) : base(message, inner) { }
        protected NegativeReferenceExeption(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    
}
