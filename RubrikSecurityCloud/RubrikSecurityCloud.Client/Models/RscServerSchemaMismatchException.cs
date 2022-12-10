using System;
namespace RubrikSecurityCloud.Client.Models
{
	public class RscServerSchemaMismatchException : Exception
	{
		public RscServerSchemaMismatchException()
		{
		}

		public RscServerSchemaMismatchException(
			string message) : base(message) { }

		public RscServerSchemaMismatchException(
            string message,
            Exception innerException) : base(message, innerException) { }
	}
}

