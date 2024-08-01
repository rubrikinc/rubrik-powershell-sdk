# New-RscMutationGcpNative
## Subcommands
### disableproject
Triggers GCP native disable project job for the given project ID.

- There is a single argument of type GcpNativeDisableProjectInput.
- Returns AsyncJobStatus.
### excludedisksfrominstancesnapshot
- There is a single argument of type GcpNativeExcludeDisksFromInstanceSnapshotInput.
- Returns System.String.
### exportdisk
Triggers GCP native export disk job for the given disk snapshot.

- There is a single argument of type GcpNativeExportDiskInput.
- Returns AsyncJobStatus.
### exportgceinstance
Triggers GCP native export instance job for the given GCE instance.

- There is a single argument of type GcpNativeExportGceInstanceInput.
- Returns AsyncJobStatus.
### refreshprojects
Trigger GCP native refresh project job for the given project IDs

- There is a single argument of type GcpNativeRefreshProjectsInput.
- Returns BatchAsyncJobStatus.
### restoregceinstance
Triggers GCP native restore instance job for the given snapshot Rubrik ID.

- There is a single argument of type GcpNativeRestoreGceInstanceInput.
- Returns AsyncJobStatus.
