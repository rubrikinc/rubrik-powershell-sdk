### CreateAutomaticRcsTargetMappingInput
Input for creating RCS locations.

- clusterUuidList: a list of System.Strings
  - List of Rubrik cluster UUIDs.
- ipMapping: a list of IpMappingInputs
  - IP mapping for each Rubrik cluster.
- lockDurationDays: System.Int64
  - Immutability lock period in days.
- name: System.String
  - Name of the RCS location.
- region: RcsRegionEnumType
  - Region for the RCS location.
- rsaKey: System.String
  - RSA key for the RCS location.
- tier: RcsTierEnumType
  - Tier for the RCS location.
