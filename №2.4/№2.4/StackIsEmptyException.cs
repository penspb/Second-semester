using System;

namespace _2._4
{
    /// <summary>
    /// exception: if stack is empty
    /// </summary>
    [Serializable]
    public class StackIsEmptyException : Exception
    {
        public StackIsEmptyException() { }
        public StackIsEmptyException(string message) : base(message) { }
        public StackIsEmptyException(string message, Exception inner) : base(message, inner) { }
        protected StackIsEmptyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
