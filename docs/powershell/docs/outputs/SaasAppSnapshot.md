### SaasAppSnapshot
A snapshot for a SaaS App workload.

- date: DateTime
  - The date the snapshot was taken.
- expirationDate: DateTime
  - The date the snapshot is set to expire.
- expiryHint: System.Boolean
  - Specifies whether a snapshot is due to expire or has already expired.
- id: System.String
  - The ID of the snapshot.
- indexTime: DateTime
  - The time that the snapshot was indexed.
- isOnDemandSnapshot: System.Boolean
  - Specifies if the snapshot is an on-demand snapshot.
- sequenceNumber: System.Int32
  - The sequence number of the snapshot.
- workloadId: System.String
  - The ID of the workload.
