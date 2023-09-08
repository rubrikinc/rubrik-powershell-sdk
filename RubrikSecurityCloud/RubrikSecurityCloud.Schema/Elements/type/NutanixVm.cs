// NutanixVm.cs
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
    #region NutanixVm
 
    public class NutanixVm: BaseType, CdmHierarchyObject, CdmHierarchySnappableNew, HierarchyObject, HierarchySnappable, NutanixCategoryDescendantType, NutanixCategoryValueDescendantType, NutanixCategoryValueLogicalChildType, NutanixClusterDescendantType, NutanixClusterLogicalChildType, NutanixPrismCentralDescendantType
    {
        #region members

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> CdmNutanixSnapshotConsistencyMandate? NutanixSnapshotConsistencyMandate
        // GraphQL -> nutanixSnapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate! (enum)
        [JsonProperty("nutanixSnapshotConsistencyMandate")]
        public CdmNutanixSnapshotConsistencyMandate? NutanixSnapshotConsistencyMandate { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> GuestOsType? OsType
        // GraphQL -> osType: GuestOsType (enum)
        [JsonProperty("osType")]
        public GuestOsType? OsType { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> NutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: NutanixSnapshotConsistencyMandate! (enum)
        [JsonProperty("snapshotConsistencyMandate")]
        public NutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate { get; set; }

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

        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        [JsonProperty("pendingSla")]
        public SlaDomain? PendingSla { get; set; }

        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        [JsonProperty("replicatedObjects")]
        public List<CdmHierarchyObject>? ReplicatedObjects { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        [JsonProperty("cdmLink")]
        public System.String? CdmLink { get; set; }

        //      C# -> System.String? CurrentHostId
        // GraphQL -> currentHostId: String (scalar)
        [JsonProperty("currentHostId")]
        public System.String? CurrentHostId { get; set; }

        //      C# -> List<System.String>? ExcludedDisks
        // GraphQL -> excludedDisks: [String!]! (scalar)
        [JsonProperty("excludedDisks")]
        public List<System.String>? ExcludedDisks { get; set; }

        //      C# -> System.String? HypervisorType
        // GraphQL -> hypervisorType: String (scalar)
        [JsonProperty("hypervisorType")]
        public System.String? HypervisorType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean! (scalar)
        [JsonProperty("isAgentRegistered")]
        public System.Boolean? IsAgentRegistered { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? NutanixVmMountCount
        // GraphQL -> nutanixVmMountCount: Int! (scalar)
        [JsonProperty("nutanixVmMountCount")]
        public System.Int32? NutanixVmMountCount { get; set; }

        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        [JsonProperty("onDemandSnapshotCount")]
        public System.Int32? OnDemandSnapshotCount { get; set; }

        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        [JsonProperty("replicatedObjectCount")]
        public System.Int32? ReplicatedObjectCount { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.String? VmUuid
        // GraphQL -> vmUuid: UUID! (scalar)
        [JsonProperty("vmUuid")]
        public System.String? VmUuid { get; set; }

        //      C# -> NutanixVmAgentStatus? AgentStatus
        // GraphQL -> agentStatus: NutanixVmAgentStatus! (type)
        [JsonProperty("agentStatus")]
        public NutanixVmAgentStatus? AgentStatus { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        [JsonProperty("latestUserNote")]
        public LatestUserNote? LatestUserNote { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        [JsonProperty("missedSnapshotConnection")]
        public MissedSnapshotCommonConnection? MissedSnapshotConnection { get; set; }

        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        [JsonProperty("missedSnapshotGroupByConnection")]
        public MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection { get; set; }

        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        [JsonProperty("newestArchivedSnapshot")]
        public CdmSnapshot? NewestArchivedSnapshot { get; set; }

        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        [JsonProperty("newestReplicatedSnapshot")]
        public CdmSnapshot? NewestReplicatedSnapshot { get; set; }

        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        [JsonProperty("newestSnapshot")]
        public CdmSnapshot? NewestSnapshot { get; set; }

        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        [JsonProperty("oldestSnapshot")]
        public CdmSnapshot? OldestSnapshot { get; set; }

        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        [JsonProperty("pendingObjectDeletionStatus")]
        public PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> NutanixBackupScript? PostBackupScript
        // GraphQL -> postBackupScript: NutanixBackupScript! (type)
        [JsonProperty("postBackupScript")]
        public NutanixBackupScript? PostBackupScript { get; set; }

        //      C# -> NutanixBackupScript? PostSnapScript
        // GraphQL -> postSnapScript: NutanixBackupScript! (type)
        [JsonProperty("postSnapScript")]
        public NutanixBackupScript? PostSnapScript { get; set; }

        //      C# -> NutanixBackupScript? PreBackupScript
        // GraphQL -> preBackupScript: NutanixBackupScript! (type)
        [JsonProperty("preBackupScript")]
        public NutanixBackupScript? PreBackupScript { get; set; }

        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        [JsonProperty("primaryClusterLocation")]
        public DataLocation? PrimaryClusterLocation { get; set; }

        //      C# -> Snappable? ReportSnappable
        // GraphQL -> reportSnappable: Snappable (type)
        [JsonProperty("reportSnappable")]
        public Snappable? ReportSnappable { get; set; }

        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        [JsonProperty("snapshotConnection")]
        public CdmSnapshotConnection? SnapshotConnection { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        [JsonProperty("snapshotGroupByConnection")]
        public CdmSnapshotGroupByConnection? SnapshotGroupByConnection { get; set; }

        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        [JsonProperty("snapshotGroupBySummary")]
        public CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary { get; set; }

        //      C# -> List<NutanixVmDisk>? VmDisks
        // GraphQL -> vmDisks: [NutanixVmDisk!]! (type)
        [JsonProperty("vmDisks")]
        public List<NutanixVmDisk>? VmDisks { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixVm";
    }

    public NutanixVm Set(
        List<Operation>? AuthorizedOperations = null,
        CdmNutanixSnapshotConsistencyMandate? NutanixSnapshotConsistencyMandate = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        GuestOsType? OsType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        NutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        SlaDomain? PendingSla = null,
        List<CdmHierarchyObject>? ReplicatedObjects = null,
        System.String? CdmId = null,
        System.String? CdmLink = null,
        System.String? CurrentHostId = null,
        List<System.String>? ExcludedDisks = null,
        System.String? HypervisorType = null,
        System.String? Id = null,
        System.Boolean? IsAgentRegistered = null,
        System.Boolean? IsRelic = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? NutanixVmMountCount = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.Int32? ReplicatedObjectCount = null,
        System.Boolean? SlaPauseStatus = null,
        System.String? VmUuid = null,
        NutanixVmAgentStatus? AgentStatus = null,
        List<Org>? AllOrgs = null,
        Cluster? Cluster = null,
        PathNode? EffectiveSlaSourceObject = null,
        LatestUserNote? LatestUserNote = null,
        List<PathNode>? LogicalPath = null,
        MissedSnapshotCommonConnection? MissedSnapshotConnection = null,
        MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection = null,
        CdmSnapshot? NewestArchivedSnapshot = null,
        CdmSnapshot? NewestReplicatedSnapshot = null,
        CdmSnapshot? NewestSnapshot = null,
        CdmSnapshot? OldestSnapshot = null,
        PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus = null,
        List<PathNode>? PhysicalPath = null,
        NutanixBackupScript? PostBackupScript = null,
        NutanixBackupScript? PostSnapScript = null,
        NutanixBackupScript? PreBackupScript = null,
        DataLocation? PrimaryClusterLocation = null,
        Snappable? ReportSnappable = null,
        CdmSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        CdmSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary = null,
        List<NutanixVmDisk>? VmDisks = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( NutanixSnapshotConsistencyMandate != null ) {
            this.NutanixSnapshotConsistencyMandate = NutanixSnapshotConsistencyMandate;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( SnapshotConsistencyMandate != null ) {
            this.SnapshotConsistencyMandate = SnapshotConsistencyMandate;
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
        if ( PendingSla != null ) {
            this.PendingSla = PendingSla;
        }
        if ( ReplicatedObjects != null ) {
            this.ReplicatedObjects = ReplicatedObjects;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( CdmLink != null ) {
            this.CdmLink = CdmLink;
        }
        if ( CurrentHostId != null ) {
            this.CurrentHostId = CurrentHostId;
        }
        if ( ExcludedDisks != null ) {
            this.ExcludedDisks = ExcludedDisks;
        }
        if ( HypervisorType != null ) {
            this.HypervisorType = HypervisorType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsAgentRegistered != null ) {
            this.IsAgentRegistered = IsAgentRegistered;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( NutanixVmMountCount != null ) {
            this.NutanixVmMountCount = NutanixVmMountCount;
        }
        if ( OnDemandSnapshotCount != null ) {
            this.OnDemandSnapshotCount = OnDemandSnapshotCount;
        }
        if ( ReplicatedObjectCount != null ) {
            this.ReplicatedObjectCount = ReplicatedObjectCount;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( VmUuid != null ) {
            this.VmUuid = VmUuid;
        }
        if ( AgentStatus != null ) {
            this.AgentStatus = AgentStatus;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( LatestUserNote != null ) {
            this.LatestUserNote = LatestUserNote;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( MissedSnapshotConnection != null ) {
            this.MissedSnapshotConnection = MissedSnapshotConnection;
        }
        if ( MissedSnapshotGroupByConnection != null ) {
            this.MissedSnapshotGroupByConnection = MissedSnapshotGroupByConnection;
        }
        if ( NewestArchivedSnapshot != null ) {
            this.NewestArchivedSnapshot = NewestArchivedSnapshot;
        }
        if ( NewestReplicatedSnapshot != null ) {
            this.NewestReplicatedSnapshot = NewestReplicatedSnapshot;
        }
        if ( NewestSnapshot != null ) {
            this.NewestSnapshot = NewestSnapshot;
        }
        if ( OldestSnapshot != null ) {
            this.OldestSnapshot = OldestSnapshot;
        }
        if ( PendingObjectDeletionStatus != null ) {
            this.PendingObjectDeletionStatus = PendingObjectDeletionStatus;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( PostBackupScript != null ) {
            this.PostBackupScript = PostBackupScript;
        }
        if ( PostSnapScript != null ) {
            this.PostSnapScript = PostSnapScript;
        }
        if ( PreBackupScript != null ) {
            this.PreBackupScript = PreBackupScript;
        }
        if ( PrimaryClusterLocation != null ) {
            this.PrimaryClusterLocation = PrimaryClusterLocation;
        }
        if ( ReportSnappable != null ) {
            this.ReportSnappable = ReportSnappable;
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
        if ( SnapshotGroupBySummary != null ) {
            this.SnapshotGroupBySummary = SnapshotGroupBySummary;
        }
        if ( VmDisks != null ) {
            this.VmDisks = VmDisks;
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
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (this.AuthorizedOperations != null) {
            s += ind + "authorizedOperations\n" ;
        }
        //      C# -> CdmNutanixSnapshotConsistencyMandate? NutanixSnapshotConsistencyMandate
        // GraphQL -> nutanixSnapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate! (enum)
        if (this.NutanixSnapshotConsistencyMandate != null) {
            s += ind + "nutanixSnapshotConsistencyMandate\n" ;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> GuestOsType? OsType
        // GraphQL -> osType: GuestOsType (enum)
        if (this.OsType != null) {
            s += ind + "osType\n" ;
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment != null) {
            s += ind + "slaAssignment\n" ;
        }
        //      C# -> NutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: NutanixSnapshotConsistencyMandate! (enum)
        if (this.SnapshotConsistencyMandate != null) {
            s += ind + "snapshotConsistencyMandate\n" ;
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
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.PendingSla).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pendingSla {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        if (this.ReplicatedObjects != null) {
                var fspec = this.ReplicatedObjects.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "replicatedObjects {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            s += ind + "cdmId\n" ;
        }
        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        if (this.CdmLink != null) {
            s += ind + "cdmLink\n" ;
        }
        //      C# -> System.String? CurrentHostId
        // GraphQL -> currentHostId: String (scalar)
        if (this.CurrentHostId != null) {
            s += ind + "currentHostId\n" ;
        }
        //      C# -> List<System.String>? ExcludedDisks
        // GraphQL -> excludedDisks: [String!]! (scalar)
        if (this.ExcludedDisks != null) {
            s += ind + "excludedDisks\n" ;
        }
        //      C# -> System.String? HypervisorType
        // GraphQL -> hypervisorType: String (scalar)
        if (this.HypervisorType != null) {
            s += ind + "hypervisorType\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean! (scalar)
        if (this.IsAgentRegistered != null) {
            s += ind + "isAgentRegistered\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
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
        //      C# -> System.Int32? NutanixVmMountCount
        // GraphQL -> nutanixVmMountCount: Int! (scalar)
        if (this.NutanixVmMountCount != null) {
            s += ind + "nutanixVmMountCount\n" ;
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount != null) {
            s += ind + "onDemandSnapshotCount\n" ;
        }
        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        if (this.ReplicatedObjectCount != null) {
            s += ind + "replicatedObjectCount\n" ;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            s += ind + "slaPauseStatus\n" ;
        }
        //      C# -> System.String? VmUuid
        // GraphQL -> vmUuid: UUID! (scalar)
        if (this.VmUuid != null) {
            s += ind + "vmUuid\n" ;
        }
        //      C# -> NutanixVmAgentStatus? AgentStatus
        // GraphQL -> agentStatus: NutanixVmAgentStatus! (type)
        if (this.AgentStatus != null) {
            var fspec = this.AgentStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "agentStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allOrgs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
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
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote != null) {
            var fspec = this.LatestUserNote.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "latestUserNote {\n" + fspec + ind + "}\n" ;
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
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        if (this.MissedSnapshotConnection != null) {
            var fspec = this.MissedSnapshotConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "missedSnapshotConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        if (this.MissedSnapshotGroupByConnection != null) {
            var fspec = this.MissedSnapshotGroupByConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "missedSnapshotGroupByConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        if (this.NewestArchivedSnapshot != null) {
            var fspec = this.NewestArchivedSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newestArchivedSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        if (this.NewestReplicatedSnapshot != null) {
            var fspec = this.NewestReplicatedSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newestReplicatedSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        if (this.NewestSnapshot != null) {
            var fspec = this.NewestSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newestSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        if (this.OldestSnapshot != null) {
            var fspec = this.OldestSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oldestSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        if (this.PendingObjectDeletionStatus != null) {
            var fspec = this.PendingObjectDeletionStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pendingObjectDeletionStatus {\n" + fspec + ind + "}\n" ;
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
        //      C# -> NutanixBackupScript? PostBackupScript
        // GraphQL -> postBackupScript: NutanixBackupScript! (type)
        if (this.PostBackupScript != null) {
            var fspec = this.PostBackupScript.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "postBackupScript {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> NutanixBackupScript? PostSnapScript
        // GraphQL -> postSnapScript: NutanixBackupScript! (type)
        if (this.PostSnapScript != null) {
            var fspec = this.PostSnapScript.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "postSnapScript {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> NutanixBackupScript? PreBackupScript
        // GraphQL -> preBackupScript: NutanixBackupScript! (type)
        if (this.PreBackupScript != null) {
            var fspec = this.PreBackupScript.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "preBackupScript {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        if (this.PrimaryClusterLocation != null) {
            var fspec = this.PrimaryClusterLocation.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "primaryClusterLocation {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Snappable? ReportSnappable
        // GraphQL -> reportSnappable: Snappable (type)
        if (this.ReportSnappable != null) {
            var fspec = this.ReportSnappable.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "reportSnappable {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
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
        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection != null) {
            var fspec = this.SnapshotGroupByConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotGroupByConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        if (this.SnapshotGroupBySummary != null) {
            var fspec = this.SnapshotGroupBySummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotGroupBySummary {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<NutanixVmDisk>? VmDisks
        // GraphQL -> vmDisks: [NutanixVmDisk!]! (type)
        if (this.VmDisks != null) {
            var fspec = this.VmDisks.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vmDisks {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (this.AuthorizedOperations == null && ec.Includes("authorizedOperations",true))
        {
            this.AuthorizedOperations = new List<Operation>();
        }
        //      C# -> CdmNutanixSnapshotConsistencyMandate? NutanixSnapshotConsistencyMandate
        // GraphQL -> nutanixSnapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate! (enum)
        if (this.NutanixSnapshotConsistencyMandate == null && ec.Includes("nutanixSnapshotConsistencyMandate",true))
        {
            this.NutanixSnapshotConsistencyMandate = new CdmNutanixSnapshotConsistencyMandate();
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType == null && ec.Includes("objectType",true))
        {
            this.ObjectType = new HierarchyObjectTypeEnum();
        }
        //      C# -> GuestOsType? OsType
        // GraphQL -> osType: GuestOsType (enum)
        if (this.OsType == null && ec.Includes("osType",true))
        {
            this.OsType = new GuestOsType();
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment == null && ec.Includes("slaAssignment",true))
        {
            this.SlaAssignment = new SlaAssignmentTypeEnum();
        }
        //      C# -> NutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: NutanixSnapshotConsistencyMandate! (enum)
        if (this.SnapshotConsistencyMandate == null && ec.Includes("snapshotConsistencyMandate",true))
        {
            this.SnapshotConsistencyMandate = new NutanixSnapshotConsistencyMandate();
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain == null && ec.Includes("configuredSlaDomain",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));
            this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain == null && ec.Includes("effectiveRetentionSlaDomain",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));
            this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain == null && ec.Includes("effectiveSlaDomain",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));
            this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla == null && ec.Includes("pendingSla",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("pendingSla"));
            this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        if (this.ReplicatedObjects == null && ec.Includes("replicatedObjects",false))
        {
            this.ReplicatedObjects = new List<CdmHierarchyObject>();
            this.ReplicatedObjects.ApplyExploratoryFieldSpec(ec.NewChild("replicatedObjects"));
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId == null && ec.Includes("cdmId",true))
        {
            this.CdmId = "FETCH";
        }
        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        if (this.CdmLink == null && ec.Includes("cdmLink",true))
        {
            this.CdmLink = "FETCH";
        }
        //      C# -> System.String? CurrentHostId
        // GraphQL -> currentHostId: String (scalar)
        if (this.CurrentHostId == null && ec.Includes("currentHostId",true))
        {
            this.CurrentHostId = "FETCH";
        }
        //      C# -> List<System.String>? ExcludedDisks
        // GraphQL -> excludedDisks: [String!]! (scalar)
        if (this.ExcludedDisks == null && ec.Includes("excludedDisks",true))
        {
            this.ExcludedDisks = new List<System.String>();
        }
        //      C# -> System.String? HypervisorType
        // GraphQL -> hypervisorType: String (scalar)
        if (this.HypervisorType == null && ec.Includes("hypervisorType",true))
        {
            this.HypervisorType = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean! (scalar)
        if (this.IsAgentRegistered == null && ec.Includes("isAgentRegistered",true))
        {
            this.IsAgentRegistered = true;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && ec.Includes("isRelic",true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants == null && ec.Includes("numWorkloadDescendants",true))
        {
            this.NumWorkloadDescendants = Int32.MinValue;
        }
        //      C# -> System.Int32? NutanixVmMountCount
        // GraphQL -> nutanixVmMountCount: Int! (scalar)
        if (this.NutanixVmMountCount == null && ec.Includes("nutanixVmMountCount",true))
        {
            this.NutanixVmMountCount = Int32.MinValue;
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount == null && ec.Includes("onDemandSnapshotCount",true))
        {
            this.OnDemandSnapshotCount = Int32.MinValue;
        }
        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        if (this.ReplicatedObjectCount == null && ec.Includes("replicatedObjectCount",true))
        {
            this.ReplicatedObjectCount = Int32.MinValue;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus == null && ec.Includes("slaPauseStatus",true))
        {
            this.SlaPauseStatus = true;
        }
        //      C# -> System.String? VmUuid
        // GraphQL -> vmUuid: UUID! (scalar)
        if (this.VmUuid == null && ec.Includes("vmUuid",true))
        {
            this.VmUuid = "FETCH";
        }
        //      C# -> NutanixVmAgentStatus? AgentStatus
        // GraphQL -> agentStatus: NutanixVmAgentStatus! (type)
        if (this.AgentStatus == null && ec.Includes("agentStatus",false))
        {
            this.AgentStatus = new NutanixVmAgentStatus();
            this.AgentStatus.ApplyExploratoryFieldSpec(ec.NewChild("agentStatus"));
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && ec.Includes("allOrgs",false))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(ec.NewChild("allOrgs"));
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject == null && ec.Includes("effectiveSlaSourceObject",false))
        {
            this.EffectiveSlaSourceObject = new PathNode();
            this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaSourceObject"));
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote == null && ec.Includes("latestUserNote",false))
        {
            this.LatestUserNote = new LatestUserNote();
            this.LatestUserNote.ApplyExploratoryFieldSpec(ec.NewChild("latestUserNote"));
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath == null && ec.Includes("logicalPath",false))
        {
            this.LogicalPath = new List<PathNode>();
            this.LogicalPath.ApplyExploratoryFieldSpec(ec.NewChild("logicalPath"));
        }
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        if (this.MissedSnapshotConnection == null && ec.Includes("missedSnapshotConnection",false))
        {
            this.MissedSnapshotConnection = new MissedSnapshotCommonConnection();
            this.MissedSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotConnection"));
        }
        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        if (this.MissedSnapshotGroupByConnection == null && ec.Includes("missedSnapshotGroupByConnection",false))
        {
            this.MissedSnapshotGroupByConnection = new MissedSnapshotGroupByConnection();
            this.MissedSnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotGroupByConnection"));
        }
        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        if (this.NewestArchivedSnapshot == null && ec.Includes("newestArchivedSnapshot",false))
        {
            this.NewestArchivedSnapshot = new CdmSnapshot();
            this.NewestArchivedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestArchivedSnapshot"));
        }
        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        if (this.NewestReplicatedSnapshot == null && ec.Includes("newestReplicatedSnapshot",false))
        {
            this.NewestReplicatedSnapshot = new CdmSnapshot();
            this.NewestReplicatedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestReplicatedSnapshot"));
        }
        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        if (this.NewestSnapshot == null && ec.Includes("newestSnapshot",false))
        {
            this.NewestSnapshot = new CdmSnapshot();
            this.NewestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestSnapshot"));
        }
        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        if (this.OldestSnapshot == null && ec.Includes("oldestSnapshot",false))
        {
            this.OldestSnapshot = new CdmSnapshot();
            this.OldestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("oldestSnapshot"));
        }
        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        if (this.PendingObjectDeletionStatus == null && ec.Includes("pendingObjectDeletionStatus",false))
        {
            this.PendingObjectDeletionStatus = new PendingSnapshotsOfObjectDeletion();
            this.PendingObjectDeletionStatus.ApplyExploratoryFieldSpec(ec.NewChild("pendingObjectDeletionStatus"));
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath == null && ec.Includes("physicalPath",false))
        {
            this.PhysicalPath = new List<PathNode>();
            this.PhysicalPath.ApplyExploratoryFieldSpec(ec.NewChild("physicalPath"));
        }
        //      C# -> NutanixBackupScript? PostBackupScript
        // GraphQL -> postBackupScript: NutanixBackupScript! (type)
        if (this.PostBackupScript == null && ec.Includes("postBackupScript",false))
        {
            this.PostBackupScript = new NutanixBackupScript();
            this.PostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScript"));
        }
        //      C# -> NutanixBackupScript? PostSnapScript
        // GraphQL -> postSnapScript: NutanixBackupScript! (type)
        if (this.PostSnapScript == null && ec.Includes("postSnapScript",false))
        {
            this.PostSnapScript = new NutanixBackupScript();
            this.PostSnapScript.ApplyExploratoryFieldSpec(ec.NewChild("postSnapScript"));
        }
        //      C# -> NutanixBackupScript? PreBackupScript
        // GraphQL -> preBackupScript: NutanixBackupScript! (type)
        if (this.PreBackupScript == null && ec.Includes("preBackupScript",false))
        {
            this.PreBackupScript = new NutanixBackupScript();
            this.PreBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScript"));
        }
        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        if (this.PrimaryClusterLocation == null && ec.Includes("primaryClusterLocation",false))
        {
            this.PrimaryClusterLocation = new DataLocation();
            this.PrimaryClusterLocation.ApplyExploratoryFieldSpec(ec.NewChild("primaryClusterLocation"));
        }
        //      C# -> Snappable? ReportSnappable
        // GraphQL -> reportSnappable: Snappable (type)
        if (this.ReportSnappable == null && ec.Includes("reportSnappable",false))
        {
            this.ReportSnappable = new Snappable();
            this.ReportSnappable.ApplyExploratoryFieldSpec(ec.NewChild("reportSnappable"));
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        if (this.SnapshotConnection == null && ec.Includes("snapshotConnection",false))
        {
            this.SnapshotConnection = new CdmSnapshotConnection();
            this.SnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotConnection"));
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution == null && ec.Includes("snapshotDistribution",false))
        {
            this.SnapshotDistribution = new SnapshotDistribution();
            this.SnapshotDistribution.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDistribution"));
        }
        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection == null && ec.Includes("snapshotGroupByConnection",false))
        {
            this.SnapshotGroupByConnection = new CdmSnapshotGroupByConnection();
            this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByConnection"));
        }
        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        if (this.SnapshotGroupBySummary == null && ec.Includes("snapshotGroupBySummary",false))
        {
            this.SnapshotGroupBySummary = new CdmSnapshotGroupBySummaryConnection();
            this.SnapshotGroupBySummary.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupBySummary"));
        }
        //      C# -> List<NutanixVmDisk>? VmDisks
        // GraphQL -> vmDisks: [NutanixVmDisk!]! (type)
        if (this.VmDisks == null && ec.Includes("vmDisks",false))
        {
            this.VmDisks = new List<NutanixVmDisk>();
            this.VmDisks.ApplyExploratoryFieldSpec(ec.NewChild("vmDisks"));
        }
    }


    #endregion

    } // class NutanixVm
    
    #endregion

    public static class ListNutanixVmExtensions
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
            this List<NutanixVm> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVm> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVm());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<NutanixVm> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types