### CdmClusterStatusTypeEnum
Status type of the Rubrik cluster upgrade process.

- Stable - Cluster is stable with no pending upgrades.
- StableWithUpgradeInfo - Cluster is stable with upgrade information available.
- UpgradeRecommended - Upgrade is recommended for the cluster.
- PrechecksRunning - Prechecks are running before upgrade.
- PrechecksFailureError - Prechecks failed with error.
- PrechecksFailureWarning - Prechecks failed with warning.
- DownloadingPackage - Package is being downloaded.
- DownloadPackageFailed - Package download failed.
- UpgradeScheduled - Upgrade is scheduled.
- UpgradeScheduledWithWarning - Upgrade is scheduled with warning.
- ReadyForUpgrade - Cluster is ready for upgrade.
- Upgrading - Cluster is currently upgrading.
- FailedToInitiateUpgrade - Failed to initiate upgrade.
- UpgradeFailed - Upgrade failed.
- ResumingUpgrade - Upgrade is being resumed.
- RollingBackUpgrade - Upgrade is being rolled back.
- RollbackFailed - Rollback failed.
- Disconnected - Cluster is disconnected.
- ReadyForDownload - Cluster is ready for download.
- OnOldRelease - Cluster is on an old release.
- Unknown - Status is unknown.
