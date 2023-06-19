// AwsNativeAccount.cs
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region AwsNativeAccount
 
    public class AwsNativeAccount: BaseType, HierarchyObject, PolarisHierarchyObject
    {
        #region members

        //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations { get; set; }

        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType! (enum)
        [JsonProperty("cloudType")]
        public AwsCloudType? CloudType { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> AwsAccountStatus? Status
        // GraphQL -> status: AwsAccountStatus! (enum)
        [JsonProperty("status")]
        public AwsAccountStatus? Status { get; set; }

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

        //      C# -> System.Int32? EbsVolumeCount
        // GraphQL -> ebsVolumeCount: Int! (scalar)
        [JsonProperty("ebsVolumeCount")]
        public System.Int32? EbsVolumeCount { get; set; }

        //      C# -> System.Int32? Ec2InstanceCount
        // GraphQL -> ec2InstanceCount: Int! (scalar)
        [JsonProperty("ec2InstanceCount")]
        public System.Int32? Ec2InstanceCount { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        [JsonProperty("lastRefreshedAt")]
        public DateTime? LastRefreshedAt { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? RdsInstanceCount
        // GraphQL -> rdsInstanceCount: Int! (scalar)
        [JsonProperty("rdsInstanceCount")]
        public System.Int32? RdsInstanceCount { get; set; }

        //      C# -> System.Int32? S3BucketCount
        // GraphQL -> s3BucketCount: Int! (scalar)
        [JsonProperty("s3BucketCount")]
        public System.Int32? S3BucketCount { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> AwsNativeEbsVolumeConnection? AwsNativeEbsVolumes
        // GraphQL -> awsNativeEbsVolumes: AwsNativeEbsVolumeConnection! (type)
        [JsonProperty("awsNativeEbsVolumes")]
        public AwsNativeEbsVolumeConnection? AwsNativeEbsVolumes { get; set; }

        //      C# -> AwsNativeEc2InstanceConnection? AwsNativeEc2Instances
        // GraphQL -> awsNativeEc2Instances: AwsNativeEc2InstanceConnection! (type)
        [JsonProperty("awsNativeEc2Instances")]
        public AwsNativeEc2InstanceConnection? AwsNativeEc2Instances { get; set; }

        //      C# -> AwsNativeRdsInstanceConnection? AwsNativeRdsInstances
        // GraphQL -> awsNativeRdsInstances: AwsNativeRdsInstanceConnection! (type)
        [JsonProperty("awsNativeRdsInstances")]
        public AwsNativeRdsInstanceConnection? AwsNativeRdsInstances { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> List<AwsNativeRegionSpec>? RegionSpecs
        // GraphQL -> regionSpecs: [AwsNativeRegionSpec!]! (type)
        [JsonProperty("regionSpecs")]
        public List<AwsNativeRegionSpec>? RegionSpecs { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }


        #endregion

    #region methods

    public AwsNativeAccount Set(
        List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations = null,
        AwsCloudType? CloudType = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        AwsAccountStatus? Status = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        System.Int32? EbsVolumeCount = null,
        System.Int32? Ec2InstanceCount = null,
        System.String? Id = null,
        DateTime? LastRefreshedAt = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? RdsInstanceCount = null,
        System.Int32? S3BucketCount = null,
        System.Boolean? SlaPauseStatus = null,
        List<Org>? AllOrgs = null,
        AwsNativeEbsVolumeConnection? AwsNativeEbsVolumes = null,
        AwsNativeEc2InstanceConnection? AwsNativeEc2Instances = null,
        AwsNativeRdsInstanceConnection? AwsNativeRdsInstances = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<PathNode>? LogicalPath = null,
        List<PathNode>? PhysicalPath = null,
        List<AwsNativeRegionSpec>? RegionSpecs = null,
        SnapshotDistribution? SnapshotDistribution = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        if ( EbsVolumeCount != null ) {
            this.EbsVolumeCount = EbsVolumeCount;
        }
        if ( Ec2InstanceCount != null ) {
            this.Ec2InstanceCount = Ec2InstanceCount;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastRefreshedAt != null ) {
            this.LastRefreshedAt = LastRefreshedAt;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( RdsInstanceCount != null ) {
            this.RdsInstanceCount = RdsInstanceCount;
        }
        if ( S3BucketCount != null ) {
            this.S3BucketCount = S3BucketCount;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AwsNativeEbsVolumes != null ) {
            this.AwsNativeEbsVolumes = AwsNativeEbsVolumes;
        }
        if ( AwsNativeEc2Instances != null ) {
            this.AwsNativeEc2Instances = AwsNativeEc2Instances;
        }
        if ( AwsNativeRdsInstances != null ) {
            this.AwsNativeRdsInstances = AwsNativeRdsInstances;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( RegionSpecs != null ) {
            this.RegionSpecs = RegionSpecs;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
        if (this.AuthorizedOperations != null) {
            s += ind + "authorizedOperations\n" ;
        }
        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType! (enum)
        if (this.CloudType != null) {
            s += ind + "cloudType\n" ;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment != null) {
            s += ind + "slaAssignment\n" ;
        }
        //      C# -> AwsAccountStatus? Status
        // GraphQL -> status: AwsAccountStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.ConfiguredSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "configuredSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveRetentionSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveRetentionSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.Int32? EbsVolumeCount
        // GraphQL -> ebsVolumeCount: Int! (scalar)
        if (this.EbsVolumeCount != null) {
            s += ind + "ebsVolumeCount\n" ;
        }
        //      C# -> System.Int32? Ec2InstanceCount
        // GraphQL -> ec2InstanceCount: Int! (scalar)
        if (this.Ec2InstanceCount != null) {
            s += ind + "ec2InstanceCount\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        if (this.LastRefreshedAt != null) {
            s += ind + "lastRefreshedAt\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants != null) {
            s += ind + "numWorkloadDescendants\n" ;
        }
        //      C# -> System.Int32? RdsInstanceCount
        // GraphQL -> rdsInstanceCount: Int! (scalar)
        if (this.RdsInstanceCount != null) {
            s += ind + "rdsInstanceCount\n" ;
        }
        //      C# -> System.Int32? S3BucketCount
        // GraphQL -> s3BucketCount: Int! (scalar)
        if (this.S3BucketCount != null) {
            s += ind + "s3BucketCount\n" ;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            s += ind + "slaPauseStatus\n" ;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allOrgs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AwsNativeEbsVolumeConnection? AwsNativeEbsVolumes
        // GraphQL -> awsNativeEbsVolumes: AwsNativeEbsVolumeConnection! (type)
        if (this.AwsNativeEbsVolumes != null) {
            var fspec = this.AwsNativeEbsVolumes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "awsNativeEbsVolumes {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AwsNativeEc2InstanceConnection? AwsNativeEc2Instances
        // GraphQL -> awsNativeEc2Instances: AwsNativeEc2InstanceConnection! (type)
        if (this.AwsNativeEc2Instances != null) {
            var fspec = this.AwsNativeEc2Instances.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "awsNativeEc2Instances {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AwsNativeRdsInstanceConnection? AwsNativeRdsInstances
        // GraphQL -> awsNativeRdsInstances: AwsNativeRdsInstanceConnection! (type)
        if (this.AwsNativeRdsInstances != null) {
            var fspec = this.AwsNativeRdsInstances.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "awsNativeRdsInstances {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            var fspec = this.EffectiveSlaSourceObject.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveSlaSourceObject {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            var fspec = this.LogicalPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "logicalPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            var fspec = this.PhysicalPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "physicalPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AwsNativeRegionSpec>? RegionSpecs
        // GraphQL -> regionSpecs: [AwsNativeRegionSpec!]! (type)
        if (this.RegionSpecs != null) {
            var fspec = this.RegionSpecs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "regionSpecs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            var fspec = this.SnapshotDistribution.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotDistribution {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
        if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations", true))
        {
            this.AuthorizedOperations = new List<PolarisObjectAuthorizedOperationsEnum>();
        }
        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType! (enum)
        if (this.CloudType == null && Exploration.Includes(parent + ".cloudType", true))
        {
            this.CloudType = new AwsCloudType();
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new HierarchyObjectTypeEnum();
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment", true))
        {
            this.SlaAssignment = new SlaAssignmentTypeEnum();
        }
        //      C# -> AwsAccountStatus? Status
        // GraphQL -> status: AwsAccountStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new AwsAccountStatus();
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain == null && Exploration.Includes(parent + ".configuredSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".configuredSlaDomain");
            this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain == null && Exploration.Includes(parent + ".effectiveRetentionSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".effectiveRetentionSlaDomain");
            this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain == null && Exploration.Includes(parent + ".effectiveSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".effectiveSlaDomain");
            this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.Int32? EbsVolumeCount
        // GraphQL -> ebsVolumeCount: Int! (scalar)
        if (this.EbsVolumeCount == null && Exploration.Includes(parent + ".ebsVolumeCount", true))
        {
            this.EbsVolumeCount = Int32.MinValue;
        }
        //      C# -> System.Int32? Ec2InstanceCount
        // GraphQL -> ec2InstanceCount: Int! (scalar)
        if (this.Ec2InstanceCount == null && Exploration.Includes(parent + ".ec2InstanceCount", true))
        {
            this.Ec2InstanceCount = Int32.MinValue;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        if (this.LastRefreshedAt == null && Exploration.Includes(parent + ".lastRefreshedAt", true))
        {
            this.LastRefreshedAt = new DateTime();
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants == null && Exploration.Includes(parent + ".numWorkloadDescendants", true))
        {
            this.NumWorkloadDescendants = Int32.MinValue;
        }
        //      C# -> System.Int32? RdsInstanceCount
        // GraphQL -> rdsInstanceCount: Int! (scalar)
        if (this.RdsInstanceCount == null && Exploration.Includes(parent + ".rdsInstanceCount", true))
        {
            this.RdsInstanceCount = Int32.MinValue;
        }
        //      C# -> System.Int32? S3BucketCount
        // GraphQL -> s3BucketCount: Int! (scalar)
        if (this.S3BucketCount == null && Exploration.Includes(parent + ".s3BucketCount", true))
        {
            this.S3BucketCount = Int32.MinValue;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus", true))
        {
            this.SlaPauseStatus = true;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(parent + ".allOrgs");
        }
        //      C# -> AwsNativeEbsVolumeConnection? AwsNativeEbsVolumes
        // GraphQL -> awsNativeEbsVolumes: AwsNativeEbsVolumeConnection! (type)
        if (this.AwsNativeEbsVolumes == null && Exploration.Includes(parent + ".awsNativeEbsVolumes"))
        {
            this.AwsNativeEbsVolumes = new AwsNativeEbsVolumeConnection();
            this.AwsNativeEbsVolumes.ApplyExploratoryFieldSpec(parent + ".awsNativeEbsVolumes");
        }
        //      C# -> AwsNativeEc2InstanceConnection? AwsNativeEc2Instances
        // GraphQL -> awsNativeEc2Instances: AwsNativeEc2InstanceConnection! (type)
        if (this.AwsNativeEc2Instances == null && Exploration.Includes(parent + ".awsNativeEc2Instances"))
        {
            this.AwsNativeEc2Instances = new AwsNativeEc2InstanceConnection();
            this.AwsNativeEc2Instances.ApplyExploratoryFieldSpec(parent + ".awsNativeEc2Instances");
        }
        //      C# -> AwsNativeRdsInstanceConnection? AwsNativeRdsInstances
        // GraphQL -> awsNativeRdsInstances: AwsNativeRdsInstanceConnection! (type)
        if (this.AwsNativeRdsInstances == null && Exploration.Includes(parent + ".awsNativeRdsInstances"))
        {
            this.AwsNativeRdsInstances = new AwsNativeRdsInstanceConnection();
            this.AwsNativeRdsInstances.ApplyExploratoryFieldSpec(parent + ".awsNativeRdsInstances");
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
        {
            this.EffectiveSlaSourceObject = new PathNode();
            this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(parent + ".effectiveSlaSourceObject");
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
        {
            this.LogicalPath = new List<PathNode>();
            this.LogicalPath.ApplyExploratoryFieldSpec(parent + ".logicalPath");
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
        {
            this.PhysicalPath = new List<PathNode>();
            this.PhysicalPath.ApplyExploratoryFieldSpec(parent + ".physicalPath");
        }
        //      C# -> List<AwsNativeRegionSpec>? RegionSpecs
        // GraphQL -> regionSpecs: [AwsNativeRegionSpec!]! (type)
        if (this.RegionSpecs == null && Exploration.Includes(parent + ".regionSpecs"))
        {
            this.RegionSpecs = new List<AwsNativeRegionSpec>();
            this.RegionSpecs.ApplyExploratoryFieldSpec(parent + ".regionSpecs");
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
        {
            this.SnapshotDistribution = new SnapshotDistribution();
            this.SnapshotDistribution.ApplyExploratoryFieldSpec(parent + ".snapshotDistribution");
        }
    }


    #endregion

    } // class AwsNativeAccount
    
    #endregion

    public static class ListAwsNativeAccountExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<AwsNativeAccount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsNativeAccount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsNativeAccount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types