using System;

namespace _2._4
{
    [Serializable]
    public class ExceptionStackOverFlow : Exception
    {
        public ExceptionStackOverFlow() { }
        public ExceptionStackOverFlow(string message) : base(message) { }
        public ExceptionStackOverFlow(string message, Exception inner) : base(message, inner) { }
        protected ExceptionStackOverFlow(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
   
}
