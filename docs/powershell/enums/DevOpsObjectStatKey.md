### DevOpsObjectStatKey
The canonical stat-key vocabulary for DevOps object statistics. The
generated string form of a value (for example "BYTES_STORED") is the form
persisted in the devops_object_stat_kv table's stat_key column.

- BYTES_STORED - Total bytes stored across the object's snapshots.
- LATEST_SNAPSHOT_AT - Most recent snapshot time, in epoch seconds.
- OLDEST_SNAPSHOT_AT - Earliest snapshot time, in epoch seconds.
- NUM_ADO_WORK_ITEMS - Count of Azure DevOps work items under a project.
- NUM_ADO_WIKIS - Count of Azure DevOps wikis under a project.
- NUM_GITHUB_PULL_REQUESTS - Count of GitHub pull requests under a repository.
- NUM_GITHUB_ISSUES - Count of GitHub issues under a repository.
