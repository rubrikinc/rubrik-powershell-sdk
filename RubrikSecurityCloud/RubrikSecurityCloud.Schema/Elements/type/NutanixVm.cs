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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region NutanixVm
 
    public class NutanixVm: BaseType, CdmHierarchyObject, CdmHierarchySnappableNew, HierarchyObject, HierarchySnappable, NutanixClusterDescendantType, NutanixClusterLogicalChildType
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
            s += ind + "configuredSlaDomain {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.ConfiguredSlaDomain).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain != null) {
            s += ind + "effectiveRetentionSlaDomain {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveRetentionSlaDomain).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
            s += ind + "effectiveSlaDomain {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveSlaDomain).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla != null) {
            s += ind + "pendingSla {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.PendingSla).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        if (this.ReplicatedObjects != null) {
            s += ind + "replicatedObjects {\n" +
                this.ReplicatedObjects.AsFieldSpec(indent+1) + ind + "}\n";
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
            s += ind + "agentStatus {\n" + this.AgentStatus.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            s += ind + "allOrgs {\n" + this.AllOrgs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            s += ind + "cluster {\n" + this.Cluster.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            s += ind + "effectiveSlaSourceObject {\n" + this.EffectiveSlaSourceObject.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote != null) {
            s += ind + "latestUserNote {\n" + this.LatestUserNote.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            s += ind + "logicalPath {\n" + this.LogicalPath.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        if (this.MissedSnapshotConnection != null) {
            s += ind + "missedSnapshotConnection {\n" + this.MissedSnapshotConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        if (this.MissedSnapshotGroupByConnection != null) {
            s += ind + "missedSnapshotGroupByConnection {\n" + this.MissedSnapshotGroupByConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        if (this.NewestArchivedSnapshot != null) {
            s += ind + "newestArchivedSnapshot {\n" + this.NewestArchivedSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        if (this.NewestReplicatedSnapshot != null) {
            s += ind + "newestReplicatedSnapshot {\n" + this.NewestReplicatedSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        if (this.NewestSnapshot != null) {
            s += ind + "newestSnapshot {\n" + this.NewestSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        if (this.OldestSnapshot != null) {
            s += ind + "oldestSnapshot {\n" + this.OldestSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        if (this.PendingObjectDeletionStatus != null) {
            s += ind + "pendingObjectDeletionStatus {\n" + this.PendingObjectDeletionStatus.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            s += ind + "physicalPath {\n" + this.PhysicalPath.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> NutanixBackupScript? PostBackupScript
        // GraphQL -> postBackupScript: NutanixBackupScript! (type)
        if (this.PostBackupScript != null) {
            s += ind + "postBackupScript {\n" + this.PostBackupScript.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> NutanixBackupScript? PostSnapScript
        // GraphQL -> postSnapScript: NutanixBackupScript! (type)
        if (this.PostSnapScript != null) {
            s += ind + "postSnapScript {\n" + this.PostSnapScript.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> NutanixBackupScript? PreBackupScript
        // GraphQL -> preBackupScript: NutanixBackupScript! (type)
        if (this.PreBackupScript != null) {
            s += ind + "preBackupScript {\n" + this.PreBackupScript.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        if (this.PrimaryClusterLocation != null) {
            s += ind + "primaryClusterLocation {\n" + this.PrimaryClusterLocation.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> Snappable? ReportSnappable
        // GraphQL -> reportSnappable: Snappable (type)
        if (this.ReportSnappable != null) {
            s += ind + "reportSnappable {\n" + this.ReportSnappable.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        if (this.SnapshotConnection != null) {
            s += ind + "snapshotConnection {\n" + this.SnapshotConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            s += ind + "snapshotDistribution {\n" + this.SnapshotDistribution.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection != null) {
            s += ind + "snapshotGroupByConnection {\n" + this.SnapshotGroupByConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        if (this.SnapshotGroupBySummary != null) {
            s += ind + "snapshotGroupBySummary {\n" + this.SnapshotGroupBySummary.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<NutanixVmDisk>? VmDisks
        // GraphQL -> vmDisks: [NutanixVmDisk!]! (type)
        if (this.VmDisks != null) {
            s += ind + "vmDisks {\n" + this.VmDisks.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations", true))
        {
            this.AuthorizedOperations = new List<Operation>();
        }
        //      C# -> CdmNutanixSnapshotConsistencyMandate? NutanixSnapshotConsistencyMandate
        // GraphQL -> nutanixSnapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate! (enum)
        if (this.NutanixSnapshotConsistencyMandate == null && Exploration.Includes(parent + ".nutanixSnapshotConsistencyMandate", true))
        {
            this.NutanixSnapshotConsistencyMandate = new CdmNutanixSnapshotConsistencyMandate();
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new HierarchyObjectTypeEnum();
        }
        //      C# -> GuestOsType? OsType
        // GraphQL -> osType: GuestOsType (enum)
        if (this.OsType == null && Exploration.Includes(parent + ".osType", true))
        {
            this.OsType = new GuestOsType();
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment", true))
        {
            this.SlaAssignment = new SlaAssignmentTypeEnum();
        }
        //      C# -> NutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: NutanixSnapshotConsistencyMandate! (enum)
        if (this.SnapshotConsistencyMandate == null && Exploration.Includes(parent + ".snapshotConsistencyMandate", true))
        {
            this.SnapshotConsistencyMandate = new NutanixSnapshotConsistencyMandate();
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
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla == null && Exploration.Includes(parent + ".pendingSla"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".pendingSla");
            this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        if (this.ReplicatedObjects == null && Exploration.Includes(parent + ".replicatedObjects"))
        {
            this.ReplicatedObjects = new List<CdmHierarchyObject>();
            this.ReplicatedObjects.ApplyExploratoryFieldSpec(parent + ".replicatedObjects");
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId == null && Exploration.Includes(parent + ".cdmId", true))
        {
            this.CdmId = "FETCH";
        }
        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        if (this.CdmLink == null && Exploration.Includes(parent + ".cdmLink", true))
        {
            this.CdmLink = "FETCH";
        }
        //      C# -> System.String? CurrentHostId
        // GraphQL -> currentHostId: String (scalar)
        if (this.CurrentHostId == null && Exploration.Includes(parent + ".currentHostId", true))
        {
            this.CurrentHostId = "FETCH";
        }
        //      C# -> List<System.String>? ExcludedDisks
        // GraphQL -> excludedDisks: [String!]! (scalar)
        if (this.ExcludedDisks == null && Exploration.Includes(parent + ".excludedDisks", true))
        {
            this.ExcludedDisks = new List<System.String>();
        }
        //      C# -> System.String? HypervisorType
        // GraphQL -> hypervisorType: String (scalar)
        if (this.HypervisorType == null && Exploration.Includes(parent + ".hypervisorType", true))
        {
            this.HypervisorType = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean! (scalar)
        if (this.IsAgentRegistered == null && Exploration.Includes(parent + ".isAgentRegistered", true))
        {
            this.IsAgentRegistered = true;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
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
        //      C# -> System.Int32? NutanixVmMountCount
        // GraphQL -> nutanixVmMountCount: Int! (scalar)
        if (this.NutanixVmMountCount == null && Exploration.Includes(parent + ".nutanixVmMountCount", true))
        {
            this.NutanixVmMountCount = Int32.MinValue;
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount == null && Exploration.Includes(parent + ".onDemandSnapshotCount", true))
        {
            this.OnDemandSnapshotCount = Int32.MinValue;
        }
        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        if (this.ReplicatedObjectCount == null && Exploration.Includes(parent + ".replicatedObjectCount", true))
        {
            this.ReplicatedObjectCount = Int32.MinValue;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus", true))
        {
            this.SlaPauseStatus = true;
        }
        //      C# -> System.String? VmUuid
        // GraphQL -> vmUuid: UUID! (scalar)
        if (this.VmUuid == null && Exploration.Includes(parent + ".vmUuid", true))
        {
            this.VmUuid = "FETCH";
        }
        //      C# -> NutanixVmAgentStatus? AgentStatus
        // GraphQL -> agentStatus: NutanixVmAgentStatus! (type)
        if (this.AgentStatus == null && Exploration.Includes(parent + ".agentStatus"))
        {
            this.AgentStatus = new NutanixVmAgentStatus();
            this.AgentStatus.ApplyExploratoryFieldSpec(parent + ".agentStatus");
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(parent + ".allOrgs");
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
        {
            this.EffectiveSlaSourceObject = new PathNode();
            this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(parent + ".effectiveSlaSourceObject");
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote == null && Exploration.Includes(parent + ".latestUserNote"))
        {
            this.LatestUserNote = new LatestUserNote();
            this.LatestUserNote.ApplyExploratoryFieldSpec(parent + ".latestUserNote");
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
        {
            this.LogicalPath = new List<PathNode>();
            this.LogicalPath.ApplyExploratoryFieldSpec(parent + ".logicalPath");
        }
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        if (this.MissedSnapshotConnection == null && Exploration.Includes(parent + ".missedSnapshotConnection"))
        {
            this.MissedSnapshotConnection = new MissedSnapshotCommonConnection();
            this.MissedSnapshotConnection.ApplyExploratoryFieldSpec(parent + ".missedSnapshotConnection");
        }
        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        if (this.MissedSnapshotGroupByConnection == null && Exploration.Includes(parent + ".missedSnapshotGroupByConnection"))
        {
            this.MissedSnapshotGroupByConnection = new MissedSnapshotGroupByConnection();
            this.MissedSnapshotGroupByConnection.ApplyExploratoryFieldSpec(parent + ".missedSnapshotGroupByConnection");
        }
        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        if (this.NewestArchivedSnapshot == null && Exploration.Includes(parent + ".newestArchivedSnapshot"))
        {
            this.NewestArchivedSnapshot = new CdmSnapshot();
            this.NewestArchivedSnapshot.ApplyExploratoryFieldSpec(parent + ".newestArchivedSnapshot");
        }
        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        if (this.NewestReplicatedSnapshot == null && Exploration.Includes(parent + ".newestReplicatedSnapshot"))
        {
            this.NewestReplicatedSnapshot = new CdmSnapshot();
            this.NewestReplicatedSnapshot.ApplyExploratoryFieldSpec(parent + ".newestReplicatedSnapshot");
        }
        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        if (this.NewestSnapshot == null && Exploration.Includes(parent + ".newestSnapshot"))
        {
            this.NewestSnapshot = new CdmSnapshot();
            this.NewestSnapshot.ApplyExploratoryFieldSpec(parent + ".newestSnapshot");
        }
        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        if (this.OldestSnapshot == null && Exploration.Includes(parent + ".oldestSnapshot"))
        {
            this.OldestSnapshot = new CdmSnapshot();
            this.OldestSnapshot.ApplyExploratoryFieldSpec(parent + ".oldestSnapshot");
        }
        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        if (this.PendingObjectDeletionStatus == null && Exploration.Includes(parent + ".pendingObjectDeletionStatus"))
        {
            this.PendingObjectDeletionStatus = new PendingSnapshotsOfObjectDeletion();
            this.PendingObjectDeletionStatus.ApplyExploratoryFieldSpec(parent + ".pendingObjectDeletionStatus");
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
        {
            this.PhysicalPath = new List<PathNode>();
            this.PhysicalPath.ApplyExploratoryFieldSpec(parent + ".physicalPath");
        }
        //      C# -> NutanixBackupScript? PostBackupScript
        // GraphQL -> postBackupScript: NutanixBackupScript! (type)
        if (this.PostBackupScript == null && Exploration.Includes(parent + ".postBackupScript"))
        {
            this.PostBackupScript = new NutanixBackupScript();
            this.PostBackupScript.ApplyExploratoryFieldSpec(parent + ".postBackupScript");
        }
        //      C# -> NutanixBackupScript? PostSnapScript
        // GraphQL -> postSnapScript: NutanixBackupScript! (type)
        if (this.PostSnapScript == null && Exploration.Includes(parent + ".postSnapScript"))
        {
            this.PostSnapScript = new NutanixBackupScript();
            this.PostSnapScript.ApplyExploratoryFieldSpec(parent + ".postSnapScript");
        }
        //      C# -> NutanixBackupScript? PreBackupScript
        // GraphQL -> preBackupScript: NutanixBackupScript! (type)
        if (this.PreBackupScript == null && Exploration.Includes(parent + ".preBackupScript"))
        {
            this.PreBackupScript = new NutanixBackupScript();
            this.PreBackupScript.ApplyExploratoryFieldSpec(parent + ".preBackupScript");
        }
        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        if (this.PrimaryClusterLocation == null && Exploration.Includes(parent + ".primaryClusterLocation"))
        {
            this.PrimaryClusterLocation = new DataLocation();
            this.PrimaryClusterLocation.ApplyExploratoryFieldSpec(parent + ".primaryClusterLocation");
        }
        //      C# -> Snappable? ReportSnappable
        // GraphQL -> reportSnappable: Snappable (type)
        if (this.ReportSnappable == null && Exploration.Includes(parent + ".reportSnappable"))
        {
            this.ReportSnappable = new Snappable();
            this.ReportSnappable.ApplyExploratoryFieldSpec(parent + ".reportSnappable");
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        if (this.SnapshotConnection == null && Exploration.Includes(parent + ".snapshotConnection"))
        {
            this.SnapshotConnection = new CdmSnapshotConnection();
            this.SnapshotConnection.ApplyExploratoryFieldSpec(parent + ".snapshotConnection");
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
        {
            this.SnapshotDistribution = new SnapshotDistribution();
            this.SnapshotDistribution.ApplyExploratoryFieldSpec(parent + ".snapshotDistribution");
        }
        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection == null && Exploration.Includes(parent + ".snapshotGroupByConnection"))
        {
            this.SnapshotGroupByConnection = new CdmSnapshotGroupByConnection();
            this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(parent + ".snapshotGroupByConnection");
        }
        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        if (this.SnapshotGroupBySummary == null && Exploration.Includes(parent + ".snapshotGroupBySummary"))
        {
            this.SnapshotGroupBySummary = new CdmSnapshotGroupBySummaryConnection();
            this.SnapshotGroupBySummary.ApplyExploratoryFieldSpec(parent + ".snapshotGroupBySummary");
        }
        //      C# -> List<NutanixVmDisk>? VmDisks
        // GraphQL -> vmDisks: [NutanixVmDisk!]! (type)
        if (this.VmDisks == null && Exploration.Includes(parent + ".vmDisks"))
        {
            this.VmDisks = new List<NutanixVmDisk>();
            this.VmDisks.ApplyExploratoryFieldSpec(parent + ".vmDisks");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVm> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVm());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types