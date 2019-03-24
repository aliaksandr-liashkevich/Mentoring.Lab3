using System;
using System.Runtime.Serialization;

namespace Mentoring.Lab3.NumberLibrary.Exceptions
{
    [Serializable]
    public class ParsingException : Exception
    {
        public ParsingException(string numberValue)
        {
            NumberValue = numberValue;
        }

        public ParsingException(string message, string numberValue)
            : base(message)
        {
            NumberValue = numberValue;
        }

        public ParsingException(string message, string numberValue, Exception innerException)
            : base(message, innerException)
        {
            NumberValue = numberValue;
        }

        protected ParsingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public string NumberValue { get; }
    }
}