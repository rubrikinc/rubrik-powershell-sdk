// ManagedVolume.cs
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
    #region ManagedVolume
 
    public class ManagedVolume: IFragment, HierarchyObject, CdmHierarchyObject, CdmHierarchySnappableNew
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

        //      C# -> List<System.String>? ClientNamePatterns
        // GraphQL -> clientNamePatterns: [String!]! (scalar)
        [JsonProperty("clientNamePatterns")]
        public List<System.String>? ClientNamePatterns { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        [JsonProperty("numChannels")]
        public System.Int32? NumChannels { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        [JsonProperty("onDemandSnapshotCount")]
        public System.Int32? OnDemandSnapshotCount { get; set; }

        //      C# -> System.Int64? PhysicalUsedSize
        // GraphQL -> physicalUsedSize: Long! (scalar)
        [JsonProperty("physicalUsedSize")]
        public System.Int64? PhysicalUsedSize { get; set; }

        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        [JsonProperty("protectionDate")]
        public DateTime? ProtectionDate { get; set; }

        //      C# -> System.Int64? ProvisionedSize
        // GraphQL -> provisionedSize: Long! (scalar)
        [JsonProperty("provisionedSize")]
        public System.Int64? ProvisionedSize { get; set; }

        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        [JsonProperty("replicatedObjectCount")]
        public System.Int32? ReplicatedObjectCount { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        [JsonProperty("subnet")]
        public System.String? Subnet { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> ManagedVolumeSlaClientConfig? ClientConfig
        // GraphQL -> clientConfig: ManagedVolumeSlaClientConfig (type)
        [JsonProperty("clientConfig")]
        public ManagedVolumeSlaClientConfig? ClientConfig { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> ManagedVolumeDescendantTypeConnection? DescendantConnection
        // GraphQL -> descendantConnection: ManagedVolumeDescendantTypeConnection! (type)
        [JsonProperty("descendantConnection")]
        public ManagedVolumeDescendantTypeConnection? DescendantConnection { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost (type)
        [JsonProperty("host")]
        public PhysicalHost? Host { get; set; }

        //      C# -> ManagedVolumeHostDetail? HostDetail
        // GraphQL -> hostDetail: ManagedVolumeHostDetail (type)
        [JsonProperty("hostDetail")]
        public ManagedVolumeHostDetail? HostDetail { get; set; }

        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        [JsonProperty("latestUserNote")]
        public LatestUserNote? LatestUserNote { get; set; }

        //      C# -> ManagedVolumeMountConnection? LiveMounts
        // GraphQL -> liveMounts: ManagedVolumeMountConnection! (type)
        [JsonProperty("liveMounts")]
        public ManagedVolumeMountConnection? LiveMounts { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> ManagedVolumeMount? MainMount
        // GraphQL -> mainMount: ManagedVolumeMount (type)
        [JsonProperty("mainMount")]
        public ManagedVolumeMount? MainMount { get; set; }

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

        //      C# -> ManagedVolumePhysicalChildTypeConnection? PhysicalChildConnection
        // GraphQL -> physicalChildConnection: ManagedVolumePhysicalChildTypeConnection! (type)
        [JsonProperty("physicalChildConnection")]
        public ManagedVolumePhysicalChildTypeConnection? PhysicalChildConnection { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        [JsonProperty("primaryClusterLocation")]
        public DataLocation? PrimaryClusterLocation { get; set; }

        //      C# -> ManagedVolumeQueuedSnapshotGroupByConnection? QueuedSnapshotGroupBys
        // GraphQL -> queuedSnapshotGroupBys: ManagedVolumeQueuedSnapshotGroupByConnection (type)
        [JsonProperty("queuedSnapshotGroupBys")]
        public ManagedVolumeQueuedSnapshotGroupByConnection? QueuedSnapshotGroupBys { get; set; }

        //      C# -> ManagedVolumeQueuedSnapshotConnection? QueuedSnapshots
        // GraphQL -> queuedSnapshots: ManagedVolumeQueuedSnapshotConnection (type)
        [JsonProperty("queuedSnapshots")]
        public ManagedVolumeQueuedSnapshotConnection? QueuedSnapshots { get; set; }

        //      C# -> Snappable? ReportWorkload
        // GraphQL -> reportWorkload: Snappable (type)
        [JsonProperty("reportWorkload")]
        public Snappable? ReportWorkload { get; set; }

        //      C# -> ManagedVolumeSmbShare? SmbShare
        // GraphQL -> smbShare: ManagedVolumeSmbShare (type)
        [JsonProperty("smbShare")]
        public ManagedVolumeSmbShare? SmbShare { get; set; }

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

        //      C# -> ManagedVolumeApplicationTag? ApplicationTag
        // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
        [JsonProperty("applicationTag")]
        public ManagedVolumeApplicationTag? ApplicationTag { get; set; }

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> ManagedVolumeType? ManagedVolumeType
        // GraphQL -> managedVolumeType: ManagedVolumeType! (enum)
        [JsonProperty("managedVolumeType")]
        public ManagedVolumeType? ManagedVolumeType { get; set; }

        //      C# -> MountState? MountState
        // GraphQL -> mountState: MountState (enum)
        [JsonProperty("mountState")]
        public MountState? MountState { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> ManagedVolumeShareType? Protocol
        // GraphQL -> protocol: ManagedVolumeShareType! (enum)
        [JsonProperty("protocol")]
        public ManagedVolumeShareType? Protocol { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> ManagedVolumeState? State
        // GraphQL -> state: ManagedVolumeState! (enum)
        [JsonProperty("state")]
        public ManagedVolumeState? State { get; set; }

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

    public ManagedVolume Set(
        System.String? CdmId = null,
        System.String? CdmLink = null,
        List<System.String>? ClientNamePatterns = null,
        System.String? Id = null,
        System.Boolean? IsRelic = null,
        System.String? Name = null,
        System.Int32? NumChannels = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.Int64? PhysicalUsedSize = null,
        DateTime? ProtectionDate = null,
        System.Int64? ProvisionedSize = null,
        System.Int32? ReplicatedObjectCount = null,
        System.Boolean? SlaPauseStatus = null,
        System.String? Subnet = null,
        List<Org>? AllOrgs = null,
        ManagedVolumeSlaClientConfig? ClientConfig = null,
        Cluster? Cluster = null,
        ManagedVolumeDescendantTypeConnection? DescendantConnection = null,
        PathNode? EffectiveSlaSourceObject = null,
        PhysicalHost? Host = null,
        ManagedVolumeHostDetail? HostDetail = null,
        LatestUserNote? LatestUserNote = null,
        ManagedVolumeMountConnection? LiveMounts = null,
        List<PathNode>? LogicalPath = null,
        ManagedVolumeMount? MainMount = null,
        MissedSnapshotCommonConnection? MissedSnapshotConnection = null,
        MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection = null,
        CdmSnapshot? NewestArchivedSnapshot = null,
        CdmSnapshot? NewestReplicatedSnapshot = null,
        CdmSnapshot? NewestSnapshot = null,
        CdmSnapshot? OldestSnapshot = null,
        PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus = null,
        ManagedVolumePhysicalChildTypeConnection? PhysicalChildConnection = null,
        List<PathNode>? PhysicalPath = null,
        DataLocation? PrimaryClusterLocation = null,
        ManagedVolumeQueuedSnapshotGroupByConnection? QueuedSnapshotGroupBys = null,
        ManagedVolumeQueuedSnapshotConnection? QueuedSnapshots = null,
        Snappable? ReportWorkload = null,
        ManagedVolumeSmbShare? SmbShare = null,
        CdmSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        CdmSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary = null,
        ManagedVolumeApplicationTag? ApplicationTag = null,
        List<Operation>? AuthorizedOperations = null,
        ManagedVolumeType? ManagedVolumeType = null,
        MountState? MountState = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        ManagedVolumeShareType? Protocol = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        ManagedVolumeState? State = null,
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
        if ( ClientNamePatterns != null ) {
            this.ClientNamePatterns = ClientNamePatterns;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumChannels != null ) {
            this.NumChannels = NumChannels;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( OnDemandSnapshotCount != null ) {
            this.OnDemandSnapshotCount = OnDemandSnapshotCount;
        }
        if ( PhysicalUsedSize != null ) {
            this.PhysicalUsedSize = PhysicalUsedSize;
        }
        if ( ProtectionDate != null ) {
            this.ProtectionDate = ProtectionDate;
        }
        if ( ProvisionedSize != null ) {
            this.ProvisionedSize = ProvisionedSize;
        }
        if ( ReplicatedObjectCount != null ) {
            this.ReplicatedObjectCount = ReplicatedObjectCount;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( Subnet != null ) {
            this.Subnet = Subnet;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( ClientConfig != null ) {
            this.ClientConfig = ClientConfig;
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
        if ( Host != null ) {
            this.Host = Host;
        }
        if ( HostDetail != null ) {
            this.HostDetail = HostDetail;
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
        if ( MainMount != null ) {
            this.MainMount = MainMount;
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
        if ( PhysicalChildConnection != null ) {
            this.PhysicalChildConnection = PhysicalChildConnection;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( PrimaryClusterLocation != null ) {
            this.PrimaryClusterLocation = PrimaryClusterLocation;
        }
        if ( QueuedSnapshotGroupBys != null ) {
            this.QueuedSnapshotGroupBys = QueuedSnapshotGroupBys;
        }
        if ( QueuedSnapshots != null ) {
            this.QueuedSnapshots = QueuedSnapshots;
        }
        if ( ReportWorkload != null ) {
            this.ReportWorkload = ReportWorkload;
        }
        if ( SmbShare != null ) {
            this.SmbShare = SmbShare;
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
        if ( ApplicationTag != null ) {
            this.ApplicationTag = ApplicationTag;
        }
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ManagedVolumeType != null ) {
            this.ManagedVolumeType = ManagedVolumeType;
        }
        if ( MountState != null ) {
            this.MountState = MountState;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Protocol != null ) {
            this.Protocol = Protocol;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( State != null ) {
            this.State = State;
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
            //      C# -> List<System.String>? ClientNamePatterns
            // GraphQL -> clientNamePatterns: [String!]! (scalar)
            if (this.ClientNamePatterns != null)
            {
                 s += ind + "clientNamePatterns\n";

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
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int32? NumChannels
            // GraphQL -> numChannels: Int! (scalar)
            if (this.NumChannels != null)
            {
                 s += ind + "numChannels\n";

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
            //      C# -> System.Int64? PhysicalUsedSize
            // GraphQL -> physicalUsedSize: Long! (scalar)
            if (this.PhysicalUsedSize != null)
            {
                 s += ind + "physicalUsedSize\n";

            }
            //      C# -> DateTime? ProtectionDate
            // GraphQL -> protectionDate: DateTime (scalar)
            if (this.ProtectionDate != null)
            {
                 s += ind + "protectionDate\n";

            }
            //      C# -> System.Int64? ProvisionedSize
            // GraphQL -> provisionedSize: Long! (scalar)
            if (this.ProvisionedSize != null)
            {
                 s += ind + "provisionedSize\n";

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
            //      C# -> System.String? Subnet
            // GraphQL -> subnet: String (scalar)
            if (this.Subnet != null)
            {
                 s += ind + "subnet\n";

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
            //      C# -> ManagedVolumeSlaClientConfig? ClientConfig
            // GraphQL -> clientConfig: ManagedVolumeSlaClientConfig (type)
            if (this.ClientConfig != null)
            {
                 s += ind + "clientConfig\n";

                 s += ind + "{\n" + 
                 this.ClientConfig.AsFragment(indent+1) + 
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
            //      C# -> ManagedVolumeDescendantTypeConnection? DescendantConnection
            // GraphQL -> descendantConnection: ManagedVolumeDescendantTypeConnection! (type)
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
            //      C# -> PhysicalHost? Host
            // GraphQL -> host: PhysicalHost (type)
            if (this.Host != null)
            {
                 s += ind + "host\n";

                 s += ind + "{\n" + 
                 this.Host.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeHostDetail? HostDetail
            // GraphQL -> hostDetail: ManagedVolumeHostDetail (type)
            if (this.HostDetail != null)
            {
                 s += ind + "hostDetail\n";

                 s += ind + "{\n" + 
                 this.HostDetail.AsFragment(indent+1) + 
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
            //      C# -> ManagedVolumeMountConnection? LiveMounts
            // GraphQL -> liveMounts: ManagedVolumeMountConnection! (type)
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
            //      C# -> ManagedVolumeMount? MainMount
            // GraphQL -> mainMount: ManagedVolumeMount (type)
            if (this.MainMount != null)
            {
                 s += ind + "mainMount\n";

                 s += ind + "{\n" + 
                 this.MainMount.AsFragment(indent+1) + 
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
            //      C# -> ManagedVolumePhysicalChildTypeConnection? PhysicalChildConnection
            // GraphQL -> physicalChildConnection: ManagedVolumePhysicalChildTypeConnection! (type)
            if (this.PhysicalChildConnection != null)
            {
                 s += ind + "physicalChildConnection\n";

                 s += ind + "{\n" + 
                 this.PhysicalChildConnection.AsFragment(indent+1) + 
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
            //      C# -> ManagedVolumeQueuedSnapshotGroupByConnection? QueuedSnapshotGroupBys
            // GraphQL -> queuedSnapshotGroupBys: ManagedVolumeQueuedSnapshotGroupByConnection (type)
            if (this.QueuedSnapshotGroupBys != null)
            {
                 s += ind + "queuedSnapshotGroupBys\n";

                 s += ind + "{\n" + 
                 this.QueuedSnapshotGroupBys.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeQueuedSnapshotConnection? QueuedSnapshots
            // GraphQL -> queuedSnapshots: ManagedVolumeQueuedSnapshotConnection (type)
            if (this.QueuedSnapshots != null)
            {
                 s += ind + "queuedSnapshots\n";

                 s += ind + "{\n" + 
                 this.QueuedSnapshots.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Snappable? ReportWorkload
            // GraphQL -> reportWorkload: Snappable (type)
            if (this.ReportWorkload != null)
            {
                 s += ind + "reportWorkload\n";

                 s += ind + "{\n" + 
                 this.ReportWorkload.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeSmbShare? SmbShare
            // GraphQL -> smbShare: ManagedVolumeSmbShare (type)
            if (this.SmbShare != null)
            {
                 s += ind + "smbShare\n";

                 s += ind + "{\n" + 
                 this.SmbShare.AsFragment(indent+1) + 
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
            //      C# -> ManagedVolumeApplicationTag? ApplicationTag
            // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
            if (this.ApplicationTag != null)
            {
                 s += ind + "applicationTag\n";

            }
            //      C# -> List<Operation>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [Operation!]! (enum)
            if (this.AuthorizedOperations != null)
            {
                 s += ind + "authorizedOperations\n";

            }
            //      C# -> ManagedVolumeType? ManagedVolumeType
            // GraphQL -> managedVolumeType: ManagedVolumeType! (enum)
            if (this.ManagedVolumeType != null)
            {
                 s += ind + "managedVolumeType\n";

            }
            //      C# -> MountState? MountState
            // GraphQL -> mountState: MountState (enum)
            if (this.MountState != null)
            {
                 s += ind + "mountState\n";

            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            //      C# -> ManagedVolumeShareType? Protocol
            // GraphQL -> protocol: ManagedVolumeShareType! (enum)
            if (this.Protocol != null)
            {
                 s += ind + "protocol\n";

            }
            //      C# -> SlaAssignmentTypeEnum? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
            if (this.SlaAssignment != null)
            {
                 s += ind + "slaAssignment\n";

            }
            //      C# -> ManagedVolumeState? State
            // GraphQL -> state: ManagedVolumeState! (enum)
            if (this.State != null)
            {
                 s += ind + "state\n";

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
            //      C# -> List<System.String>? ClientNamePatterns
            // GraphQL -> clientNamePatterns: [String!]! (scalar)
            if (this.ClientNamePatterns == null && Exploration.Includes(parent + ".clientNamePatterns$"))
            {
                this.ClientNamePatterns = new List<System.String>();
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
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int32? NumChannels
            // GraphQL -> numChannels: Int! (scalar)
            if (this.NumChannels == null && Exploration.Includes(parent + ".numChannels$"))
            {
                this.NumChannels = new System.Int32();
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
            //      C# -> System.Int64? PhysicalUsedSize
            // GraphQL -> physicalUsedSize: Long! (scalar)
            if (this.PhysicalUsedSize == null && Exploration.Includes(parent + ".physicalUsedSize$"))
            {
                this.PhysicalUsedSize = new System.Int64();
            }
            //      C# -> DateTime? ProtectionDate
            // GraphQL -> protectionDate: DateTime (scalar)
            if (this.ProtectionDate == null && Exploration.Includes(parent + ".protectionDate$"))
            {
                this.ProtectionDate = new DateTime();
            }
            //      C# -> System.Int64? ProvisionedSize
            // GraphQL -> provisionedSize: Long! (scalar)
            if (this.ProvisionedSize == null && Exploration.Includes(parent + ".provisionedSize$"))
            {
                this.ProvisionedSize = new System.Int64();
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
            //      C# -> System.String? Subnet
            // GraphQL -> subnet: String (scalar)
            if (this.Subnet == null && Exploration.Includes(parent + ".subnet$"))
            {
                this.Subnet = new System.String("FETCH");
            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
            {
                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFragment(parent + ".allOrgs");
            }
            //      C# -> ManagedVolumeSlaClientConfig? ClientConfig
            // GraphQL -> clientConfig: ManagedVolumeSlaClientConfig (type)
            if (this.ClientConfig == null && Exploration.Includes(parent + ".clientConfig"))
            {
                this.ClientConfig = new ManagedVolumeSlaClientConfig();
                this.ClientConfig.ApplyExploratoryFragment(parent + ".clientConfig");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> ManagedVolumeDescendantTypeConnection? DescendantConnection
            // GraphQL -> descendantConnection: ManagedVolumeDescendantTypeConnection! (type)
            if (this.DescendantConnection == null && Exploration.Includes(parent + ".descendantConnection"))
            {
                this.DescendantConnection = new ManagedVolumeDescendantTypeConnection();
                this.DescendantConnection.ApplyExploratoryFragment(parent + ".descendantConnection");
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
            {
                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFragment(parent + ".effectiveSlaSourceObject");
            }
            //      C# -> PhysicalHost? Host
            // GraphQL -> host: PhysicalHost (type)
            if (this.Host == null && Exploration.Includes(parent + ".host"))
            {
                this.Host = new PhysicalHost();
                this.Host.ApplyExploratoryFragment(parent + ".host");
            }
            //      C# -> ManagedVolumeHostDetail? HostDetail
            // GraphQL -> hostDetail: ManagedVolumeHostDetail (type)
            if (this.HostDetail == null && Exploration.Includes(parent + ".hostDetail"))
            {
                this.HostDetail = new ManagedVolumeHostDetail();
                this.HostDetail.ApplyExploratoryFragment(parent + ".hostDetail");
            }
            //      C# -> LatestUserNote? LatestUserNote
            // GraphQL -> latestUserNote: LatestUserNote (type)
            if (this.LatestUserNote == null && Exploration.Includes(parent + ".latestUserNote"))
            {
                this.LatestUserNote = new LatestUserNote();
                this.LatestUserNote.ApplyExploratoryFragment(parent + ".latestUserNote");
            }
            //      C# -> ManagedVolumeMountConnection? LiveMounts
            // GraphQL -> liveMounts: ManagedVolumeMountConnection! (type)
            if (this.LiveMounts == null && Exploration.Includes(parent + ".liveMounts"))
            {
                this.LiveMounts = new ManagedVolumeMountConnection();
                this.LiveMounts.ApplyExploratoryFragment(parent + ".liveMounts");
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
            {
                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFragment(parent + ".logicalPath");
            }
            //      C# -> ManagedVolumeMount? MainMount
            // GraphQL -> mainMount: ManagedVolumeMount (type)
            if (this.MainMount == null && Exploration.Includes(parent + ".mainMount"))
            {
                this.MainMount = new ManagedVolumeMount();
                this.MainMount.ApplyExploratoryFragment(parent + ".mainMount");
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
            //      C# -> ManagedVolumePhysicalChildTypeConnection? PhysicalChildConnection
            // GraphQL -> physicalChildConnection: ManagedVolumePhysicalChildTypeConnection! (type)
            if (this.PhysicalChildConnection == null && Exploration.Includes(parent + ".physicalChildConnection"))
            {
                this.PhysicalChildConnection = new ManagedVolumePhysicalChildTypeConnection();
                this.PhysicalChildConnection.ApplyExploratoryFragment(parent + ".physicalChildConnection");
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
            //      C# -> ManagedVolumeQueuedSnapshotGroupByConnection? QueuedSnapshotGroupBys
            // GraphQL -> queuedSnapshotGroupBys: ManagedVolumeQueuedSnapshotGroupByConnection (type)
            if (this.QueuedSnapshotGroupBys == null && Exploration.Includes(parent + ".queuedSnapshotGroupBys"))
            {
                this.QueuedSnapshotGroupBys = new ManagedVolumeQueuedSnapshotGroupByConnection();
                this.QueuedSnapshotGroupBys.ApplyExploratoryFragment(parent + ".queuedSnapshotGroupBys");
            }
            //      C# -> ManagedVolumeQueuedSnapshotConnection? QueuedSnapshots
            // GraphQL -> queuedSnapshots: ManagedVolumeQueuedSnapshotConnection (type)
            if (this.QueuedSnapshots == null && Exploration.Includes(parent + ".queuedSnapshots"))
            {
                this.QueuedSnapshots = new ManagedVolumeQueuedSnapshotConnection();
                this.QueuedSnapshots.ApplyExploratoryFragment(parent + ".queuedSnapshots");
            }
            //      C# -> Snappable? ReportWorkload
            // GraphQL -> reportWorkload: Snappable (type)
            if (this.ReportWorkload == null && Exploration.Includes(parent + ".reportWorkload"))
            {
                this.ReportWorkload = new Snappable();
                this.ReportWorkload.ApplyExploratoryFragment(parent + ".reportWorkload");
            }
            //      C# -> ManagedVolumeSmbShare? SmbShare
            // GraphQL -> smbShare: ManagedVolumeSmbShare (type)
            if (this.SmbShare == null && Exploration.Includes(parent + ".smbShare"))
            {
                this.SmbShare = new ManagedVolumeSmbShare();
                this.SmbShare.ApplyExploratoryFragment(parent + ".smbShare");
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
            //      C# -> ManagedVolumeApplicationTag? ApplicationTag
            // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
            if (this.ApplicationTag == null && Exploration.Includes(parent + ".applicationTag$"))
            {
                this.ApplicationTag = new ManagedVolumeApplicationTag();
            }
            //      C# -> List<Operation>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [Operation!]! (enum)
            if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations$"))
            {
                this.AuthorizedOperations = new List<Operation>();
            }
            //      C# -> ManagedVolumeType? ManagedVolumeType
            // GraphQL -> managedVolumeType: ManagedVolumeType! (enum)
            if (this.ManagedVolumeType == null && Exploration.Includes(parent + ".managedVolumeType$"))
            {
                this.ManagedVolumeType = new ManagedVolumeType();
            }
            //      C# -> MountState? MountState
            // GraphQL -> mountState: MountState (enum)
            if (this.MountState == null && Exploration.Includes(parent + ".mountState$"))
            {
                this.MountState = new MountState();
            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new HierarchyObjectTypeEnum();
            }
            //      C# -> ManagedVolumeShareType? Protocol
            // GraphQL -> protocol: ManagedVolumeShareType! (enum)
            if (this.Protocol == null && Exploration.Includes(parent + ".protocol$"))
            {
                this.Protocol = new ManagedVolumeShareType();
            }
            //      C# -> SlaAssignmentTypeEnum? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
            if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment$"))
            {
                this.SlaAssignment = new SlaAssignmentTypeEnum();
            }
            //      C# -> ManagedVolumeState? State
            // GraphQL -> state: ManagedVolumeState! (enum)
            if (this.State == null && Exploration.Includes(parent + ".state$"))
            {
                this.State = new ManagedVolumeState();
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

    } // class ManagedVolume
    #endregion

    public static class ListManagedVolumeExtensions
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
            this List<ManagedVolume> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolume> list, 
            String parent = "")
        {
            var item = new ManagedVolume();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types