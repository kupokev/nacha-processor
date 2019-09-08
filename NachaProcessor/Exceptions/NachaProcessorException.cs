using System;

namespace NachaProcessor.Exceptions
{
    [Serializable]
    public class NachaProcessorException : Exception
    {
        public NachaProcessorException()
        {

        }

        public NachaProcessorException(string message)
        : base(message)
        {
        }

        public NachaProcessorException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
