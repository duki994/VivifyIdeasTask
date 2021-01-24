using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace VivifyIdeasTask.Heroes
{
    public class IllegalWeaponException : Exception
    {
        public IllegalWeaponException()
        {
        }

        public IllegalWeaponException(string message) : base(message)
        {
        }

        public IllegalWeaponException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IllegalWeaponException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
