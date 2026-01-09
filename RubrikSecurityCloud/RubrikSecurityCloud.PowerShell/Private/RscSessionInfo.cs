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
		/// Logs an improved version mismatch warning with detailed guidance
		/// </summary>
		private void LogVersionMismatchWarning()
		{
			var comparison = CompareVersions(_schemaVersion, _serverVersion);

			switch (comparison)
			{
				case VersionComparison.SdkOlder:
					_logger.Warning($"SDK version mismatch detected: Your SDK schema version ({_schemaVersion}) " +
						$"is older than the server version ({_serverVersion}). " +
						$"Consider updating your SDK to access the latest features and avoid potential compatibility issues. " +
						$"Run 'Update-Module RubrikSecurityCloud' to get the latest version.");
					break;

				case VersionComparison.SdkNewer:
					_logger.Warning($"SDK version mismatch detected: Your SDK schema version ({_schemaVersion}) " +
						$"is newer than the server version ({_serverVersion}). " +
						$"Some SDK features may not be available on this server. " +
						$"The SDK maintains backward compatibility, but consider using an SDK version that matches your server.");
					break;

				case VersionComparison.Unknown:
				default:
					_logger.Warning($"SDK version mismatch detected: SDK schema version ({_schemaVersion}) " +
						$"does not match server version ({_serverVersion}). " +
						$"This may cause compatibility issues. For optimal performance, use an SDK version that matches your server version. " +
						$"Run 'Get-RscVersion' to check current versions.");
					break;
			}
		}

		/// <summary>
		/// Compares SDK and server versions to determine their relationship
		/// </summary>
		/// <param name="sdkVersion">SDK schema version</param>
		/// <param name="serverVersion">Server deployment version</param>
		/// <returns>Version comparison result</returns>
		private VersionComparison CompareVersions(string sdkVersion, string serverVersion)
		{
			try
			{
				// Both versions typically follow the format "v20230524-16" or similar date-based format
				// Extract date portions for comparison
				var sdkDatePart = ExtractDateFromVersion(sdkVersion);
				var serverDatePart = ExtractDateFromVersion(serverVersion);

				if (sdkDatePart.HasValue && serverDatePart.HasValue)
				{
					if (sdkDatePart.Value < serverDatePart.Value)
						return VersionComparison.SdkOlder;
					else if (sdkDatePart.Value > serverDatePart.Value)
						return VersionComparison.SdkNewer;
				}
			}
			catch (Exception ex)
			{
				_logger.Debug($"Error comparing versions: {ex.Message}");
			}

			return VersionComparison.Unknown;
		}

		/// <summary>
		/// Extracts date portion from version string for comparison
		/// </summary>
		/// <param name="version">Version string like "v20230524-16"</param>
		/// <returns>DateTime if successfully parsed, null otherwise</returns>
		private DateTime? ExtractDateFromVersion(string version)
		{
			if (string.IsNullOrEmpty(version))
				return null;

			// Try to extract date from formats like "v20230524-16", "20230524-16", etc.
			var match = System.Text.RegularExpressions.Regex.Match(version, @"v?(\d{8})");
			if (match.Success && match.Groups.Count > 1)
			{
				var dateString = match.Groups[1].Value;
				if (DateTime.TryParseExact(dateString, "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out DateTime date))
				{
					return date;
				}
			}

			return null;
		}

		/// <summary>
		/// Enumeration for version comparison results
		/// </summary>
		private enum VersionComparison
		{
			SdkOlder,
			SdkNewer,
			Unknown
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

