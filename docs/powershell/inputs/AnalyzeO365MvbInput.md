### AnalyzeO365MvbInput
Defines the request for starting O365 recovery analysis job.

- orgId: System.String
  - ID of the O365 organization.
- groupId: System.String
  - ID of the O365 group.
- lastNumberOfDays: System.Int32
  - Analysis interval in days.
- workloads: list of O365MvbWorkloadTypes
  - List of workload types to analyze.
- shouldExcludeArchivedMailbox: System.Boolean
  - Whether to exclude archived mailboxes.
- snapshotTime: DateTime
  - Time of the recovery point snapshot.
