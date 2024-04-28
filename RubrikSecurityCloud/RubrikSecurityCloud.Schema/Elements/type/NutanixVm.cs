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

        //      C# -> NutanixVmSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: NutanixVmSnapshotConsistencyMandate! (enum)
        [JsonProperty("snapshotConsistencyMandate")]
        public NutanixVmSnapshotConsistencyMandate? SnapshotConsistencyMandate { get; set; }

        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        [JsonProperty("configuredSlaDomain")]
        public RscInterface<SlaDomain> ConfiguredSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        [JsonProperty("effectiveRetentionSlaDomain")]
        public RscInterface<SlaDomain> EffectiveRetentionSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        [JsonProperty("effectiveSlaDomain")]
        public RscInterface<SlaDomain> EffectiveSlaDomain { get; set; }

        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        [JsonProperty("pendingSla")]
        public RscInterface<SlaDomain> PendingSla { get; set; }

        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        [JsonProperty("replicatedObjects")]
        public RscInterfaceList<CdmHierarchyObject> ReplicatedObjects { get; set; }

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

        //      C# -> List<CrossAccountReplicatedObjectInfo>? CrossAccountReplicatedObjectInfos
        // GraphQL -> crossAccountReplicatedObjectInfos: [CrossAccountReplicatedObjectInfo!] (type)
        [JsonProperty("crossAccountReplicatedObjectInfos")]
        public List<CrossAccountReplicatedObjectInfo>? CrossAccountReplicatedObjectInfos { get; set; }

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

        //      C# -> CdmSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: CdmSnapshot (type)
        [JsonProperty("newestIndexedSnapshot")]
        public CdmSnapshot? NewestIndexedSnapshot { get; set; }

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

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars MissedSnapshotConnection { get; set; }

        public RscGqlVars MissedSnapshotGroupByConnection { get; set; }

        public RscGqlVars SnapshotConnection { get; set; }

        public RscGqlVars SnapshotGroupByConnection { get; set; }

        public RscGqlVars SnapshotGroupBySummary { get; set; }


        public InlineVars() {
            Tuple<string, string>[] missedSnapshotConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("filter", "MissedSnapshotFilterInput"),
                };
            this.MissedSnapshotConnection =
                new RscGqlVars(null, missedSnapshotConnectionArgs, null, true);
            Tuple<string, string>[] missedSnapshotGroupByConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("filter", "MissedSnapshotFilterInput"),
                    Tuple.Create("groupBy", "MissedSnapshotGroupByTime!"),
                    Tuple.Create("timezoneOffset", "Float"),
                };
            this.MissedSnapshotGroupByConnection =
                new RscGqlVars(null, missedSnapshotGroupByConnectionArgs, null, true);
            Tuple<string, string>[] snapshotConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("filter", "CdmSnapshotFilterInput"),
                    Tuple.Create("sortBy", "CdmSnapshotSortByEnum"),
                    Tuple.Create("sortOrder", "SortOrder"),
                };
            this.SnapshotConnection =
                new RscGqlVars(null, snapshotConnectionArgs, null, true);
            Tuple<string, string>[] snapshotGroupByConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("timezoneOffset", "Float"),
                    Tuple.Create("filter", "CdmSnapshotFilterInput"),
                    Tuple.Create("groupBy", "CdmSnapshotGroupByEnum!"),
                };
            this.SnapshotGroupByConnection =
                new RscGqlVars(null, snapshotGroupByConnectionArgs, null, true);
            Tuple<string, string>[] snapshotGroupBySummaryArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("timezoneOffset", "Float"),
                    Tuple.Create("filter", "CdmSnapshotFilterInput"),
                    Tuple.Create("groupBy", "CdmSnapshotGroupByEnum!"),
                };
            this.SnapshotGroupBySummary =
                new RscGqlVars(null, snapshotGroupBySummaryArgs, null, true);
        }
    }

    public NutanixVm()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "NutanixVm";
    }

    public NutanixVm Set(
        List<Operation>? AuthorizedOperations = null,
        CdmNutanixSnapshotConsistencyMandate? NutanixSnapshotConsistencyMandate = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        GuestOsType? OsType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        NutanixVmSnapshotConsistencyMandate? SnapshotConsistencyMandate = null,
        RscInterface<SlaDomain> ConfiguredSlaDomain = null,
        RscInterface<SlaDomain> EffectiveRetentionSlaDomain = null,
        RscInterface<SlaDomain> EffectiveSlaDomain = null,
        RscInterface<SlaDomain> PendingSla = null,
        RscInterfaceList<CdmHierarchyObject> ReplicatedObjects = null,
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
        List<CrossAccountReplicatedObjectInfo>? CrossAccountReplicatedObjectInfos = null,
        PathNode? EffectiveSlaSourceObject = null,
        LatestUserNote? LatestUserNote = null,
        List<PathNode>? LogicalPath = null,
        MissedSnapshotCommonConnection? MissedSnapshotConnection = null,
        MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection = null,
        CdmSnapshot? NewestArchivedSnapshot = null,
        CdmSnapshot? NewestIndexedSnapshot = null,
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
        if ( CrossAccountReplicatedObjectInfos != null ) {
            this.CrossAccountReplicatedObjectInfos = CrossAccountReplicatedObjectInfos;
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
        if ( NewestIndexedSnapshot != null ) {
            this.NewestIndexedSnapshot = NewestIndexedSnapshot;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (this.AuthorizedOperations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authorizedOperations\n" ;
            } else {
                s += ind + "authorizedOperations\n" ;
            }
        }
        //      C# -> CdmNutanixSnapshotConsistencyMandate? NutanixSnapshotConsistencyMandate
        // GraphQL -> nutanixSnapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate! (enum)
        if (this.NutanixSnapshotConsistencyMandate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nutanixSnapshotConsistencyMandate\n" ;
            } else {
                s += ind + "nutanixSnapshotConsistencyMandate\n" ;
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
        //      C# -> GuestOsType? OsType
        // GraphQL -> osType: GuestOsType (enum)
        if (this.OsType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osType\n" ;
            } else {
                s += ind + "osType\n" ;
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
        //      C# -> NutanixVmSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: NutanixVmSnapshotConsistencyMandate! (enum)
        if (this.SnapshotConsistencyMandate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotConsistencyMandate\n" ;
            } else {
                s += ind + "snapshotConsistencyMandate\n" ;
            }
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain != null) {
            var fspec = this.ConfiguredSlaDomain.AsFieldSpec(conf.Child("configuredSlaDomain"));
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
            var fspec = this.EffectiveRetentionSlaDomain.AsFieldSpec(conf.Child("effectiveRetentionSlaDomain"));
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
            var fspec = this.EffectiveSlaDomain.AsFieldSpec(conf.Child("effectiveSlaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla != null) {
            var fspec = this.PendingSla.AsFieldSpec(conf.Child("pendingSla"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pendingSla" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        if (this.ReplicatedObjects != null) {
            var fspec = this.ReplicatedObjects.AsFieldSpec(conf.Child("replicatedObjects"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicatedObjects" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
            }
        }
        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        if (this.CdmLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmLink\n" ;
            } else {
                s += ind + "cdmLink\n" ;
            }
        }
        //      C# -> System.String? CurrentHostId
        // GraphQL -> currentHostId: String (scalar)
        if (this.CurrentHostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentHostId\n" ;
            } else {
                s += ind + "currentHostId\n" ;
            }
        }
        //      C# -> List<System.String>? ExcludedDisks
        // GraphQL -> excludedDisks: [String!]! (scalar)
        if (this.ExcludedDisks != null) {
            if (conf.Flat) {
                s += conf.Prefix + "excludedDisks\n" ;
            } else {
                s += ind + "excludedDisks\n" ;
            }
        }
        //      C# -> System.String? HypervisorType
        // GraphQL -> hypervisorType: String (scalar)
        if (this.HypervisorType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hypervisorType\n" ;
            } else {
                s += ind + "hypervisorType\n" ;
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
        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean! (scalar)
        if (this.IsAgentRegistered != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAgentRegistered\n" ;
            } else {
                s += ind + "isAgentRegistered\n" ;
            }
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRelic\n" ;
            } else {
                s += ind + "isRelic\n" ;
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
        //      C# -> System.Int32? NutanixVmMountCount
        // GraphQL -> nutanixVmMountCount: Int! (scalar)
        if (this.NutanixVmMountCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nutanixVmMountCount\n" ;
            } else {
                s += ind + "nutanixVmMountCount\n" ;
            }
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "onDemandSnapshotCount\n" ;
            } else {
                s += ind + "onDemandSnapshotCount\n" ;
            }
        }
        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        if (this.ReplicatedObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicatedObjectCount\n" ;
            } else {
                s += ind + "replicatedObjectCount\n" ;
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
        //      C# -> System.String? VmUuid
        // GraphQL -> vmUuid: UUID! (scalar)
        if (this.VmUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmUuid\n" ;
            } else {
                s += ind + "vmUuid\n" ;
            }
        }
        //      C# -> NutanixVmAgentStatus? AgentStatus
        // GraphQL -> agentStatus: NutanixVmAgentStatus! (type)
        if (this.AgentStatus != null) {
            var fspec = this.AgentStatus.AsFieldSpec(conf.Child("agentStatus"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "agentStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(conf.Child("allOrgs"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allOrgs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CrossAccountReplicatedObjectInfo>? CrossAccountReplicatedObjectInfos
        // GraphQL -> crossAccountReplicatedObjectInfos: [CrossAccountReplicatedObjectInfo!] (type)
        if (this.CrossAccountReplicatedObjectInfos != null) {
            var fspec = this.CrossAccountReplicatedObjectInfos.AsFieldSpec(conf.Child("crossAccountReplicatedObjectInfos"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "crossAccountReplicatedObjectInfos" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            var fspec = this.EffectiveSlaSourceObject.AsFieldSpec(conf.Child("effectiveSlaSourceObject"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaSourceObject" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote != null) {
            var fspec = this.LatestUserNote.AsFieldSpec(conf.Child("latestUserNote"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestUserNote" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            var fspec = this.LogicalPath.AsFieldSpec(conf.Child("logicalPath"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logicalPath" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        if (this.MissedSnapshotConnection != null) {
            var fspec = this.MissedSnapshotConnection.AsFieldSpec(conf.Child("missedSnapshotConnection"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "missedSnapshotConnection" + "\n(" + this.Vars.MissedSnapshotConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        if (this.MissedSnapshotGroupByConnection != null) {
            var fspec = this.MissedSnapshotGroupByConnection.AsFieldSpec(conf.Child("missedSnapshotGroupByConnection"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "missedSnapshotGroupByConnection" + "\n(" + this.Vars.MissedSnapshotGroupByConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        if (this.NewestArchivedSnapshot != null) {
            var fspec = this.NewestArchivedSnapshot.AsFieldSpec(conf.Child("newestArchivedSnapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newestArchivedSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: CdmSnapshot (type)
        if (this.NewestIndexedSnapshot != null) {
            var fspec = this.NewestIndexedSnapshot.AsFieldSpec(conf.Child("newestIndexedSnapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newestIndexedSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        if (this.NewestReplicatedSnapshot != null) {
            var fspec = this.NewestReplicatedSnapshot.AsFieldSpec(conf.Child("newestReplicatedSnapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newestReplicatedSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        if (this.NewestSnapshot != null) {
            var fspec = this.NewestSnapshot.AsFieldSpec(conf.Child("newestSnapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newestSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        if (this.OldestSnapshot != null) {
            var fspec = this.OldestSnapshot.AsFieldSpec(conf.Child("oldestSnapshot"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oldestSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        if (this.PendingObjectDeletionStatus != null) {
            var fspec = this.PendingObjectDeletionStatus.AsFieldSpec(conf.Child("pendingObjectDeletionStatus"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pendingObjectDeletionStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            var fspec = this.PhysicalPath.AsFieldSpec(conf.Child("physicalPath"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "physicalPath" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NutanixBackupScript? PostBackupScript
        // GraphQL -> postBackupScript: NutanixBackupScript! (type)
        if (this.PostBackupScript != null) {
            var fspec = this.PostBackupScript.AsFieldSpec(conf.Child("postBackupScript"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "postBackupScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NutanixBackupScript? PostSnapScript
        // GraphQL -> postSnapScript: NutanixBackupScript! (type)
        if (this.PostSnapScript != null) {
            var fspec = this.PostSnapScript.AsFieldSpec(conf.Child("postSnapScript"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "postSnapScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NutanixBackupScript? PreBackupScript
        // GraphQL -> preBackupScript: NutanixBackupScript! (type)
        if (this.PreBackupScript != null) {
            var fspec = this.PreBackupScript.AsFieldSpec(conf.Child("preBackupScript"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "preBackupScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        if (this.PrimaryClusterLocation != null) {
            var fspec = this.PrimaryClusterLocation.AsFieldSpec(conf.Child("primaryClusterLocation"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "primaryClusterLocation" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Snappable? ReportSnappable
        // GraphQL -> reportSnappable: Snappable (type)
        if (this.ReportSnappable != null) {
            var fspec = this.ReportSnappable.AsFieldSpec(conf.Child("reportSnappable"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "reportSnappable" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        if (this.SnapshotConnection != null) {
            var fspec = this.SnapshotConnection.AsFieldSpec(conf.Child("snapshotConnection"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotConnection" + "\n(" + this.Vars.SnapshotConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            var fspec = this.SnapshotDistribution.AsFieldSpec(conf.Child("snapshotDistribution"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotDistribution" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection != null) {
            var fspec = this.SnapshotGroupByConnection.AsFieldSpec(conf.Child("snapshotGroupByConnection"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotGroupByConnection" + "\n(" + this.Vars.SnapshotGroupByConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        if (this.SnapshotGroupBySummary != null) {
            var fspec = this.SnapshotGroupBySummary.AsFieldSpec(conf.Child("snapshotGroupBySummary"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotGroupBySummary" + "\n(" + this.Vars.SnapshotGroupBySummary.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<NutanixVmDisk>? VmDisks
        // GraphQL -> vmDisks: [NutanixVmDisk!]! (type)
        if (this.VmDisks != null) {
            var fspec = this.VmDisks.AsFieldSpec(conf.Child("vmDisks"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmDisks" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (ec.Includes("authorizedOperations",true))
        {
            if(this.AuthorizedOperations == null) {

                this.AuthorizedOperations = new List<Operation>();

            } else {


            }
        }
        else if (this.AuthorizedOperations != null && ec.Excludes("authorizedOperations",true))
        {
            this.AuthorizedOperations = null;
        }
        //      C# -> CdmNutanixSnapshotConsistencyMandate? NutanixSnapshotConsistencyMandate
        // GraphQL -> nutanixSnapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate! (enum)
        if (ec.Includes("nutanixSnapshotConsistencyMandate",true))
        {
            if(this.NutanixSnapshotConsistencyMandate == null) {

                this.NutanixSnapshotConsistencyMandate = new CdmNutanixSnapshotConsistencyMandate();

            } else {


            }
        }
        else if (this.NutanixSnapshotConsistencyMandate != null && ec.Excludes("nutanixSnapshotConsistencyMandate",true))
        {
            this.NutanixSnapshotConsistencyMandate = null;
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
        //      C# -> GuestOsType? OsType
        // GraphQL -> osType: GuestOsType (enum)
        if (ec.Includes("osType",true))
        {
            if(this.OsType == null) {

                this.OsType = new GuestOsType();

            } else {


            }
        }
        else if (this.OsType != null && ec.Excludes("osType",true))
        {
            this.OsType = null;
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
        //      C# -> NutanixVmSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: NutanixVmSnapshotConsistencyMandate! (enum)
        if (ec.Includes("snapshotConsistencyMandate",true))
        {
            if(this.SnapshotConsistencyMandate == null) {

                this.SnapshotConsistencyMandate = new NutanixVmSnapshotConsistencyMandate();

            } else {


            }
        }
        else if (this.SnapshotConsistencyMandate != null && ec.Excludes("snapshotConsistencyMandate",true))
        {
            this.SnapshotConsistencyMandate = null;
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (ec.Includes("configuredSlaDomain",false))
        {
            if(this.ConfiguredSlaDomain == null) {

                this.ConfiguredSlaDomain = new RscInterface<SlaDomain>();
                this.ConfiguredSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));

            } else {

                this.ConfiguredSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("configuredSlaDomain"));

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

                this.EffectiveRetentionSlaDomain = new RscInterface<SlaDomain>();
                this.EffectiveRetentionSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));

            } else {

                this.EffectiveRetentionSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("effectiveRetentionSlaDomain"));

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

                this.EffectiveSlaDomain = new RscInterface<SlaDomain>();
                this.EffectiveSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));

            } else {

                this.EffectiveSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));

            }
        }
        else if (this.EffectiveSlaDomain != null && ec.Excludes("effectiveSlaDomain",false))
        {
            this.EffectiveSlaDomain = null;
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (ec.Includes("pendingSla",false))
        {
            if(this.PendingSla == null) {

                this.PendingSla = new RscInterface<SlaDomain>();
                this.PendingSla.ApplyExploratoryFieldSpec(ec.NewChild("pendingSla"));

            } else {

                this.PendingSla.ApplyExploratoryFieldSpec(ec.NewChild("pendingSla"));

            }
        }
        else if (this.PendingSla != null && ec.Excludes("pendingSla",false))
        {
            this.PendingSla = null;
        }
        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        if (ec.Includes("replicatedObjects",false))
        {
            if(this.ReplicatedObjects == null) {

                this.ReplicatedObjects = new RscInterfaceList<CdmHierarchyObject>();
                this.ReplicatedObjects.ApplyExploratoryFieldSpec(ec.NewChild("replicatedObjects"));

            } else {

                this.ReplicatedObjects.ApplyExploratoryFieldSpec(ec.NewChild("replicatedObjects"));

            }
        }
        else if (this.ReplicatedObjects != null && ec.Excludes("replicatedObjects",false))
        {
            this.ReplicatedObjects = null;
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (ec.Includes("cdmId",true))
        {
            if(this.CdmId == null) {

                this.CdmId = "FETCH";

            } else {


            }
        }
        else if (this.CdmId != null && ec.Excludes("cdmId",true))
        {
            this.CdmId = null;
        }
        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        if (ec.Includes("cdmLink",true))
        {
            if(this.CdmLink == null) {

                this.CdmLink = "FETCH";

            } else {


            }
        }
        else if (this.CdmLink != null && ec.Excludes("cdmLink",true))
        {
            this.CdmLink = null;
        }
        //      C# -> System.String? CurrentHostId
        // GraphQL -> currentHostId: String (scalar)
        if (ec.Includes("currentHostId",true))
        {
            if(this.CurrentHostId == null) {

                this.CurrentHostId = "FETCH";

            } else {


            }
        }
        else if (this.CurrentHostId != null && ec.Excludes("currentHostId",true))
        {
            this.CurrentHostId = null;
        }
        //      C# -> List<System.String>? ExcludedDisks
        // GraphQL -> excludedDisks: [String!]! (scalar)
        if (ec.Includes("excludedDisks",true))
        {
            if(this.ExcludedDisks == null) {

                this.ExcludedDisks = new List<System.String>();

            } else {


            }
        }
        else if (this.ExcludedDisks != null && ec.Excludes("excludedDisks",true))
        {
            this.ExcludedDisks = null;
        }
        //      C# -> System.String? HypervisorType
        // GraphQL -> hypervisorType: String (scalar)
        if (ec.Includes("hypervisorType",true))
        {
            if(this.HypervisorType == null) {

                this.HypervisorType = "FETCH";

            } else {


            }
        }
        else if (this.HypervisorType != null && ec.Excludes("hypervisorType",true))
        {
            this.HypervisorType = null;
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
        //      C# -> System.Boolean? IsAgentRegistered
        // GraphQL -> isAgentRegistered: Boolean! (scalar)
        if (ec.Includes("isAgentRegistered",true))
        {
            if(this.IsAgentRegistered == null) {

                this.IsAgentRegistered = true;

            } else {


            }
        }
        else if (this.IsAgentRegistered != null && ec.Excludes("isAgentRegistered",true))
        {
            this.IsAgentRegistered = null;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (ec.Includes("isRelic",true))
        {
            if(this.IsRelic == null) {

                this.IsRelic = true;

            } else {


            }
        }
        else if (this.IsRelic != null && ec.Excludes("isRelic",true))
        {
            this.IsRelic = null;
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
        //      C# -> System.Int32? NutanixVmMountCount
        // GraphQL -> nutanixVmMountCount: Int! (scalar)
        if (ec.Includes("nutanixVmMountCount",true))
        {
            if(this.NutanixVmMountCount == null) {

                this.NutanixVmMountCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.NutanixVmMountCount != null && ec.Excludes("nutanixVmMountCount",true))
        {
            this.NutanixVmMountCount = null;
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (ec.Includes("onDemandSnapshotCount",true))
        {
            if(this.OnDemandSnapshotCount == null) {

                this.OnDemandSnapshotCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.OnDemandSnapshotCount != null && ec.Excludes("onDemandSnapshotCount",true))
        {
            this.OnDemandSnapshotCount = null;
        }
        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        if (ec.Includes("replicatedObjectCount",true))
        {
            if(this.ReplicatedObjectCount == null) {

                this.ReplicatedObjectCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ReplicatedObjectCount != null && ec.Excludes("replicatedObjectCount",true))
        {
            this.ReplicatedObjectCount = null;
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
        //      C# -> System.String? VmUuid
        // GraphQL -> vmUuid: UUID! (scalar)
        if (ec.Includes("vmUuid",true))
        {
            if(this.VmUuid == null) {

                this.VmUuid = "FETCH";

            } else {


            }
        }
        else if (this.VmUuid != null && ec.Excludes("vmUuid",true))
        {
            this.VmUuid = null;
        }
        //      C# -> NutanixVmAgentStatus? AgentStatus
        // GraphQL -> agentStatus: NutanixVmAgentStatus! (type)
        if (ec.Includes("agentStatus",false))
        {
            if(this.AgentStatus == null) {

                this.AgentStatus = new NutanixVmAgentStatus();
                this.AgentStatus.ApplyExploratoryFieldSpec(ec.NewChild("agentStatus"));

            } else {

                this.AgentStatus.ApplyExploratoryFieldSpec(ec.NewChild("agentStatus"));

            }
        }
        else if (this.AgentStatus != null && ec.Excludes("agentStatus",false))
        {
            this.AgentStatus = null;
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
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> List<CrossAccountReplicatedObjectInfo>? CrossAccountReplicatedObjectInfos
        // GraphQL -> crossAccountReplicatedObjectInfos: [CrossAccountReplicatedObjectInfo!] (type)
        if (ec.Includes("crossAccountReplicatedObjectInfos",false))
        {
            if(this.CrossAccountReplicatedObjectInfos == null) {

                this.CrossAccountReplicatedObjectInfos = new List<CrossAccountReplicatedObjectInfo>();
                this.CrossAccountReplicatedObjectInfos.ApplyExploratoryFieldSpec(ec.NewChild("crossAccountReplicatedObjectInfos"));

            } else {

                this.CrossAccountReplicatedObjectInfos.ApplyExploratoryFieldSpec(ec.NewChild("crossAccountReplicatedObjectInfos"));

            }
        }
        else if (this.CrossAccountReplicatedObjectInfos != null && ec.Excludes("crossAccountReplicatedObjectInfos",false))
        {
            this.CrossAccountReplicatedObjectInfos = null;
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
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (ec.Includes("latestUserNote",false))
        {
            if(this.LatestUserNote == null) {

                this.LatestUserNote = new LatestUserNote();
                this.LatestUserNote.ApplyExploratoryFieldSpec(ec.NewChild("latestUserNote"));

            } else {

                this.LatestUserNote.ApplyExploratoryFieldSpec(ec.NewChild("latestUserNote"));

            }
        }
        else if (this.LatestUserNote != null && ec.Excludes("latestUserNote",false))
        {
            this.LatestUserNote = null;
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
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        if (ec.Includes("missedSnapshotConnection",false))
        {
            if(this.MissedSnapshotConnection == null) {

                this.MissedSnapshotConnection = new MissedSnapshotCommonConnection();
                this.MissedSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotConnection"));

            } else {

                this.MissedSnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotConnection"));

            }
        }
        else if (this.MissedSnapshotConnection != null && ec.Excludes("missedSnapshotConnection",false))
        {
            this.MissedSnapshotConnection = null;
        }
        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        if (ec.Includes("missedSnapshotGroupByConnection",false))
        {
            if(this.MissedSnapshotGroupByConnection == null) {

                this.MissedSnapshotGroupByConnection = new MissedSnapshotGroupByConnection();
                this.MissedSnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotGroupByConnection"));

            } else {

                this.MissedSnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotGroupByConnection"));

            }
        }
        else if (this.MissedSnapshotGroupByConnection != null && ec.Excludes("missedSnapshotGroupByConnection",false))
        {
            this.MissedSnapshotGroupByConnection = null;
        }
        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        if (ec.Includes("newestArchivedSnapshot",false))
        {
            if(this.NewestArchivedSnapshot == null) {

                this.NewestArchivedSnapshot = new CdmSnapshot();
                this.NewestArchivedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestArchivedSnapshot"));

            } else {

                this.NewestArchivedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestArchivedSnapshot"));

            }
        }
        else if (this.NewestArchivedSnapshot != null && ec.Excludes("newestArchivedSnapshot",false))
        {
            this.NewestArchivedSnapshot = null;
        }
        //      C# -> CdmSnapshot? NewestIndexedSnapshot
        // GraphQL -> newestIndexedSnapshot: CdmSnapshot (type)
        if (ec.Includes("newestIndexedSnapshot",false))
        {
            if(this.NewestIndexedSnapshot == null) {

                this.NewestIndexedSnapshot = new CdmSnapshot();
                this.NewestIndexedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestIndexedSnapshot"));

            } else {

                this.NewestIndexedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestIndexedSnapshot"));

            }
        }
        else if (this.NewestIndexedSnapshot != null && ec.Excludes("newestIndexedSnapshot",false))
        {
            this.NewestIndexedSnapshot = null;
        }
        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        if (ec.Includes("newestReplicatedSnapshot",false))
        {
            if(this.NewestReplicatedSnapshot == null) {

                this.NewestReplicatedSnapshot = new CdmSnapshot();
                this.NewestReplicatedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestReplicatedSnapshot"));

            } else {

                this.NewestReplicatedSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestReplicatedSnapshot"));

            }
        }
        else if (this.NewestReplicatedSnapshot != null && ec.Excludes("newestReplicatedSnapshot",false))
        {
            this.NewestReplicatedSnapshot = null;
        }
        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        if (ec.Includes("newestSnapshot",false))
        {
            if(this.NewestSnapshot == null) {

                this.NewestSnapshot = new CdmSnapshot();
                this.NewestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestSnapshot"));

            } else {

                this.NewestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("newestSnapshot"));

            }
        }
        else if (this.NewestSnapshot != null && ec.Excludes("newestSnapshot",false))
        {
            this.NewestSnapshot = null;
        }
        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        if (ec.Includes("oldestSnapshot",false))
        {
            if(this.OldestSnapshot == null) {

                this.OldestSnapshot = new CdmSnapshot();
                this.OldestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("oldestSnapshot"));

            } else {

                this.OldestSnapshot.ApplyExploratoryFieldSpec(ec.NewChild("oldestSnapshot"));

            }
        }
        else if (this.OldestSnapshot != null && ec.Excludes("oldestSnapshot",false))
        {
            this.OldestSnapshot = null;
        }
        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        if (ec.Includes("pendingObjectDeletionStatus",false))
        {
            if(this.PendingObjectDeletionStatus == null) {

                this.PendingObjectDeletionStatus = new PendingSnapshotsOfObjectDeletion();
                this.PendingObjectDeletionStatus.ApplyExploratoryFieldSpec(ec.NewChild("pendingObjectDeletionStatus"));

            } else {

                this.PendingObjectDeletionStatus.ApplyExploratoryFieldSpec(ec.NewChild("pendingObjectDeletionStatus"));

            }
        }
        else if (this.PendingObjectDeletionStatus != null && ec.Excludes("pendingObjectDeletionStatus",false))
        {
            this.PendingObjectDeletionStatus = null;
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
        //      C# -> NutanixBackupScript? PostBackupScript
        // GraphQL -> postBackupScript: NutanixBackupScript! (type)
        if (ec.Includes("postBackupScript",false))
        {
            if(this.PostBackupScript == null) {

                this.PostBackupScript = new NutanixBackupScript();
                this.PostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScript"));

            } else {

                this.PostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScript"));

            }
        }
        else if (this.PostBackupScript != null && ec.Excludes("postBackupScript",false))
        {
            this.PostBackupScript = null;
        }
        //      C# -> NutanixBackupScript? PostSnapScript
        // GraphQL -> postSnapScript: NutanixBackupScript! (type)
        if (ec.Includes("postSnapScript",false))
        {
            if(this.PostSnapScript == null) {

                this.PostSnapScript = new NutanixBackupScript();
                this.PostSnapScript.ApplyExploratoryFieldSpec(ec.NewChild("postSnapScript"));

            } else {

                this.PostSnapScript.ApplyExploratoryFieldSpec(ec.NewChild("postSnapScript"));

            }
        }
        else if (this.PostSnapScript != null && ec.Excludes("postSnapScript",false))
        {
            this.PostSnapScript = null;
        }
        //      C# -> NutanixBackupScript? PreBackupScript
        // GraphQL -> preBackupScript: NutanixBackupScript! (type)
        if (ec.Includes("preBackupScript",false))
        {
            if(this.PreBackupScript == null) {

                this.PreBackupScript = new NutanixBackupScript();
                this.PreBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScript"));

            } else {

                this.PreBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScript"));

            }
        }
        else if (this.PreBackupScript != null && ec.Excludes("preBackupScript",false))
        {
            this.PreBackupScript = null;
        }
        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        if (ec.Includes("primaryClusterLocation",false))
        {
            if(this.PrimaryClusterLocation == null) {

                this.PrimaryClusterLocation = new DataLocation();
                this.PrimaryClusterLocation.ApplyExploratoryFieldSpec(ec.NewChild("primaryClusterLocation"));

            } else {

                this.PrimaryClusterLocation.ApplyExploratoryFieldSpec(ec.NewChild("primaryClusterLocation"));

            }
        }
        else if (this.PrimaryClusterLocation != null && ec.Excludes("primaryClusterLocation",false))
        {
            this.PrimaryClusterLocation = null;
        }
        //      C# -> Snappable? ReportSnappable
        // GraphQL -> reportSnappable: Snappable (type)
        if (ec.Includes("reportSnappable",false))
        {
            if(this.ReportSnappable == null) {

                this.ReportSnappable = new Snappable();
                this.ReportSnappable.ApplyExploratoryFieldSpec(ec.NewChild("reportSnappable"));

            } else {

                this.ReportSnappable.ApplyExploratoryFieldSpec(ec.NewChild("reportSnappable"));

            }
        }
        else if (this.ReportSnappable != null && ec.Excludes("reportSnappable",false))
        {
            this.ReportSnappable = null;
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        if (ec.Includes("snapshotConnection",false))
        {
            if(this.SnapshotConnection == null) {

                this.SnapshotConnection = new CdmSnapshotConnection();
                this.SnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotConnection"));

            } else {

                this.SnapshotConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotConnection"));

            }
        }
        else if (this.SnapshotConnection != null && ec.Excludes("snapshotConnection",false))
        {
            this.SnapshotConnection = null;
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
        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        if (ec.Includes("snapshotGroupByConnection",false))
        {
            if(this.SnapshotGroupByConnection == null) {

                this.SnapshotGroupByConnection = new CdmSnapshotGroupByConnection();
                this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByConnection"));

            } else {

                this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupByConnection"));

            }
        }
        else if (this.SnapshotGroupByConnection != null && ec.Excludes("snapshotGroupByConnection",false))
        {
            this.SnapshotGroupByConnection = null;
        }
        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        if (ec.Includes("snapshotGroupBySummary",false))
        {
            if(this.SnapshotGroupBySummary == null) {

                this.SnapshotGroupBySummary = new CdmSnapshotGroupBySummaryConnection();
                this.SnapshotGroupBySummary.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupBySummary"));

            } else {

                this.SnapshotGroupBySummary.ApplyExploratoryFieldSpec(ec.NewChild("snapshotGroupBySummary"));

            }
        }
        else if (this.SnapshotGroupBySummary != null && ec.Excludes("snapshotGroupBySummary",false))
        {
            this.SnapshotGroupBySummary = null;
        }
        //      C# -> List<NutanixVmDisk>? VmDisks
        // GraphQL -> vmDisks: [NutanixVmDisk!]! (type)
        if (ec.Includes("vmDisks",false))
        {
            if(this.VmDisks == null) {

                this.VmDisks = new List<NutanixVmDisk>();
                this.VmDisks.ApplyExploratoryFieldSpec(ec.NewChild("vmDisks"));

            } else {

                this.VmDisks.ApplyExploratoryFieldSpec(ec.NewChild("vmDisks"));

            }
        }
        else if (this.VmDisks != null && ec.Excludes("vmDisks",false))
        {
            this.VmDisks = null;
        }
    }


    #endregion

    } // class NutanixVm
    
    #endregion

    public static class ListNutanixVmExtensions
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
            this List<NutanixVm> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixVm> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<NutanixVm> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types