### ClusterJobStatusTypeEnum
Represents a Rubrik cluster's upgrade job status.

- Unknown - Represents the Rubrik cluster's upgrade status is not known.
- UpToDate - Represents that the Rubrik cluster is up-to-date.
- ReadyForDownload - Represents that the Rubrik cluster is ready to download a new tarball.
- PreCheckFailureError - Represents that the Rubrik cluster has one or more upgrade precheck failure.
- PreCheckFailureWarning - Represents that the Rubrik cluster has one or more upgrade precheck warning.
- DownloadingPackage - Represents that download job is running in the Rubrik cluster.
- DownloadPackageFailed - Represents that download job failed in the Rubrik cluster.
- ReadyForUpgrade - Represents that the Rubrik cluster is ready for upgrade.
- Upgrading - Represents that the Rubrik cluster is upgrading.
- FailedToInitiateUpgrade - Represents that upgrade failed to start in the Rubrik cluster.
- UpgradeFailed - Represents that upgrade has failed in the Rubrik cluster.
- ResumingUpgrade - Represents that upgrade has resumed in the Rubrik cluster.
- RollingBackUpgrade - Represents that upgrade is being rolled back in the Rubrik cluster.
- RollbackFailed - Represents that upgrade rollback has failed in the Rubrik cluster.
