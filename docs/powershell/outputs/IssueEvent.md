### IssueEvent


- timestamp: System.Int64
  - Timestamp of the issue event in milliseconds.
- type: IssueEventType
  - Type of the issue event, for example whitelist or snapshot.
- violationsDelta: System.Int32
  - Change in number of violations as a result of this event.
- snapshotFid: System.String
  - The associated snapshot FID if the type is snapshot, otherwise empty string.
- violations: System.Int32
  - Total number of violations for this event.
