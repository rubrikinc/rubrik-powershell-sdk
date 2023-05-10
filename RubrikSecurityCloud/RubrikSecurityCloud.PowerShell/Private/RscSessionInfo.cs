using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using Rubrik.SecurityCloud.Types;
using RubrikSecurityCloud.Client;
using Rubrik.SecurityCloud.NetSDK.Client.Models.Authentication;
using RubrikSecurityCloud.PowerShell.Models;

namespace RubrikSecurityCloud.PowerShell.Private
{
	/// <summary>
	/// Used to return information on the user session and SDK/Server
	/// versions in use.
	/// </summary>
	public class RscSessionInfo
	{
		private readonly RscGraphQLClient _client;
		private readonly IRscLogger _logger;

		private readonly string _schemaVersion;
		private readonly string _serverVersion;
		private readonly AuthenticationState _authenticationState;
		private readonly string _clientId;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rscClient">Instance of RscGraphQLClient</param>
        /// <param name="logger">Instance of type implementing IRscLogger</param>
        /// <exception cref="Exception"></exception>
        public RscSessionInfo(RscGraphQLClient rscClient, IRscLogger logger)
		{
			this._client = rscClient;
			this._logger = logger;
			this._authenticationState = rscClient.AuthenticationState;
			this._clientId = rscClient.ClientId;

			this._schemaVersion = SchemaMeta.GraphqlSchemaVersion;

			if (_authenticationState != AuthenticationState.AUTHORIZED)
			{
				throw new Exception("No active RSC Session found.");
			}

			string queryParam = "";
			GraphQL.GraphQLRequest request = new GraphQL.GraphQLRequest
			{
				Query = $"query GetRscVersion{{\n" +
				$"{Query.DeploymentVersion(ref queryParam)}\n}}",
				OperationName = "GetRscVersion"
			};

			_logger.Debug($"Sending GQL Query:\n{request.Query}");

			Task<string> dataTask =
				_client.InvokeGenericCallAsync<string>(request);
			dataTask.Wait();

			this._serverVersion = dataTask.Result;

			_logger.Debug($"Server Version: {_serverVersion}, " +
				$"SDKSchema Version: {_schemaVersion}");

			if (_schemaVersion != _serverVersion)
			{
				_logger.Warning($"The installed RSC SDK version does not " +
				$"match the server version.");
			}
		}

		/// <summary>
		/// Returns an instance of RscPsVersionTable containing the
		/// server deployment version and the SDK schema version.
		/// </summary>
		/// <returns>Instance of RscPsVersionTable</returns>
		public RscPsVersionTable GetRscPsVersion()
		{
			return new RscPsVersionTable(this._schemaVersion, this._serverVersion);
		}

		/// <summary>
		/// Returns an instance of RscPsSession info containing the
		/// client information, authentication state and version info.
		/// </summary>
		/// <returns>Instance of RscPsSessionInfo</returns>
		public RscPsSessionInfo GetSessionInfo()
		{
			return new RscPsSessionInfo(
                _clientId,
                _authenticationState,
                _schemaVersion,
                _serverVersion);
		}
	}
}

