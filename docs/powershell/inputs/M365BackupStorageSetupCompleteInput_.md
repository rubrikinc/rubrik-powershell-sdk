### M365BackupStorageSetupCompleteInput
Configuration for the setup of M365 Backup Storage.

- stateToken: System.String
  - CSRF token for the setup flow.
- appTypes: list of System.Strings
  - Types of the applications created in the flow.
- authInfoForType: list of AuthInfoForTypeInputs
  - Specifies the authorization information for application type used in the setup flow. The information includes authorization code and redirect URL used in the OAuth flow.
