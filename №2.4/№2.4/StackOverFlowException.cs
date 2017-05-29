using System;

namespace _2._4
{
    /// <summary>
    /// exception: if stack is overflow
    /// </summary>
    [Serializable]
    public class StackOverFlowException : Exception
    {
        public StackOverFlowException() { }
        public StackOverFlowException(string message) : base(message) { }
        public StackOverFlowException(string message, Exception inner) : base(message, inner) { }
        protected StackOverFlowException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
   
}
