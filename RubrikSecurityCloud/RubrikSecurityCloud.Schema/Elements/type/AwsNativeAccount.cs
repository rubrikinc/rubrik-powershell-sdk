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

namespace Rubrik.SecurityCloud.Types
{
    #region AwsNativeAccount
 
    public class AwsNativeAccount: IFragment, PolarisHierarchyObject, HierarchyObject
    {
        #region members
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

        #endregion

    #region methods

    public AwsNativeAccount Set(
        System.Int32? EbsVolumeCount = null,
        System.Int32? Ec2InstanceCount = null,
        System.String? Id = null,
        DateTime? LastRefreshedAt = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? RdsInstanceCount = null,
        System.Boolean? SlaPauseStatus = null,
        List<Org>? AllOrgs = null,
        AwsNativeEbsVolumeConnection? AwsNativeEbsVolumes = null,
        AwsNativeEc2InstanceConnection? AwsNativeEc2Instances = null,
        AwsNativeRdsInstanceConnection? AwsNativeRdsInstances = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<PathNode>? LogicalPath = null,
        List<PathNode>? PhysicalPath = null,
        List<AwsNativeRegionSpec>? RegionSpecs = null,
        SnapshotDistribution? SnapshotDistribution = null,
        List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations = null,
        AwsCloudType? CloudType = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        AwsAccountStatus? Status = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null
    ) 
    {
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
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int32? EbsVolumeCount
            // GraphQL -> ebsVolumeCount: Int! (scalar)
            if (this.EbsVolumeCount != null)
            {
                 s += ind + "ebsVolumeCount\n";

            }
            //      C# -> System.Int32? Ec2InstanceCount
            // GraphQL -> ec2InstanceCount: Int! (scalar)
            if (this.Ec2InstanceCount != null)
            {
                 s += ind + "ec2InstanceCount\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> DateTime? LastRefreshedAt
            // GraphQL -> lastRefreshedAt: DateTime (scalar)
            if (this.LastRefreshedAt != null)
            {
                 s += ind + "lastRefreshedAt\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int32? NumWorkloadDescendants
            // GraphQL -> numWorkloadDescendants: Int! (scalar)
            if (this.NumWorkloadDescendants != null)
            {
                 s += ind + "numWorkloadDescendants\n";

            }
            //      C# -> System.Int32? RdsInstanceCount
            // GraphQL -> rdsInstanceCount: Int! (scalar)
            if (this.RdsInstanceCount != null)
            {
                 s += ind + "rdsInstanceCount\n";

            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus != null)
            {
                 s += ind + "slaPauseStatus\n";

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
            //      C# -> AwsNativeEbsVolumeConnection? AwsNativeEbsVolumes
            // GraphQL -> awsNativeEbsVolumes: AwsNativeEbsVolumeConnection! (type)
            if (this.AwsNativeEbsVolumes != null)
            {
                 s += ind + "awsNativeEbsVolumes\n";

                 s += ind + "{\n" + 
                 this.AwsNativeEbsVolumes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AwsNativeEc2InstanceConnection? AwsNativeEc2Instances
            // GraphQL -> awsNativeEc2Instances: AwsNativeEc2InstanceConnection! (type)
            if (this.AwsNativeEc2Instances != null)
            {
                 s += ind + "awsNativeEc2Instances\n";

                 s += ind + "{\n" + 
                 this.AwsNativeEc2Instances.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AwsNativeRdsInstanceConnection? AwsNativeRdsInstances
            // GraphQL -> awsNativeRdsInstances: AwsNativeRdsInstanceConnection! (type)
            if (this.AwsNativeRdsInstances != null)
            {
                 s += ind + "awsNativeRdsInstances\n";

                 s += ind + "{\n" + 
                 this.AwsNativeRdsInstances.AsFragment(indent+1) + 
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
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath != null)
            {
                 s += ind + "logicalPath\n";

                 s += ind + "{\n" + 
                 this.LogicalPath.AsFragment(indent+1) + 
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
            //      C# -> List<AwsNativeRegionSpec>? RegionSpecs
            // GraphQL -> regionSpecs: [AwsNativeRegionSpec!]! (type)
            if (this.RegionSpecs != null)
            {
                 s += ind + "regionSpecs\n";

                 s += ind + "{\n" + 
                 this.RegionSpecs.AsFragment(indent+1) + 
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
            //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
            if (this.AuthorizedOperations != null)
            {
                 s += ind + "authorizedOperations\n";

            }
            //      C# -> AwsCloudType? CloudType
            // GraphQL -> cloudType: AwsCloudType! (enum)
            if (this.CloudType != null)
            {
                 s += ind + "cloudType\n";

            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            //      C# -> SlaAssignmentTypeEnum? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
            if (this.SlaAssignment != null)
            {
                 s += ind + "slaAssignment\n";

            }
            //      C# -> AwsAccountStatus? Status
            // GraphQL -> status: AwsAccountStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

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
            //      C# -> System.Int32? EbsVolumeCount
            // GraphQL -> ebsVolumeCount: Int! (scalar)
            if (this.EbsVolumeCount == null && Exploration.Includes(parent + ".ebsVolumeCount$"))
            {
                this.EbsVolumeCount = new System.Int32();
            }
            //      C# -> System.Int32? Ec2InstanceCount
            // GraphQL -> ec2InstanceCount: Int! (scalar)
            if (this.Ec2InstanceCount == null && Exploration.Includes(parent + ".ec2InstanceCount$"))
            {
                this.Ec2InstanceCount = new System.Int32();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> DateTime? LastRefreshedAt
            // GraphQL -> lastRefreshedAt: DateTime (scalar)
            if (this.LastRefreshedAt == null && Exploration.Includes(parent + ".lastRefreshedAt$"))
            {
                this.LastRefreshedAt = new DateTime();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int32? NumWorkloadDescendants
            // GraphQL -> numWorkloadDescendants: Int! (scalar)
            if (this.NumWorkloadDescendants == null && Exploration.Includes(parent + ".numWorkloadDescendants$"))
            {
                this.NumWorkloadDescendants = new System.Int32();
            }
            //      C# -> System.Int32? RdsInstanceCount
            // GraphQL -> rdsInstanceCount: Int! (scalar)
            if (this.RdsInstanceCount == null && Exploration.Includes(parent + ".rdsInstanceCount$"))
            {
                this.RdsInstanceCount = new System.Int32();
            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus$"))
            {
                this.SlaPauseStatus = new System.Boolean();
            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
            {
                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFragment(parent + ".allOrgs");
            }
            //      C# -> AwsNativeEbsVolumeConnection? AwsNativeEbsVolumes
            // GraphQL -> awsNativeEbsVolumes: AwsNativeEbsVolumeConnection! (type)
            if (this.AwsNativeEbsVolumes == null && Exploration.Includes(parent + ".awsNativeEbsVolumes"))
            {
                this.AwsNativeEbsVolumes = new AwsNativeEbsVolumeConnection();
                this.AwsNativeEbsVolumes.ApplyExploratoryFragment(parent + ".awsNativeEbsVolumes");
            }
            //      C# -> AwsNativeEc2InstanceConnection? AwsNativeEc2Instances
            // GraphQL -> awsNativeEc2Instances: AwsNativeEc2InstanceConnection! (type)
            if (this.AwsNativeEc2Instances == null && Exploration.Includes(parent + ".awsNativeEc2Instances"))
            {
                this.AwsNativeEc2Instances = new AwsNativeEc2InstanceConnection();
                this.AwsNativeEc2Instances.ApplyExploratoryFragment(parent + ".awsNativeEc2Instances");
            }
            //      C# -> AwsNativeRdsInstanceConnection? AwsNativeRdsInstances
            // GraphQL -> awsNativeRdsInstances: AwsNativeRdsInstanceConnection! (type)
            if (this.AwsNativeRdsInstances == null && Exploration.Includes(parent + ".awsNativeRdsInstances"))
            {
                this.AwsNativeRdsInstances = new AwsNativeRdsInstanceConnection();
                this.AwsNativeRdsInstances.ApplyExploratoryFragment(parent + ".awsNativeRdsInstances");
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
            {
                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFragment(parent + ".effectiveSlaSourceObject");
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
            {
                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFragment(parent + ".logicalPath");
            }
            //      C# -> List<PathNode>? PhysicalPath
            // GraphQL -> physicalPath: [PathNode!]! (type)
            if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
            {
                this.PhysicalPath = new List<PathNode>();
                this.PhysicalPath.ApplyExploratoryFragment(parent + ".physicalPath");
            }
            //      C# -> List<AwsNativeRegionSpec>? RegionSpecs
            // GraphQL -> regionSpecs: [AwsNativeRegionSpec!]! (type)
            if (this.RegionSpecs == null && Exploration.Includes(parent + ".regionSpecs"))
            {
                this.RegionSpecs = new List<AwsNativeRegionSpec>();
                this.RegionSpecs.ApplyExploratoryFragment(parent + ".regionSpecs");
            }
            //      C# -> SnapshotDistribution? SnapshotDistribution
            // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
            if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
            {
                this.SnapshotDistribution = new SnapshotDistribution();
                this.SnapshotDistribution.ApplyExploratoryFragment(parent + ".snapshotDistribution");
            }
            //      C# -> List<PolarisObjectAuthorizedOperationsEnum>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [PolarisObjectAuthorizedOperationsEnum!]! (enum)
            if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations$"))
            {
                this.AuthorizedOperations = new List<PolarisObjectAuthorizedOperationsEnum>();
            }
            //      C# -> AwsCloudType? CloudType
            // GraphQL -> cloudType: AwsCloudType! (enum)
            if (this.CloudType == null && Exploration.Includes(parent + ".cloudType$"))
            {
                this.CloudType = new AwsCloudType();
            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new HierarchyObjectTypeEnum();
            }
            //      C# -> SlaAssignmentTypeEnum? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
            if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment$"))
            {
                this.SlaAssignment = new SlaAssignmentTypeEnum();
            }
            //      C# -> AwsAccountStatus? Status
            // GraphQL -> status: AwsAccountStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new AwsAccountStatus();
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

    } // class AwsNativeAccount
    #endregion

    public static class ListAwsNativeAccountExtensions
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
            this List<AwsNativeAccount> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsNativeAccount> list, 
            String parent = "")
        {
            var item = new AwsNativeAccount();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types