// OracleDatabase.cs
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
    #region OracleDatabase
 
    public class OracleDatabase: BaseType, CdmHierarchyObject, CdmHierarchySnappableNew, HierarchyObject, OracleDataGuardGroupDescendantType, OracleDataGuardGroupLogicalChildType, OracleHostDescendantType, OracleHostLogicalChildType, OracleRacDescendantType, OracleRacLogicalChildType, OracleTopLevelDescendantType
    {
        #region members

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> DataGuardType? DataGuardType
        // GraphQL -> dataGuardType: DataGuardType! (enum)
        [JsonProperty("dataGuardType")]
        public DataGuardType? DataGuardType { get; set; }

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

        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        [JsonProperty("pendingSla")]
        public SlaDomain? PendingSla { get; set; }

        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        [JsonProperty("replicatedObjects")]
        public List<CdmHierarchyObject>? ReplicatedObjects { get; set; }

        //      C# -> System.String? ArchiveLogMode
        // GraphQL -> archiveLogMode: String! (scalar)
        [JsonProperty("archiveLogMode")]
        public System.String? ArchiveLogMode { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        [JsonProperty("cdmLink")]
        public System.String? CdmLink { get; set; }

        //      C# -> System.String? DbRole
        // GraphQL -> dbRole: String! (scalar)
        [JsonProperty("dbRole")]
        public System.String? DbRole { get; set; }

        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String! (scalar)
        [JsonProperty("dbUniqueName")]
        public System.String? DbUniqueName { get; set; }

        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int! (scalar)
        [JsonProperty("hostLogRetentionHours")]
        public System.Int32? HostLogRetentionHours { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsLiveMount
        // GraphQL -> isLiveMount: Boolean! (scalar)
        [JsonProperty("isLiveMount")]
        public System.Boolean? IsLiveMount { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.Int32? LogBackupFrequency
        // GraphQL -> logBackupFrequency: Int! (scalar)
        [JsonProperty("logBackupFrequency")]
        public System.Int32? LogBackupFrequency { get; set; }

        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        [JsonProperty("logRetentionHours")]
        public System.Int32? LogRetentionHours { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int64? NumChannels
        // GraphQL -> numChannels: Long! (scalar)
        [JsonProperty("numChannels")]
        public System.Int64? NumChannels { get; set; }

        //      C# -> System.Int32? NumInstances
        // GraphQL -> numInstances: Int! (scalar)
        [JsonProperty("numInstances")]
        public System.Int32? NumInstances { get; set; }

        //      C# -> System.Int32? NumLogSnapshots
        // GraphQL -> numLogSnapshots: Int! (scalar)
        [JsonProperty("numLogSnapshots")]
        public System.Int32? NumLogSnapshots { get; set; }

        //      C# -> System.Int32? NumTablespaces
        // GraphQL -> numTablespaces: Int! (scalar)
        [JsonProperty("numTablespaces")]
        public System.Int32? NumTablespaces { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        [JsonProperty("onDemandSnapshotCount")]
        public System.Int32? OnDemandSnapshotCount { get; set; }

        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        [JsonProperty("replicatedObjectCount")]
        public System.Int32? ReplicatedObjectCount { get; set; }

        //      C# -> System.Int32? SectionSizeInGigabytes
        // GraphQL -> sectionSizeInGigabytes: Int! (scalar)
        [JsonProperty("sectionSizeInGigabytes")]
        public System.Int32? SectionSizeInGigabytes { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        [JsonProperty("tablespaces")]
        public List<System.String>? Tablespaces { get; set; }

        //      C# -> System.Boolean? UseSecureThrift
        // GraphQL -> useSecureThrift: Boolean! (scalar)
        [JsonProperty("useSecureThrift")]
        public System.Boolean? UseSecureThrift { get; set; }

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

        //      C# -> OracleDataGuardGroup? DataGuardGroup
        // GraphQL -> dataGuardGroup: OracleDataGuardGroup (type)
        [JsonProperty("dataGuardGroup")]
        public OracleDataGuardGroup? DataGuardGroup { get; set; }

        //      C# -> OracleDirectoryPaths? DirectoryPaths
        // GraphQL -> directoryPaths: OracleDirectoryPaths (type)
        [JsonProperty("directoryPaths")]
        public OracleDirectoryPaths? DirectoryPaths { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> List<OracleDatabaseInstance>? Instances
        // GraphQL -> instances: [OracleDatabaseInstance!]! (type)
        [JsonProperty("instances")]
        public List<OracleDatabaseInstance>? Instances { get; set; }

        //      C# -> OracleDatabaseLastValidationStatus? LastValidationResult
        // GraphQL -> lastValidationResult: OracleDatabaseLastValidationStatus (type)
        [JsonProperty("lastValidationResult")]
        public OracleDatabaseLastValidationStatus? LastValidationResult { get; set; }

        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        [JsonProperty("latestUserNote")]
        public LatestUserNote? LatestUserNote { get; set; }

        //      C# -> OracleLiveMountConnection? LiveMounts
        // GraphQL -> liveMounts: OracleLiveMountConnection! (type)
        [JsonProperty("liveMounts")]
        public OracleLiveMountConnection? LiveMounts { get; set; }

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

        //      C# -> List<OraclePdb>? Pdbs
        // GraphQL -> pdbs: [OraclePdb!]! (type)
        [JsonProperty("pdbs")]
        public List<OraclePdb>? Pdbs { get; set; }

        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        [JsonProperty("pendingObjectDeletionStatus")]
        public PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        [JsonProperty("primaryClusterLocation")]
        public DataLocation? PrimaryClusterLocation { get; set; }

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

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars LiveMounts { get; set; }

        public RscGqlVars MissedSnapshotConnection { get; set; }

        public RscGqlVars MissedSnapshotGroupByConnection { get; set; }

        public RscGqlVars SnapshotConnection { get; set; }

        public RscGqlVars SnapshotGroupByConnection { get; set; }

        public RscGqlVars SnapshotGroupBySummary { get; set; }


        public InlineVars() {
            Tuple<string, string>[] liveMountsArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("filters", "[OracleLiveMountFilterInput!]"),
                    Tuple.Create("sortBy", "OracleLiveMountSortBy"),
                };
            this.LiveMounts =
                new RscGqlVars(null, liveMountsArgs, null, true);
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

    public OracleDatabase()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "OracleDatabase";
    }

    public OracleDatabase Set(
        List<Operation>? AuthorizedOperations = null,
        DataGuardType? DataGuardType = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        SlaDomain? PendingSla = null,
        List<CdmHierarchyObject>? ReplicatedObjects = null,
        System.String? ArchiveLogMode = null,
        System.String? CdmId = null,
        System.String? CdmLink = null,
        System.String? DbRole = null,
        System.String? DbUniqueName = null,
        System.Int32? HostLogRetentionHours = null,
        System.String? Id = null,
        System.Boolean? IsLiveMount = null,
        System.Boolean? IsRelic = null,
        System.Int32? LogBackupFrequency = null,
        System.Int32? LogRetentionHours = null,
        System.String? Name = null,
        System.Int64? NumChannels = null,
        System.Int32? NumInstances = null,
        System.Int32? NumLogSnapshots = null,
        System.Int32? NumTablespaces = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.Int32? ReplicatedObjectCount = null,
        System.Int32? SectionSizeInGigabytes = null,
        System.Boolean? SlaPauseStatus = null,
        List<System.String>? Tablespaces = null,
        System.Boolean? UseSecureThrift = null,
        List<Org>? AllOrgs = null,
        Cluster? Cluster = null,
        List<CrossAccountReplicatedObjectInfo>? CrossAccountReplicatedObjectInfos = null,
        OracleDataGuardGroup? DataGuardGroup = null,
        OracleDirectoryPaths? DirectoryPaths = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<OracleDatabaseInstance>? Instances = null,
        OracleDatabaseLastValidationStatus? LastValidationResult = null,
        LatestUserNote? LatestUserNote = null,
        OracleLiveMountConnection? LiveMounts = null,
        List<PathNode>? LogicalPath = null,
        MissedSnapshotCommonConnection? MissedSnapshotConnection = null,
        MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection = null,
        CdmSnapshot? NewestArchivedSnapshot = null,
        CdmSnapshot? NewestIndexedSnapshot = null,
        CdmSnapshot? NewestReplicatedSnapshot = null,
        CdmSnapshot? NewestSnapshot = null,
        CdmSnapshot? OldestSnapshot = null,
        List<OraclePdb>? Pdbs = null,
        PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus = null,
        List<PathNode>? PhysicalPath = null,
        DataLocation? PrimaryClusterLocation = null,
        CdmSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        CdmSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( DataGuardType != null ) {
            this.DataGuardType = DataGuardType;
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
        if ( PendingSla != null ) {
            this.PendingSla = PendingSla;
        }
        if ( ReplicatedObjects != null ) {
            this.ReplicatedObjects = ReplicatedObjects;
        }
        if ( ArchiveLogMode != null ) {
            this.ArchiveLogMode = ArchiveLogMode;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( CdmLink != null ) {
            this.CdmLink = CdmLink;
        }
        if ( DbRole != null ) {
            this.DbRole = DbRole;
        }
        if ( DbUniqueName != null ) {
            this.DbUniqueName = DbUniqueName;
        }
        if ( HostLogRetentionHours != null ) {
            this.HostLogRetentionHours = HostLogRetentionHours;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsLiveMount != null ) {
            this.IsLiveMount = IsLiveMount;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( LogBackupFrequency != null ) {
            this.LogBackupFrequency = LogBackupFrequency;
        }
        if ( LogRetentionHours != null ) {
            this.LogRetentionHours = LogRetentionHours;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumChannels != null ) {
            this.NumChannels = NumChannels;
        }
        if ( NumInstances != null ) {
            this.NumInstances = NumInstances;
        }
        if ( NumLogSnapshots != null ) {
            this.NumLogSnapshots = NumLogSnapshots;
        }
        if ( NumTablespaces != null ) {
            this.NumTablespaces = NumTablespaces;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( OnDemandSnapshotCount != null ) {
            this.OnDemandSnapshotCount = OnDemandSnapshotCount;
        }
        if ( ReplicatedObjectCount != null ) {
            this.ReplicatedObjectCount = ReplicatedObjectCount;
        }
        if ( SectionSizeInGigabytes != null ) {
            this.SectionSizeInGigabytes = SectionSizeInGigabytes;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( Tablespaces != null ) {
            this.Tablespaces = Tablespaces;
        }
        if ( UseSecureThrift != null ) {
            this.UseSecureThrift = UseSecureThrift;
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
        if ( DataGuardGroup != null ) {
            this.DataGuardGroup = DataGuardGroup;
        }
        if ( DirectoryPaths != null ) {
            this.DirectoryPaths = DirectoryPaths;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( Instances != null ) {
            this.Instances = Instances;
        }
        if ( LastValidationResult != null ) {
            this.LastValidationResult = LastValidationResult;
        }
        if ( LatestUserNote != null ) {
            this.LatestUserNote = LatestUserNote;
        }
        if ( LiveMounts != null ) {
            this.LiveMounts = LiveMounts;
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
        if ( Pdbs != null ) {
            this.Pdbs = Pdbs;
        }
        if ( PendingObjectDeletionStatus != null ) {
            this.PendingObjectDeletionStatus = PendingObjectDeletionStatus;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( PrimaryClusterLocation != null ) {
            this.PrimaryClusterLocation = PrimaryClusterLocation;
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
        //      C# -> DataGuardType? DataGuardType
        // GraphQL -> dataGuardType: DataGuardType! (enum)
        if (this.DataGuardType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataGuardType\n" ;
            } else {
                s += ind + "dataGuardType\n" ;
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
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.PendingSla, conf.Child("pendingSla"));
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
        //      C# -> System.String? ArchiveLogMode
        // GraphQL -> archiveLogMode: String! (scalar)
        if (this.ArchiveLogMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archiveLogMode\n" ;
            } else {
                s += ind + "archiveLogMode\n" ;
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
        //      C# -> System.String? DbRole
        // GraphQL -> dbRole: String! (scalar)
        if (this.DbRole != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbRole\n" ;
            } else {
                s += ind + "dbRole\n" ;
            }
        }
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String! (scalar)
        if (this.DbUniqueName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dbUniqueName\n" ;
            } else {
                s += ind + "dbUniqueName\n" ;
            }
        }
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int! (scalar)
        if (this.HostLogRetentionHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostLogRetentionHours\n" ;
            } else {
                s += ind + "hostLogRetentionHours\n" ;
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
        //      C# -> System.Boolean? IsLiveMount
        // GraphQL -> isLiveMount: Boolean! (scalar)
        if (this.IsLiveMount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isLiveMount\n" ;
            } else {
                s += ind + "isLiveMount\n" ;
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
        //      C# -> System.Int32? LogBackupFrequency
        // GraphQL -> logBackupFrequency: Int! (scalar)
        if (this.LogBackupFrequency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logBackupFrequency\n" ;
            } else {
                s += ind + "logBackupFrequency\n" ;
            }
        }
        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        if (this.LogRetentionHours != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logRetentionHours\n" ;
            } else {
                s += ind + "logRetentionHours\n" ;
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
        //      C# -> System.Int64? NumChannels
        // GraphQL -> numChannels: Long! (scalar)
        if (this.NumChannels != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numChannels\n" ;
            } else {
                s += ind + "numChannels\n" ;
            }
        }
        //      C# -> System.Int32? NumInstances
        // GraphQL -> numInstances: Int! (scalar)
        if (this.NumInstances != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numInstances\n" ;
            } else {
                s += ind + "numInstances\n" ;
            }
        }
        //      C# -> System.Int32? NumLogSnapshots
        // GraphQL -> numLogSnapshots: Int! (scalar)
        if (this.NumLogSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numLogSnapshots\n" ;
            } else {
                s += ind + "numLogSnapshots\n" ;
            }
        }
        //      C# -> System.Int32? NumTablespaces
        // GraphQL -> numTablespaces: Int! (scalar)
        if (this.NumTablespaces != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numTablespaces\n" ;
            } else {
                s += ind + "numTablespaces\n" ;
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
        //      C# -> System.Int32? SectionSizeInGigabytes
        // GraphQL -> sectionSizeInGigabytes: Int! (scalar)
        if (this.SectionSizeInGigabytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sectionSizeInGigabytes\n" ;
            } else {
                s += ind + "sectionSizeInGigabytes\n" ;
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
        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        if (this.Tablespaces != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tablespaces\n" ;
            } else {
                s += ind + "tablespaces\n" ;
            }
        }
        //      C# -> System.Boolean? UseSecureThrift
        // GraphQL -> useSecureThrift: Boolean! (scalar)
        if (this.UseSecureThrift != null) {
            if (conf.Flat) {
                s += conf.Prefix + "useSecureThrift\n" ;
            } else {
                s += ind + "useSecureThrift\n" ;
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
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "crossAccountReplicatedObjectInfos" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleDataGuardGroup? DataGuardGroup
        // GraphQL -> dataGuardGroup: OracleDataGuardGroup (type)
        if (this.DataGuardGroup != null) {
            var fspec = this.DataGuardGroup.AsFieldSpec(conf.Child("dataGuardGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataGuardGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleDirectoryPaths? DirectoryPaths
        // GraphQL -> directoryPaths: OracleDirectoryPaths (type)
        if (this.DirectoryPaths != null) {
            var fspec = this.DirectoryPaths.AsFieldSpec(conf.Child("directoryPaths"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "directoryPaths" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> List<OracleDatabaseInstance>? Instances
        // GraphQL -> instances: [OracleDatabaseInstance!]! (type)
        if (this.Instances != null) {
            var fspec = this.Instances.AsFieldSpec(conf.Child("instances"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "instances" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleDatabaseLastValidationStatus? LastValidationResult
        // GraphQL -> lastValidationResult: OracleDatabaseLastValidationStatus (type)
        if (this.LastValidationResult != null) {
            var fspec = this.LastValidationResult.AsFieldSpec(conf.Child("lastValidationResult"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "lastValidationResult" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote != null) {
            var fspec = this.LatestUserNote.AsFieldSpec(conf.Child("latestUserNote"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestUserNote" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleLiveMountConnection? LiveMounts
        // GraphQL -> liveMounts: OracleLiveMountConnection! (type)
        if (this.LiveMounts != null) {
            var fspec = this.LiveMounts.AsFieldSpec(conf.Child("liveMounts"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "liveMounts" + "\n(" + this.Vars.LiveMounts.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        if (this.MissedSnapshotConnection != null) {
            var fspec = this.MissedSnapshotConnection.AsFieldSpec(conf.Child("missedSnapshotConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oldestSnapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<OraclePdb>? Pdbs
        // GraphQL -> pdbs: [OraclePdb!]! (type)
        if (this.Pdbs != null) {
            var fspec = this.Pdbs.AsFieldSpec(conf.Child("pdbs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pdbs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        if (this.PendingObjectDeletionStatus != null) {
            var fspec = this.PendingObjectDeletionStatus.AsFieldSpec(conf.Child("pendingObjectDeletionStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "physicalPath" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        if (this.PrimaryClusterLocation != null) {
            var fspec = this.PrimaryClusterLocation.AsFieldSpec(conf.Child("primaryClusterLocation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "primaryClusterLocation" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        if (this.SnapshotConnection != null) {
            var fspec = this.SnapshotConnection.AsFieldSpec(conf.Child("snapshotConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotGroupBySummary" + "\n(" + this.Vars.SnapshotGroupBySummary.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> DataGuardType? DataGuardType
        // GraphQL -> dataGuardType: DataGuardType! (enum)
        if (ec.Includes("dataGuardType",true))
        {
            if(this.DataGuardType == null) {

                this.DataGuardType = new DataGuardType();

            } else {


            }
        }
        else if (this.DataGuardType != null && ec.Excludes("dataGuardType",true))
        {
            this.DataGuardType = null;
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
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (ec.Includes("pendingSla",false))
        {
            if(this.PendingSla == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("pendingSla"));
                this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("pendingSla"));
                this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

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

                this.ReplicatedObjects = new List<CdmHierarchyObject>();
                this.ReplicatedObjects.ApplyExploratoryFieldSpec(ec.NewChild("replicatedObjects"));

            } else {

                this.ReplicatedObjects.ApplyExploratoryFieldSpec(ec.NewChild("replicatedObjects"));

            }
        }
        else if (this.ReplicatedObjects != null && ec.Excludes("replicatedObjects",false))
        {
            this.ReplicatedObjects = null;
        }
        //      C# -> System.String? ArchiveLogMode
        // GraphQL -> archiveLogMode: String! (scalar)
        if (ec.Includes("archiveLogMode",true))
        {
            if(this.ArchiveLogMode == null) {

                this.ArchiveLogMode = "FETCH";

            } else {


            }
        }
        else if (this.ArchiveLogMode != null && ec.Excludes("archiveLogMode",true))
        {
            this.ArchiveLogMode = null;
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
        //      C# -> System.String? DbRole
        // GraphQL -> dbRole: String! (scalar)
        if (ec.Includes("dbRole",true))
        {
            if(this.DbRole == null) {

                this.DbRole = "FETCH";

            } else {


            }
        }
        else if (this.DbRole != null && ec.Excludes("dbRole",true))
        {
            this.DbRole = null;
        }
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String! (scalar)
        if (ec.Includes("dbUniqueName",true))
        {
            if(this.DbUniqueName == null) {

                this.DbUniqueName = "FETCH";

            } else {


            }
        }
        else if (this.DbUniqueName != null && ec.Excludes("dbUniqueName",true))
        {
            this.DbUniqueName = null;
        }
        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int! (scalar)
        if (ec.Includes("hostLogRetentionHours",true))
        {
            if(this.HostLogRetentionHours == null) {

                this.HostLogRetentionHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.HostLogRetentionHours != null && ec.Excludes("hostLogRetentionHours",true))
        {
            this.HostLogRetentionHours = null;
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
        //      C# -> System.Boolean? IsLiveMount
        // GraphQL -> isLiveMount: Boolean! (scalar)
        if (ec.Includes("isLiveMount",true))
        {
            if(this.IsLiveMount == null) {

                this.IsLiveMount = true;

            } else {


            }
        }
        else if (this.IsLiveMount != null && ec.Excludes("isLiveMount",true))
        {
            this.IsLiveMount = null;
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
        //      C# -> System.Int32? LogBackupFrequency
        // GraphQL -> logBackupFrequency: Int! (scalar)
        if (ec.Includes("logBackupFrequency",true))
        {
            if(this.LogBackupFrequency == null) {

                this.LogBackupFrequency = Int32.MinValue;

            } else {


            }
        }
        else if (this.LogBackupFrequency != null && ec.Excludes("logBackupFrequency",true))
        {
            this.LogBackupFrequency = null;
        }
        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int! (scalar)
        if (ec.Includes("logRetentionHours",true))
        {
            if(this.LogRetentionHours == null) {

                this.LogRetentionHours = Int32.MinValue;

            } else {


            }
        }
        else if (this.LogRetentionHours != null && ec.Excludes("logRetentionHours",true))
        {
            this.LogRetentionHours = null;
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
        //      C# -> System.Int64? NumChannels
        // GraphQL -> numChannels: Long! (scalar)
        if (ec.Includes("numChannels",true))
        {
            if(this.NumChannels == null) {

                this.NumChannels = new System.Int64();

            } else {


            }
        }
        else if (this.NumChannels != null && ec.Excludes("numChannels",true))
        {
            this.NumChannels = null;
        }
        //      C# -> System.Int32? NumInstances
        // GraphQL -> numInstances: Int! (scalar)
        if (ec.Includes("numInstances",true))
        {
            if(this.NumInstances == null) {

                this.NumInstances = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumInstances != null && ec.Excludes("numInstances",true))
        {
            this.NumInstances = null;
        }
        //      C# -> System.Int32? NumLogSnapshots
        // GraphQL -> numLogSnapshots: Int! (scalar)
        if (ec.Includes("numLogSnapshots",true))
        {
            if(this.NumLogSnapshots == null) {

                this.NumLogSnapshots = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumLogSnapshots != null && ec.Excludes("numLogSnapshots",true))
        {
            this.NumLogSnapshots = null;
        }
        //      C# -> System.Int32? NumTablespaces
        // GraphQL -> numTablespaces: Int! (scalar)
        if (ec.Includes("numTablespaces",true))
        {
            if(this.NumTablespaces == null) {

                this.NumTablespaces = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumTablespaces != null && ec.Excludes("numTablespaces",true))
        {
            this.NumTablespaces = null;
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
        //      C# -> System.Int32? SectionSizeInGigabytes
        // GraphQL -> sectionSizeInGigabytes: Int! (scalar)
        if (ec.Includes("sectionSizeInGigabytes",true))
        {
            if(this.SectionSizeInGigabytes == null) {

                this.SectionSizeInGigabytes = Int32.MinValue;

            } else {


            }
        }
        else if (this.SectionSizeInGigabytes != null && ec.Excludes("sectionSizeInGigabytes",true))
        {
            this.SectionSizeInGigabytes = null;
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
        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        if (ec.Includes("tablespaces",true))
        {
            if(this.Tablespaces == null) {

                this.Tablespaces = new List<System.String>();

            } else {


            }
        }
        else if (this.Tablespaces != null && ec.Excludes("tablespaces",true))
        {
            this.Tablespaces = null;
        }
        //      C# -> System.Boolean? UseSecureThrift
        // GraphQL -> useSecureThrift: Boolean! (scalar)
        if (ec.Includes("useSecureThrift",true))
        {
            if(this.UseSecureThrift == null) {

                this.UseSecureThrift = true;

            } else {


            }
        }
        else if (this.UseSecureThrift != null && ec.Excludes("useSecureThrift",true))
        {
            this.UseSecureThrift = null;
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
        //      C# -> OracleDataGuardGroup? DataGuardGroup
        // GraphQL -> dataGuardGroup: OracleDataGuardGroup (type)
        if (ec.Includes("dataGuardGroup",false))
        {
            if(this.DataGuardGroup == null) {

                this.DataGuardGroup = new OracleDataGuardGroup();
                this.DataGuardGroup.ApplyExploratoryFieldSpec(ec.NewChild("dataGuardGroup"));

            } else {

                this.DataGuardGroup.ApplyExploratoryFieldSpec(ec.NewChild("dataGuardGroup"));

            }
        }
        else if (this.DataGuardGroup != null && ec.Excludes("dataGuardGroup",false))
        {
            this.DataGuardGroup = null;
        }
        //      C# -> OracleDirectoryPaths? DirectoryPaths
        // GraphQL -> directoryPaths: OracleDirectoryPaths (type)
        if (ec.Includes("directoryPaths",false))
        {
            if(this.DirectoryPaths == null) {

                this.DirectoryPaths = new OracleDirectoryPaths();
                this.DirectoryPaths.ApplyExploratoryFieldSpec(ec.NewChild("directoryPaths"));

            } else {

                this.DirectoryPaths.ApplyExploratoryFieldSpec(ec.NewChild("directoryPaths"));

            }
        }
        else if (this.DirectoryPaths != null && ec.Excludes("directoryPaths",false))
        {
            this.DirectoryPaths = null;
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
        //      C# -> List<OracleDatabaseInstance>? Instances
        // GraphQL -> instances: [OracleDatabaseInstance!]! (type)
        if (ec.Includes("instances",false))
        {
            if(this.Instances == null) {

                this.Instances = new List<OracleDatabaseInstance>();
                this.Instances.ApplyExploratoryFieldSpec(ec.NewChild("instances"));

            } else {

                this.Instances.ApplyExploratoryFieldSpec(ec.NewChild("instances"));

            }
        }
        else if (this.Instances != null && ec.Excludes("instances",false))
        {
            this.Instances = null;
        }
        //      C# -> OracleDatabaseLastValidationStatus? LastValidationResult
        // GraphQL -> lastValidationResult: OracleDatabaseLastValidationStatus (type)
        if (ec.Includes("lastValidationResult",false))
        {
            if(this.LastValidationResult == null) {

                this.LastValidationResult = new OracleDatabaseLastValidationStatus();
                this.LastValidationResult.ApplyExploratoryFieldSpec(ec.NewChild("lastValidationResult"));

            } else {

                this.LastValidationResult.ApplyExploratoryFieldSpec(ec.NewChild("lastValidationResult"));

            }
        }
        else if (this.LastValidationResult != null && ec.Excludes("lastValidationResult",false))
        {
            this.LastValidationResult = null;
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
        //      C# -> OracleLiveMountConnection? LiveMounts
        // GraphQL -> liveMounts: OracleLiveMountConnection! (type)
        if (ec.Includes("liveMounts",false))
        {
            if(this.LiveMounts == null) {

                this.LiveMounts = new OracleLiveMountConnection();
                this.LiveMounts.ApplyExploratoryFieldSpec(ec.NewChild("liveMounts"));

            } else {

                this.LiveMounts.ApplyExploratoryFieldSpec(ec.NewChild("liveMounts"));

            }
        }
        else if (this.LiveMounts != null && ec.Excludes("liveMounts",false))
        {
            this.LiveMounts = null;
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
        //      C# -> List<OraclePdb>? Pdbs
        // GraphQL -> pdbs: [OraclePdb!]! (type)
        if (ec.Includes("pdbs",false))
        {
            if(this.Pdbs == null) {

                this.Pdbs = new List<OraclePdb>();
                this.Pdbs.ApplyExploratoryFieldSpec(ec.NewChild("pdbs"));

            } else {

                this.Pdbs.ApplyExploratoryFieldSpec(ec.NewChild("pdbs"));

            }
        }
        else if (this.Pdbs != null && ec.Excludes("pdbs",false))
        {
            this.Pdbs = null;
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
    }


    #endregion

    } // class OracleDatabase
    
    #endregion

    public static class ListOracleDatabaseExtensions
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
            this List<OracleDatabase> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OracleDatabase> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OracleDatabase> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleDatabase());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OracleDatabase> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types