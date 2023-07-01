// GcpNativeDisk.cs
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
    #region GcpNativeDisk
 
    public class GcpNativeDisk: BaseType, GcpNativeProjectDescendantType, GcpNativeProjectLogicalChildType, HierarchyObject, PolarisHierarchyObject, PolarisHierarchySnappable
    {
        #region members

        //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

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

        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        [JsonProperty("diskId")]
        public System.String? DiskId { get; set; }

        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        [JsonProperty("diskName")]
        public System.String? DiskName { get; set; }

        //      C# -> System.String? DiskType
        // GraphQL -> diskType: String! (scalar)
        [JsonProperty("diskType")]
        public System.String? DiskType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? KmsKey
        // GraphQL -> kmsKey: String! (scalar)
        [JsonProperty("kmsKey")]
        public System.String? KmsKey { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        [JsonProperty("onDemandSnapshotCount")]
        public System.Int32? OnDemandSnapshotCount { get; set; }

        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        [JsonProperty("projectId")]
        public System.String? ProjectId { get; set; }

        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        [JsonProperty("region")]
        public System.String? Region { get; set; }

        //      C# -> List<System.String>? ReplicaZones
        // GraphQL -> replicaZones: [String!]! (scalar)
        [JsonProperty("replicaZones")]
        public List<System.String>? ReplicaZones { get; set; }

        //      C# -> System.Int32? SizeInGiBs
        // GraphQL -> sizeInGiBs: Int! (scalar)
        [JsonProperty("sizeInGiBs")]
        public System.Int32? SizeInGiBs { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.String? Zone
        // GraphQL -> zone: String! (scalar)
        [JsonProperty("zone")]
        public System.String? Zone { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> List<GcpNativeAttachmentDetails>? AttachedInstances
        // GraphQL -> attachedInstances: [GcpNativeAttachmentDetails!]! (type)
        [JsonProperty("attachedInstances")]
        public List<GcpNativeAttachmentDetails>? AttachedInstances { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> GcpNativeProject? GcpNativeProject
        // GraphQL -> gcpNativeProject: GcpNativeProject! (type)
        [JsonProperty("gcpNativeProject")]
        public GcpNativeProject? GcpNativeProject { get; set; }

        //      C# -> List<Label>? Labels
        // GraphQL -> labels: [Label!]! (type)
        [JsonProperty("labels")]
        public List<Label>? Labels { get; set; }

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

        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        [JsonProperty("workloadSnapshotConnection")]
        public GenericSnapshotConnection? WorkloadSnapshotConnection { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpNativeDisk";
    }

    public GcpNativeDisk Set(
        List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        System.String? DiskId = null,
        System.String? DiskName = null,
        System.String? DiskType = null,
        System.String? Id = null,
        System.Boolean? IsRelic = null,
        System.String? KmsKey = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.String? ProjectId = null,
        System.String? Region = null,
        List<System.String>? ReplicaZones = null,
        System.Int32? SizeInGiBs = null,
        System.Boolean? SlaPauseStatus = null,
        System.String? Zone = null,
        List<Org>? AllOrgs = null,
        List<GcpNativeAttachmentDetails>? AttachedInstances = null,
        PathNode? EffectiveSlaSourceObject = null,
        GcpNativeProject? GcpNativeProject = null,
        List<Label>? Labels = null,
        List<PathNode>? LogicalPath = null,
        PolarisSnapshot? NewestIndexedSnapshot = null,
        PolarisSnapshot? NewestSnapshot = null,
        PolarisSnapshot? OldestSnapshot = null,
        List<PathNode>? PhysicalPath = null,
        PolarisSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        PolarisSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection = null,
        GenericSnapshotConnection? WorkloadSnapshotConnection = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
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
        if ( DiskId != null ) {
            this.DiskId = DiskId;
        }
        if ( DiskName != null ) {
            this.DiskName = DiskName;
        }
        if ( DiskType != null ) {
            this.DiskType = DiskType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( KmsKey != null ) {
            this.KmsKey = KmsKey;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( OnDemandSnapshotCount != null ) {
            this.OnDemandSnapshotCount = OnDemandSnapshotCount;
        }
        if ( ProjectId != null ) {
            this.ProjectId = ProjectId;
        }
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( ReplicaZones != null ) {
            this.ReplicaZones = ReplicaZones;
        }
        if ( SizeInGiBs != null ) {
            this.SizeInGiBs = SizeInGiBs;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( Zone != null ) {
            this.Zone = Zone;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AttachedInstances != null ) {
            this.AttachedInstances = AttachedInstances;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( GcpNativeProject != null ) {
            this.GcpNativeProject = GcpNativeProject;
        }
        if ( Labels != null ) {
            this.Labels = Labels;
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
        if ( WorkloadSnapshotConnection != null ) {
            this.WorkloadSnapshotConnection = WorkloadSnapshotConnection;
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
        //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
        if (this.AuthorizedOperations != null) {
            s += ind + "authorizedOperations\n" ;
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
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (this.DiskId != null) {
            s += ind + "diskId\n" ;
        }
        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        if (this.DiskName != null) {
            s += ind + "diskName\n" ;
        }
        //      C# -> System.String? DiskType
        // GraphQL -> diskType: String! (scalar)
        if (this.DiskType != null) {
            s += ind + "diskType\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> System.String? KmsKey
        // GraphQL -> kmsKey: String! (scalar)
        if (this.KmsKey != null) {
            s += ind + "kmsKey\n" ;
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
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount != null) {
            s += ind + "onDemandSnapshotCount\n" ;
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId != null) {
            s += ind + "projectId\n" ;
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> List<System.String>? ReplicaZones
        // GraphQL -> replicaZones: [String!]! (scalar)
        if (this.ReplicaZones != null) {
            s += ind + "replicaZones\n" ;
        }
        //      C# -> System.Int32? SizeInGiBs
        // GraphQL -> sizeInGiBs: Int! (scalar)
        if (this.SizeInGiBs != null) {
            s += ind + "sizeInGiBs\n" ;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            s += ind + "slaPauseStatus\n" ;
        }
        //      C# -> System.String? Zone
        // GraphQL -> zone: String! (scalar)
        if (this.Zone != null) {
            s += ind + "zone\n" ;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allOrgs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<GcpNativeAttachmentDetails>? AttachedInstances
        // GraphQL -> attachedInstances: [GcpNativeAttachmentDetails!]! (type)
        if (this.AttachedInstances != null) {
            var fspec = this.AttachedInstances.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "attachedInstances {\n" + fspec + ind + "}\n" ;
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
        //      C# -> GcpNativeProject? GcpNativeProject
        // GraphQL -> gcpNativeProject: GcpNativeProject! (type)
        if (this.GcpNativeProject != null) {
            var fspec = this.GcpNativeProject.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "gcpNativeProject {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<Label>? Labels
        // GraphQL -> labels: [Label!]! (type)
        if (this.Labels != null) {
            var fspec = this.Labels.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "labels {\n" + fspec + ind + "}\n" ;
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
        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        if (this.NewestIndexedSnapshot != null) {
            var fspec = this.NewestIndexedSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newestIndexedSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        if (this.NewestSnapshot != null) {
            var fspec = this.NewestSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newestSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        if (this.OldestSnapshot != null) {
            var fspec = this.OldestSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oldestSnapshot {\n" + fspec + ind + "}\n" ;
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
        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        if (this.SnapshotConnection != null) {
            var fspec = this.SnapshotConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotConnection {\n" + fspec + ind + "}\n" ;
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
        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection != null) {
            var fspec = this.SnapshotGroupByConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotGroupByConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        if (this.SnapshotGroupByNewConnection != null) {
            var fspec = this.SnapshotGroupByNewConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotGroupByNewConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        if (this.WorkloadSnapshotConnection != null) {
            var fspec = this.WorkloadSnapshotConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "workloadSnapshotConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<PolarisSnappableAuthorizedOperationsEnum>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [PolarisSnappableAuthorizedOperationsEnum!]! (enum)
        if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations", true))
        {
            this.AuthorizedOperations = new List<PolarisSnappableAuthorizedOperationsEnum>();
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
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (this.DiskId == null && Exploration.Includes(parent + ".diskId", true))
        {
            this.DiskId = "FETCH";
        }
        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        if (this.DiskName == null && Exploration.Includes(parent + ".diskName", true))
        {
            this.DiskName = "FETCH";
        }
        //      C# -> System.String? DiskType
        // GraphQL -> diskType: String! (scalar)
        if (this.DiskType == null && Exploration.Includes(parent + ".diskType", true))
        {
            this.DiskType = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.String? KmsKey
        // GraphQL -> kmsKey: String! (scalar)
        if (this.KmsKey == null && Exploration.Includes(parent + ".kmsKey", true))
        {
            this.KmsKey = "FETCH";
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
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount == null && Exploration.Includes(parent + ".onDemandSnapshotCount", true))
        {
            this.OnDemandSnapshotCount = Int32.MinValue;
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId == null && Exploration.Includes(parent + ".projectId", true))
        {
            this.ProjectId = "FETCH";
        }
        //      C# -> System.String? Region
        // GraphQL -> region: String! (scalar)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = "FETCH";
        }
        //      C# -> List<System.String>? ReplicaZones
        // GraphQL -> replicaZones: [String!]! (scalar)
        if (this.ReplicaZones == null && Exploration.Includes(parent + ".replicaZones", true))
        {
            this.ReplicaZones = new List<System.String>();
        }
        //      C# -> System.Int32? SizeInGiBs
        // GraphQL -> sizeInGiBs: Int! (scalar)
        if (this.SizeInGiBs == null && Exploration.Includes(parent + ".sizeInGiBs", true))
        {
            this.SizeInGiBs = Int32.MinValue;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus", true))
        {
            this.SlaPauseStatus = true;
        }
        //      C# -> System.String? Zone
        // GraphQL -> zone: String! (scalar)
        if (this.Zone == null && Exploration.Includes(parent + ".zone", true))
        {
            this.Zone = "FETCH";
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(parent + ".allOrgs");
        }
        //      C# -> List<GcpNativeAttachmentDetails>? AttachedInstances
        // GraphQL -> attachedInstances: [GcpNativeAttachmentDetails!]! (type)
        if (this.AttachedInstances == null && Exploration.Includes(parent + ".attachedInstances"))
        {
            this.AttachedInstances = new List<GcpNativeAttachmentDetails>();
            this.AttachedInstances.ApplyExploratoryFieldSpec(parent + ".attachedInstances");
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
        {
            this.EffectiveSlaSourceObject = new PathNode();
            this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(parent + ".effectiveSlaSourceObject");
        }
        //      C# -> GcpNativeProject? GcpNativeProject
        // GraphQL -> gcpNativeProject: GcpNativeProject! (type)
        if (this.GcpNativeProject == null && Exploration.Includes(parent + ".gcpNativeProject"))
        {
            this.GcpNativeProject = new GcpNativeProject();
            this.GcpNativeProject.ApplyExploratoryFieldSpec(parent + ".gcpNativeProject");
        }
        //      C# -> List<Label>? Labels
        // GraphQL -> labels: [Label!]! (type)
        if (this.Labels == null && Exploration.Includes(parent + ".labels"))
        {
            this.Labels = new List<Label>();
            this.Labels.ApplyExploratoryFieldSpec(parent + ".labels");
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
        {
            this.LogicalPath = new List<PathNode>();
            this.LogicalPath.ApplyExploratoryFieldSpec(parent + ".logicalPath");
        }
        //      C# -> PolarisSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: PolarisSnapshot (type)
        if (this.NewestIndexedSnapshot == null && Exploration.Includes(parent + ".newestIndexedSnapshot"))
        {
            this.NewestIndexedSnapshot = new PolarisSnapshot();
            this.NewestIndexedSnapshot.ApplyExploratoryFieldSpec(parent + ".newestIndexedSnapshot");
        }
        //      C# -> PolarisSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: PolarisSnapshot (type)
        if (this.NewestSnapshot == null && Exploration.Includes(parent + ".newestSnapshot"))
        {
            this.NewestSnapshot = new PolarisSnapshot();
            this.NewestSnapshot.ApplyExploratoryFieldSpec(parent + ".newestSnapshot");
        }
        //      C# -> PolarisSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: PolarisSnapshot (type)
        if (this.OldestSnapshot == null && Exploration.Includes(parent + ".oldestSnapshot"))
        {
            this.OldestSnapshot = new PolarisSnapshot();
            this.OldestSnapshot.ApplyExploratoryFieldSpec(parent + ".oldestSnapshot");
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
        {
            this.PhysicalPath = new List<PathNode>();
            this.PhysicalPath.ApplyExploratoryFieldSpec(parent + ".physicalPath");
        }
        //      C# -> PolarisSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: PolarisSnapshotConnection (type)
        if (this.SnapshotConnection == null && Exploration.Includes(parent + ".snapshotConnection"))
        {
            this.SnapshotConnection = new PolarisSnapshotConnection();
            this.SnapshotConnection.ApplyExploratoryFieldSpec(parent + ".snapshotConnection");
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
        {
            this.SnapshotDistribution = new SnapshotDistribution();
            this.SnapshotDistribution.ApplyExploratoryFieldSpec(parent + ".snapshotDistribution");
        }
        //      C# -> PolarisSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: PolarisSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection == null && Exploration.Includes(parent + ".snapshotGroupByConnection"))
        {
            this.SnapshotGroupByConnection = new PolarisSnapshotGroupByConnection();
            this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(parent + ".snapshotGroupByConnection");
        }
        //      C# -> PolarisSnapshotGroupByNewConnection? SnapshotGroupByNewConnection
        // GraphQL -> snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection (type)
        if (this.SnapshotGroupByNewConnection == null && Exploration.Includes(parent + ".snapshotGroupByNewConnection"))
        {
            this.SnapshotGroupByNewConnection = new PolarisSnapshotGroupByNewConnection();
            this.SnapshotGroupByNewConnection.ApplyExploratoryFieldSpec(parent + ".snapshotGroupByNewConnection");
        }
        //      C# -> GenericSnapshotConnection? WorkloadSnapshotConnection
        // GraphQL -> workloadSnapshotConnection: GenericSnapshotConnection (type)
        if (this.WorkloadSnapshotConnection == null && Exploration.Includes(parent + ".workloadSnapshotConnection"))
        {
            this.WorkloadSnapshotConnection = new GenericSnapshotConnection();
            this.WorkloadSnapshotConnection.ApplyExploratoryFieldSpec(parent + ".workloadSnapshotConnection");
        }
    }


    #endregion

    } // class GcpNativeDisk
    
    #endregion

    public static class ListGcpNativeDiskExtensions
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
            this List<GcpNativeDisk> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GcpNativeDisk> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpNativeDisk());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types