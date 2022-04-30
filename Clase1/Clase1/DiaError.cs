using System.Runtime.Serialization;

namespace Clase1
{
    [Serializable]
    internal class DiaError : Exception
    {
        public DiaError()
        {
        }

        public DiaError(string? message) : base(message)
        {
        }

        public DiaError(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DiaError(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}