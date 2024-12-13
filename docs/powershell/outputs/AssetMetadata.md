### AssetMetadata
AssetMetadata stores the metadata of the asset.

- platform: Platform
  - Platform signifies the platform of the asset.
- platformCategory: PlatformCategory
  - Platform category stores the platform category of the asset.
- cloudAccountInfo: CloudAccountInfo
  - Cloud account signifies the cloud account of the asset.
- clusterInfo: ClusterInfo
  - Cluster information signifies the cluster details of the asset.
- size: System.Int64
  - Size signifies the size of the asset in bytes.
- physicalHost: System.String
  - Physical host signifies the physical host of the asset.
- region: System.String
  - Region signifies the region of the asset.
- firstSeenTime: System.Int64
  - First seen time signifies the initial detection time of the asset in
 milliseconds.
- creationTime: System.Int64
  - Creation time signifies the creation time of the asset in milliseconds.
- lastAccessTime: System.Int64
  - Last access time signifies the last access time of the asset in
 milliseconds.
- backupStatus: BackupStatus
  - Backup status signifies the status of backup of the asset.
- rubrikSlaInfo: RubrikSlaInfo
  - Rubrik SLA Domain information signifies the SLA Domain information for
 the asset. This field will only be populated when Rubrik backs up the
 asset.
- encryption: Encryption
  - Signifies the encryption status for the asset.
- logging: Logging
  - Signifies logging status for the asset.
- networkAccess: NetworkAccess
  - Signifies network access for the asset.
- objectTags: list of AssetTags
  - Signifies the object tags for the asset.
- name: System.String
  - Signifies the name of the asset.
- appSpecificMetadata: AppMetadata
  - Signifies the application-specific metadata.
