### RubrikManagedLckTarget
Specific information for LCK archival target created on Rubrik cluster.

- name: System.String
  - Name of the LCK target.
- s3Endpoint: System.String
  - Amazon S3 endpoint of the LCK target.
- roleName: System.String
  - Role name provided for the LCK target.
- agency: System.String
  - Agency provided for the LCK target.
- certificateContent: System.String
  - Certificate content provided for the LCK target.
- kmsMasterKeyId: System.String
  - KMS master key provided for the LCK target.
- connectionStatus: ConnectionStatusType
  - Connection status of the LCK target.
- accountName: System.String
  - Account name of the LCK target.
- bucketName: System.String
  - Bucket name of the LCK target.
- geoAxisEndpoint: System.String
  - Geo axis endpoint of the LCK target.
- region: AwsLckRegion
  - Region of the LCK target.
- rsaKey: System.String
  - RSA key of the LCK target.
- syncStatus: TargetSyncStatus
  - Synchronization status of LCK location.
- syncFailureReason: System.String
  - Reason why sync of this target with CDM failed.
- encryptionType: TargetEncryptionTypeEnum
  - Encryption type provided for the LCK target.
- storageClass: AwsStorageClass
  - Storage class of the LCK target.
- awsRetrievalTier: AwsRetrievalTier
  - AWS retrieval tier of the LCK target.
- cluster: Cluster
  - The cluster to which this target belongs.
- targetType: TargetType
  - The type of the target.
- id: System.String
  - The ID of the target.
- locationScope: LocationScope
  - The scope of the location of the target. Possible values are Global or Local.
- isActive: System.Boolean
  - Specifies whether the status of the target is active. When set to false, the target is either paused or not enabled.
- isArchived: System.Boolean
  - Specifies whether the target is archived.
- targetMapping: TargetMappingBasic
  - Archival location to which the mapping target belongs.
- clusterName: System.String
  - Name of the Rubrik cluster that archives to this archival location.
- status: ArchivalLocationStatus
  - Status of the target.
- upgradeStatus: UpgradeStatus
  - Upgrade status of the target.
- consumedBytes: System.Int64
  - Number of bytes stored on the target.
- runningTasks: System.Int32
  - Number of archiving tasks running on this target.
- failedTasks: System.Int32
  - Number of archiving tasks failed on this target.
- readerRetrievalMethod: ReaderRetrievalMethod
  - The retrieval method of the reader target.
- targetMappingBasic: list of TargetMappingBasics
  - List of archival groups the archival target belongs to. In case the target has no valid mappings, a null array is returned.
- locationConnectionStatus: ConnectionStatusType
  - Status of the target.