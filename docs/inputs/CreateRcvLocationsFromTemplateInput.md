### CreateRcvLocationsFromTemplateInput
Input for creating Rubrik Cloud Vault locations.

- clusterUuidList: a list of System.Strings
  - List of Rubrik cluster UUIDs.
- ipMapping: a list of IpMappingInputs
  - IP mapping for each Rubrik cluster.
- lockDurationDays: System.Int64
  - Immutability lock period in days.
- name: System.String
  - Name of the RCV location.
- region: RcsRegionEnumType
  - Region for the RCV location.
- rsaKey: System.String
  - RSA key for the RCV location.
- tier: RcsTierEnumType
  - Tier for the RCV location.
