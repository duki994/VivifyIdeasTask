using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace VivifyIdeasTask.Heroes
{
    public class NoWeaponException : Exception
    {
        public NoWeaponException()
        {
        }

        public NoWeaponException(string message) : base(message)
        {
        }

        public NoWeaponException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoWeaponException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
