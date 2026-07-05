### TakeCloudDirectSnapshotInput
Input for taking NAS Cloud Direct on demand snapshot.

- userNote: System.String
  - Optional free-text note attached to the on-demand snapshot. Surfaces in Latest Note for the share.
- objectFid: System.String
  - FID of NAS Cloud Direct object to take on demand snapshot on.
- slaId: System.String
  - SLA Domain ID used for the on demand snapshot.
- exclusions: list of CloudDirectExclusionInputs
  - List of exclusions for the on demand backup.
