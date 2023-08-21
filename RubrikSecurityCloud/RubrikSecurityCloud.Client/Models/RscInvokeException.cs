using System;
namespace RubrikSecurityCloud.Client.Models
{
    public class RscInvokeException : Exception
    {
        public RscInvokeException()
        {
        }

        public RscInvokeException(
            string message) : base(message) { }

        public RscInvokeException(
            string message,
            Exception innerException) : base(message, innerException) { }
    }
}

