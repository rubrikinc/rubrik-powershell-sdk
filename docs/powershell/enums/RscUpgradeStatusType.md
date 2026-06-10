### RscUpgradeStatusType
Represents the RSC upgrade status for a Rubrik cluster.

- UNKNOWN - Represents that the upgrade status of the Rubrik cluster is not known.
- READY_FOR_DOWNLOAD - Represents that the Rubrik cluster is ready to download a new tarball.
- READY_FOR_UPGRADE - Represents that the Rubrik cluster is ready for upgrade.
- DOWNLOADING - Represents that the download job is running in the Rubrik cluster.
- UPGRADING - Represents that the Rubrik cluster is upgrading.
- PRECHECKING - Represents that upgrade prechecks are running in the Rubrik cluster.
- ROLLINGBACK - Represents that the upgrade is being rolled back in the Rubrik cluster.
- DOWNLOAD_FAILED - Represents that the download job failed in the Rubrik cluster.
- PRECHECK_FAILED - Represents that the Rubrik cluster has one or more upgrade precheck failures.
- UPGRADE_FAILED - Represents that the upgrade has failed in the Rubrik cluster.
- ROLLINGBACK_FAILED - Represents that the upgrade rollback has failed in the Rubrik cluster.
- WAITING_FOR_OPERATION_TO_START - Represents that the latest triggered operation is waiting to start in the Rubrik cluster.
- CDM_ONLY_OPERATION - Represents that the Rubrik cluster is undergoing a CDM-only operation.
- INITIALIZING - Represents that the upgrade status of the Rubrik cluster is not initialized.
- DISCONNECTED - Represents that the Rubrik cluster is disconnected.
