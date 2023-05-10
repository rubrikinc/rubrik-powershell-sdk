// MssqlDatabase.cs
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
    #region MssqlDatabase
 
    public class MssqlDatabase: IFragment, CdmHierarchyObject, CdmHierarchySnappableNew, HierarchyObject, MssqlAvailabilityGroupDescendantType, MssqlAvailabilityGroupLogicalChildType, MssqlInstanceDescendantType, MssqlInstanceLogicalChildType, MssqlTopLevelDescendantType, PhysicalHostDescendantType, WindowsClusterDescendantType
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

        //      C# -> System.Int32? CdmOnDemandSnapshotCount
        // GraphQL -> cdmOnDemandSnapshotCount: Int! (scalar)
        [JsonProperty("cdmOnDemandSnapshotCount")]
        public System.Int32? CdmOnDemandSnapshotCount { get; set; }

        //      C# -> System.Boolean? CopyOnly
        // GraphQL -> copyOnly: Boolean! (scalar)
        [JsonProperty("copyOnly")]
        public System.Boolean? CopyOnly { get; set; }

        //      C# -> System.String? DagId
        // GraphQL -> dagId: UUID! (scalar)
        [JsonProperty("dagId")]
        public System.String? DagId { get; set; }

        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean! (scalar)
        [JsonProperty("hasLogConfigFromSla")]
        public System.Boolean? HasLogConfigFromSla { get; set; }

        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        [JsonProperty("hasPermissions")]
        public System.Boolean? HasPermissions { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsInAvailabilityGroup
        // GraphQL -> isInAvailabilityGroup: Boolean! (scalar)
        [JsonProperty("isInAvailabilityGroup")]
        public System.Boolean? IsInAvailabilityGroup { get; set; }

        //      C# -> System.Boolean? IsLogShippingSecondary
        // GraphQL -> isLogShippingSecondary: Boolean! (scalar)
        [JsonProperty("isLogShippingSecondary")]
        public System.Boolean? IsLogShippingSecondary { get; set; }

        //      C# -> System.Boolean? IsMount
        // GraphQL -> isMount: Boolean! (scalar)
        [JsonProperty("isMount")]
        public System.Boolean? IsMount { get; set; }

        //      C# -> System.Boolean? IsOnline
        // GraphQL -> isOnline: Boolean! (scalar)
        [JsonProperty("isOnline")]
        public System.Boolean? IsOnline { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.Single? LogBackupFrequencyInSeconds
        // GraphQL -> logBackupFrequencyInSeconds: Float! (scalar)
        [JsonProperty("logBackupFrequencyInSeconds")]
        public System.Single? LogBackupFrequencyInSeconds { get; set; }

        //      C# -> System.Int32? LogBackupRetentionInHours
        // GraphQL -> logBackupRetentionInHours: Int! (scalar)
        [JsonProperty("logBackupRetentionInHours")]
        public System.Int32? LogBackupRetentionInHours { get; set; }

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

        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String! (scalar)
        [JsonProperty("postBackupScript")]
        public System.String? PostBackupScript { get; set; }

        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String! (scalar)
        [JsonProperty("preBackupScript")]
        public System.String? PreBackupScript { get; set; }

        //      C# -> System.String? RecoveryModel
        // GraphQL -> recoveryModel: String! (scalar)
        [JsonProperty("recoveryModel")]
        public System.String? RecoveryModel { get; set; }

        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        [JsonProperty("replicatedObjectCount")]
        public System.Int32? ReplicatedObjectCount { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> List<System.String>? UnprotectableReasons
        // GraphQL -> unprotectableReasons: [String!]! (scalar)
        [JsonProperty("unprotectableReasons")]
        public List<System.String>? UnprotectableReasons { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> CdmGroupedSnapshotConnection? CdmGroupedSnapshots
        // GraphQL -> cdmGroupedSnapshots: CdmGroupedSnapshotConnection! (type)
        [JsonProperty("cdmGroupedSnapshots")]
        public CdmGroupedSnapshotConnection? CdmGroupedSnapshots { get; set; }

        //      C# -> CdmWorkloadSnapshot? CdmNewestSnapshot
        // GraphQL -> cdmNewestSnapshot: CdmWorkloadSnapshot (type)
        [JsonProperty("cdmNewestSnapshot")]
        public CdmWorkloadSnapshot? CdmNewestSnapshot { get; set; }

        //      C# -> CdmWorkloadSnapshot? CdmOldestSnapshot
        // GraphQL -> cdmOldestSnapshot: CdmWorkloadSnapshot (type)
        [JsonProperty("cdmOldestSnapshot")]
        public CdmWorkloadSnapshot? CdmOldestSnapshot { get; set; }

        //      C# -> CdmWorkloadSnapshotConnection? CdmSnapshots
        // GraphQL -> cdmSnapshots: CdmWorkloadSnapshotConnection! (type)
        [JsonProperty("cdmSnapshots")]
        public CdmWorkloadSnapshotConnection? CdmSnapshots { get; set; }

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

        //      C# -> MssqlDatabaseLiveMountConnection? LiveMounts
        // GraphQL -> liveMounts: MssqlDatabaseLiveMountConnection! (type)
        [JsonProperty("liveMounts")]
        public MssqlDatabaseLiveMountConnection? LiveMounts { get; set; }

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

        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        [JsonProperty("primaryClusterLocation")]
        public DataLocation? PrimaryClusterLocation { get; set; }

        //      C# -> List<CdmMssqlDbReplica>? Replicas
        // GraphQL -> replicas: [CdmMssqlDbReplica!]! (type)
        [JsonProperty("replicas")]
        public List<CdmMssqlDbReplica>? Replicas { get; set; }

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

    public MssqlDatabase Set(
        System.String? CdmId = null,
        System.String? CdmLink = null,
        System.Int32? CdmOnDemandSnapshotCount = null,
        System.Boolean? CopyOnly = null,
        System.String? DagId = null,
        System.Boolean? HasLogConfigFromSla = null,
        System.Boolean? HasPermissions = null,
        System.String? Id = null,
        System.Boolean? IsInAvailabilityGroup = null,
        System.Boolean? IsLogShippingSecondary = null,
        System.Boolean? IsMount = null,
        System.Boolean? IsOnline = null,
        System.Boolean? IsRelic = null,
        System.Single? LogBackupFrequencyInSeconds = null,
        System.Int32? LogBackupRetentionInHours = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.String? PostBackupScript = null,
        System.String? PreBackupScript = null,
        System.String? RecoveryModel = null,
        System.Int32? ReplicatedObjectCount = null,
        System.Boolean? SlaPauseStatus = null,
        List<System.String>? UnprotectableReasons = null,
        List<Org>? AllOrgs = null,
        CdmGroupedSnapshotConnection? CdmGroupedSnapshots = null,
        CdmWorkloadSnapshot? CdmNewestSnapshot = null,
        CdmWorkloadSnapshot? CdmOldestSnapshot = null,
        CdmWorkloadSnapshotConnection? CdmSnapshots = null,
        Cluster? Cluster = null,
        PathNode? EffectiveSlaSourceObject = null,
        LatestUserNote? LatestUserNote = null,
        MssqlDatabaseLiveMountConnection? LiveMounts = null,
        List<PathNode>? LogicalPath = null,
        MissedSnapshotCommonConnection? MissedSnapshotConnection = null,
        MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection = null,
        CdmSnapshot? NewestArchivedSnapshot = null,
        CdmSnapshot? NewestReplicatedSnapshot = null,
        CdmSnapshot? NewestSnapshot = null,
        CdmSnapshot? OldestSnapshot = null,
        PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus = null,
        List<PathNode>? PhysicalPath = null,
        DataLocation? PrimaryClusterLocation = null,
        List<CdmMssqlDbReplica>? Replicas = null,
        CdmSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        CdmSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary = null,
        List<Operation>? AuthorizedOperations = null,
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
        if ( CdmOnDemandSnapshotCount != null ) {
            this.CdmOnDemandSnapshotCount = CdmOnDemandSnapshotCount;
        }
        if ( CopyOnly != null ) {
            this.CopyOnly = CopyOnly;
        }
        if ( DagId != null ) {
            this.DagId = DagId;
        }
        if ( HasLogConfigFromSla != null ) {
            this.HasLogConfigFromSla = HasLogConfigFromSla;
        }
        if ( HasPermissions != null ) {
            this.HasPermissions = HasPermissions;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsInAvailabilityGroup != null ) {
            this.IsInAvailabilityGroup = IsInAvailabilityGroup;
        }
        if ( IsLogShippingSecondary != null ) {
            this.IsLogShippingSecondary = IsLogShippingSecondary;
        }
        if ( IsMount != null ) {
            this.IsMount = IsMount;
        }
        if ( IsOnline != null ) {
            this.IsOnline = IsOnline;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( LogBackupFrequencyInSeconds != null ) {
            this.LogBackupFrequencyInSeconds = LogBackupFrequencyInSeconds;
        }
        if ( LogBackupRetentionInHours != null ) {
            this.LogBackupRetentionInHours = LogBackupRetentionInHours;
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
        if ( PostBackupScript != null ) {
            this.PostBackupScript = PostBackupScript;
        }
        if ( PreBackupScript != null ) {
            this.PreBackupScript = PreBackupScript;
        }
        if ( RecoveryModel != null ) {
            this.RecoveryModel = RecoveryModel;
        }
        if ( ReplicatedObjectCount != null ) {
            this.ReplicatedObjectCount = ReplicatedObjectCount;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( UnprotectableReasons != null ) {
            this.UnprotectableReasons = UnprotectableReasons;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( CdmGroupedSnapshots != null ) {
            this.CdmGroupedSnapshots = CdmGroupedSnapshots;
        }
        if ( CdmNewestSnapshot != null ) {
            this.CdmNewestSnapshot = CdmNewestSnapshot;
        }
        if ( CdmOldestSnapshot != null ) {
            this.CdmOldestSnapshot = CdmOldestSnapshot;
        }
        if ( CdmSnapshots != null ) {
            this.CdmSnapshots = CdmSnapshots;
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
        if ( PrimaryClusterLocation != null ) {
            this.PrimaryClusterLocation = PrimaryClusterLocation;
        }
        if ( Replicas != null ) {
            this.Replicas = Replicas;
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
            //      C# -> System.Int32? CdmOnDemandSnapshotCount
            // GraphQL -> cdmOnDemandSnapshotCount: Int! (scalar)
            if (this.CdmOnDemandSnapshotCount != null)
            {
                 s += ind + "cdmOnDemandSnapshotCount\n";

            }
            //      C# -> System.Boolean? CopyOnly
            // GraphQL -> copyOnly: Boolean! (scalar)
            if (this.CopyOnly != null)
            {
                 s += ind + "copyOnly\n";

            }
            //      C# -> System.String? DagId
            // GraphQL -> dagId: UUID! (scalar)
            if (this.DagId != null)
            {
                 s += ind + "dagId\n";

            }
            //      C# -> System.Boolean? HasLogConfigFromSla
            // GraphQL -> hasLogConfigFromSla: Boolean! (scalar)
            if (this.HasLogConfigFromSla != null)
            {
                 s += ind + "hasLogConfigFromSla\n";

            }
            //      C# -> System.Boolean? HasPermissions
            // GraphQL -> hasPermissions: Boolean! (scalar)
            if (this.HasPermissions != null)
            {
                 s += ind + "hasPermissions\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsInAvailabilityGroup
            // GraphQL -> isInAvailabilityGroup: Boolean! (scalar)
            if (this.IsInAvailabilityGroup != null)
            {
                 s += ind + "isInAvailabilityGroup\n";

            }
            //      C# -> System.Boolean? IsLogShippingSecondary
            // GraphQL -> isLogShippingSecondary: Boolean! (scalar)
            if (this.IsLogShippingSecondary != null)
            {
                 s += ind + "isLogShippingSecondary\n";

            }
            //      C# -> System.Boolean? IsMount
            // GraphQL -> isMount: Boolean! (scalar)
            if (this.IsMount != null)
            {
                 s += ind + "isMount\n";

            }
            //      C# -> System.Boolean? IsOnline
            // GraphQL -> isOnline: Boolean! (scalar)
            if (this.IsOnline != null)
            {
                 s += ind + "isOnline\n";

            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic != null)
            {
                 s += ind + "isRelic\n";

            }
            //      C# -> System.Single? LogBackupFrequencyInSeconds
            // GraphQL -> logBackupFrequencyInSeconds: Float! (scalar)
            if (this.LogBackupFrequencyInSeconds != null)
            {
                 s += ind + "logBackupFrequencyInSeconds\n";

            }
            //      C# -> System.Int32? LogBackupRetentionInHours
            // GraphQL -> logBackupRetentionInHours: Int! (scalar)
            if (this.LogBackupRetentionInHours != null)
            {
                 s += ind + "logBackupRetentionInHours\n";

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
            //      C# -> System.Int32? OnDemandSnapshotCount
            // GraphQL -> onDemandSnapshotCount: Int! (scalar)
            if (this.OnDemandSnapshotCount != null)
            {
                 s += ind + "onDemandSnapshotCount\n";

            }
            //      C# -> System.String? PostBackupScript
            // GraphQL -> postBackupScript: String! (scalar)
            if (this.PostBackupScript != null)
            {
                 s += ind + "postBackupScript\n";

            }
            //      C# -> System.String? PreBackupScript
            // GraphQL -> preBackupScript: String! (scalar)
            if (this.PreBackupScript != null)
            {
                 s += ind + "preBackupScript\n";

            }
            //      C# -> System.String? RecoveryModel
            // GraphQL -> recoveryModel: String! (scalar)
            if (this.RecoveryModel != null)
            {
                 s += ind + "recoveryModel\n";

            }
            //      C# -> System.Int32? ReplicatedObjectCount
            // GraphQL -> replicatedObjectCount: Int! (scalar)
            if (this.ReplicatedObjectCount != null)
            {
                 s += ind + "replicatedObjectCount\n";

            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus != null)
            {
                 s += ind + "slaPauseStatus\n";

            }
            //      C# -> List<System.String>? UnprotectableReasons
            // GraphQL -> unprotectableReasons: [String!]! (scalar)
            if (this.UnprotectableReasons != null)
            {
                 s += ind + "unprotectableReasons\n";

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
            //      C# -> CdmGroupedSnapshotConnection? CdmGroupedSnapshots
            // GraphQL -> cdmGroupedSnapshots: CdmGroupedSnapshotConnection! (type)
            if (this.CdmGroupedSnapshots != null)
            {
                 s += ind + "cdmGroupedSnapshots\n";

                 s += ind + "{\n" + 
                 this.CdmGroupedSnapshots.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmWorkloadSnapshot? CdmNewestSnapshot
            // GraphQL -> cdmNewestSnapshot: CdmWorkloadSnapshot (type)
            if (this.CdmNewestSnapshot != null)
            {
                 s += ind + "cdmNewestSnapshot\n";

                 s += ind + "{\n" + 
                 this.CdmNewestSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmWorkloadSnapshot? CdmOldestSnapshot
            // GraphQL -> cdmOldestSnapshot: CdmWorkloadSnapshot (type)
            if (this.CdmOldestSnapshot != null)
            {
                 s += ind + "cdmOldestSnapshot\n";

                 s += ind + "{\n" + 
                 this.CdmOldestSnapshot.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmWorkloadSnapshotConnection? CdmSnapshots
            // GraphQL -> cdmSnapshots: CdmWorkloadSnapshotConnection! (type)
            if (this.CdmSnapshots != null)
            {
                 s += ind + "cdmSnapshots\n";

                 s += ind + "{\n" + 
                 this.CdmSnapshots.AsFragment(indent+1) + 
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
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject != null)
            {
                 s += ind + "effectiveSlaSourceObject\n";

                 s += ind + "{\n" + 
                 this.EffectiveSlaSourceObject.AsFragment(indent+1) + 
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
            //      C# -> MssqlDatabaseLiveMountConnection? LiveMounts
            // GraphQL -> liveMounts: MssqlDatabaseLiveMountConnection! (type)
            if (this.LiveMounts != null)
            {
                 s += ind + "liveMounts\n";

                 s += ind + "{\n" + 
                 this.LiveMounts.AsFragment(indent+1) + 
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
            //      C# -> List<CdmMssqlDbReplica>? Replicas
            // GraphQL -> replicas: [CdmMssqlDbReplica!]! (type)
            if (this.Replicas != null)
            {
                 s += ind + "replicas\n";

                 s += ind + "{\n" + 
                 this.Replicas.AsFragment(indent+1) + 
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
            //      C# -> System.Int32? CdmOnDemandSnapshotCount
            // GraphQL -> cdmOnDemandSnapshotCount: Int! (scalar)
            if (this.CdmOnDemandSnapshotCount == null && Exploration.Includes(parent + ".cdmOnDemandSnapshotCount$"))
            {
                this.CdmOnDemandSnapshotCount = new System.Int32();
            }
            //      C# -> System.Boolean? CopyOnly
            // GraphQL -> copyOnly: Boolean! (scalar)
            if (this.CopyOnly == null && Exploration.Includes(parent + ".copyOnly$"))
            {
                this.CopyOnly = new System.Boolean();
            }
            //      C# -> System.String? DagId
            // GraphQL -> dagId: UUID! (scalar)
            if (this.DagId == null && Exploration.Includes(parent + ".dagId$"))
            {
                this.DagId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? HasLogConfigFromSla
            // GraphQL -> hasLogConfigFromSla: Boolean! (scalar)
            if (this.HasLogConfigFromSla == null && Exploration.Includes(parent + ".hasLogConfigFromSla$"))
            {
                this.HasLogConfigFromSla = new System.Boolean();
            }
            //      C# -> System.Boolean? HasPermissions
            // GraphQL -> hasPermissions: Boolean! (scalar)
            if (this.HasPermissions == null && Exploration.Includes(parent + ".hasPermissions$"))
            {
                this.HasPermissions = new System.Boolean();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsInAvailabilityGroup
            // GraphQL -> isInAvailabilityGroup: Boolean! (scalar)
            if (this.IsInAvailabilityGroup == null && Exploration.Includes(parent + ".isInAvailabilityGroup$"))
            {
                this.IsInAvailabilityGroup = new System.Boolean();
            }
            //      C# -> System.Boolean? IsLogShippingSecondary
            // GraphQL -> isLogShippingSecondary: Boolean! (scalar)
            if (this.IsLogShippingSecondary == null && Exploration.Includes(parent + ".isLogShippingSecondary$"))
            {
                this.IsLogShippingSecondary = new System.Boolean();
            }
            //      C# -> System.Boolean? IsMount
            // GraphQL -> isMount: Boolean! (scalar)
            if (this.IsMount == null && Exploration.Includes(parent + ".isMount$"))
            {
                this.IsMount = new System.Boolean();
            }
            //      C# -> System.Boolean? IsOnline
            // GraphQL -> isOnline: Boolean! (scalar)
            if (this.IsOnline == null && Exploration.Includes(parent + ".isOnline$"))
            {
                this.IsOnline = new System.Boolean();
            }
            //      C# -> System.Boolean? IsRelic
            // GraphQL -> isRelic: Boolean! (scalar)
            if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic$"))
            {
                this.IsRelic = new System.Boolean();
            }
            //      C# -> System.Single? LogBackupFrequencyInSeconds
            // GraphQL -> logBackupFrequencyInSeconds: Float! (scalar)
            if (this.LogBackupFrequencyInSeconds == null && Exploration.Includes(parent + ".logBackupFrequencyInSeconds$"))
            {
                this.LogBackupFrequencyInSeconds = new System.Single();
            }
            //      C# -> System.Int32? LogBackupRetentionInHours
            // GraphQL -> logBackupRetentionInHours: Int! (scalar)
            if (this.LogBackupRetentionInHours == null && Exploration.Includes(parent + ".logBackupRetentionInHours$"))
            {
                this.LogBackupRetentionInHours = new System.Int32();
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
            //      C# -> System.Int32? OnDemandSnapshotCount
            // GraphQL -> onDemandSnapshotCount: Int! (scalar)
            if (this.OnDemandSnapshotCount == null && Exploration.Includes(parent + ".onDemandSnapshotCount$"))
            {
                this.OnDemandSnapshotCount = new System.Int32();
            }
            //      C# -> System.String? PostBackupScript
            // GraphQL -> postBackupScript: String! (scalar)
            if (this.PostBackupScript == null && Exploration.Includes(parent + ".postBackupScript$"))
            {
                this.PostBackupScript = new System.String("FETCH");
            }
            //      C# -> System.String? PreBackupScript
            // GraphQL -> preBackupScript: String! (scalar)
            if (this.PreBackupScript == null && Exploration.Includes(parent + ".preBackupScript$"))
            {
                this.PreBackupScript = new System.String("FETCH");
            }
            //      C# -> System.String? RecoveryModel
            // GraphQL -> recoveryModel: String! (scalar)
            if (this.RecoveryModel == null && Exploration.Includes(parent + ".recoveryModel$"))
            {
                this.RecoveryModel = new System.String("FETCH");
            }
            //      C# -> System.Int32? ReplicatedObjectCount
            // GraphQL -> replicatedObjectCount: Int! (scalar)
            if (this.ReplicatedObjectCount == null && Exploration.Includes(parent + ".replicatedObjectCount$"))
            {
                this.ReplicatedObjectCount = new System.Int32();
            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus$"))
            {
                this.SlaPauseStatus = new System.Boolean();
            }
            //      C# -> List<System.String>? UnprotectableReasons
            // GraphQL -> unprotectableReasons: [String!]! (scalar)
            if (this.UnprotectableReasons == null && Exploration.Includes(parent + ".unprotectableReasons$"))
            {
                this.UnprotectableReasons = new List<System.String>();
            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
            {
                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFragment(parent + ".allOrgs");
            }
            //      C# -> CdmGroupedSnapshotConnection? CdmGroupedSnapshots
            // GraphQL -> cdmGroupedSnapshots: CdmGroupedSnapshotConnection! (type)
            if (this.CdmGroupedSnapshots == null && Exploration.Includes(parent + ".cdmGroupedSnapshots"))
            {
                this.CdmGroupedSnapshots = new CdmGroupedSnapshotConnection();
                this.CdmGroupedSnapshots.ApplyExploratoryFragment(parent + ".cdmGroupedSnapshots");
            }
            //      C# -> CdmWorkloadSnapshot? CdmNewestSnapshot
            // GraphQL -> cdmNewestSnapshot: CdmWorkloadSnapshot (type)
            if (this.CdmNewestSnapshot == null && Exploration.Includes(parent + ".cdmNewestSnapshot"))
            {
                this.CdmNewestSnapshot = new CdmWorkloadSnapshot();
                this.CdmNewestSnapshot.ApplyExploratoryFragment(parent + ".cdmNewestSnapshot");
            }
            //      C# -> CdmWorkloadSnapshot? CdmOldestSnapshot
            // GraphQL -> cdmOldestSnapshot: CdmWorkloadSnapshot (type)
            if (this.CdmOldestSnapshot == null && Exploration.Includes(parent + ".cdmOldestSnapshot"))
            {
                this.CdmOldestSnapshot = new CdmWorkloadSnapshot();
                this.CdmOldestSnapshot.ApplyExploratoryFragment(parent + ".cdmOldestSnapshot");
            }
            //      C# -> CdmWorkloadSnapshotConnection? CdmSnapshots
            // GraphQL -> cdmSnapshots: CdmWorkloadSnapshotConnection! (type)
            if (this.CdmSnapshots == null && Exploration.Includes(parent + ".cdmSnapshots"))
            {
                this.CdmSnapshots = new CdmWorkloadSnapshotConnection();
                this.CdmSnapshots.ApplyExploratoryFragment(parent + ".cdmSnapshots");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
            {
                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFragment(parent + ".effectiveSlaSourceObject");
            }
            //      C# -> LatestUserNote? LatestUserNote
            // GraphQL -> latestUserNote: LatestUserNote (type)
            if (this.LatestUserNote == null && Exploration.Includes(parent + ".latestUserNote"))
            {
                this.LatestUserNote = new LatestUserNote();
                this.LatestUserNote.ApplyExploratoryFragment(parent + ".latestUserNote");
            }
            //      C# -> MssqlDatabaseLiveMountConnection? LiveMounts
            // GraphQL -> liveMounts: MssqlDatabaseLiveMountConnection! (type)
            if (this.LiveMounts == null && Exploration.Includes(parent + ".liveMounts"))
            {
                this.LiveMounts = new MssqlDatabaseLiveMountConnection();
                this.LiveMounts.ApplyExploratoryFragment(parent + ".liveMounts");
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
            //      C# -> List<CdmMssqlDbReplica>? Replicas
            // GraphQL -> replicas: [CdmMssqlDbReplica!]! (type)
            if (this.Replicas == null && Exploration.Includes(parent + ".replicas"))
            {
                this.Replicas = new List<CdmMssqlDbReplica>();
                this.Replicas.ApplyExploratoryFragment(parent + ".replicas");
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

    } // class MssqlDatabase
    #endregion

    public static class ListMssqlDatabaseExtensions
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
            this List<MssqlDatabase> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MssqlDatabase> list, 
            String parent = "")
        {
            var item = new MssqlDatabase();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types