### UpdateRcvTargetInput
Input for the Rubrik Cloud Vault update request.

- id: System.String
  - ID of the RCV location.
- name: System.String
  - New name for the RCV location.
- lockDurationDays: System.Int64
  - Lock duration for the immutable location, in days.
- ipMapping: IpMappingInput
  - List of allowed IP addresses for the RCV location.
- shouldBypassProxy: System.Boolean
  - Specifies whether the proxy settings must be bypassed for the RCV archival target.
