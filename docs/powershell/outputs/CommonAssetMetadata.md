### CommonAssetMetadata
Comprehensive metadata for assets.

- platform: Platform
  - Specifies the infrastructure platform of the asset.
- platformCategory: PlatformCategory
  - Specifies the platform category of the asset.
- cloudAccountInfo: CloudAccountInfo
  - Specifies the cloud provider account where the asset resides.
- clusterInfo: ClusterInfo
  - Specifies the cluster details of the asset.
- size: System.Int64
  - Specifies the size of the asset in bytes.
- physicalHost: System.String
  - Specifies the physical host associated with the asset.
- region: System.String
  - Specifies the geographic region of the asset.
- firstSeenTime: System.Int64
  - Specifies the initial detection time of the asset in
milliseconds.
- creationTime: System.Int64
  - Specifies the creation timestamp of the asset in milliseconds.
- lastAccessTime: System.Int64
  - Specifies the last access time for the asset in
milliseconds.
- backupStatus: BackupStatus
  - Specifies the current backup state of the asset.
- rubrikSlaInfo: RubrikSlaInfo
  - Specifies the Rubrik SLA Domain information for
the asset. Only populated when Rubrik backs up the
asset.
- encryption: Encryption
  - Specifies the encryption status for the asset.
- logging: Logging
  - Specifies the logging status for the asset.
- networkAccess: NetworkAccess
  - Specifies network accessibility for the asset.
- objectTags: list of AssetTags
  - Specifies the object tags assigned to the asset.
- name: System.String
  - Specifies the name of the asset.
- appSpecificMetadata: AppMetadata
  - Specifies application-specific metadata.
- objectType: ManagedObjectType
  - Specifies the managed type of the object.
- snapshotTimestamp: System.Int64
  - Specifies the timestamp of the snapshot in milliseconds.
- isDeleted: System.Boolean
  - Specifies whether the asset is marked as deleted.
- sensitivityLevel: SensitivityLevel
  - Specifies the data sensitivity level of the asset.
