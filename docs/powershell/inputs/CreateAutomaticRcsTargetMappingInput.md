### CreateAutomaticRcsTargetMappingInput
Input for creating RCS locations.

- name: System.String
  - Name of the RCS location.
- region: RcsRegionEnumType
  - Region for the RCS location.
- rsaKey: System.String
  - RSA key for the RCS location.
- tier: RcsTierEnumType
  - Tier for the RCS location.
- lockDurationDays: System.Int64
  - Immutability lock period in days.
- clusterUuidList: list of System.Strings
  - List of Rubrik cluster UUIDs.
- ipMapping: list of IpMappingInputs
  - IP mapping for each Rubrik cluster.
- shouldBypassProxy: System.Boolean
  - Specifies whether the proxy settings must be bypassed for  the RCV archival target.
- proxySettings: ProxySettingsInput
  - Proxy configuration for the Rubrik cluster to reach this Rubrik Cloud Vault (RCV) Azure location.
- shouldBypassProxyForDatapaths: System.Boolean
  - When set, blob storage (data path) traffic bypasses the configured proxy while Azure AD authentication traffic continues to use it.
- redundancy: RcvRedundancy
  - Redundancy for the RCV location.
- azureKeyVaultKey: AzureKeyVaultKeyIdentifierInput
  - Azure Key Vault key to encrypt the archival target.
