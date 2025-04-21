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

        //      C# -> CloudAccountState? CloudAccountState
        // GraphQL -> cloudAccountState: CloudAccountState! (enum)
        [JsonProperty("cloudAccountState")]
        public CloudAccountState? CloudAccountState { get; set; }

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

        //      C# -> System.String? CloudSlabDns
        // GraphQL -> cloudSlabDns: String! (scalar)
        [JsonProperty("cloudSlabDns")]
        public System.String? CloudSlabDns { get; set; }

        //      C# -> System.Int32? DynamoDbTableCount
        // GraphQL -> dynamoDbTableCount: Int! (scalar)
        [JsonProperty("dynamoDbTableCount")]
        public System.Int32? DynamoDbTableCount { get; set; }

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

        //      C# -> ApplicationCloudAccountToExocomputeConfig? ApplicationCloudAccountExoConfigs
        // GraphQL -> applicationCloudAccountExoConfigs: ApplicationCloudAccountToExocomputeConfig! (type)
        [JsonProperty("applicationCloudAccountExoConfigs")]
        public ApplicationCloudAccountToExocomputeConfig? ApplicationCloudAccountExoConfigs { get; set; }

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

        //      C# -> CompactSlaDomain? RscNativeObjectPendingSla
        // GraphQL -> rscNativeObjectPendingSla: CompactSlaDomain (type)
        [JsonProperty("rscNativeObjectPendingSla")]
        public CompactSlaDomain? RscNativeObjectPendingSla { get; set; }

        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        [JsonProperty("securityMetadata")]
        public SecurityMetadata? SecurityMetadata { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars NumWorkloadDescendants { get; set; }

        public RscGqlVars AwsNativeEbsVolumes { get; set; }

        public RscGqlVars AwsNativeEc2Instances { get; set; }

        public RscGqlVars AwsNativeRdsInstances { get; set; }


        public InlineVars() {
            Tuple<string, string>[] numWorkloadDescendantsArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("objectTypes", "[ManagedObjectType!]"),
                };
            this.NumWorkloadDescendants =
                new RscGqlVars(null, numWorkloadDescendantsArgs, null, true);
            Tuple<string, string>[] awsNativeEbsVolumesArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortBy", "AwsNativeEbsVolumeSortFields"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("ebsVolumeFilters", "AwsNativeEbsVolumeFilters"),
                };
            this.AwsNativeEbsVolumes =
                new RscGqlVars(null, awsNativeEbsVolumesArgs, null, true);
            Tuple<string, string>[] awsNativeEc2InstancesArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortBy", "AwsNativeEc2InstanceSortFields"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("ec2InstanceFilters", "AwsNativeEc2InstanceFilters"),
                };
            this.AwsNativeEc2Instances =
                new RscGqlVars(null, awsNativeEc2InstancesArgs, null, true);
            Tuple<string, string>[] awsNativeRdsInstancesArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortBy", "AwsNativeRdsInstanceSortFields"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("rdsInstanceFilters", "AwsNativeRdsInstanceFilters"),
                };
            this.AwsNativeRdsInstances =
                new RscGqlVars(null, awsNativeRdsInstancesArgs, null, true);
        }
    }

    public AwsNativeAccount()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "AwsNativeAccount";
    }

    public AwsNativeAccount Set(
        List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations = null,
        CloudAccountState? CloudAccountState = null,
        AwsCloudType? CloudType = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        AwsAccountStatus? Status = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        System.String? CloudSlabDns = null,
        System.Int32? DynamoDbTableCount = null,
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
        ApplicationCloudAccountToExocomputeConfig? ApplicationCloudAccountExoConfigs = null,
        AwsNativeEbsVolumeConnection? AwsNativeEbsVolumes = null,
        AwsNativeEc2InstanceConnection? AwsNativeEc2Instances = null,
        AwsNativeRdsInstanceConnection? AwsNativeRdsInstances = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<PathNode>? LogicalPath = null,
        List<PathNode>? PhysicalPath = null,
        List<AwsNativeRegionSpec>? RegionSpecs = null,
        CompactSlaDomain? RscNativeObjectPendingSla = null,
        SecurityMetadata? SecurityMetadata = null,
        SnapshotDistribution? SnapshotDistribution = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( CloudAccountState != null ) {
            this.CloudAccountState = CloudAccountState;
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
        if ( CloudSlabDns != null ) {
            this.CloudSlabDns = CloudSlabDns;
        }
        if ( DynamoDbTableCount != null ) {
            this.DynamoDbTableCount = DynamoDbTableCount;
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
        if ( ApplicationCloudAccountExoConfigs != null ) {
            this.ApplicationCloudAccountExoConfigs = ApplicationCloudAccountExoConfigs;
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
        if ( RscNativeObjectPendingSla != null ) {
            this.RscNativeObjectPendingSla = RscNativeObjectPendingSla;
        }
        if ( SecurityMetadata != null ) {
            this.SecurityMetadata = SecurityMetadata;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
        if (this.AuthorizedOperations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authorizedOperations\n" ;
            } else {
                s += ind + "authorizedOperations\n" ;
            }
        }
        //      C# -> CloudAccountState? CloudAccountState
        // GraphQL -> cloudAccountState: CloudAccountState! (enum)
        if (this.CloudAccountState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudAccountState\n" ;
            } else {
                s += ind + "cloudAccountState\n" ;
            }
        }
        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType! (enum)
        if (this.CloudType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudType\n" ;
            } else {
                s += ind + "cloudType\n" ;
            }
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaAssignment\n" ;
            } else {
                s += ind + "slaAssignment\n" ;
            }
        }
        //      C# -> AwsAccountStatus? Status
        // GraphQL -> status: AwsAccountStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.ConfiguredSlaDomain, conf.Child("configuredSlaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configuredSlaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.EffectiveRetentionSlaDomain, conf.Child("effectiveRetentionSlaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveRetentionSlaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.EffectiveSlaDomain, conf.Child("effectiveSlaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? CloudSlabDns
        // GraphQL -> cloudSlabDns: String! (scalar)
        if (this.CloudSlabDns != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudSlabDns\n" ;
            } else {
                s += ind + "cloudSlabDns\n" ;
            }
        }
        //      C# -> System.Int32? DynamoDbTableCount
        // GraphQL -> dynamoDbTableCount: Int! (scalar)
        if (this.DynamoDbTableCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dynamoDbTableCount\n" ;
            } else {
                s += ind + "dynamoDbTableCount\n" ;
            }
        }
        //      C# -> System.Int32? EbsVolumeCount
        // GraphQL -> ebsVolumeCount: Int! (scalar)
        if (this.EbsVolumeCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ebsVolumeCount\n" ;
            } else {
                s += ind + "ebsVolumeCount\n" ;
            }
        }
        //      C# -> System.Int32? Ec2InstanceCount
        // GraphQL -> ec2InstanceCount: Int! (scalar)
        if (this.Ec2InstanceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ec2InstanceCount\n" ;
            } else {
                s += ind + "ec2InstanceCount\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        if (this.LastRefreshedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRefreshedAt\n" ;
            } else {
                s += ind + "lastRefreshedAt\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numWorkloadDescendants\n" ;
            } else {
                s += ind + "numWorkloadDescendants\n" ;
            }
        }
        //      C# -> System.Int32? RdsInstanceCount
        // GraphQL -> rdsInstanceCount: Int! (scalar)
        if (this.RdsInstanceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rdsInstanceCount\n" ;
            } else {
                s += ind + "rdsInstanceCount\n" ;
            }
        }
        //      C# -> System.Int32? S3BucketCount
        // GraphQL -> s3BucketCount: Int! (scalar)
        if (this.S3BucketCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "s3BucketCount\n" ;
            } else {
                s += ind + "s3BucketCount\n" ;
            }
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaPauseStatus\n" ;
            } else {
                s += ind + "slaPauseStatus\n" ;
            }
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(conf.Child("allOrgs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allOrgs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ApplicationCloudAccountToExocomputeConfig? ApplicationCloudAccountExoConfigs
        // GraphQL -> applicationCloudAccountExoConfigs: ApplicationCloudAccountToExocomputeConfig! (type)
        if (this.ApplicationCloudAccountExoConfigs != null) {
            var fspec = this.ApplicationCloudAccountExoConfigs.AsFieldSpec(conf.Child("applicationCloudAccountExoConfigs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "applicationCloudAccountExoConfigs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsNativeEbsVolumeConnection? AwsNativeEbsVolumes
        // GraphQL -> awsNativeEbsVolumes: AwsNativeEbsVolumeConnection! (type)
        if (this.AwsNativeEbsVolumes != null) {
            var fspec = this.AwsNativeEbsVolumes.AsFieldSpec(conf.Child("awsNativeEbsVolumes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsNativeEbsVolumes" + "\n(" + this.Vars.AwsNativeEbsVolumes.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsNativeEc2InstanceConnection? AwsNativeEc2Instances
        // GraphQL -> awsNativeEc2Instances: AwsNativeEc2InstanceConnection! (type)
        if (this.AwsNativeEc2Instances != null) {
            var fspec = this.AwsNativeEc2Instances.AsFieldSpec(conf.Child("awsNativeEc2Instances"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsNativeEc2Instances" + "\n(" + this.Vars.AwsNativeEc2Instances.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AwsNativeRdsInstanceConnection? AwsNativeRdsInstances
        // GraphQL -> awsNativeRdsInstances: AwsNativeRdsInstanceConnection! (type)
        if (this.AwsNativeRdsInstances != null) {
            var fspec = this.AwsNativeRdsInstances.AsFieldSpec(conf.Child("awsNativeRdsInstances"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsNativeRdsInstances" + "\n(" + this.Vars.AwsNativeRdsInstances.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            var fspec = this.EffectiveSlaSourceObject.AsFieldSpec(conf.Child("effectiveSlaSourceObject"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaSourceObject" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            var fspec = this.LogicalPath.AsFieldSpec(conf.Child("logicalPath"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logicalPath" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            var fspec = this.PhysicalPath.AsFieldSpec(conf.Child("physicalPath"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "physicalPath" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AwsNativeRegionSpec>? RegionSpecs
        // GraphQL -> regionSpecs: [AwsNativeRegionSpec!]! (type)
        if (this.RegionSpecs != null) {
            var fspec = this.RegionSpecs.AsFieldSpec(conf.Child("regionSpecs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "regionSpecs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CompactSlaDomain? RscNativeObjectPendingSla
        // GraphQL -> rscNativeObjectPendingSla: CompactSlaDomain (type)
        if (this.RscNativeObjectPendingSla != null) {
            var fspec = this.RscNativeObjectPendingSla.AsFieldSpec(conf.Child("rscNativeObjectPendingSla"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rscNativeObjectPendingSla" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        if (this.SecurityMetadata != null) {
            var fspec = this.SecurityMetadata.AsFieldSpec(conf.Child("securityMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "securityMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            var fspec = this.SnapshotDistribution.AsFieldSpec(conf.Child("snapshotDistribution"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotDistribution" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
        if (ec.Includes("authorizedOperations",true))
        {
            if(this.AuthorizedOperations == null) {

                this.AuthorizedOperations = new List<PolarisObjectAuthorizedOperationsEnum>();

            } else {


            }
        }
        else if (this.AuthorizedOperations != null && ec.Excludes("authorizedOperations",true))
        {
            this.AuthorizedOperations = null;
        }
        //      C# -> CloudAccountState? CloudAccountState
        // GraphQL -> cloudAccountState: CloudAccountState! (enum)
        if (ec.Includes("cloudAccountState",true))
        {
            if(this.CloudAccountState == null) {

                this.CloudAccountState = new CloudAccountState();

            } else {


            }
        }
        else if (this.CloudAccountState != null && ec.Excludes("cloudAccountState",true))
        {
            this.CloudAccountState = null;
        }
        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType! (enum)
        if (ec.Includes("cloudType",true))
        {
            if(this.CloudType == null) {

                this.CloudType = new AwsCloudType();

            } else {


            }
        }
        else if (this.CloudType != null && ec.Excludes("cloudType",true))
        {
            this.CloudType = null;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new HierarchyObjectTypeEnum();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (ec.Includes("slaAssignment",true))
        {
            if(this.SlaAssignment == null) {

                this.SlaAssignment = new SlaAssignmentTypeEnum();

            } else {


            }
        }
        else if (this.SlaAssignment != null && ec.Excludes("slaAssignment",true))
        {
            this.SlaAssignment = null;
        }
        //      C# -> AwsAccountStatus? Status
        // GraphQL -> status: AwsAccountStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new AwsAccountStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (ec.Includes("configuredSlaDomain",false))
        {
            if(this.ConfiguredSlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));
                this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));
                this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.ConfiguredSlaDomain != null && ec.Excludes("configuredSlaDomain",false))
        {
            this.ConfiguredSlaDomain = null;
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (ec.Includes("effectiveRetentionSlaDomain",false))
        {
            if(this.EffectiveRetentionSlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));
                this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));
                this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.EffectiveRetentionSlaDomain != null && ec.Excludes("effectiveRetentionSlaDomain",false))
        {
            this.EffectiveRetentionSlaDomain = null;
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (ec.Includes("effectiveSlaDomain",false))
        {
            if(this.EffectiveSlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));
                this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));
                this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.EffectiveSlaDomain != null && ec.Excludes("effectiveSlaDomain",false))
        {
            this.EffectiveSlaDomain = null;
        }
        //      C# -> System.String? CloudSlabDns
        // GraphQL -> cloudSlabDns: String! (scalar)
        if (ec.Includes("cloudSlabDns",true))
        {
            if(this.CloudSlabDns == null) {

                this.CloudSlabDns = "FETCH";

            } else {


            }
        }
        else if (this.CloudSlabDns != null && ec.Excludes("cloudSlabDns",true))
        {
            this.CloudSlabDns = null;
        }
        //      C# -> System.Int32? DynamoDbTableCount
        // GraphQL -> dynamoDbTableCount: Int! (scalar)
        if (ec.Includes("dynamoDbTableCount",true))
        {
            if(this.DynamoDbTableCount == null) {

                this.DynamoDbTableCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.DynamoDbTableCount != null && ec.Excludes("dynamoDbTableCount",true))
        {
            this.DynamoDbTableCount = null;
        }
        //      C# -> System.Int32? EbsVolumeCount
        // GraphQL -> ebsVolumeCount: Int! (scalar)
        if (ec.Includes("ebsVolumeCount",true))
        {
            if(this.EbsVolumeCount == null) {

                this.EbsVolumeCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.EbsVolumeCount != null && ec.Excludes("ebsVolumeCount",true))
        {
            this.EbsVolumeCount = null;
        }
        //      C# -> System.Int32? Ec2InstanceCount
        // GraphQL -> ec2InstanceCount: Int! (scalar)
        if (ec.Includes("ec2InstanceCount",true))
        {
            if(this.Ec2InstanceCount == null) {

                this.Ec2InstanceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Ec2InstanceCount != null && ec.Excludes("ec2InstanceCount",true))
        {
            this.Ec2InstanceCount = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        if (ec.Includes("lastRefreshedAt",true))
        {
            if(this.LastRefreshedAt == null) {

                this.LastRefreshedAt = new DateTime();

            } else {


            }
        }
        else if (this.LastRefreshedAt != null && ec.Excludes("lastRefreshedAt",true))
        {
            this.LastRefreshedAt = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (ec.Includes("numWorkloadDescendants",true))
        {
            if(this.NumWorkloadDescendants == null) {

                this.NumWorkloadDescendants = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumWorkloadDescendants != null && ec.Excludes("numWorkloadDescendants",true))
        {
            this.NumWorkloadDescendants = null;
        }
        //      C# -> System.Int32? RdsInstanceCount
        // GraphQL -> rdsInstanceCount: Int! (scalar)
        if (ec.Includes("rdsInstanceCount",true))
        {
            if(this.RdsInstanceCount == null) {

                this.RdsInstanceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.RdsInstanceCount != null && ec.Excludes("rdsInstanceCount",true))
        {
            this.RdsInstanceCount = null;
        }
        //      C# -> System.Int32? S3BucketCount
        // GraphQL -> s3BucketCount: Int! (scalar)
        if (ec.Includes("s3BucketCount",true))
        {
            if(this.S3BucketCount == null) {

                this.S3BucketCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.S3BucketCount != null && ec.Excludes("s3BucketCount",true))
        {
            this.S3BucketCount = null;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (ec.Includes("slaPauseStatus",true))
        {
            if(this.SlaPauseStatus == null) {

                this.SlaPauseStatus = true;

            } else {


            }
        }
        else if (this.SlaPauseStatus != null && ec.Excludes("slaPauseStatus",true))
        {
            this.SlaPauseStatus = null;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (ec.Includes("allOrgs",false))
        {
            if(this.AllOrgs == null) {

                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));

            } else {

                this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));

            }
        }
        else if (this.AllOrgs != null && ec.Excludes("allOrgs",false))
        {
            this.AllOrgs = null;
        }
        //      C# -> ApplicationCloudAccountToExocomputeConfig? ApplicationCloudAccountExoConfigs
        // GraphQL -> applicationCloudAccountExoConfigs: ApplicationCloudAccountToExocomputeConfig! (type)
        if (ec.Includes("applicationCloudAccountExoConfigs",false))
        {
            if(this.ApplicationCloudAccountExoConfigs == null) {

                this.ApplicationCloudAccountExoConfigs = new ApplicationCloudAccountToExocomputeConfig();
                this.ApplicationCloudAccountExoConfigs.ApplyExploratoryFieldSpec(ec.NewChild("applicationCloudAccountExoConfigs"));

            } else {

                this.ApplicationCloudAccountExoConfigs.ApplyExploratoryFieldSpec(ec.NewChild("applicationCloudAccountExoConfigs"));

            }
        }
        else if (this.ApplicationCloudAccountExoConfigs != null && ec.Excludes("applicationCloudAccountExoConfigs",false))
        {
            this.ApplicationCloudAccountExoConfigs = null;
        }
        //      C# -> AwsNativeEbsVolumeConnection? AwsNativeEbsVolumes
        // GraphQL -> awsNativeEbsVolumes: AwsNativeEbsVolumeConnection! (type)
        if (ec.Includes("awsNativeEbsVolumes",false))
        {
            if(this.AwsNativeEbsVolumes == null) {

                this.AwsNativeEbsVolumes = new AwsNativeEbsVolumeConnection();
                this.AwsNativeEbsVolumes.ApplyExploratoryFieldSpec(ec.NewChild("awsNativeEbsVolumes"));

            } else {

                this.AwsNativeEbsVolumes.ApplyExploratoryFieldSpec(ec.NewChild("awsNativeEbsVolumes"));

            }
        }
        else if (this.AwsNativeEbsVolumes != null && ec.Excludes("awsNativeEbsVolumes",false))
        {
            this.AwsNativeEbsVolumes = null;
        }
        //      C# -> AwsNativeEc2InstanceConnection? AwsNativeEc2Instances
        // GraphQL -> awsNativeEc2Instances: AwsNativeEc2InstanceConnection! (type)
        if (ec.Includes("awsNativeEc2Instances",false))
        {
            if(this.AwsNativeEc2Instances == null) {

                this.AwsNativeEc2Instances = new AwsNativeEc2InstanceConnection();
                this.AwsNativeEc2Instances.ApplyExploratoryFieldSpec(ec.NewChild("awsNativeEc2Instances"));

            } else {

                this.AwsNativeEc2Instances.ApplyExploratoryFieldSpec(ec.NewChild("awsNativeEc2Instances"));

            }
        }
        else if (this.AwsNativeEc2Instances != null && ec.Excludes("awsNativeEc2Instances",false))
        {
            this.AwsNativeEc2Instances = null;
        }
        //      C# -> AwsNativeRdsInstanceConnection? AwsNativeRdsInstances
        // GraphQL -> awsNativeRdsInstances: AwsNativeRdsInstanceConnection! (type)
        if (ec.Includes("awsNativeRdsInstances",false))
        {
            if(this.AwsNativeRdsInstances == null) {

                this.AwsNativeRdsInstances = new AwsNativeRdsInstanceConnection();
                this.AwsNativeRdsInstances.ApplyExploratoryFieldSpec(ec.NewChild("awsNativeRdsInstances"));

            } else {

                this.AwsNativeRdsInstances.ApplyExploratoryFieldSpec(ec.NewChild("awsNativeRdsInstances"));

            }
        }
        else if (this.AwsNativeRdsInstances != null && ec.Excludes("awsNativeRdsInstances",false))
        {
            this.AwsNativeRdsInstances = null;
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (ec.Includes("effectiveSlaSourceObject",false))
        {
            if(this.EffectiveSlaSourceObject == null) {

                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaSourceObject"));

            } else {

                this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaSourceObject"));

            }
        }
        else if (this.EffectiveSlaSourceObject != null && ec.Excludes("effectiveSlaSourceObject",false))
        {
            this.EffectiveSlaSourceObject = null;
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (ec.Includes("logicalPath",false))
        {
            if(this.LogicalPath == null) {

                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFieldSpec(ec.NewChild("logicalPath"));

            } else {

                this.LogicalPath.ApplyExploratoryFieldSpec(ec.NewChild("logicalPath"));

            }
        }
        else if (this.LogicalPath != null && ec.Excludes("logicalPath",false))
        {
            this.LogicalPath = null;
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (ec.Includes("physicalPath",false))
        {
            if(this.PhysicalPath == null) {

                this.PhysicalPath = new List<PathNode>();
                this.PhysicalPath.ApplyExploratoryFieldSpec(ec.NewChild("physicalPath"));

            } else {

                this.PhysicalPath.ApplyExploratoryFieldSpec(ec.NewChild("physicalPath"));

            }
        }
        else if (this.PhysicalPath != null && ec.Excludes("physicalPath",false))
        {
            this.PhysicalPath = null;
        }
        //      C# -> List<AwsNativeRegionSpec>? RegionSpecs
        // GraphQL -> regionSpecs: [AwsNativeRegionSpec!]! (type)
        if (ec.Includes("regionSpecs",false))
        {
            if(this.RegionSpecs == null) {

                this.RegionSpecs = new List<AwsNativeRegionSpec>();
                this.RegionSpecs.ApplyExploratoryFieldSpec(ec.NewChild("regionSpecs"));

            } else {

                this.RegionSpecs.ApplyExploratoryFieldSpec(ec.NewChild("regionSpecs"));

            }
        }
        else if (this.RegionSpecs != null && ec.Excludes("regionSpecs",false))
        {
            this.RegionSpecs = null;
        }
        //      C# -> CompactSlaDomain? RscNativeObjectPendingSla
        // GraphQL -> rscNativeObjectPendingSla: CompactSlaDomain (type)
        if (ec.Includes("rscNativeObjectPendingSla",false))
        {
            if(this.RscNativeObjectPendingSla == null) {

                this.RscNativeObjectPendingSla = new CompactSlaDomain();
                this.RscNativeObjectPendingSla.ApplyExploratoryFieldSpec(ec.NewChild("rscNativeObjectPendingSla"));

            } else {

                this.RscNativeObjectPendingSla.ApplyExploratoryFieldSpec(ec.NewChild("rscNativeObjectPendingSla"));

            }
        }
        else if (this.RscNativeObjectPendingSla != null && ec.Excludes("rscNativeObjectPendingSla",false))
        {
            this.RscNativeObjectPendingSla = null;
        }
        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        if (ec.Includes("securityMetadata",false))
        {
            if(this.SecurityMetadata == null) {

                this.SecurityMetadata = new SecurityMetadata();
                this.SecurityMetadata.ApplyExploratoryFieldSpec(ec.NewChild("securityMetadata"));

            } else {

                this.SecurityMetadata.ApplyExploratoryFieldSpec(ec.NewChild("securityMetadata"));

            }
        }
        else if (this.SecurityMetadata != null && ec.Excludes("securityMetadata",false))
        {
            this.SecurityMetadata = null;
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (ec.Includes("snapshotDistribution",false))
        {
            if(this.SnapshotDistribution == null) {

                this.SnapshotDistribution = new SnapshotDistribution();
                this.SnapshotDistribution.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDistribution"));

            } else {

                this.SnapshotDistribution.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDistribution"));

            }
        }
        else if (this.SnapshotDistribution != null && ec.Excludes("snapshotDistribution",false))
        {
            this.SnapshotDistribution = null;
        }
    }


    #endregion

    } // class AwsNativeAccount
    
    #endregion

    public static class ListAwsNativeAccountExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AwsNativeAccount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsNativeAccount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsNativeAccount> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsNativeAccount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsNativeAccount> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types