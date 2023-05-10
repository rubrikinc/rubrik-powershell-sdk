// AwsNativeEc2Instance.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region AwsNativeEc2Instance
 
    public class AwsNativeEc2Instance: IFragment, AwsNativeAccountDescendantType, AwsNativeAccountLogicalChildType, AwsNativeHierarchyObject, HierarchyObject, PolarisHierarchyObject, PolarisHierarchySnappable
    {
        #region members
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> System.String? AwsAccountRubrikId
        // GraphQL -> awsAccountRubrikId: String! (scalar)
        [JsonProperty("awsAccountRubrikId")]
        public System.String? AwsAccountRubrikId { get; set; }

        //      C# -> System.String? AwsNativeAccountName
        // GraphQL -> awsNativeAccountName: String! (scalar)
        [JsonProperty("awsNativeAccountName")]
        public System.String? AwsNativeAccountName { get; set; }

        //      C# -> System.String? CloudNativeId
        // GraphQL -> cloudNativeId: String! (scalar)
        [JsonProperty("cloudNativeId")]
        public System.String? CloudNativeId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        [JsonProperty("instanceName")]
        public System.String? InstanceName { get; set; }

        //      C# -> System.String? InstanceNativeId
        // GraphQL -> instanceNativeId: String! (scalar)
        [JsonProperty("instanceNativeId")]
        public System.String? InstanceNativeId { get; set; }

        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        [JsonProperty("instanceType")]
        public System.String? InstanceType { get; set; }

        //      C# -> System.Boolean? IsExocomputeConfigured
        // GraphQL -> isExocomputeConfigured: Boolean! (scalar)
        [JsonProperty("isExocomputeConfigured")]
        public System.Boolean? IsExocomputeConfigured { get; set; }

        //      C# -> System.Boolean? IsIndexingEnabled
        // GraphQL -> isIndexingEnabled: Boolean! (scalar)
        [JsonProperty("isIndexingEnabled")]
        public System.Boolean? IsIndexingEnabled { get; set; }

        //      C# -> System.Boolean? IsMarketplace
        // GraphQL -> isMarketplace: Boolean! (scalar)
        [JsonProperty("isMarketplace")]
        public System.Boolean? IsMarketplace { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeName
        // GraphQL -> nativeName: String! (scalar)
        [JsonProperty("nativeName")]
        public System.String? NativeName { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        [JsonProperty("onDemandSnapshotCount")]
        public System.Int32? OnDemandSnapshotCount { get; set; }

        //      C# -> System.String? PrivateIp
        // GraphQL -> privateIp: String! (scalar)
        [JsonProperty("privateIp")]
        public System.String? PrivateIp { get; set; }

        //      C# -> System.String? PublicIp
        // GraphQL -> publicIp: String! (scalar)
        [JsonProperty("publicIp")]
        public System.String? PublicIp { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.String? SshKeyPairName
        // GraphQL -> sshKeyPairName: String! (scalar)
        [JsonProperty("sshKeyPairName")]
        public System.String? SshKeyPairName { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> System.String? VpcName
        // GraphQL -> vpcName: String! (scalar)
        [JsonProperty("vpcName")]
        public System.String? VpcName { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> List<AwsNativeEbsVolume>? AttachedEbsVolumes
        // GraphQL -> attachedEbsVolumes: [AwsNativeEbsVolume!]! (type)
        [JsonProperty("attachedEbsVolumes")]
        public List<AwsNativeEbsVolume>? AttachedEbsVolumes { get; set; }

        //      C# -> List<AttachmentSpecForEc2Instance>? AttachmentSpecs
        // GraphQL -> attachmentSpecs: [AttachmentSpecForEc2Instance!]! (type)
        [JsonProperty("attachmentSpecs")]
        public List<AttachmentSpecForEc2Instance>? AttachmentSpecs { get; set; }

        //      C# -> AwsNativeAccount? AwsNativeAccount
        // GraphQL -> awsNativeAccount: AwsNativeAccount! (type)
        [JsonProperty("awsNativeAccount")]
        public AwsNativeAccount? AwsNativeAccount { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> PhysicalHost? HostInfo
        // GraphQL -> hostInfo: PhysicalHost (type)
        [JsonProperty("hostInfo")]
        public PhysicalHost? HostInfo { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        [JsonProperty("newestIndexedSnapshot")]
        public PolarisSnapshot? NewestIndexedSnapshot { get; set; }

        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        [JsonProperty("newestSnapshot")]
        public PolarisSnapshot? NewestSnapshot { get; set; }

        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        [JsonProperty("oldestSnapshot")]
        public PolarisSnapshot? OldestSnapshot { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        [JsonProperty("snapshotConnection")]
        public PolarisSnapshotConnection? SnapshotConnection { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        [JsonProperty("snapshotGroupByConnection")]
        public PolarisSnapshotGroupByConnection? SnapshotGroupByConnection { get; set; }

        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        [JsonProperty("snapshotGroupByNewConnection")]
        public PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection { get; set; }

        //      C# -> List<Tag>? Tags
        // GraphQL -> tags: [Tag!]! (type)
        [JsonProperty("tags")]
        public List<Tag>? Tags { get; set; }

        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        [JsonProperty("workloadSnapshotConnection")]
        public GenericSnapshotConnection? WorkloadSnapshotConnection { get; set; }

        //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> OsType? OsType
        // GraphQL -> osType: OsType! (enum)
        [JsonProperty("osType")]
        public OsType? OsType { get; set; }

        //      C# -> AwsNativeRegion? Region
        // GraphQL -> region: AwsNativeRegion! (enum)
        [JsonProperty("region")]
        public AwsNativeRegion? Region { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        [JsonProperty("configuredSlaDomain")]
        public SlaDomain? ConfiguredSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        [JsonProperty("effectiveRetentionSlaDomain")]
        public SlaDomain? EffectiveRetentionSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        [JsonProperty("effectiveSlaDomain")]
        public SlaDomain? EffectiveSlaDomain { get; set; }

        #endregion

    #region methods

    public AwsNativeEc2Instance Set(
        System.String? AvailabilityZone = null,
        System.String? AwsAccountRubrikId = null,
        System.String? AwsNativeAccountName = null,
        System.String? CloudNativeId = null,
        System.String? Id = null,
        System.String? InstanceName = null,
        System.String? InstanceNativeId = null,
        System.String? InstanceType = null,
        System.Boolean? IsExocomputeConfigured = null,
        System.Boolean? IsIndexingEnabled = null,
        System.Boolean? IsMarketplace = null,
        System.Boolean? IsRelic = null,
        System.String? Name = null,
        System.String? NativeName = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.String? PrivateIp = null,
        System.String? PublicIp = null,
        System.Boolean? SlaPauseStatus = null,
        System.String? SshKeyPairName = null,
        System.String? VpcId = null,
        System.String? VpcName = null,
        List<Org>? AllOrgs = null,
        List<AwsNativeEbsVolume>? AttachedEbsVolumes = null,
        List<AttachmentSpecForEc2Instance>? AttachmentSpecs = null,
        AwsNativeAccount? AwsNativeAccount = null,
        PathNode? EffectiveSlaSourceObject = null,
        PhysicalHost? HostInfo = null,
        List<PathNode>? LogicalPath = null,
        PolarisSnapshot? NewestIndexedSnapshot = null,
        PolarisSnapshot? NewestSnapshot = null,
        PolarisSnapshot? OldestSnapshot = null,
        List<PathNode>? PhysicalPath = null,
        PolarisSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        PolarisSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection = null,
        List<Tag>? Tags = null,
        GenericSnapshotConnection? WorkloadSnapshotConnection = null,
        List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        OsType? OsType = null,
        AwsNativeRegion? Region = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null
    ) 
    {
        if ( AvailabilityZone != null ) {
            this.AvailabilityZone = AvailabilityZone;
        }
        if ( AwsAccountRubrikId != null ) {
            this.AwsAccountRubrikId = AwsAccountRubrikId;
        }
        if ( AwsNativeAccountName != null ) {
            this.AwsNativeAccountName = AwsNativeAccountName;
        }
        if ( CloudNativeId != null ) {
            this.CloudNativeId = CloudNativeId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( InstanceName != null ) {
            this.InstanceName = InstanceName;
        }
        if ( InstanceNativeId != null ) {
            this.InstanceNativeId = InstanceNativeId;
        }
        if ( InstanceType != null ) {
            this.InstanceType = InstanceType;
        }
        if ( IsExocomputeConfigured != null ) {
            this.IsExocomputeConfigured = IsExocomputeConfigured;
        }
        if ( IsIndexingEnabled != null ) {
            this.IsIndexingEnabled = IsIndexingEnabled;
        }
        if ( IsMarketplace != null ) {
            this.IsMarketplace = IsMarketplace;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeName != null ) {
            this.NativeName = NativeName;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( OnDemandSnapshotCount != null ) {
            this.OnDemandSnapshotCount = OnDemandSnapshotCount;
        }
        if ( PrivateIp != null ) {
            this.PrivateIp = PrivateIp;
        }
        if ( PublicIp != null ) {
            this.PublicIp = PublicIp;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( SshKeyPairName != null ) {
            this.SshKeyPairName = SshKeyPairName;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
        }
        if ( VpcName != null ) {
            this.VpcName = VpcName;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AttachedEbsVolumes != null ) {
            this.AttachedEbsVolumes = AttachedEbsVolumes;
        }
        if ( AttachmentSpecs != null ) {
            this.AttachmentSpecs = AttachmentSpecs;
        }
        if ( AwsNativeAccount != null ) {
            this.AwsNativeAccount = AwsNativeAccount;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( HostInfo != null ) {
            this.HostInfo = HostInfo;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( NewestIndexedSnapshot != null ) {
            this.NewestIndexedSnapshot = NewestIndexedSnapshot;
        }
        if ( NewestSnapshot != null ) {
            this.NewestSnapshot = NewestSnapshot;
        }
        if ( OldestSnapshot != null ) {
            this.OldestSnapshot = OldestSnapshot;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( SnapshotConnection != null ) {
            this.SnapshotConnection = SnapshotConnection;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        if ( SnapshotGroupByConnection != null ) {
            this.SnapshotGroupByConnection = SnapshotGroupByConnection;
        }
        if ( SnapshotGroupByNewConnection != null ) {
            this.SnapshotGroupByNewConnection = SnapshotGroupByNewConnection;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
        }
        if ( WorkloadSnapshotConnection != null ) {
            this.WorkloadSnapshotConnection = WorkloadSnapshotConnection;
        }
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( ConfiguredSlaDomain != null ) {
            this.ConfiguredSlaDomain = ConfiguredSlaDomain;
        }
        if ( EffectiveRetentionSlaDomain != null ) {
            this.EffectiveRetentionSlaDomain = EffectiveRetentionSlaDomain;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? AvailabilityZone
            // GraphQL -> availabilityZone: String! (scalar)
            if (this.AvailabilityZone != null)
            {
                 s += ind + "availabilityZone\n";

            }
            //      C# -> System.String? AwsAccountRubrikId
            // GraphQL -> awsAccountRubrikId: String! (scalar)
            if (this.AwsAccountRubrikId != null)
            {
                 s += ind + "awsAccountRubrikId\n";

            }
            //      C# -> System.String? AwsNativeAccountName
            // GraphQL -> awsNativeAccountName: String! (scalar)
            if (this.AwsNativeAccountName != null)
            {
                 s += ind + "awsNativeAccountName\n";

            }
            //      C# -> System.String? CloudNativeId
            // GraphQL -> cloudNativeId: String! (scalar)
            if (this.CloudNativeId != null)
            {
                 s += ind + "cloudNativeId\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? InstanceName
            // GraphQL -> instanceName: String! (scalar)
            if (this.InstanceName != null)
            {
                 s += ind + "instanceName\n";

            }
            //      C# -> System.String? InstanceNativeId
            // GraphQL -> instanceNativeId: String! (scalar)
            if (this.InstanceNativeId != null)
            {
                 s += ind + "instanceNativeId\n";

            }
            //      C# -> System.String? InstanceType
            // GraphQL -> instanceType: String! (scalar)
            if (this.InstanceType != null)
            {
                 s += ind + "instanceType\n";

            }
            //      C# -> System.Boolean? IsExocomputeConfigured
            // GraphQL -> isExocomputeConfigured: Boolean! (scalar)
            if (this.IsExocomputeConfigured != null)
            {
                 s += ind + "isExocomputeConfigured\n";

            }
            //      C# -> System.Boolean? IsIndexingEnabled
            // GraphQL -> isIndexingEnabled: Boolean! (scalar)
            if (this.IsIndexingEnabled != null)
            {
                 s += ind + "isIndexingEnabled\n";

            }
            //      C# -> System.Boolean? IsMarketplace
            // GraphQL -> isMarketplace: Boolean! (scalar)
            if (this.IsMarketplace != null)
            {
                 s += ind + "isMarketplace\n";

            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic != null)
            {
                 s += ind + "isRelic\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? NativeName
            // GraphQL -> nativeName: String! (scalar)
            if (this.NativeName != null)
            {
                 s += ind + "nativeName\n";

            }
            //      C# -> System.Int32? NumWorkloadDescendants
            // GraphQL -> numWorkloadDescendants: Int! (scalar)
            if (this.NumWorkloadDescendants != null)
            {
                 s += ind + "numWorkloadDescendants\n";

            }
            //      C# -> System.Int32? OnDemandSnapshotCount
            // GraphQL -> onDemandSnapshotCount: Int! (scalar)
            if (this.OnDemandSnapshotCount != null)
            {
                 s += ind + "onDemandSnapshotCount\n";

            }
            //      C# -> System.String? PrivateIp
            // GraphQL -> privateIp: String! (scalar)
            if (this.PrivateIp != null)
            {
                 s += ind + "privateIp\n";

            }
            //      C# -> System.String? PublicIp
            // GraphQL -> publicIp: String! (scalar)
            if (this.PublicIp != null)
            {
                 s += ind + "publicIp\n";

            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus != null)
            {
                 s += ind + "slaPauseStatus\n";

            }
            //      C# -> System.String? SshKeyPairName
            // GraphQL -> sshKeyPairName: String! (scalar)
            if (this.SshKeyPairName != null)
            {
                 s += ind + "sshKeyPairName\n";

            }
            //      C# -> System.String? VpcId
            // GraphQL -> vpcId: String! (scalar)
            if (this.VpcId != null)
            {
                 s += ind + "vpcId\n";

            }
            //      C# -> System.String? VpcName
            // GraphQL -> vpcName: String! (scalar)
            if (this.VpcName != null)
            {
                 s += ind + "vpcName\n";

            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs != null)
            {
                 s += ind + "allOrgs\n";

                 s += ind + "{\n" + 
                 this.AllOrgs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AwsNativeEbsVolume>? AttachedEbsVolumes
            // GraphQL -> attachedEbsVolumes: [AwsNativeEbsVolume!]! (type)
            if (this.AttachedEbsVolumes != null)
            {
                 s += ind + "attachedEbsVolumes\n";

                 s += ind + "{\n" + 
                 this.AttachedEbsVolumes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<AttachmentSpecForEc2Instance>? AttachmentSpecs
            // GraphQL -> attachmentSpecs: [AttachmentSpecForEc2Instance!]! (type)
            if (this.AttachmentSpecs != null)
            {
                 s += ind + "attachmentSpecs\n";

                 s += ind + "{\n" + 
                 this.AttachmentSpecs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AwsNativeAccount? AwsNativeAccount
            // GraphQL -> awsNativeAccount: AwsNativeAccount! (type)
            if (this.AwsNativeAccount != null)
            {
                 s += ind + "awsNativeAccount\n";

                 s += ind + "{\n" + 
                 this.AwsNativeAccount.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject != null)
            {
                 s += ind + "effectiveSlaSourceObject\n";

                 s += ind + "{\n" + 
                 this.EffectiveSlaSourceObject.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PhysicalHost? HostInfo
            // GraphQL -> hostInfo: PhysicalHost (type)
            if (this.HostInfo != null)
            {
                 s += ind + "hostInfo\n";

                 s += ind + "{\n" + 
                 this.HostInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath != null)
            {
                 s += ind + "logicalPath\n";

                 s += ind + "{\n" + 
                 this.LogicalPath.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PolarisSnapshot? NewestIndexedSnapshot
            // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
            if (this.NewestIndexedSnapshot != null)
            {
                 s += ind + "newestIndexedSnapshot\n";

                 s += ind + "{\n" + 
                 this.NewestIndexedSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PolarisSnapshot? NewestSnapshot
            // GraphQL -> newestSnapshot: PolarisSnapshot (type)
            if (this.NewestSnapshot != null)
            {
                 s += ind + "newestSnapshot\n";

                 s += ind + "{\n" + 
                 this.NewestSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PolarisSnapshot? OldestSnapshot
            // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
            if (this.OldestSnapshot != null)
            {
                 s += ind + "oldestSnapshot\n";

                 s += ind + "{\n" + 
                 this.OldestSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<PathNode>? PhysicalPath
            // GraphQL -> physicalPath: [PathNode!]! (type)
            if (this.PhysicalPath != null)
            {
                 s += ind + "physicalPath\n";

                 s += ind + "{\n" + 
                 this.PhysicalPath.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PolarisSnapshotConnection? SnapshotConnection
            // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
            if (this.SnapshotConnection != null)
            {
                 s += ind + "snapshotConnection\n";

                 s += ind + "{\n" + 
                 this.SnapshotConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SnapshotDistribution? SnapshotDistribution
            // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
            if (this.SnapshotDistribution != null)
            {
                 s += ind + "snapshotDistribution\n";

                 s += ind + "{\n" + 
                 this.SnapshotDistribution.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
            // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
            if (this.SnapshotGroupByConnection != null)
            {
                 s += ind + "snapshotGroupByConnection\n";

                 s += ind + "{\n" + 
                 this.SnapshotGroupByConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
            // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
            if (this.SnapshotGroupByNewConnection != null)
            {
                 s += ind + "snapshotGroupByNewConnection\n";

                 s += ind + "{\n" + 
                 this.SnapshotGroupByNewConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<Tag>? Tags
            // GraphQL -> tags: [Tag!]! (type)
            if (this.Tags != null)
            {
                 s += ind + "tags\n";

                 s += ind + "{\n" + 
                 this.Tags.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
            // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
            if (this.WorkloadSnapshotConnection != null)
            {
                 s += ind + "workloadSnapshotConnection\n";

                 s += ind + "{\n" + 
                 this.WorkloadSnapshotConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
            if (this.AuthorizedOperations != null)
            {
                 s += ind + "authorizedOperations\n";

            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            //      C# -> OsType? OsType
            // GraphQL -> osType: OsType! (enum)
            if (this.OsType != null)
            {
                 s += ind + "osType\n";

            }
            //      C# -> AwsNativeRegion? Region
            // GraphQL -> region: AwsNativeRegion! (enum)
            if (this.Region != null)
            {
                 s += ind + "region\n";

            }
            //      C# -> SlaAssignmentTypeEnum? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
            if (this.SlaAssignment != null)
            {
                 s += ind + "slaAssignment\n";

            }
                        //      C# -> SlaDomain? ConfiguredSlaDomain
            // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
            if (this.ConfiguredSlaDomain != null)
            {
                s += ind + "configuredSlaDomain\n";
                s += ind + "{\n";

                string typename = this.ConfiguredSlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.ConfiguredSlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
            // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
            if (this.EffectiveRetentionSlaDomain != null)
            {
                s += ind + "effectiveRetentionSlaDomain\n";
                s += ind + "{\n";

                string typename = this.EffectiveRetentionSlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.EffectiveRetentionSlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> SlaDomain? EffectiveSlaDomain
            // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
            if (this.EffectiveSlaDomain != null)
            {
                s += ind + "effectiveSlaDomain\n";
                s += ind + "{\n";

                string typename = this.EffectiveSlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.EffectiveSlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AvailabilityZone
            // GraphQL -> availabilityZone: String! (scalar)
            if (this.AvailabilityZone == null && Exploration.Includes(parent + ".availabilityZone$"))
            {
                this.AvailabilityZone = new System.String("FETCH");
            }
            //      C# -> System.String? AwsAccountRubrikId
            // GraphQL -> awsAccountRubrikId: String! (scalar)
            if (this.AwsAccountRubrikId == null && Exploration.Includes(parent + ".awsAccountRubrikId$"))
            {
                this.AwsAccountRubrikId = new System.String("FETCH");
            }
            //      C# -> System.String? AwsNativeAccountName
            // GraphQL -> awsNativeAccountName: String! (scalar)
            if (this.AwsNativeAccountName == null && Exploration.Includes(parent + ".awsNativeAccountName$"))
            {
                this.AwsNativeAccountName = new System.String("FETCH");
            }
            //      C# -> System.String? CloudNativeId
            // GraphQL -> cloudNativeId: String! (scalar)
            if (this.CloudNativeId == null && Exploration.Includes(parent + ".cloudNativeId$"))
            {
                this.CloudNativeId = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? InstanceName
            // GraphQL -> instanceName: String! (scalar)
            if (this.InstanceName == null && Exploration.Includes(parent + ".instanceName$"))
            {
                this.InstanceName = new System.String("FETCH");
            }
            //      C# -> System.String? InstanceNativeId
            // GraphQL -> instanceNativeId: String! (scalar)
            if (this.InstanceNativeId == null && Exploration.Includes(parent + ".instanceNativeId$"))
            {
                this.InstanceNativeId = new System.String("FETCH");
            }
            //      C# -> System.String? InstanceType
            // GraphQL -> instanceType: String! (scalar)
            if (this.InstanceType == null && Exploration.Includes(parent + ".instanceType$"))
            {
                this.InstanceType = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsExocomputeConfigured
            // GraphQL -> isExocomputeConfigured: Boolean! (scalar)
            if (this.IsExocomputeConfigured == null && Exploration.Includes(parent + ".isExocomputeConfigured$"))
            {
                this.IsExocomputeConfigured = new System.Boolean();
            }
            //      C# -> System.Boolean? IsIndexingEnabled
            // GraphQL -> isIndexingEnabled: Boolean! (scalar)
            if (this.IsIndexingEnabled == null && Exploration.Includes(parent + ".isIndexingEnabled$"))
            {
                this.IsIndexingEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsMarketplace
            // GraphQL -> isMarketplace: Boolean! (scalar)
            if (this.IsMarketplace == null && Exploration.Includes(parent + ".isMarketplace$"))
            {
                this.IsMarketplace = new System.Boolean();
            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic$"))
            {
                this.IsRelic = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? NativeName
            // GraphQL -> nativeName: String! (scalar)
            if (this.NativeName == null && Exploration.Includes(parent + ".nativeName$"))
            {
                this.NativeName = new System.String("FETCH");
            }
            //      C# -> System.Int32? NumWorkloadDescendants
            // GraphQL -> numWorkloadDescendants: Int! (scalar)
            if (this.NumWorkloadDescendants == null && Exploration.Includes(parent + ".numWorkloadDescendants$"))
            {
                this.NumWorkloadDescendants = new System.Int32();
            }
            //      C# -> System.Int32? OnDemandSnapshotCount
            // GraphQL -> onDemandSnapshotCount: Int! (scalar)
            if (this.OnDemandSnapshotCount == null && Exploration.Includes(parent + ".onDemandSnapshotCount$"))
            {
                this.OnDemandSnapshotCount = new System.Int32();
            }
            //      C# -> System.String? PrivateIp
            // GraphQL -> privateIp: String! (scalar)
            if (this.PrivateIp == null && Exploration.Includes(parent + ".privateIp$"))
            {
                this.PrivateIp = new System.String("FETCH");
            }
            //      C# -> System.String? PublicIp
            // GraphQL -> publicIp: String! (scalar)
            if (this.PublicIp == null && Exploration.Includes(parent + ".publicIp$"))
            {
                this.PublicIp = new System.String("FETCH");
            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus$"))
            {
                this.SlaPauseStatus = new System.Boolean();
            }
            //      C# -> System.String? SshKeyPairName
            // GraphQL -> sshKeyPairName: String! (scalar)
            if (this.SshKeyPairName == null && Exploration.Includes(parent + ".sshKeyPairName$"))
            {
                this.SshKeyPairName = new System.String("FETCH");
            }
            //      C# -> System.String? VpcId
            // GraphQL -> vpcId: String! (scalar)
            if (this.VpcId == null && Exploration.Includes(parent + ".vpcId$"))
            {
                this.VpcId = new System.String("FETCH");
            }
            //      C# -> System.String? VpcName
            // GraphQL -> vpcName: String! (scalar)
            if (this.VpcName == null && Exploration.Includes(parent + ".vpcName$"))
            {
                this.VpcName = new System.String("FETCH");
            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
            {
                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFragment(parent + ".allOrgs");
            }
            //      C# -> List<AwsNativeEbsVolume>? AttachedEbsVolumes
            // GraphQL -> attachedEbsVolumes: [AwsNativeEbsVolume!]! (type)
            if (this.AttachedEbsVolumes == null && Exploration.Includes(parent + ".attachedEbsVolumes"))
            {
                this.AttachedEbsVolumes = new List<AwsNativeEbsVolume>();
                this.AttachedEbsVolumes.ApplyExploratoryFragment(parent + ".attachedEbsVolumes");
            }
            //      C# -> List<AttachmentSpecForEc2Instance>? AttachmentSpecs
            // GraphQL -> attachmentSpecs: [AttachmentSpecForEc2Instance!]! (type)
            if (this.AttachmentSpecs == null && Exploration.Includes(parent + ".attachmentSpecs"))
            {
                this.AttachmentSpecs = new List<AttachmentSpecForEc2Instance>();
                this.AttachmentSpecs.ApplyExploratoryFragment(parent + ".attachmentSpecs");
            }
            //      C# -> AwsNativeAccount? AwsNativeAccount
            // GraphQL -> awsNativeAccount: AwsNativeAccount! (type)
            if (this.AwsNativeAccount == null && Exploration.Includes(parent + ".awsNativeAccount"))
            {
                this.AwsNativeAccount = new AwsNativeAccount();
                this.AwsNativeAccount.ApplyExploratoryFragment(parent + ".awsNativeAccount");
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
            {
                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFragment(parent + ".effectiveSlaSourceObject");
            }
            //      C# -> PhysicalHost? HostInfo
            // GraphQL -> hostInfo: PhysicalHost (type)
            if (this.HostInfo == null && Exploration.Includes(parent + ".hostInfo"))
            {
                this.HostInfo = new PhysicalHost();
                this.HostInfo.ApplyExploratoryFragment(parent + ".hostInfo");
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
            {
                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFragment(parent + ".logicalPath");
            }
            //      C# -> PolarisSnapshot? NewestIndexedSnapshot
            // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
            if (this.NewestIndexedSnapshot == null && Exploration.Includes(parent + ".newestIndexedSnapshot"))
            {
                this.NewestIndexedSnapshot = new PolarisSnapshot();
                this.NewestIndexedSnapshot.ApplyExploratoryFragment(parent + ".newestIndexedSnapshot");
            }
            //      C# -> PolarisSnapshot? NewestSnapshot
            // GraphQL -> newestSnapshot: PolarisSnapshot (type)
            if (this.NewestSnapshot == null && Exploration.Includes(parent + ".newestSnapshot"))
            {
                this.NewestSnapshot = new PolarisSnapshot();
                this.NewestSnapshot.ApplyExploratoryFragment(parent + ".newestSnapshot");
            }
            //      C# -> PolarisSnapshot? OldestSnapshot
            // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
            if (this.OldestSnapshot == null && Exploration.Includes(parent + ".oldestSnapshot"))
            {
                this.OldestSnapshot = new PolarisSnapshot();
                this.OldestSnapshot.ApplyExploratoryFragment(parent + ".oldestSnapshot");
            }
            //      C# -> List<PathNode>? PhysicalPath
            // GraphQL -> physicalPath: [PathNode!]! (type)
            if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
            {
                this.PhysicalPath = new List<PathNode>();
                this.PhysicalPath.ApplyExploratoryFragment(parent + ".physicalPath");
            }
            //      C# -> PolarisSnapshotConnection? SnapshotConnection
            // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
            if (this.SnapshotConnection == null && Exploration.Includes(parent + ".snapshotConnection"))
            {
                this.SnapshotConnection = new PolarisSnapshotConnection();
                this.SnapshotConnection.ApplyExploratoryFragment(parent + ".snapshotConnection");
            }
            //      C# -> SnapshotDistribution? SnapshotDistribution
            // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
            if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
            {
                this.SnapshotDistribution = new SnapshotDistribution();
                this.SnapshotDistribution.ApplyExploratoryFragment(parent + ".snapshotDistribution");
            }
            //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
            // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
            if (this.SnapshotGroupByConnection == null && Exploration.Includes(parent + ".snapshotGroupByConnection"))
            {
                this.SnapshotGroupByConnection = new PolarisSnapshotGroupByConnection();
                this.SnapshotGroupByConnection.ApplyExploratoryFragment(parent + ".snapshotGroupByConnection");
            }
            //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
            // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
            if (this.SnapshotGroupByNewConnection == null && Exploration.Includes(parent + ".snapshotGroupByNewConnection"))
            {
                this.SnapshotGroupByNewConnection = new PolarisSnapshotGroupByNewConnection();
                this.SnapshotGroupByNewConnection.ApplyExploratoryFragment(parent + ".snapshotGroupByNewConnection");
            }
            //      C# -> List<Tag>? Tags
            // GraphQL -> tags: [Tag!]! (type)
            if (this.Tags == null && Exploration.Includes(parent + ".tags"))
            {
                this.Tags = new List<Tag>();
                this.Tags.ApplyExploratoryFragment(parent + ".tags");
            }
            //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
            // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
            if (this.WorkloadSnapshotConnection == null && Exploration.Includes(parent + ".workloadSnapshotConnection"))
            {
                this.WorkloadSnapshotConnection = new GenericSnapshotConnection();
                this.WorkloadSnapshotConnection.ApplyExploratoryFragment(parent + ".workloadSnapshotConnection");
            }
            //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
            if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations$"))
            {
                this.AuthorizedOperations = new List<PolarisSnappableAuthorizedOperationsEnum>();
            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new HierarchyObjectTypeEnum();
            }
            //      C# -> OsType? OsType
            // GraphQL -> osType: OsType! (enum)
            if (this.OsType == null && Exploration.Includes(parent + ".osType$"))
            {
                this.OsType = new OsType();
            }
            //      C# -> AwsNativeRegion? Region
            // GraphQL -> region: AwsNativeRegion! (enum)
            if (this.Region == null && Exploration.Includes(parent + ".region$"))
            {
                this.Region = new AwsNativeRegion();
            }
            //      C# -> SlaAssignmentTypeEnum? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
            if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment$"))
            {
                this.SlaAssignment = new SlaAssignmentTypeEnum();
            }
            //      C# -> SlaDomain? ConfiguredSlaDomain
            // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
            if (this.ConfiguredSlaDomain == null && Exploration.Includes(parent + ".configuredSlaDomain"))
            {
                this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.ConfiguredSlaDomain.ApplyExploratoryFragment(parent + ".configuredSlaDomain");
            }
            //      C# -> SlaDomain? EffectiveRetentionSlaDomain
            // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
            if (this.EffectiveRetentionSlaDomain == null && Exploration.Includes(parent + ".effectiveRetentionSlaDomain"))
            {
                this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.EffectiveRetentionSlaDomain.ApplyExploratoryFragment(parent + ".effectiveRetentionSlaDomain");
            }
            //      C# -> SlaDomain? EffectiveSlaDomain
            // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
            if (this.EffectiveSlaDomain == null && Exploration.Includes(parent + ".effectiveSlaDomain"))
            {
                this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.EffectiveSlaDomain.ApplyExploratoryFragment(parent + ".effectiveSlaDomain");
            }
        }


    #endregion

    } // class AwsNativeEc2Instance
    #endregion

    public static class ListAwsNativeEc2InstanceExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<AwsNativeEc2Instance> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsNativeEc2Instance> list, 
            String parent = "")
        {
            var item = new AwsNativeEc2Instance();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types