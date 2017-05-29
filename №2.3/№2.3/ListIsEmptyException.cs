using System;

namespace _2._3
{
    /// <summary>
    /// Exception: appeal to empty list
    /// </summary>
    [Serializable]
    public class ListIsEmptyException : Exception
    {
        public ListIsEmptyException() { }
        public ListIsEmptyException(string message) : base(message) { }
        public ListIsEmptyException(string message, Exception inner) : base(message, inner) { }
        protected ListIsEmptyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

