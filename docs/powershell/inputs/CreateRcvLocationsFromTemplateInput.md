### CreateRcvLocationsFromTemplateInput
Input for creating Rubrik Cloud Vault Azure locations.

- name: System.String
  - Name of the Rubrik Cloud Vault Azure location.
- region: RcsRegionEnumType
  - Region for the Rubrik Cloud Vault Azure location.
- tier: RcsTierEnumType
  - Tier for the Rubrik Cloud Vault Azure location.
- lockDurationDays: System.Int64
  - Immutability lock period in days.
- clusterUuidList: list of System.Strings
  - List of Rubrik cluster UUIDs.
- ipMapping: list of IpMappingInputs
  - IP mapping for each Rubrik cluster.
- shouldBypassProxy: System.Boolean
  - Specifies whether the proxy settings must be bypassed for  the Rubrik Cloud Vault Azure archival target.
- redundancy: RcvRedundancy
  - Redundancy for the Rubrik Cloud Vault Azure location.
- rsaKey: System.String
  - RSA key for the Rubrik Cloud Vault Azure location.
- azureKeyVaultKey: AzureKeyVaultKeyIdentifierInput
  - Azure Key Vault key to encrypt the archival target.
