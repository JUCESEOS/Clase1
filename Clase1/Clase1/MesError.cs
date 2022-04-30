using System.Runtime.Serialization;

namespace Clase1
{
    [Serializable]
    internal class MesError : Exception
    {
        public MesError()
        {
        }

        public MesError(string? message) : base(message)
        {
        }

        public MesError(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MesError(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}