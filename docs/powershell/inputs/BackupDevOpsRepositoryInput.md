### BackupDevOpsRepositoryInput
Input message for the API to take an on-demand backup of a DevOps
repository.

- repositoryId: System.String
  - RSC-assigned UUID of the DevOps repository to backup.
- retentionSlaId: System.String
  - UUID of the retention SLA Domain to apply to the on-demand snapshot.
If empty, the repository's currently assigned SLA Domain is used.
Retrieve available SLA Domains by calling the slaDomains GraphQL query.
