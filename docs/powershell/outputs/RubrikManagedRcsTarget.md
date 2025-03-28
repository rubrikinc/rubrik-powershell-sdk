### RubrikManagedRcsTarget
Specific information for Rubrik Cloud Vault (RCV) Azure target created on Rubrik.

- shouldBypassProxy: System.Boolean
  - Specifies whether the proxy settings is bypassed for  the RCV Azure archival target.
- isVersionLevelImmutabilityEnabled: System.Boolean
  - Specifies whether blob immutability is enabled for the RCV Azure archival target.
- syncStatus: TargetSyncStatus
  - Sync status of RCV target.
- region: RcsRegionEnumType
  - Region of RCV Azure target.
- tier: RcsTierEnumType
  - Tier for RCV target.
- subscriptionId: System.String
  - Subscription ID for RCV Azure target.
- resourceGroup: System.String
  - Resource group for RCV Azure target.
- storageAccountName: System.String
  - Storage account name for RCV Azure target.
- redundancy: RcvRedundancy
  - Redundancy for RCV Azure target.
- redundancyState: RcvRedundancyState
  - Redundancy state for RCV Azure target.
- lastRedundancySyncTime: DateTime
  - Last time when redundancy state was synchronized for the RCV Azure target.
- spaceUsageAlertThreshold: System.Int32
  - Space usage threshold of RCV Azure target above which alert will be raised.
- syncFailureReason: System.String
  - Reason why sync of this target with CDM failed.
- storageConsumptionValue: System.Single
  - Storage consumption value of RCV Azure target.
- immutabilityPeriodDays: System.Int64
  - Immutability lock duration of RCV Azure target in days.
- privateEndpointConnection: PrivateEndpointConnection
  - RCV Private endpoint connection details.
- clusterIpMapping: ClusterIpMapping
  - IP allow list for location.
- cluster: Cluster
  - The cluster to which this target belongs.
- targetType: TargetType
  - The type of the target.
- id: System.String
  - The ID of the target.
- name: System.String
  - The name of the target.
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
