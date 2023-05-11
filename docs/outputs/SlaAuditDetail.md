### SlaAuditDetail
Audit log of SLA Domain changes based on user action.

- applyToExistingSnapshots: System.Boolean
  - Specifies whether to apply changes to existing snapshots.
- applyToOndemandAndDownloadedSnapshots: System.Boolean
  - Specifies whether to apply changes to on-demand and downloaded snapshots.
- cluster: Cluster
  - Rubrik cluster UUID.
- currentSlaSummary: SlaDomain
  - Current SLA Domain summary.
- previousSlaSummary: SlaDomain
  - SLA Domain summary before edit or update.
- timestamp: DateTime
  - The time at which the user performed this action on the SLA Domain.
- userAction: System.String
  - The action (create/update/delete) performed on the SLA Domain.
- userName: System.String
  - Name of the user who performed the create or edit action on the SLA Domain.
