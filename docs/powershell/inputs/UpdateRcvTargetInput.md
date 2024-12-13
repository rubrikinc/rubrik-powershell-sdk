### UpdateRcvTargetInput
Input for the Rubrik Cloud Vault Azure update request.

- id: System.String
  - ID of the RCV Azure archival location.
- name: System.String
  - New name for the RCV Azure archival location.
- lockDurationDays: System.Int64
  - Lock duration for the immutable location, in days.
- ipMapping: IpMappingInput
  - List of allowed IP addresses for the RCV Azure archival location.
- shouldBypassProxy: System.Boolean
  - Specifies whether the proxy settings must be bypassed for the RCV Azure archival target.
