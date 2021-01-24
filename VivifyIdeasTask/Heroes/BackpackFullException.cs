using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace VivifyIdeasTask.Heroes
{
    public class BackpackFullException : Exception
    {
        public BackpackFullException()
        {
        }

        public BackpackFullException(string message) : base(message)
        {
        }

        public BackpackFullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BackpackFullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
