### AwsNativeEbsVolume
AWS native EBS volume.

- volumeNativeId: System.String
  - AWS Native ID of EBS volume.
- cloudNativeId: System.String
  - AWS Native ID of EBS volume.
- volumeName: System.String
  - Name of volume on AWS. Name is not necessarily unique for different volumes.
- volumeType: System.String
  - AWS Native EBS volume type. Some examples are: g3, io2. This field cannot be null or empty string and will be mapped directly to available EBS volumes on cloud(AWS). For more information, see https://aws.amazon.com/ebs/volume-types.
- sizeInGiBs: System.Int32
  - Size of volume in GiB.
- iops: System.Int64
  - Input/Output (IO) limit per second for volume.
- region: AwsNativeRegion
  - Name of the region. Some examples are: US_EAST_1, AP_EAST_1. This field cannot be null or empty string and will be mapped directly to available regions for EBS volume on cloud(AWS). For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html#concepts-available-regions.
- isExocomputeConfigured: System.Boolean
  - Whether exocompute is configured for the region where the volume is.
- availabilityZone: System.String
  - Name of the Availability Zone (AZ). Some examples are: US_EAST_1, AP_EAST_1. This field cannot be null or empty string and will be mapped directly to available AZ for EC2 instance on cloud(AWS). For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html#concepts-availability-zones.
- tags: list of Tags
  - List of tags associated with volume.
- isRelic: System.Boolean
  - Whether the volume is relic.
- awsAccountRubrikId: System.String
  - Rubrik ID of Instance.
- attachmentSpecs: list of AttachmentSpecForEbsVolumes
  - List of EC2 instance details to which volume is attached.
- awsNativeAccountName: System.String
  - Name for the AWS account.
- isIndexingEnabled: System.Boolean
  - Specifies whether file indexing is enabled for this EBS volume or not. When enabled, Rubrik scans the file structure within the EBS volume in a protected environment, where only the metadata such as folder structure, file names, and file sizes is accessible to Rubrik. 
- isMarketplace: System.Boolean
  - Whether the volume image is marketplace image.
- nativeName: System.String
  - AWS Native name of the object.
- awsNativeAccountDetails: AwsNativeAccountDetails
  - AWS native account details.
- fileIndexingStatus: FileIndexingStatus
  - Specifies the file indexing status for this EBS volume. When enabled, Rubrik scans the file structure within the EBS volume in a protected environment, where only the metadata such as folder structure, file names, and file sizes is accessible to Rubrik. If the status is not specified by the user, file indexing is automatically enabled when archival is configured.
- authorizedOperations: list of PolarisSnappableAuthorizedOperationsEnums
  - The authorized operations on the object.
- awsNativeAccount: AwsNativeAccount
  - AWS Native account associated with the EBS Volumes.
- awsAccount: AwsNativeAccount
  - AWS Native account associated with the EBS Volumes.
- attachedEc2Instances: list of AwsNativeEc2Instances
  - EC2 Instances to which this volume is attached.
- rscNativeObjectPendingSla: CompactSlaDomain
  - SLA Domain assignment which is pending on the Rubrik Security Cloud native objects.
- rscPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus
  - Object pause pending assignment details for RSC objects.
- id: System.String
  - FID of the hierarchy object.
- name: System.String
  - Name of the hierarchy object.
- objectType: HierarchyObjectTypeEnum
  - Type of this object.
- slaAssignment: SlaAssignmentTypeEnum
  - SLA Domain assignment type for this object.
- effectiveSlaDomain: SlaDomain
  - Effective SLA Domain of the hierarchy object.
- slaPauseStatus: System.Boolean
  - Pause status of the effective SLA Domain of the hierarchy object.
- snapshotDistribution: SnapshotDistribution
  - Distribution of the snapshots of the hierarchy object.
- effectiveRetentionSlaDomain: SlaDomain
  - Effective retention of the SLA Domain of the hierarchy object.
- configuredSlaDomain: SlaDomain
  - SLA Domain configured for the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - Path node of the effective SLA Domain source.
- logicalPath: list of PathNodes
  - Sequential list of the logical ancestors of this object.
- physicalPath: list of PathNodes
  - Sequential list of the physical ancestors of this object.
- numWorkloadDescendants: System.Int32
  - Number of descendant workloads of this object.
- allOrgs: list of Orgs
  - Organizations to which this hierarchy object belongs.
- securityMetadata: SecurityMetadata
  - Security posture metadata.
- objectPauseStatus: ObjectPauseStatus
  - Pause status of the hierarchy object.
- snapshotConnection: PolarisSnapshotConnection
  - The list of snapshots taken for this workload.
- workloadSnapshotConnection: GenericSnapshotConnection
  - The list of snapshots taken for this workload.
- snapshotGroupByConnection: PolarisSnapshotGroupByConnection
  - GroupBy connection for the snapshots of this workload.
- snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection
  - GroupBy connection for the snapshots of this workload.
- newestSnapshot: PolarisSnapshot
  - The most recent snapshot of this workload.
- oldestSnapshot: PolarisSnapshot
  - The oldest snapshot of this workload.
- onDemandSnapshotCount: System.Int32
  - The number of on-demand snapshots.
- newestIndexedSnapshot: PolarisSnapshot
  - The latest snapshot that is indexed and unexpired, and therefore restorable.
