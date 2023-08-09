### CreateRcvLocationsFromTemplateInput
Input for creating Rubrik Cloud Vault locations.

- name: System.String
  - Name of the RCV location.
- region: RcsRegionEnumType
  - Region for the RCV location.
- tier: RcsTierEnumType
  - Tier for the RCV location.
- lockDurationDays: System.Int64
  - Immutability lock period in days.
- clusterUuidList: list of System.Strings
  - List of Rubrik cluster UUIDs.
- ipMapping: list of IpMappingInputs
  - IP mapping for each Rubrik cluster.
- shouldBypassProxy: System.Boolean
  - Specifies whether the proxy settings must be bypassed for  the RCV archival target.
- rsaKey: System.String
  - RSA key for the RCV location.
