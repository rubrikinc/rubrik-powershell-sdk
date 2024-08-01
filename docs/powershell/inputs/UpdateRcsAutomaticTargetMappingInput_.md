### UpdateRcsAutomaticTargetMappingInput
Input to update RCS automatic target mapping.

- id: System.String
  - ID of the target mapping.
- name: System.String
  - Name of the target mapping.
- lockDurationDays: System.Int64
  - Immutability lock duration in days.
- clusterUuidList: list of System.Strings
  - List of cluster UUIDs.
- shouldBypassProxy: System.Boolean
  - Specifies whether the proxy settings must be bypassed  the RCV archival target.
