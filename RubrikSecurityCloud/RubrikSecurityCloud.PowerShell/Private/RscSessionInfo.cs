using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.Client;
using RubrikSecurityCloud.NetSDK.Client.Models.Authentication;
using RubrikSecurityCloud.PowerShell.Models;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

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
				$"{Query.DeploymentVersion(queryParam)}\n}}",
				OperationName = "GetRscVersion"
			};

			_logger.Debug($"Sending GQL Query:\n{request.Query}");

			Task<string> dataTask =
				_client.InvokeGenericCallAsync<string>(request, logger: logger);
			dataTask.Wait();

			this._serverVersion = dataTask.Result;

			_logger.Debug($"Server Version: {_serverVersion}, " +
				$"SDKSchema Version: {_schemaVersion}");

			if (_schemaVersion != _serverVersion)
			{
				LogVersionMismatchWarning();
			}
		}

		/// <summary>
		/// Logs a version mismatch message with severity based on the age
		/// of the drift. Less than 30 days: Info. 30+ days: Warning.
		/// </summary>
		private void LogVersionMismatchWarning()
		{
			var result = VersionHelper.Compare(_schemaVersion, _serverVersion);
			bool isSignificant = VersionHelper.IsSignificant(result);
			string deltaInfo = result.Delta.HasValue
				? $" ({(int)result.Delta.Value.TotalDays} days apart)"
				: "";

			string message;
			switch (result.Direction)
			{
				case VersionHelper.Direction.SdkOlder:
					message = $"SDK schema version ({_schemaVersion}) is older " +
						$"than the server version ({_serverVersion}){deltaInfo}. " +
						(isSignificant
							? "Consider updating: Run 'Update-Module RubrikSecurityCloud'."
							: "A minor version difference is generally safe.");
					break;

				case VersionHelper.Direction.SdkNewer:
					message = $"SDK schema version ({_schemaVersion}) is newer " +
						$"than the server version ({_serverVersion}){deltaInfo}. " +
						(isSignificant
							? "Some SDK features may not be available on this server."
							: "A minor version difference is generally safe.");
					break;

				default:
					message = $"SDK schema version ({_schemaVersion}) does not " +
						$"match server version ({_serverVersion}). " +
						"Run 'Get-RscVersion' to check current versions.";
					break;
			}

			if (isSignificant)
				_logger.Warning(message);
			else
				_logger.Info(message);
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
