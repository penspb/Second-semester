using System;

namespace _2._4
{

    [Serializable]
    public class ExceptionStackIsEmpty : Exception
    {
        public ExceptionStackIsEmpty() { }
        public ExceptionStackIsEmpty(string message) : base(message) { }
        public ExceptionStackIsEmpty(string message, Exception inner) : base(message, inner) { }
        protected ExceptionStackIsEmpty(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
