### ArchivalObjectInfo
Archival object information.

- objectName: System.String
  - Name of the object.
- objectType: System.String
  - Type of the object.
- objectLocation: System.String
  - Physical location of the object.
- slaDomain: System.String
  - SLA Domain of the object.
- archivalLag: System.Int64
  - Number of local snapshots pending upload to the archival location.
- storageUsage: System.Int64
  - Archival storage usage of the object in bytes.
- numActiveSnapshots: System.Int64
  - Number of active snapshots on the archival location.
- latestArchivedSnapshotDate: DateTime
  - Date of the latest archived snapshot.
- objectStatus: System.String
  - Status of the object.
- workloadId: System.String
  - Internal ID of the object.
- monthlyGrowthBytes: System.Single
  - Forecasted monthly storage growth in bytes for the object. May be negative for shrinking workloads. A zero value can mean either no forecast data exists or the workload is forecast to be flat.
- archivalLocationId: System.String
  - Identifier of the archival location for this row.
- archivalLocationName: System.String
  - Human-readable name of the archival location for this row.
- storageTier: System.String
  - Storage tier or class for this archival location (e.g. STANDARD,
STANDARD_IA, COOL, ARCHIVE, GLACIER). The exact value space varies
by location_type; consult cloud-provider tier documentation for
the meaningful values per type.
- locationType: System.String
  - Archival location type for this row (e.g. AWS_S3, AZURE, RCV_AWS,
GLACIER, GOOGLE).
- isRcv: System.Boolean
  - Convenience flag indicating whether the location is a Rubrik Cloud
Vault target (RCV_AWS or RCS_AZURE), derived from location_type.
