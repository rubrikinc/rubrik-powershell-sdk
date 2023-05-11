### CdmClusterStatus
- message: System.String
  - Rubrik cluster status message.
- status: CdmClusterStatusTypeEnum
  - Rubrik cluster upgrade status. The value reflects the status of the Rubrik cluster at the various stages involved in an upgrade, for example, pre-check, download, upgrade scheduling, and rollback of the upgrade.
- statusInfo: CdmClusterStatusInfo
  - Status of the Rubrik cluster upgrade process including information about the tasks that have been completed and tasks that are pending or ongoing.
