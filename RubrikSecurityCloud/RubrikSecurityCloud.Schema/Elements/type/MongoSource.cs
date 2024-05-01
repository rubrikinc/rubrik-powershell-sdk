// MongoSource.cs
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
    #region MongoSource
 
    public class MongoSource: BaseType, CdmHierarchyObject, HierarchyObject
    {
        #region members

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> MongoDiscoveryStatus? DiscoveryStatus
        // GraphQL -> discoveryStatus: MongoDiscoveryStatus! (enum)
        [JsonProperty("discoveryStatus")]
        public MongoDiscoveryStatus? DiscoveryStatus { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> MongoSourceType? SourceType
        // GraphQL -> sourceType: MongoSourceType! (enum)
        [JsonProperty("sourceType")]
        public MongoSourceType? SourceType { get; set; }

        //      C# -> MongoSourceStatus? Status
        // GraphQL -> status: MongoSourceStatus! (enum)
        [JsonProperty("status")]
        public MongoSourceStatus? Status { get; set; }

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

        //      C# -> System.Int32? ActiveCollectionCount
        // GraphQL -> activeCollectionCount: Int! (scalar)
        [JsonProperty("activeCollectionCount")]
        public System.Int32? ActiveCollectionCount { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        [JsonProperty("lastRefreshTime")]
        public DateTime? LastRefreshTime { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        [JsonProperty("primaryClusterUuid")]
        public System.String? PrimaryClusterUuid { get; set; }

        //      C# -> System.Int32? ProtectedCollectionCount
        // GraphQL -> protectedCollectionCount: Int! (scalar)
        [JsonProperty("protectedCollectionCount")]
        public System.Int32? ProtectedCollectionCount { get; set; }

        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        [JsonProperty("replicatedObjectCount")]
        public System.Int32? ReplicatedObjectCount { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

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

        //      C# -> PhysicalHostConnection? DataHosts
        // GraphQL -> dataHosts: PhysicalHostConnection! (type)
        [JsonProperty("dataHosts")]
        public PhysicalHostConnection? DataHosts { get; set; }

        //      C# -> MongoSourceDescendantTypeConnection? DescendantConnection
        // GraphQL -> descendantConnection: MongoSourceDescendantTypeConnection! (type)
        [JsonProperty("descendantConnection")]
        public MongoSourceDescendantTypeConnection? DescendantConnection { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> List<CdmMongoNode>? IgnoreSecondaryNodes
        // GraphQL -> ignoreSecondaryNodes: [CdmMongoNode!] (type)
        [JsonProperty("ignoreSecondaryNodes")]
        public List<CdmMongoNode>? IgnoreSecondaryNodes { get; set; }

        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        [JsonProperty("latestUserNote")]
        public LatestUserNote? LatestUserNote { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        [JsonProperty("pendingObjectDeletionStatus")]
        public PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus { get; set; }

        //      C# -> MongoSourcePhysicalChildTypeConnection? PhysicalChildConnection
        // GraphQL -> physicalChildConnection: MongoSourcePhysicalChildTypeConnection! (type)
        [JsonProperty("physicalChildConnection")]
        public MongoSourcePhysicalChildTypeConnection? PhysicalChildConnection { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        [JsonProperty("primaryClusterLocation")]
        public DataLocation? PrimaryClusterLocation { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> List<CdmMongoNode>? SourceNodes
        // GraphQL -> sourceNodes: [CdmMongoNode!]! (type)
        [JsonProperty("sourceNodes")]
        public List<CdmMongoNode>? SourceNodes { get; set; }

        //      C# -> CdmMongoSslParams? SslParams
        // GraphQL -> sslParams: CdmMongoSslParams (type)
        [JsonProperty("sslParams")]
        public CdmMongoSslParams? SslParams { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars DataHosts { get; set; }

        public RscGqlVars DescendantConnection { get; set; }

        public RscGqlVars PhysicalChildConnection { get; set; }


        public InlineVars() {
            Tuple<string, string>[] dataHostsArgs = {
                    Tuple.Create("sortBy", "HierarchySortByField"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("filter", "[Filter!]"),
                };
            this.DataHosts =
                new RscGqlVars(null, dataHostsArgs, null, true);
            Tuple<string, string>[] descendantConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("sortBy", "HierarchySortByField"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                    Tuple.Create("filter", "[Filter!]"),
                    Tuple.Create("workloadHierarchy", "WorkloadLevelHierarchy"),
                };
            this.DescendantConnection =
                new RscGqlVars(null, descendantConnectionArgs, null, true);
            Tuple<string, string>[] physicalChildConnectionArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("sortBy", "HierarchySortByField"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                    Tuple.Create("filter", "[Filter!]"),
                    Tuple.Create("workloadHierarchy", "WorkloadLevelHierarchy"),
                };
            this.PhysicalChildConnection =
                new RscGqlVars(null, physicalChildConnectionArgs, null, true);
        }
    }

    public MongoSource()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "MongoSource";
    }

    public MongoSource Set(
        List<Operation>? AuthorizedOperations = null,
        MongoDiscoveryStatus? DiscoveryStatus = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        MongoSourceType? SourceType = null,
        MongoSourceStatus? Status = null,
        RscInterface<SlaDomain> ConfiguredSlaDomain = null,
        RscInterface<SlaDomain> EffectiveRetentionSlaDomain = null,
        RscInterface<SlaDomain> EffectiveSlaDomain = null,
        RscInterface<SlaDomain> PendingSla = null,
        RscInterfaceList<CdmHierarchyObject> ReplicatedObjects = null,
        System.Int32? ActiveCollectionCount = null,
        System.String? CdmId = null,
        System.String? ClusterUuid = null,
        System.String? Id = null,
        System.Boolean? IsRelic = null,
        DateTime? LastRefreshTime = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.String? PrimaryClusterUuid = null,
        System.Int32? ProtectedCollectionCount = null,
        System.Int32? ReplicatedObjectCount = null,
        System.Boolean? SlaPauseStatus = null,
        System.String? Username = null,
        List<Org>? AllOrgs = null,
        Cluster? Cluster = null,
        List<CrossAccountReplicatedObjectInfo>? CrossAccountReplicatedObjectInfos = null,
        PhysicalHostConnection? DataHosts = null,
        MongoSourceDescendantTypeConnection? DescendantConnection = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<CdmMongoNode>? IgnoreSecondaryNodes = null,
        LatestUserNote? LatestUserNote = null,
        List<PathNode>? LogicalPath = null,
        PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus = null,
        MongoSourcePhysicalChildTypeConnection? PhysicalChildConnection = null,
        List<PathNode>? PhysicalPath = null,
        DataLocation? PrimaryClusterLocation = null,
        SnapshotDistribution? SnapshotDistribution = null,
        List<CdmMongoNode>? SourceNodes = null,
        CdmMongoSslParams? SslParams = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( DiscoveryStatus != null ) {
            this.DiscoveryStatus = DiscoveryStatus;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( SourceType != null ) {
            this.SourceType = SourceType;
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
        if ( PendingSla != null ) {
            this.PendingSla = PendingSla;
        }
        if ( ReplicatedObjects != null ) {
            this.ReplicatedObjects = ReplicatedObjects;
        }
        if ( ActiveCollectionCount != null ) {
            this.ActiveCollectionCount = ActiveCollectionCount;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( LastRefreshTime != null ) {
            this.LastRefreshTime = LastRefreshTime;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( PrimaryClusterUuid != null ) {
            this.PrimaryClusterUuid = PrimaryClusterUuid;
        }
        if ( ProtectedCollectionCount != null ) {
            this.ProtectedCollectionCount = ProtectedCollectionCount;
        }
        if ( ReplicatedObjectCount != null ) {
            this.ReplicatedObjectCount = ReplicatedObjectCount;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( Username != null ) {
            this.Username = Username;
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
        if ( DataHosts != null ) {
            this.DataHosts = DataHosts;
        }
        if ( DescendantConnection != null ) {
            this.DescendantConnection = DescendantConnection;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( IgnoreSecondaryNodes != null ) {
            this.IgnoreSecondaryNodes = IgnoreSecondaryNodes;
        }
        if ( LatestUserNote != null ) {
            this.LatestUserNote = LatestUserNote;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
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
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        if ( SourceNodes != null ) {
            this.SourceNodes = SourceNodes;
        }
        if ( SslParams != null ) {
            this.SslParams = SslParams;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
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
        //      C# -> MongoDiscoveryStatus? DiscoveryStatus
        // GraphQL -> discoveryStatus: MongoDiscoveryStatus! (enum)
        if (this.DiscoveryStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "discoveryStatus\n" ;
            } else {
                s += ind + "discoveryStatus\n" ;
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
        //      C# -> MongoSourceType? SourceType
        // GraphQL -> sourceType: MongoSourceType! (enum)
        if (this.SourceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceType\n" ;
            } else {
                s += ind + "sourceType\n" ;
            }
        }
        //      C# -> MongoSourceStatus? Status
        // GraphQL -> status: MongoSourceStatus! (enum)
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
        //      C# -> System.Int32? ActiveCollectionCount
        // GraphQL -> activeCollectionCount: Int! (scalar)
        if (this.ActiveCollectionCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeCollectionCount\n" ;
            } else {
                s += ind + "activeCollectionCount\n" ;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
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
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRelic\n" ;
            } else {
                s += ind + "isRelic\n" ;
            }
        }
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (this.LastRefreshTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRefreshTime\n" ;
            } else {
                s += ind + "lastRefreshTime\n" ;
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
        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        if (this.PrimaryClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterUuid\n" ;
            } else {
                s += ind + "primaryClusterUuid\n" ;
            }
        }
        //      C# -> System.Int32? ProtectedCollectionCount
        // GraphQL -> protectedCollectionCount: Int! (scalar)
        if (this.ProtectedCollectionCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectedCollectionCount\n" ;
            } else {
                s += ind + "protectedCollectionCount\n" ;
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
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            if (conf.Flat) {
                s += conf.Prefix + "username\n" ;
            } else {
                s += ind + "username\n" ;
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
        //      C# -> PhysicalHostConnection? DataHosts
        // GraphQL -> dataHosts: PhysicalHostConnection! (type)
        if (this.DataHosts != null) {
            var fspec = this.DataHosts.AsFieldSpec(conf.Child("dataHosts"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataHosts" + "\n(" + this.Vars.DataHosts.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MongoSourceDescendantTypeConnection? DescendantConnection
        // GraphQL -> descendantConnection: MongoSourceDescendantTypeConnection! (type)
        if (this.DescendantConnection != null) {
            var fspec = this.DescendantConnection.AsFieldSpec(conf.Child("descendantConnection"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "descendantConnection" + "\n(" + this.Vars.DescendantConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> List<CdmMongoNode>? IgnoreSecondaryNodes
        // GraphQL -> ignoreSecondaryNodes: [CdmMongoNode!] (type)
        if (this.IgnoreSecondaryNodes != null) {
            var fspec = this.IgnoreSecondaryNodes.AsFieldSpec(conf.Child("ignoreSecondaryNodes"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ignoreSecondaryNodes" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> MongoSourcePhysicalChildTypeConnection? PhysicalChildConnection
        // GraphQL -> physicalChildConnection: MongoSourcePhysicalChildTypeConnection! (type)
        if (this.PhysicalChildConnection != null) {
            var fspec = this.PhysicalChildConnection.AsFieldSpec(conf.Child("physicalChildConnection"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "physicalChildConnection" + "\n(" + this.Vars.PhysicalChildConnection.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> List<CdmMongoNode>? SourceNodes
        // GraphQL -> sourceNodes: [CdmMongoNode!]! (type)
        if (this.SourceNodes != null) {
            var fspec = this.SourceNodes.AsFieldSpec(conf.Child("sourceNodes"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceNodes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmMongoSslParams? SslParams
        // GraphQL -> sslParams: CdmMongoSslParams (type)
        if (this.SslParams != null) {
            var fspec = this.SslParams.AsFieldSpec(conf.Child("sslParams"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sslParams" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> MongoDiscoveryStatus? DiscoveryStatus
        // GraphQL -> discoveryStatus: MongoDiscoveryStatus! (enum)
        if (ec.Includes("discoveryStatus",true))
        {
            if(this.DiscoveryStatus == null) {

                this.DiscoveryStatus = new MongoDiscoveryStatus();

            } else {


            }
        }
        else if (this.DiscoveryStatus != null && ec.Excludes("discoveryStatus",true))
        {
            this.DiscoveryStatus = null;
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
        //      C# -> MongoSourceType? SourceType
        // GraphQL -> sourceType: MongoSourceType! (enum)
        if (ec.Includes("sourceType",true))
        {
            if(this.SourceType == null) {

                this.SourceType = new MongoSourceType();

            } else {


            }
        }
        else if (this.SourceType != null && ec.Excludes("sourceType",true))
        {
            this.SourceType = null;
        }
        //      C# -> MongoSourceStatus? Status
        // GraphQL -> status: MongoSourceStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new MongoSourceStatus();

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
        //      C# -> System.Int32? ActiveCollectionCount
        // GraphQL -> activeCollectionCount: Int! (scalar)
        if (ec.Includes("activeCollectionCount",true))
        {
            if(this.ActiveCollectionCount == null) {

                this.ActiveCollectionCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ActiveCollectionCount != null && ec.Excludes("activeCollectionCount",true))
        {
            this.ActiveCollectionCount = null;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
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
        //      C# -> DateTime? LastRefreshTime
        // GraphQL -> lastRefreshTime: DateTime (scalar)
        if (ec.Includes("lastRefreshTime",true))
        {
            if(this.LastRefreshTime == null) {

                this.LastRefreshTime = new DateTime();

            } else {


            }
        }
        else if (this.LastRefreshTime != null && ec.Excludes("lastRefreshTime",true))
        {
            this.LastRefreshTime = null;
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
        //      C# -> System.String? PrimaryClusterUuid
        // GraphQL -> primaryClusterUuid: UUID! (scalar)
        if (ec.Includes("primaryClusterUuid",true))
        {
            if(this.PrimaryClusterUuid == null) {

                this.PrimaryClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterUuid != null && ec.Excludes("primaryClusterUuid",true))
        {
            this.PrimaryClusterUuid = null;
        }
        //      C# -> System.Int32? ProtectedCollectionCount
        // GraphQL -> protectedCollectionCount: Int! (scalar)
        if (ec.Includes("protectedCollectionCount",true))
        {
            if(this.ProtectedCollectionCount == null) {

                this.ProtectedCollectionCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ProtectedCollectionCount != null && ec.Excludes("protectedCollectionCount",true))
        {
            this.ProtectedCollectionCount = null;
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
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (ec.Includes("username",true))
        {
            if(this.Username == null) {

                this.Username = "FETCH";

            } else {


            }
        }
        else if (this.Username != null && ec.Excludes("username",true))
        {
            this.Username = null;
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
        //      C# -> PhysicalHostConnection? DataHosts
        // GraphQL -> dataHosts: PhysicalHostConnection! (type)
        if (ec.Includes("dataHosts",false))
        {
            if(this.DataHosts == null) {

                this.DataHosts = new PhysicalHostConnection();
                this.DataHosts.ApplyExploratoryFieldSpec(ec.NewChild("dataHosts"));

            } else {

                this.DataHosts.ApplyExploratoryFieldSpec(ec.NewChild("dataHosts"));

            }
        }
        else if (this.DataHosts != null && ec.Excludes("dataHosts",false))
        {
            this.DataHosts = null;
        }
        //      C# -> MongoSourceDescendantTypeConnection? DescendantConnection
        // GraphQL -> descendantConnection: MongoSourceDescendantTypeConnection! (type)
        if (ec.Includes("descendantConnection",false))
        {
            if(this.DescendantConnection == null) {

                this.DescendantConnection = new MongoSourceDescendantTypeConnection();
                this.DescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("descendantConnection"));

            } else {

                this.DescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("descendantConnection"));

            }
        }
        else if (this.DescendantConnection != null && ec.Excludes("descendantConnection",false))
        {
            this.DescendantConnection = null;
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
        //      C# -> List<CdmMongoNode>? IgnoreSecondaryNodes
        // GraphQL -> ignoreSecondaryNodes: [CdmMongoNode!] (type)
        if (ec.Includes("ignoreSecondaryNodes",false))
        {
            if(this.IgnoreSecondaryNodes == null) {

                this.IgnoreSecondaryNodes = new List<CdmMongoNode>();
                this.IgnoreSecondaryNodes.ApplyExploratoryFieldSpec(ec.NewChild("ignoreSecondaryNodes"));

            } else {

                this.IgnoreSecondaryNodes.ApplyExploratoryFieldSpec(ec.NewChild("ignoreSecondaryNodes"));

            }
        }
        else if (this.IgnoreSecondaryNodes != null && ec.Excludes("ignoreSecondaryNodes",false))
        {
            this.IgnoreSecondaryNodes = null;
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
        //      C# -> MongoSourcePhysicalChildTypeConnection? PhysicalChildConnection
        // GraphQL -> physicalChildConnection: MongoSourcePhysicalChildTypeConnection! (type)
        if (ec.Includes("physicalChildConnection",false))
        {
            if(this.PhysicalChildConnection == null) {

                this.PhysicalChildConnection = new MongoSourcePhysicalChildTypeConnection();
                this.PhysicalChildConnection.ApplyExploratoryFieldSpec(ec.NewChild("physicalChildConnection"));

            } else {

                this.PhysicalChildConnection.ApplyExploratoryFieldSpec(ec.NewChild("physicalChildConnection"));

            }
        }
        else if (this.PhysicalChildConnection != null && ec.Excludes("physicalChildConnection",false))
        {
            this.PhysicalChildConnection = null;
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
        //      C# -> List<CdmMongoNode>? SourceNodes
        // GraphQL -> sourceNodes: [CdmMongoNode!]! (type)
        if (ec.Includes("sourceNodes",false))
        {
            if(this.SourceNodes == null) {

                this.SourceNodes = new List<CdmMongoNode>();
                this.SourceNodes.ApplyExploratoryFieldSpec(ec.NewChild("sourceNodes"));

            } else {

                this.SourceNodes.ApplyExploratoryFieldSpec(ec.NewChild("sourceNodes"));

            }
        }
        else if (this.SourceNodes != null && ec.Excludes("sourceNodes",false))
        {
            this.SourceNodes = null;
        }
        //      C# -> CdmMongoSslParams? SslParams
        // GraphQL -> sslParams: CdmMongoSslParams (type)
        if (ec.Includes("sslParams",false))
        {
            if(this.SslParams == null) {

                this.SslParams = new CdmMongoSslParams();
                this.SslParams.ApplyExploratoryFieldSpec(ec.NewChild("sslParams"));

            } else {

                this.SslParams.ApplyExploratoryFieldSpec(ec.NewChild("sslParams"));

            }
        }
        else if (this.SslParams != null && ec.Excludes("sslParams",false))
        {
            this.SslParams = null;
        }
    }


    #endregion

    } // class MongoSource
    
    #endregion

    public static class ListMongoSourceExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<MongoSource> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MongoSource> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MongoSource> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MongoSource());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MongoSource> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types