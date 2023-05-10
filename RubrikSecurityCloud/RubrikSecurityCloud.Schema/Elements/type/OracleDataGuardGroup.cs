// OracleDataGuardGroup.cs
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
    #region OracleDataGuardGroup
 
    public class OracleDataGuardGroup: IFragment, CdmHierarchyObject, CdmHierarchySnappableNew, HierarchyObject, OracleTopLevelDescendantType
    {
        #region members
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        [JsonProperty("cdmLink")]
        public System.String? CdmLink { get; set; }

        //      C# -> System.String? DataGuardGroupId
        // GraphQL -> dataGuardGroupId: String (scalar)
        [JsonProperty("dataGuardGroupId")]
        public System.String? DataGuardGroupId { get; set; }

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

        //      C# -> List<System.String>? PreferredDataGuardMemberUniqueNames
        // GraphQL -> preferredDataGuardMemberUniqueNames: [String!]! (scalar)
        [JsonProperty("preferredDataGuardMemberUniqueNames")]
        public List<System.String>? PreferredDataGuardMemberUniqueNames { get; set; }

        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        [JsonProperty("replicatedObjectCount")]
        public System.Int32? ReplicatedObjectCount { get; set; }

        //      C# -> System.Int32? SectionSizeInGigabytes
        // GraphQL -> sectionSizeInGigabytes: Int! (scalar)
        [JsonProperty("sectionSizeInGigabytes")]
        public System.Int32? SectionSizeInGigabytes { get; set; }

        //      C# -> System.Boolean? ShouldBackupFromPrimaryOnly
        // GraphQL -> shouldBackupFromPrimaryOnly: Boolean! (scalar)
        [JsonProperty("shouldBackupFromPrimaryOnly")]
        public System.Boolean? ShouldBackupFromPrimaryOnly { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> List<System.String>? Tablespaces
        // GraphQL -> tablespaces: [String!]! (scalar)
        [JsonProperty("tablespaces")]
        public List<System.String>? Tablespaces { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> OracleDataGuardGroupDescendantTypeConnection? DescendantConnection
        // GraphQL -> descendantConnection: OracleDataGuardGroupDescendantTypeConnection! (type)
        [JsonProperty("descendantConnection")]
        public OracleDataGuardGroupDescendantTypeConnection? DescendantConnection { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> OracleDatabaseLastValidationStatus? LastValidationResult
        // GraphQL -> lastValidationResult: OracleDatabaseLastValidationStatus (type)
        [JsonProperty("lastValidationResult")]
        public OracleDatabaseLastValidationStatus? LastValidationResult { get; set; }

        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        [JsonProperty("latestUserNote")]
        public LatestUserNote? LatestUserNote { get; set; }

        //      C# -> OracleDataGuardGroupLogicalChildTypeConnection? LogicalChildConnection
        // GraphQL -> logicalChildConnection: OracleDataGuardGroupLogicalChildTypeConnection! (type)
        [JsonProperty("logicalChildConnection")]
        public OracleDataGuardGroupLogicalChildTypeConnection? LogicalChildConnection { get; set; }

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

        #endregion

    #region methods

    public OracleDataGuardGroup Set(
        System.String? CdmId = null,
        System.String? CdmLink = null,
        System.String? DataGuardGroupId = null,
        System.String? DbRole = null,
        System.String? DbUniqueName = null,
        System.Int32? HostLogRetentionHours = null,
        System.String? Id = null,
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
        List<System.String>? PreferredDataGuardMemberUniqueNames = null,
        System.Int32? ReplicatedObjectCount = null,
        System.Int32? SectionSizeInGigabytes = null,
        System.Boolean? ShouldBackupFromPrimaryOnly = null,
        System.Boolean? SlaPauseStatus = null,
        List<System.String>? Tablespaces = null,
        List<Org>? AllOrgs = null,
        Cluster? Cluster = null,
        OracleDataGuardGroupDescendantTypeConnection? DescendantConnection = null,
        PathNode? EffectiveSlaSourceObject = null,
        OracleDatabaseLastValidationStatus? LastValidationResult = null,
        LatestUserNote? LatestUserNote = null,
        OracleDataGuardGroupLogicalChildTypeConnection? LogicalChildConnection = null,
        List<PathNode>? LogicalPath = null,
        MissedSnapshotCommonConnection? MissedSnapshotConnection = null,
        MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection = null,
        CdmSnapshot? NewestArchivedSnapshot = null,
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
        CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary = null,
        List<Operation>? AuthorizedOperations = null,
        DataGuardType? DataGuardType = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        SlaDomain? PendingSla = null,
        List<CdmHierarchyObject>? ReplicatedObjects = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( CdmLink != null ) {
            this.CdmLink = CdmLink;
        }
        if ( DataGuardGroupId != null ) {
            this.DataGuardGroupId = DataGuardGroupId;
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
        if ( PreferredDataGuardMemberUniqueNames != null ) {
            this.PreferredDataGuardMemberUniqueNames = PreferredDataGuardMemberUniqueNames;
        }
        if ( ReplicatedObjectCount != null ) {
            this.ReplicatedObjectCount = ReplicatedObjectCount;
        }
        if ( SectionSizeInGigabytes != null ) {
            this.SectionSizeInGigabytes = SectionSizeInGigabytes;
        }
        if ( ShouldBackupFromPrimaryOnly != null ) {
            this.ShouldBackupFromPrimaryOnly = ShouldBackupFromPrimaryOnly;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( Tablespaces != null ) {
            this.Tablespaces = Tablespaces;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( DescendantConnection != null ) {
            this.DescendantConnection = DescendantConnection;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( LastValidationResult != null ) {
            this.LastValidationResult = LastValidationResult;
        }
        if ( LatestUserNote != null ) {
            this.LatestUserNote = LatestUserNote;
        }
        if ( LogicalChildConnection != null ) {
            this.LogicalChildConnection = LogicalChildConnection;
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
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId != null)
            {
                 s += ind + "cdmId\n";

            }
            //      C# -> System.String? CdmLink
            // GraphQL -> cdmLink: String! (scalar)
            if (this.CdmLink != null)
            {
                 s += ind + "cdmLink\n";

            }
            //      C# -> System.String? DataGuardGroupId
            // GraphQL -> dataGuardGroupId: String (scalar)
            if (this.DataGuardGroupId != null)
            {
                 s += ind + "dataGuardGroupId\n";

            }
            //      C# -> System.String? DbRole
            // GraphQL -> dbRole: String! (scalar)
            if (this.DbRole != null)
            {
                 s += ind + "dbRole\n";

            }
            //      C# -> System.String? DbUniqueName
            // GraphQL -> dbUniqueName: String! (scalar)
            if (this.DbUniqueName != null)
            {
                 s += ind + "dbUniqueName\n";

            }
            //      C# -> System.Int32? HostLogRetentionHours
            // GraphQL -> hostLogRetentionHours: Int! (scalar)
            if (this.HostLogRetentionHours != null)
            {
                 s += ind + "hostLogRetentionHours\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic != null)
            {
                 s += ind + "isRelic\n";

            }
            //      C# -> System.Int32? LogBackupFrequency
            // GraphQL -> logBackupFrequency: Int! (scalar)
            if (this.LogBackupFrequency != null)
            {
                 s += ind + "logBackupFrequency\n";

            }
            //      C# -> System.Int32? LogRetentionHours
            // GraphQL -> logRetentionHours: Int! (scalar)
            if (this.LogRetentionHours != null)
            {
                 s += ind + "logRetentionHours\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int64? NumChannels
            // GraphQL -> numChannels: Long! (scalar)
            if (this.NumChannels != null)
            {
                 s += ind + "numChannels\n";

            }
            //      C# -> System.Int32? NumInstances
            // GraphQL -> numInstances: Int! (scalar)
            if (this.NumInstances != null)
            {
                 s += ind + "numInstances\n";

            }
            //      C# -> System.Int32? NumLogSnapshots
            // GraphQL -> numLogSnapshots: Int! (scalar)
            if (this.NumLogSnapshots != null)
            {
                 s += ind + "numLogSnapshots\n";

            }
            //      C# -> System.Int32? NumTablespaces
            // GraphQL -> numTablespaces: Int! (scalar)
            if (this.NumTablespaces != null)
            {
                 s += ind + "numTablespaces\n";

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
            //      C# -> List<System.String>? PreferredDataGuardMemberUniqueNames
            // GraphQL -> preferredDataGuardMemberUniqueNames: [String!]! (scalar)
            if (this.PreferredDataGuardMemberUniqueNames != null)
            {
                 s += ind + "preferredDataGuardMemberUniqueNames\n";

            }
            //      C# -> System.Int32? ReplicatedObjectCount
            // GraphQL -> replicatedObjectCount: Int! (scalar)
            if (this.ReplicatedObjectCount != null)
            {
                 s += ind + "replicatedObjectCount\n";

            }
            //      C# -> System.Int32? SectionSizeInGigabytes
            // GraphQL -> sectionSizeInGigabytes: Int! (scalar)
            if (this.SectionSizeInGigabytes != null)
            {
                 s += ind + "sectionSizeInGigabytes\n";

            }
            //      C# -> System.Boolean? ShouldBackupFromPrimaryOnly
            // GraphQL -> shouldBackupFromPrimaryOnly: Boolean! (scalar)
            if (this.ShouldBackupFromPrimaryOnly != null)
            {
                 s += ind + "shouldBackupFromPrimaryOnly\n";

            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus != null)
            {
                 s += ind + "slaPauseStatus\n";

            }
            //      C# -> List<System.String>? Tablespaces
            // GraphQL -> tablespaces: [String!]! (scalar)
            if (this.Tablespaces != null)
            {
                 s += ind + "tablespaces\n";

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
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> OracleDataGuardGroupDescendantTypeConnection? DescendantConnection
            // GraphQL -> descendantConnection: OracleDataGuardGroupDescendantTypeConnection! (type)
            if (this.DescendantConnection != null)
            {
                 s += ind + "descendantConnection\n";

                 s += ind + "{\n" + 
                 this.DescendantConnection.AsFragment(indent+1) + 
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
            //      C# -> OracleDatabaseLastValidationStatus? LastValidationResult
            // GraphQL -> lastValidationResult: OracleDatabaseLastValidationStatus (type)
            if (this.LastValidationResult != null)
            {
                 s += ind + "lastValidationResult\n";

                 s += ind + "{\n" + 
                 this.LastValidationResult.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> LatestUserNote? LatestUserNote
            // GraphQL -> latestUserNote: LatestUserNote (type)
            if (this.LatestUserNote != null)
            {
                 s += ind + "latestUserNote\n";

                 s += ind + "{\n" + 
                 this.LatestUserNote.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> OracleDataGuardGroupLogicalChildTypeConnection? LogicalChildConnection
            // GraphQL -> logicalChildConnection: OracleDataGuardGroupLogicalChildTypeConnection! (type)
            if (this.LogicalChildConnection != null)
            {
                 s += ind + "logicalChildConnection\n";

                 s += ind + "{\n" + 
                 this.LogicalChildConnection.AsFragment(indent+1) + 
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
            //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
            // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
            if (this.MissedSnapshotConnection != null)
            {
                 s += ind + "missedSnapshotConnection\n";

                 s += ind + "{\n" + 
                 this.MissedSnapshotConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
            // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
            if (this.MissedSnapshotGroupByConnection != null)
            {
                 s += ind + "missedSnapshotGroupByConnection\n";

                 s += ind + "{\n" + 
                 this.MissedSnapshotGroupByConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshot? NewestArchivedSnapshot
            // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
            if (this.NewestArchivedSnapshot != null)
            {
                 s += ind + "newestArchivedSnapshot\n";

                 s += ind + "{\n" + 
                 this.NewestArchivedSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshot? NewestReplicatedSnapshot
            // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
            if (this.NewestReplicatedSnapshot != null)
            {
                 s += ind + "newestReplicatedSnapshot\n";

                 s += ind + "{\n" + 
                 this.NewestReplicatedSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshot? NewestSnapshot
            // GraphQL -> newestSnapshot: CdmSnapshot (type)
            if (this.NewestSnapshot != null)
            {
                 s += ind + "newestSnapshot\n";

                 s += ind + "{\n" + 
                 this.NewestSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshot? OldestSnapshot
            // GraphQL -> oldestSnapshot: CdmSnapshot (type)
            if (this.OldestSnapshot != null)
            {
                 s += ind + "oldestSnapshot\n";

                 s += ind + "{\n" + 
                 this.OldestSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<OraclePdb>? Pdbs
            // GraphQL -> pdbs: [OraclePdb!]! (type)
            if (this.Pdbs != null)
            {
                 s += ind + "pdbs\n";

                 s += ind + "{\n" + 
                 this.Pdbs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
            // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
            if (this.PendingObjectDeletionStatus != null)
            {
                 s += ind + "pendingObjectDeletionStatus\n";

                 s += ind + "{\n" + 
                 this.PendingObjectDeletionStatus.AsFragment(indent+1) + 
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
            //      C# -> DataLocation? PrimaryClusterLocation
            // GraphQL -> primaryClusterLocation: DataLocation! (type)
            if (this.PrimaryClusterLocation != null)
            {
                 s += ind + "primaryClusterLocation\n";

                 s += ind + "{\n" + 
                 this.PrimaryClusterLocation.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshotConnection? SnapshotConnection
            // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
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
            //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
            // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
            if (this.SnapshotGroupByConnection != null)
            {
                 s += ind + "snapshotGroupByConnection\n";

                 s += ind + "{\n" + 
                 this.SnapshotGroupByConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
            // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
            if (this.SnapshotGroupBySummary != null)
            {
                 s += ind + "snapshotGroupBySummary\n";

                 s += ind + "{\n" + 
                 this.SnapshotGroupBySummary.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<Operation>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [Operation!]! (enum)
            if (this.AuthorizedOperations != null)
            {
                 s += ind + "authorizedOperations\n";

            }
            //      C# -> DataGuardType? DataGuardType
            // GraphQL -> dataGuardType: DataGuardType! (enum)
            if (this.DataGuardType != null)
            {
                 s += ind + "dataGuardType\n";

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
                        //      C# -> SlaDomain? PendingSla
            // GraphQL -> pendingSla: SlaDomain (interface)
            if (this.PendingSla != null)
            {
                s += ind + "pendingSla\n";
                s += ind + "{\n";

                string typename = this.PendingSla.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.PendingSla.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
            // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
            if (this.ReplicatedObjects != null)
            {
                s += ind + "replicatedObjects\n";
                s += ind + "{\n";

                s += this.ReplicatedObjects.AsFragment(indent+1) +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId == null && Exploration.Includes(parent + ".cdmId$"))
            {
                this.CdmId = new System.String("FETCH");
            }
            //      C# -> System.String? CdmLink
            // GraphQL -> cdmLink: String! (scalar)
            if (this.CdmLink == null && Exploration.Includes(parent + ".cdmLink$"))
            {
                this.CdmLink = new System.String("FETCH");
            }
            //      C# -> System.String? DataGuardGroupId
            // GraphQL -> dataGuardGroupId: String (scalar)
            if (this.DataGuardGroupId == null && Exploration.Includes(parent + ".dataGuardGroupId$"))
            {
                this.DataGuardGroupId = new System.String("FETCH");
            }
            //      C# -> System.String? DbRole
            // GraphQL -> dbRole: String! (scalar)
            if (this.DbRole == null && Exploration.Includes(parent + ".dbRole$"))
            {
                this.DbRole = new System.String("FETCH");
            }
            //      C# -> System.String? DbUniqueName
            // GraphQL -> dbUniqueName: String! (scalar)
            if (this.DbUniqueName == null && Exploration.Includes(parent + ".dbUniqueName$"))
            {
                this.DbUniqueName = new System.String("FETCH");
            }
            //      C# -> System.Int32? HostLogRetentionHours
            // GraphQL -> hostLogRetentionHours: Int! (scalar)
            if (this.HostLogRetentionHours == null && Exploration.Includes(parent + ".hostLogRetentionHours$"))
            {
                this.HostLogRetentionHours = new System.Int32();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic$"))
            {
                this.IsRelic = new System.Boolean();
            }
            //      C# -> System.Int32? LogBackupFrequency
            // GraphQL -> logBackupFrequency: Int! (scalar)
            if (this.LogBackupFrequency == null && Exploration.Includes(parent + ".logBackupFrequency$"))
            {
                this.LogBackupFrequency = new System.Int32();
            }
            //      C# -> System.Int32? LogRetentionHours
            // GraphQL -> logRetentionHours: Int! (scalar)
            if (this.LogRetentionHours == null && Exploration.Includes(parent + ".logRetentionHours$"))
            {
                this.LogRetentionHours = new System.Int32();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int64? NumChannels
            // GraphQL -> numChannels: Long! (scalar)
            if (this.NumChannels == null && Exploration.Includes(parent + ".numChannels$"))
            {
                this.NumChannels = new System.Int64();
            }
            //      C# -> System.Int32? NumInstances
            // GraphQL -> numInstances: Int! (scalar)
            if (this.NumInstances == null && Exploration.Includes(parent + ".numInstances$"))
            {
                this.NumInstances = new System.Int32();
            }
            //      C# -> System.Int32? NumLogSnapshots
            // GraphQL -> numLogSnapshots: Int! (scalar)
            if (this.NumLogSnapshots == null && Exploration.Includes(parent + ".numLogSnapshots$"))
            {
                this.NumLogSnapshots = new System.Int32();
            }
            //      C# -> System.Int32? NumTablespaces
            // GraphQL -> numTablespaces: Int! (scalar)
            if (this.NumTablespaces == null && Exploration.Includes(parent + ".numTablespaces$"))
            {
                this.NumTablespaces = new System.Int32();
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
            //      C# -> List<System.String>? PreferredDataGuardMemberUniqueNames
            // GraphQL -> preferredDataGuardMemberUniqueNames: [String!]! (scalar)
            if (this.PreferredDataGuardMemberUniqueNames == null && Exploration.Includes(parent + ".preferredDataGuardMemberUniqueNames$"))
            {
                this.PreferredDataGuardMemberUniqueNames = new List<System.String>();
            }
            //      C# -> System.Int32? ReplicatedObjectCount
            // GraphQL -> replicatedObjectCount: Int! (scalar)
            if (this.ReplicatedObjectCount == null && Exploration.Includes(parent + ".replicatedObjectCount$"))
            {
                this.ReplicatedObjectCount = new System.Int32();
            }
            //      C# -> System.Int32? SectionSizeInGigabytes
            // GraphQL -> sectionSizeInGigabytes: Int! (scalar)
            if (this.SectionSizeInGigabytes == null && Exploration.Includes(parent + ".sectionSizeInGigabytes$"))
            {
                this.SectionSizeInGigabytes = new System.Int32();
            }
            //      C# -> System.Boolean? ShouldBackupFromPrimaryOnly
            // GraphQL -> shouldBackupFromPrimaryOnly: Boolean! (scalar)
            if (this.ShouldBackupFromPrimaryOnly == null && Exploration.Includes(parent + ".shouldBackupFromPrimaryOnly$"))
            {
                this.ShouldBackupFromPrimaryOnly = new System.Boolean();
            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus$"))
            {
                this.SlaPauseStatus = new System.Boolean();
            }
            //      C# -> List<System.String>? Tablespaces
            // GraphQL -> tablespaces: [String!]! (scalar)
            if (this.Tablespaces == null && Exploration.Includes(parent + ".tablespaces$"))
            {
                this.Tablespaces = new List<System.String>();
            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
            {
                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFragment(parent + ".allOrgs");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> OracleDataGuardGroupDescendantTypeConnection? DescendantConnection
            // GraphQL -> descendantConnection: OracleDataGuardGroupDescendantTypeConnection! (type)
            if (this.DescendantConnection == null && Exploration.Includes(parent + ".descendantConnection"))
            {
                this.DescendantConnection = new OracleDataGuardGroupDescendantTypeConnection();
                this.DescendantConnection.ApplyExploratoryFragment(parent + ".descendantConnection");
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
            {
                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFragment(parent + ".effectiveSlaSourceObject");
            }
            //      C# -> OracleDatabaseLastValidationStatus? LastValidationResult
            // GraphQL -> lastValidationResult: OracleDatabaseLastValidationStatus (type)
            if (this.LastValidationResult == null && Exploration.Includes(parent + ".lastValidationResult"))
            {
                this.LastValidationResult = new OracleDatabaseLastValidationStatus();
                this.LastValidationResult.ApplyExploratoryFragment(parent + ".lastValidationResult");
            }
            //      C# -> LatestUserNote? LatestUserNote
            // GraphQL -> latestUserNote: LatestUserNote (type)
            if (this.LatestUserNote == null && Exploration.Includes(parent + ".latestUserNote"))
            {
                this.LatestUserNote = new LatestUserNote();
                this.LatestUserNote.ApplyExploratoryFragment(parent + ".latestUserNote");
            }
            //      C# -> OracleDataGuardGroupLogicalChildTypeConnection? LogicalChildConnection
            // GraphQL -> logicalChildConnection: OracleDataGuardGroupLogicalChildTypeConnection! (type)
            if (this.LogicalChildConnection == null && Exploration.Includes(parent + ".logicalChildConnection"))
            {
                this.LogicalChildConnection = new OracleDataGuardGroupLogicalChildTypeConnection();
                this.LogicalChildConnection.ApplyExploratoryFragment(parent + ".logicalChildConnection");
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
            {
                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFragment(parent + ".logicalPath");
            }
            //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
            // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
            if (this.MissedSnapshotConnection == null && Exploration.Includes(parent + ".missedSnapshotConnection"))
            {
                this.MissedSnapshotConnection = new MissedSnapshotCommonConnection();
                this.MissedSnapshotConnection.ApplyExploratoryFragment(parent + ".missedSnapshotConnection");
            }
            //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
            // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
            if (this.MissedSnapshotGroupByConnection == null && Exploration.Includes(parent + ".missedSnapshotGroupByConnection"))
            {
                this.MissedSnapshotGroupByConnection = new MissedSnapshotGroupByConnection();
                this.MissedSnapshotGroupByConnection.ApplyExploratoryFragment(parent + ".missedSnapshotGroupByConnection");
            }
            //      C# -> CdmSnapshot? NewestArchivedSnapshot
            // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
            if (this.NewestArchivedSnapshot == null && Exploration.Includes(parent + ".newestArchivedSnapshot"))
            {
                this.NewestArchivedSnapshot = new CdmSnapshot();
                this.NewestArchivedSnapshot.ApplyExploratoryFragment(parent + ".newestArchivedSnapshot");
            }
            //      C# -> CdmSnapshot? NewestReplicatedSnapshot
            // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
            if (this.NewestReplicatedSnapshot == null && Exploration.Includes(parent + ".newestReplicatedSnapshot"))
            {
                this.NewestReplicatedSnapshot = new CdmSnapshot();
                this.NewestReplicatedSnapshot.ApplyExploratoryFragment(parent + ".newestReplicatedSnapshot");
            }
            //      C# -> CdmSnapshot? NewestSnapshot
            // GraphQL -> newestSnapshot: CdmSnapshot (type)
            if (this.NewestSnapshot == null && Exploration.Includes(parent + ".newestSnapshot"))
            {
                this.NewestSnapshot = new CdmSnapshot();
                this.NewestSnapshot.ApplyExploratoryFragment(parent + ".newestSnapshot");
            }
            //      C# -> CdmSnapshot? OldestSnapshot
            // GraphQL -> oldestSnapshot: CdmSnapshot (type)
            if (this.OldestSnapshot == null && Exploration.Includes(parent + ".oldestSnapshot"))
            {
                this.OldestSnapshot = new CdmSnapshot();
                this.OldestSnapshot.ApplyExploratoryFragment(parent + ".oldestSnapshot");
            }
            //      C# -> List<OraclePdb>? Pdbs
            // GraphQL -> pdbs: [OraclePdb!]! (type)
            if (this.Pdbs == null && Exploration.Includes(parent + ".pdbs"))
            {
                this.Pdbs = new List<OraclePdb>();
                this.Pdbs.ApplyExploratoryFragment(parent + ".pdbs");
            }
            //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
            // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
            if (this.PendingObjectDeletionStatus == null && Exploration.Includes(parent + ".pendingObjectDeletionStatus"))
            {
                this.PendingObjectDeletionStatus = new PendingSnapshotsOfObjectDeletion();
                this.PendingObjectDeletionStatus.ApplyExploratoryFragment(parent + ".pendingObjectDeletionStatus");
            }
            //      C# -> List<PathNode>? PhysicalPath
            // GraphQL -> physicalPath: [PathNode!]! (type)
            if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
            {
                this.PhysicalPath = new List<PathNode>();
                this.PhysicalPath.ApplyExploratoryFragment(parent + ".physicalPath");
            }
            //      C# -> DataLocation? PrimaryClusterLocation
            // GraphQL -> primaryClusterLocation: DataLocation! (type)
            if (this.PrimaryClusterLocation == null && Exploration.Includes(parent + ".primaryClusterLocation"))
            {
                this.PrimaryClusterLocation = new DataLocation();
                this.PrimaryClusterLocation.ApplyExploratoryFragment(parent + ".primaryClusterLocation");
            }
            //      C# -> CdmSnapshotConnection? SnapshotConnection
            // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
            if (this.SnapshotConnection == null && Exploration.Includes(parent + ".snapshotConnection"))
            {
                this.SnapshotConnection = new CdmSnapshotConnection();
                this.SnapshotConnection.ApplyExploratoryFragment(parent + ".snapshotConnection");
            }
            //      C# -> SnapshotDistribution? SnapshotDistribution
            // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
            if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
            {
                this.SnapshotDistribution = new SnapshotDistribution();
                this.SnapshotDistribution.ApplyExploratoryFragment(parent + ".snapshotDistribution");
            }
            //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
            // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
            if (this.SnapshotGroupByConnection == null && Exploration.Includes(parent + ".snapshotGroupByConnection"))
            {
                this.SnapshotGroupByConnection = new CdmSnapshotGroupByConnection();
                this.SnapshotGroupByConnection.ApplyExploratoryFragment(parent + ".snapshotGroupByConnection");
            }
            //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
            // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
            if (this.SnapshotGroupBySummary == null && Exploration.Includes(parent + ".snapshotGroupBySummary"))
            {
                this.SnapshotGroupBySummary = new CdmSnapshotGroupBySummaryConnection();
                this.SnapshotGroupBySummary.ApplyExploratoryFragment(parent + ".snapshotGroupBySummary");
            }
            //      C# -> List<Operation>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [Operation!]! (enum)
            if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations$"))
            {
                this.AuthorizedOperations = new List<Operation>();
            }
            //      C# -> DataGuardType? DataGuardType
            // GraphQL -> dataGuardType: DataGuardType! (enum)
            if (this.DataGuardType == null && Exploration.Includes(parent + ".dataGuardType$"))
            {
                this.DataGuardType = new DataGuardType();
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
            //      C# -> SlaDomain? PendingSla
            // GraphQL -> pendingSla: SlaDomain (interface)
            if (this.PendingSla == null && Exploration.Includes(parent + ".pendingSla"))
            {
                this.PendingSla = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.PendingSla.ApplyExploratoryFragment(parent + ".pendingSla");
            }
            //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
            // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
            if (this.ReplicatedObjects == null && Exploration.Includes(parent + ".replicatedObjects"))
            {
                this.ReplicatedObjects = new List<CdmHierarchyObject>();
                this.ReplicatedObjects.ApplyExploratoryFragment(parent + ".replicatedObjects");
            }
        }


    #endregion

    } // class OracleDataGuardGroup
    #endregion

    public static class ListOracleDataGuardGroupExtensions
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
            this List<OracleDataGuardGroup> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleDataGuardGroup> list, 
            String parent = "")
        {
            var item = new OracleDataGuardGroup();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types