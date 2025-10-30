// PhysicalHost.cs
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
    #region PhysicalHost
 
    public class PhysicalHost: BaseType, CdmHierarchyObject, Db2InstanceDescendantType, Db2InstancePhysicalChildType, HierarchyObject, MssqlTopLevelDescendantType
    {
        #region members

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> PendingObjectPauseAssignmentStatus? CdmPendingObjectPauseAssignment
        // GraphQL -> cdmPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus (enum)
        [JsonProperty("cdmPendingObjectPauseAssignment")]
        public PendingObjectPauseAssignmentStatus? CdmPendingObjectPauseAssignment { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> GuestOsType? OsType
        // GraphQL -> osType: GuestOsType (enum)
        [JsonProperty("osType")]
        public GuestOsType? OsType { get; set; }

        //      C# -> RbsUpgradeStatus? RbsUpgradeStatus
        // GraphQL -> rbsUpgradeStatus: RbsUpgradeStatus! (enum)
        [JsonProperty("rbsUpgradeStatus")]
        public RbsUpgradeStatus? RbsUpgradeStatus { get; set; }

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

        //      C# -> System.String? AdDomain
        // GraphQL -> adDomain: String (scalar)
        [JsonProperty("adDomain")]
        public System.String? AdDomain { get; set; }

        //      C# -> System.String? AgentId
        // GraphQL -> agentId: String (scalar)
        [JsonProperty("agentId")]
        public System.String? AgentId { get; set; }

        //      C# -> System.String? CbtStatus
        // GraphQL -> cbtStatus: String (scalar)
        [JsonProperty("cbtStatus")]
        public System.String? CbtStatus { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        [JsonProperty("cdmLink")]
        public System.String? CdmLink { get; set; }

        //      C# -> System.Boolean? DefaultCbt
        // GraphQL -> defaultCbt: Boolean (scalar)
        [JsonProperty("defaultCbt")]
        public System.Boolean? DefaultCbt { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        [JsonProperty("ipAddresses")]
        public List<System.String>? IpAddresses { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsChangelistEnabled
        // GraphQL -> isChangelistEnabled: Boolean! (scalar)
        [JsonProperty("isChangelistEnabled")]
        public System.Boolean? IsChangelistEnabled { get; set; }

        //      C# -> System.Boolean? IsExchangeHost
        // GraphQL -> isExchangeHost: Boolean! (scalar)
        [JsonProperty("isExchangeHost")]
        public System.Boolean? IsExchangeHost { get; set; }

        //      C# -> System.Boolean? IsMssqlHost
        // GraphQL -> isMssqlHost: Boolean! (scalar)
        [JsonProperty("isMssqlHost")]
        public System.Boolean? IsMssqlHost { get; set; }

        //      C# -> System.Boolean? IsOracleHost
        // GraphQL -> isOracleHost: Boolean! (scalar)
        [JsonProperty("isOracleHost")]
        public System.Boolean? IsOracleHost { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NasApiEndpoint
        // GraphQL -> nasApiEndpoint: String (scalar)
        [JsonProperty("nasApiEndpoint")]
        public System.String? NasApiEndpoint { get; set; }

        //      C# -> System.String? NasApiHostname
        // GraphQL -> nasApiHostname: String (scalar)
        [JsonProperty("nasApiHostname")]
        public System.String? NasApiHostname { get; set; }

        //      C# -> System.String? NasMigrationInfo
        // GraphQL -> nasMigrationInfo: String (scalar)
        [JsonProperty("nasMigrationInfo")]
        public System.String? NasMigrationInfo { get; set; }

        //      C# -> System.String? NasVendorType
        // GraphQL -> nasVendorType: String (scalar)
        [JsonProperty("nasVendorType")]
        public System.String? NasVendorType { get; set; }

        //      C# -> System.String? NetworkThrottle
        // GraphQL -> networkThrottle: String! (scalar)
        [JsonProperty("networkThrottle")]
        public System.String? NetworkThrottle { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.String? OsName
        // GraphQL -> osName: String (scalar)
        [JsonProperty("osName")]
        public System.String? OsName { get; set; }

        //      C# -> System.String? RbaPackageUpgradeInfo
        // GraphQL -> rbaPackageUpgradeInfo: String (scalar)
        [JsonProperty("rbaPackageUpgradeInfo")]
        public System.String? RbaPackageUpgradeInfo { get; set; }

        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        [JsonProperty("replicatedObjectCount")]
        public System.Int32? ReplicatedObjectCount { get; set; }

        //      C# -> System.String? ResourceInfo
        // GraphQL -> resourceInfo: String (scalar)
        [JsonProperty("resourceInfo")]
        public System.String? ResourceInfo { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.String? VfdState
        // GraphQL -> vfdState: String! (scalar)
        [JsonProperty("vfdState")]
        public System.String? VfdState { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> List<AssignedRscTag>? AllTags
        // GraphQL -> allTags: [AssignedRscTag!]! (type)
        [JsonProperty("allTags")]
        public List<AssignedRscTag>? AllTags { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> HostConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: HostConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public HostConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> List<CrossAccountReplicatedObjectInfo>? CrossAccountReplicatedObjectInfos
        // GraphQL -> crossAccountReplicatedObjectInfos: [CrossAccountReplicatedObjectInfo!] (type)
        [JsonProperty("crossAccountReplicatedObjectInfos")]
        public List<CrossAccountReplicatedObjectInfo>? CrossAccountReplicatedObjectInfos { get; set; }

        //      C# -> PhysicalHostDescendantTypeConnection? DescendantConnection
        // GraphQL -> descendantConnection: PhysicalHostDescendantTypeConnection! (type)
        [JsonProperty("descendantConnection")]
        public PhysicalHostDescendantTypeConnection? DescendantConnection { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> List<CdmHostVolume>? HostVolumes
        // GraphQL -> hostVolumes: [CdmHostVolume!]! (type)
        [JsonProperty("hostVolumes")]
        public List<CdmHostVolume>? HostVolumes { get; set; }

        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        [JsonProperty("latestUserNote")]
        public LatestUserNote? LatestUserNote { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> MssqlSddDetail? MssqlSddDetail
        // GraphQL -> mssqlSddDetail: MssqlSddDetail (type)
        [JsonProperty("mssqlSddDetail")]
        public MssqlSddDetail? MssqlSddDetail { get; set; }

        //      C# -> ObjectPauseStatus? ObjectPauseStatus
        // GraphQL -> objectPauseStatus: ObjectPauseStatus (type)
        [JsonProperty("objectPauseStatus")]
        public ObjectPauseStatus? ObjectPauseStatus { get; set; }

        //      C# -> OracleSddDetail? OracleSddDetail
        // GraphQL -> oracleSddDetail: OracleSddDetail (type)
        [JsonProperty("oracleSddDetail")]
        public OracleSddDetail? OracleSddDetail { get; set; }

        //      C# -> OracleSettings? OracleSettings
        // GraphQL -> oracleSettings: OracleSettings (type)
        [JsonProperty("oracleSettings")]
        public OracleSettings? OracleSettings { get; set; }

        //      C# -> OracleUserDetails? OracleUserDetails
        // GraphQL -> oracleUserDetails: OracleUserDetails (type)
        [JsonProperty("oracleUserDetails")]
        public OracleUserDetails? OracleUserDetails { get; set; }

        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        [JsonProperty("pendingObjectDeletionStatus")]
        public PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus { get; set; }

        //      C# -> PhysicalHostPhysicalChildTypeConnection? PhysicalChildConnection
        // GraphQL -> physicalChildConnection: PhysicalHostPhysicalChildTypeConnection! (type)
        [JsonProperty("physicalChildConnection")]
        public PhysicalHostPhysicalChildTypeConnection? PhysicalChildConnection { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        [JsonProperty("primaryClusterLocation")]
        public DataLocation? PrimaryClusterLocation { get; set; }

        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        [JsonProperty("securityMetadata")]
        public SecurityMetadata? SecurityMetadata { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars NumWorkloadDescendants { get; set; }

        public RscGqlVars DescendantConnection { get; set; }

        public RscGqlVars PhysicalChildConnection { get; set; }


        public InlineVars() {
            Tuple<string, string>[] numWorkloadDescendantsArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("objectTypes", "[ManagedObjectType!]"),
                };
            this.NumWorkloadDescendants =
                new RscGqlVars(null, numWorkloadDescendantsArgs, null, true);
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

    public PhysicalHost()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "PhysicalHost";
    }

    public PhysicalHost Set(
        List<Operation>? AuthorizedOperations = null,
        PendingObjectPauseAssignmentStatus? CdmPendingObjectPauseAssignment = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        GuestOsType? OsType = null,
        RbsUpgradeStatus? RbsUpgradeStatus = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        SlaDomain? PendingSla = null,
        List<CdmHierarchyObject>? ReplicatedObjects = null,
        System.String? AdDomain = null,
        System.String? AgentId = null,
        System.String? CbtStatus = null,
        System.String? CdmId = null,
        System.String? CdmLink = null,
        System.Boolean? DefaultCbt = null,
        System.String? Id = null,
        List<System.String>? IpAddresses = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsChangelistEnabled = null,
        System.Boolean? IsExchangeHost = null,
        System.Boolean? IsMssqlHost = null,
        System.Boolean? IsOracleHost = null,
        System.String? Name = null,
        System.String? NasApiEndpoint = null,
        System.String? NasApiHostname = null,
        System.String? NasMigrationInfo = null,
        System.String? NasVendorType = null,
        System.String? NetworkThrottle = null,
        System.Int32? NumWorkloadDescendants = null,
        System.String? OsName = null,
        System.String? RbaPackageUpgradeInfo = null,
        System.Int32? ReplicatedObjectCount = null,
        System.String? ResourceInfo = null,
        System.Boolean? SlaPauseStatus = null,
        System.String? VfdState = null,
        List<Org>? AllOrgs = null,
        List<AssignedRscTag>? AllTags = null,
        Cluster? Cluster = null,
        HostConnectionStatus? ConnectionStatus = null,
        List<CrossAccountReplicatedObjectInfo>? CrossAccountReplicatedObjectInfos = null,
        PhysicalHostDescendantTypeConnection? DescendantConnection = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<CdmHostVolume>? HostVolumes = null,
        LatestUserNote? LatestUserNote = null,
        List<PathNode>? LogicalPath = null,
        MssqlSddDetail? MssqlSddDetail = null,
        ObjectPauseStatus? ObjectPauseStatus = null,
        OracleSddDetail? OracleSddDetail = null,
        OracleSettings? OracleSettings = null,
        OracleUserDetails? OracleUserDetails = null,
        PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus = null,
        PhysicalHostPhysicalChildTypeConnection? PhysicalChildConnection = null,
        List<PathNode>? PhysicalPath = null,
        DataLocation? PrimaryClusterLocation = null,
        SecurityMetadata? SecurityMetadata = null,
        SnapshotDistribution? SnapshotDistribution = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( CdmPendingObjectPauseAssignment != null ) {
            this.CdmPendingObjectPauseAssignment = CdmPendingObjectPauseAssignment;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( RbsUpgradeStatus != null ) {
            this.RbsUpgradeStatus = RbsUpgradeStatus;
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
        if ( AdDomain != null ) {
            this.AdDomain = AdDomain;
        }
        if ( AgentId != null ) {
            this.AgentId = AgentId;
        }
        if ( CbtStatus != null ) {
            this.CbtStatus = CbtStatus;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( CdmLink != null ) {
            this.CdmLink = CdmLink;
        }
        if ( DefaultCbt != null ) {
            this.DefaultCbt = DefaultCbt;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IpAddresses != null ) {
            this.IpAddresses = IpAddresses;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsChangelistEnabled != null ) {
            this.IsChangelistEnabled = IsChangelistEnabled;
        }
        if ( IsExchangeHost != null ) {
            this.IsExchangeHost = IsExchangeHost;
        }
        if ( IsMssqlHost != null ) {
            this.IsMssqlHost = IsMssqlHost;
        }
        if ( IsOracleHost != null ) {
            this.IsOracleHost = IsOracleHost;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NasApiEndpoint != null ) {
            this.NasApiEndpoint = NasApiEndpoint;
        }
        if ( NasApiHostname != null ) {
            this.NasApiHostname = NasApiHostname;
        }
        if ( NasMigrationInfo != null ) {
            this.NasMigrationInfo = NasMigrationInfo;
        }
        if ( NasVendorType != null ) {
            this.NasVendorType = NasVendorType;
        }
        if ( NetworkThrottle != null ) {
            this.NetworkThrottle = NetworkThrottle;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( OsName != null ) {
            this.OsName = OsName;
        }
        if ( RbaPackageUpgradeInfo != null ) {
            this.RbaPackageUpgradeInfo = RbaPackageUpgradeInfo;
        }
        if ( ReplicatedObjectCount != null ) {
            this.ReplicatedObjectCount = ReplicatedObjectCount;
        }
        if ( ResourceInfo != null ) {
            this.ResourceInfo = ResourceInfo;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( VfdState != null ) {
            this.VfdState = VfdState;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( AllTags != null ) {
            this.AllTags = AllTags;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( CrossAccountReplicatedObjectInfos != null ) {
            this.CrossAccountReplicatedObjectInfos = CrossAccountReplicatedObjectInfos;
        }
        if ( DescendantConnection != null ) {
            this.DescendantConnection = DescendantConnection;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( HostVolumes != null ) {
            this.HostVolumes = HostVolumes;
        }
        if ( LatestUserNote != null ) {
            this.LatestUserNote = LatestUserNote;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( MssqlSddDetail != null ) {
            this.MssqlSddDetail = MssqlSddDetail;
        }
        if ( ObjectPauseStatus != null ) {
            this.ObjectPauseStatus = ObjectPauseStatus;
        }
        if ( OracleSddDetail != null ) {
            this.OracleSddDetail = OracleSddDetail;
        }
        if ( OracleSettings != null ) {
            this.OracleSettings = OracleSettings;
        }
        if ( OracleUserDetails != null ) {
            this.OracleUserDetails = OracleUserDetails;
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
        if ( SecurityMetadata != null ) {
            this.SecurityMetadata = SecurityMetadata;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
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
        //      C# -> PendingObjectPauseAssignmentStatus? CdmPendingObjectPauseAssignment
        // GraphQL -> cdmPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus (enum)
        if (this.CdmPendingObjectPauseAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmPendingObjectPauseAssignment\n" ;
            } else {
                s += ind + "cdmPendingObjectPauseAssignment\n" ;
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
        //      C# -> RbsUpgradeStatus? RbsUpgradeStatus
        // GraphQL -> rbsUpgradeStatus: RbsUpgradeStatus! (enum)
        if (this.RbsUpgradeStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rbsUpgradeStatus\n" ;
            } else {
                s += ind + "rbsUpgradeStatus\n" ;
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
        //      C# -> System.String? AdDomain
        // GraphQL -> adDomain: String (scalar)
        if (this.AdDomain != null) {
            if (conf.Flat) {
                s += conf.Prefix + "adDomain\n" ;
            } else {
                s += ind + "adDomain\n" ;
            }
        }
        //      C# -> System.String? AgentId
        // GraphQL -> agentId: String (scalar)
        if (this.AgentId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "agentId\n" ;
            } else {
                s += ind + "agentId\n" ;
            }
        }
        //      C# -> System.String? CbtStatus
        // GraphQL -> cbtStatus: String (scalar)
        if (this.CbtStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cbtStatus\n" ;
            } else {
                s += ind + "cbtStatus\n" ;
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
        //      C# -> System.Boolean? DefaultCbt
        // GraphQL -> defaultCbt: Boolean (scalar)
        if (this.DefaultCbt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultCbt\n" ;
            } else {
                s += ind + "defaultCbt\n" ;
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
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (this.IpAddresses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipAddresses\n" ;
            } else {
                s += ind + "ipAddresses\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.Boolean? IsChangelistEnabled
        // GraphQL -> isChangelistEnabled: Boolean! (scalar)
        if (this.IsChangelistEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isChangelistEnabled\n" ;
            } else {
                s += ind + "isChangelistEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsExchangeHost
        // GraphQL -> isExchangeHost: Boolean! (scalar)
        if (this.IsExchangeHost != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExchangeHost\n" ;
            } else {
                s += ind + "isExchangeHost\n" ;
            }
        }
        //      C# -> System.Boolean? IsMssqlHost
        // GraphQL -> isMssqlHost: Boolean! (scalar)
        if (this.IsMssqlHost != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isMssqlHost\n" ;
            } else {
                s += ind + "isMssqlHost\n" ;
            }
        }
        //      C# -> System.Boolean? IsOracleHost
        // GraphQL -> isOracleHost: Boolean! (scalar)
        if (this.IsOracleHost != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isOracleHost\n" ;
            } else {
                s += ind + "isOracleHost\n" ;
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
        //      C# -> System.String? NasApiEndpoint
        // GraphQL -> nasApiEndpoint: String (scalar)
        if (this.NasApiEndpoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nasApiEndpoint\n" ;
            } else {
                s += ind + "nasApiEndpoint\n" ;
            }
        }
        //      C# -> System.String? NasApiHostname
        // GraphQL -> nasApiHostname: String (scalar)
        if (this.NasApiHostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nasApiHostname\n" ;
            } else {
                s += ind + "nasApiHostname\n" ;
            }
        }
        //      C# -> System.String? NasMigrationInfo
        // GraphQL -> nasMigrationInfo: String (scalar)
        if (this.NasMigrationInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nasMigrationInfo\n" ;
            } else {
                s += ind + "nasMigrationInfo\n" ;
            }
        }
        //      C# -> System.String? NasVendorType
        // GraphQL -> nasVendorType: String (scalar)
        if (this.NasVendorType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nasVendorType\n" ;
            } else {
                s += ind + "nasVendorType\n" ;
            }
        }
        //      C# -> System.String? NetworkThrottle
        // GraphQL -> networkThrottle: String! (scalar)
        if (this.NetworkThrottle != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkThrottle\n" ;
            } else {
                s += ind + "networkThrottle\n" ;
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
        //      C# -> System.String? OsName
        // GraphQL -> osName: String (scalar)
        if (this.OsName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osName\n" ;
            } else {
                s += ind + "osName\n" ;
            }
        }
        //      C# -> System.String? RbaPackageUpgradeInfo
        // GraphQL -> rbaPackageUpgradeInfo: String (scalar)
        if (this.RbaPackageUpgradeInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rbaPackageUpgradeInfo\n" ;
            } else {
                s += ind + "rbaPackageUpgradeInfo\n" ;
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
        //      C# -> System.String? ResourceInfo
        // GraphQL -> resourceInfo: String (scalar)
        if (this.ResourceInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceInfo\n" ;
            } else {
                s += ind + "resourceInfo\n" ;
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
        //      C# -> System.String? VfdState
        // GraphQL -> vfdState: String! (scalar)
        if (this.VfdState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vfdState\n" ;
            } else {
                s += ind + "vfdState\n" ;
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
        //      C# -> List<AssignedRscTag>? AllTags
        // GraphQL -> allTags: [AssignedRscTag!]! (type)
        if (this.AllTags != null) {
            var fspec = this.AllTags.AsFieldSpec(conf.Child("allTags"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "allTags" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> HostConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: HostConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(conf.Child("connectionStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "connectionStatus" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> PhysicalHostDescendantTypeConnection? DescendantConnection
        // GraphQL -> descendantConnection: PhysicalHostDescendantTypeConnection! (type)
        if (this.DescendantConnection != null) {
            var fspec = this.DescendantConnection.AsFieldSpec(conf.Child("descendantConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaSourceObject" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CdmHostVolume>? HostVolumes
        // GraphQL -> hostVolumes: [CdmHostVolume!]! (type)
        if (this.HostVolumes != null) {
            var fspec = this.HostVolumes.AsFieldSpec(conf.Child("hostVolumes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hostVolumes" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> MssqlSddDetail? MssqlSddDetail
        // GraphQL -> mssqlSddDetail: MssqlSddDetail (type)
        if (this.MssqlSddDetail != null) {
            var fspec = this.MssqlSddDetail.AsFieldSpec(conf.Child("mssqlSddDetail"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mssqlSddDetail" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ObjectPauseStatus? ObjectPauseStatus
        // GraphQL -> objectPauseStatus: ObjectPauseStatus (type)
        if (this.ObjectPauseStatus != null) {
            var fspec = this.ObjectPauseStatus.AsFieldSpec(conf.Child("objectPauseStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectPauseStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleSddDetail? OracleSddDetail
        // GraphQL -> oracleSddDetail: OracleSddDetail (type)
        if (this.OracleSddDetail != null) {
            var fspec = this.OracleSddDetail.AsFieldSpec(conf.Child("oracleSddDetail"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oracleSddDetail" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleSettings? OracleSettings
        // GraphQL -> oracleSettings: OracleSettings (type)
        if (this.OracleSettings != null) {
            var fspec = this.OracleSettings.AsFieldSpec(conf.Child("oracleSettings"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oracleSettings" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OracleUserDetails? OracleUserDetails
        // GraphQL -> oracleUserDetails: OracleUserDetails (type)
        if (this.OracleUserDetails != null) {
            var fspec = this.OracleUserDetails.AsFieldSpec(conf.Child("oracleUserDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "oracleUserDetails" + " " + "{\n" + fspec + ind + "}\n" ;
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
        //      C# -> PhysicalHostPhysicalChildTypeConnection? PhysicalChildConnection
        // GraphQL -> physicalChildConnection: PhysicalHostPhysicalChildTypeConnection! (type)
        if (this.PhysicalChildConnection != null) {
            var fspec = this.PhysicalChildConnection.AsFieldSpec(conf.Child("physicalChildConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
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
        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        if (this.SecurityMetadata != null) {
            var fspec = this.SecurityMetadata.AsFieldSpec(conf.Child("securityMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "securityMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        //      C# -> PendingObjectPauseAssignmentStatus? CdmPendingObjectPauseAssignment
        // GraphQL -> cdmPendingObjectPauseAssignment: PendingObjectPauseAssignmentStatus (enum)
        if (ec.Includes("cdmPendingObjectPauseAssignment",true))
        {
            if(this.CdmPendingObjectPauseAssignment == null) {

                this.CdmPendingObjectPauseAssignment = new PendingObjectPauseAssignmentStatus();

            } else {


            }
        }
        else if (this.CdmPendingObjectPauseAssignment != null && ec.Excludes("cdmPendingObjectPauseAssignment",true))
        {
            this.CdmPendingObjectPauseAssignment = null;
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
        //      C# -> RbsUpgradeStatus? RbsUpgradeStatus
        // GraphQL -> rbsUpgradeStatus: RbsUpgradeStatus! (enum)
        if (ec.Includes("rbsUpgradeStatus",true))
        {
            if(this.RbsUpgradeStatus == null) {

                this.RbsUpgradeStatus = new RbsUpgradeStatus();

            } else {


            }
        }
        else if (this.RbsUpgradeStatus != null && ec.Excludes("rbsUpgradeStatus",true))
        {
            this.RbsUpgradeStatus = null;
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
        //      C# -> System.String? AdDomain
        // GraphQL -> adDomain: String (scalar)
        if (ec.Includes("adDomain",true))
        {
            if(this.AdDomain == null) {

                this.AdDomain = "FETCH";

            } else {


            }
        }
        else if (this.AdDomain != null && ec.Excludes("adDomain",true))
        {
            this.AdDomain = null;
        }
        //      C# -> System.String? AgentId
        // GraphQL -> agentId: String (scalar)
        if (ec.Includes("agentId",true))
        {
            if(this.AgentId == null) {

                this.AgentId = "FETCH";

            } else {


            }
        }
        else if (this.AgentId != null && ec.Excludes("agentId",true))
        {
            this.AgentId = null;
        }
        //      C# -> System.String? CbtStatus
        // GraphQL -> cbtStatus: String (scalar)
        if (ec.Includes("cbtStatus",true))
        {
            if(this.CbtStatus == null) {

                this.CbtStatus = "FETCH";

            } else {


            }
        }
        else if (this.CbtStatus != null && ec.Excludes("cbtStatus",true))
        {
            this.CbtStatus = null;
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
        //      C# -> System.Boolean? DefaultCbt
        // GraphQL -> defaultCbt: Boolean (scalar)
        if (ec.Includes("defaultCbt",true))
        {
            if(this.DefaultCbt == null) {

                this.DefaultCbt = true;

            } else {


            }
        }
        else if (this.DefaultCbt != null && ec.Excludes("defaultCbt",true))
        {
            this.DefaultCbt = null;
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
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (ec.Includes("ipAddresses",true))
        {
            if(this.IpAddresses == null) {

                this.IpAddresses = new List<System.String>();

            } else {


            }
        }
        else if (this.IpAddresses != null && ec.Excludes("ipAddresses",true))
        {
            this.IpAddresses = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.Boolean? IsChangelistEnabled
        // GraphQL -> isChangelistEnabled: Boolean! (scalar)
        if (ec.Includes("isChangelistEnabled",true))
        {
            if(this.IsChangelistEnabled == null) {

                this.IsChangelistEnabled = true;

            } else {


            }
        }
        else if (this.IsChangelistEnabled != null && ec.Excludes("isChangelistEnabled",true))
        {
            this.IsChangelistEnabled = null;
        }
        //      C# -> System.Boolean? IsExchangeHost
        // GraphQL -> isExchangeHost: Boolean! (scalar)
        if (ec.Includes("isExchangeHost",true))
        {
            if(this.IsExchangeHost == null) {

                this.IsExchangeHost = true;

            } else {


            }
        }
        else if (this.IsExchangeHost != null && ec.Excludes("isExchangeHost",true))
        {
            this.IsExchangeHost = null;
        }
        //      C# -> System.Boolean? IsMssqlHost
        // GraphQL -> isMssqlHost: Boolean! (scalar)
        if (ec.Includes("isMssqlHost",true))
        {
            if(this.IsMssqlHost == null) {

                this.IsMssqlHost = true;

            } else {


            }
        }
        else if (this.IsMssqlHost != null && ec.Excludes("isMssqlHost",true))
        {
            this.IsMssqlHost = null;
        }
        //      C# -> System.Boolean? IsOracleHost
        // GraphQL -> isOracleHost: Boolean! (scalar)
        if (ec.Includes("isOracleHost",true))
        {
            if(this.IsOracleHost == null) {

                this.IsOracleHost = true;

            } else {


            }
        }
        else if (this.IsOracleHost != null && ec.Excludes("isOracleHost",true))
        {
            this.IsOracleHost = null;
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
        //      C# -> System.String? NasApiEndpoint
        // GraphQL -> nasApiEndpoint: String (scalar)
        if (ec.Includes("nasApiEndpoint",true))
        {
            if(this.NasApiEndpoint == null) {

                this.NasApiEndpoint = "FETCH";

            } else {


            }
        }
        else if (this.NasApiEndpoint != null && ec.Excludes("nasApiEndpoint",true))
        {
            this.NasApiEndpoint = null;
        }
        //      C# -> System.String? NasApiHostname
        // GraphQL -> nasApiHostname: String (scalar)
        if (ec.Includes("nasApiHostname",true))
        {
            if(this.NasApiHostname == null) {

                this.NasApiHostname = "FETCH";

            } else {


            }
        }
        else if (this.NasApiHostname != null && ec.Excludes("nasApiHostname",true))
        {
            this.NasApiHostname = null;
        }
        //      C# -> System.String? NasMigrationInfo
        // GraphQL -> nasMigrationInfo: String (scalar)
        if (ec.Includes("nasMigrationInfo",true))
        {
            if(this.NasMigrationInfo == null) {

                this.NasMigrationInfo = "FETCH";

            } else {


            }
        }
        else if (this.NasMigrationInfo != null && ec.Excludes("nasMigrationInfo",true))
        {
            this.NasMigrationInfo = null;
        }
        //      C# -> System.String? NasVendorType
        // GraphQL -> nasVendorType: String (scalar)
        if (ec.Includes("nasVendorType",true))
        {
            if(this.NasVendorType == null) {

                this.NasVendorType = "FETCH";

            } else {


            }
        }
        else if (this.NasVendorType != null && ec.Excludes("nasVendorType",true))
        {
            this.NasVendorType = null;
        }
        //      C# -> System.String? NetworkThrottle
        // GraphQL -> networkThrottle: String! (scalar)
        if (ec.Includes("networkThrottle",true))
        {
            if(this.NetworkThrottle == null) {

                this.NetworkThrottle = "FETCH";

            } else {


            }
        }
        else if (this.NetworkThrottle != null && ec.Excludes("networkThrottle",true))
        {
            this.NetworkThrottle = null;
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
        //      C# -> System.String? OsName
        // GraphQL -> osName: String (scalar)
        if (ec.Includes("osName",true))
        {
            if(this.OsName == null) {

                this.OsName = "FETCH";

            } else {


            }
        }
        else if (this.OsName != null && ec.Excludes("osName",true))
        {
            this.OsName = null;
        }
        //      C# -> System.String? RbaPackageUpgradeInfo
        // GraphQL -> rbaPackageUpgradeInfo: String (scalar)
        if (ec.Includes("rbaPackageUpgradeInfo",true))
        {
            if(this.RbaPackageUpgradeInfo == null) {

                this.RbaPackageUpgradeInfo = "FETCH";

            } else {


            }
        }
        else if (this.RbaPackageUpgradeInfo != null && ec.Excludes("rbaPackageUpgradeInfo",true))
        {
            this.RbaPackageUpgradeInfo = null;
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
        //      C# -> System.String? ResourceInfo
        // GraphQL -> resourceInfo: String (scalar)
        if (ec.Includes("resourceInfo",true))
        {
            if(this.ResourceInfo == null) {

                this.ResourceInfo = "FETCH";

            } else {


            }
        }
        else if (this.ResourceInfo != null && ec.Excludes("resourceInfo",true))
        {
            this.ResourceInfo = null;
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
        //      C# -> System.String? VfdState
        // GraphQL -> vfdState: String! (scalar)
        if (ec.Includes("vfdState",true))
        {
            if(this.VfdState == null) {

                this.VfdState = "FETCH";

            } else {


            }
        }
        else if (this.VfdState != null && ec.Excludes("vfdState",true))
        {
            this.VfdState = null;
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
        //      C# -> List<AssignedRscTag>? AllTags
        // GraphQL -> allTags: [AssignedRscTag!]! (type)
        if (ec.Includes("allTags",false))
        {
            if(this.AllTags == null) {

                this.AllTags = new List<AssignedRscTag>();
                this.AllTags.ApplyExploratoryFieldSpec(ec.NewChild("allTags"));

            } else {

                this.AllTags.ApplyExploratoryFieldSpec(ec.NewChild("allTags"));

            }
        }
        else if (this.AllTags != null && ec.Excludes("allTags",false))
        {
            this.AllTags = null;
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
        //      C# -> HostConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: HostConnectionStatus (type)
        if (ec.Includes("connectionStatus",false))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new HostConnectionStatus();
                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            } else {

                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",false))
        {
            this.ConnectionStatus = null;
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
        //      C# -> PhysicalHostDescendantTypeConnection? DescendantConnection
        // GraphQL -> descendantConnection: PhysicalHostDescendantTypeConnection! (type)
        if (ec.Includes("descendantConnection",false))
        {
            if(this.DescendantConnection == null) {

                this.DescendantConnection = new PhysicalHostDescendantTypeConnection();
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
        //      C# -> List<CdmHostVolume>? HostVolumes
        // GraphQL -> hostVolumes: [CdmHostVolume!]! (type)
        if (ec.Includes("hostVolumes",false))
        {
            if(this.HostVolumes == null) {

                this.HostVolumes = new List<CdmHostVolume>();
                this.HostVolumes.ApplyExploratoryFieldSpec(ec.NewChild("hostVolumes"));

            } else {

                this.HostVolumes.ApplyExploratoryFieldSpec(ec.NewChild("hostVolumes"));

            }
        }
        else if (this.HostVolumes != null && ec.Excludes("hostVolumes",false))
        {
            this.HostVolumes = null;
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
        //      C# -> MssqlSddDetail? MssqlSddDetail
        // GraphQL -> mssqlSddDetail: MssqlSddDetail (type)
        if (ec.Includes("mssqlSddDetail",false))
        {
            if(this.MssqlSddDetail == null) {

                this.MssqlSddDetail = new MssqlSddDetail();
                this.MssqlSddDetail.ApplyExploratoryFieldSpec(ec.NewChild("mssqlSddDetail"));

            } else {

                this.MssqlSddDetail.ApplyExploratoryFieldSpec(ec.NewChild("mssqlSddDetail"));

            }
        }
        else if (this.MssqlSddDetail != null && ec.Excludes("mssqlSddDetail",false))
        {
            this.MssqlSddDetail = null;
        }
        //      C# -> ObjectPauseStatus? ObjectPauseStatus
        // GraphQL -> objectPauseStatus: ObjectPauseStatus (type)
        if (ec.Includes("objectPauseStatus",false))
        {
            if(this.ObjectPauseStatus == null) {

                this.ObjectPauseStatus = new ObjectPauseStatus();
                this.ObjectPauseStatus.ApplyExploratoryFieldSpec(ec.NewChild("objectPauseStatus"));

            } else {

                this.ObjectPauseStatus.ApplyExploratoryFieldSpec(ec.NewChild("objectPauseStatus"));

            }
        }
        else if (this.ObjectPauseStatus != null && ec.Excludes("objectPauseStatus",false))
        {
            this.ObjectPauseStatus = null;
        }
        //      C# -> OracleSddDetail? OracleSddDetail
        // GraphQL -> oracleSddDetail: OracleSddDetail (type)
        if (ec.Includes("oracleSddDetail",false))
        {
            if(this.OracleSddDetail == null) {

                this.OracleSddDetail = new OracleSddDetail();
                this.OracleSddDetail.ApplyExploratoryFieldSpec(ec.NewChild("oracleSddDetail"));

            } else {

                this.OracleSddDetail.ApplyExploratoryFieldSpec(ec.NewChild("oracleSddDetail"));

            }
        }
        else if (this.OracleSddDetail != null && ec.Excludes("oracleSddDetail",false))
        {
            this.OracleSddDetail = null;
        }
        //      C# -> OracleSettings? OracleSettings
        // GraphQL -> oracleSettings: OracleSettings (type)
        if (ec.Includes("oracleSettings",false))
        {
            if(this.OracleSettings == null) {

                this.OracleSettings = new OracleSettings();
                this.OracleSettings.ApplyExploratoryFieldSpec(ec.NewChild("oracleSettings"));

            } else {

                this.OracleSettings.ApplyExploratoryFieldSpec(ec.NewChild("oracleSettings"));

            }
        }
        else if (this.OracleSettings != null && ec.Excludes("oracleSettings",false))
        {
            this.OracleSettings = null;
        }
        //      C# -> OracleUserDetails? OracleUserDetails
        // GraphQL -> oracleUserDetails: OracleUserDetails (type)
        if (ec.Includes("oracleUserDetails",false))
        {
            if(this.OracleUserDetails == null) {

                this.OracleUserDetails = new OracleUserDetails();
                this.OracleUserDetails.ApplyExploratoryFieldSpec(ec.NewChild("oracleUserDetails"));

            } else {

                this.OracleUserDetails.ApplyExploratoryFieldSpec(ec.NewChild("oracleUserDetails"));

            }
        }
        else if (this.OracleUserDetails != null && ec.Excludes("oracleUserDetails",false))
        {
            this.OracleUserDetails = null;
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
        //      C# -> PhysicalHostPhysicalChildTypeConnection? PhysicalChildConnection
        // GraphQL -> physicalChildConnection: PhysicalHostPhysicalChildTypeConnection! (type)
        if (ec.Includes("physicalChildConnection",false))
        {
            if(this.PhysicalChildConnection == null) {

                this.PhysicalChildConnection = new PhysicalHostPhysicalChildTypeConnection();
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
        //      C# -> SecurityMetadata? SecurityMetadata
        // GraphQL -> securityMetadata: SecurityMetadata (type)
        if (ec.Includes("securityMetadata",false))
        {
            if(this.SecurityMetadata == null) {

                this.SecurityMetadata = new SecurityMetadata();
                this.SecurityMetadata.ApplyExploratoryFieldSpec(ec.NewChild("securityMetadata"));

            } else {

                this.SecurityMetadata.ApplyExploratoryFieldSpec(ec.NewChild("securityMetadata"));

            }
        }
        else if (this.SecurityMetadata != null && ec.Excludes("securityMetadata",false))
        {
            this.SecurityMetadata = null;
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
    }


    #endregion

    } // class PhysicalHost
    
    #endregion

    public static class ListPhysicalHostExtensions
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
            this List<PhysicalHost> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PhysicalHost> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PhysicalHost> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PhysicalHost());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PhysicalHost> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types