// Snappable.cs
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
    #region Snappable
 
    public class Snappable: BaseType, AnomalyResultGroupByInfo, NfAnomalyResultGroupByInfo, RansomwareResultGroupByInfo
    {
        #region members

        //      C# -> ComplianceStatusEnum? ArchivalComplianceStatus
        // GraphQL -> archivalComplianceStatus: ComplianceStatusEnum (enum)
        [JsonProperty("archivalComplianceStatus")]
        public ComplianceStatusEnum? ArchivalComplianceStatus { get; set; }

        //      C# -> ComplianceStatusEnum? ComplianceStatus
        // GraphQL -> complianceStatus: ComplianceStatusEnum (enum)
        [JsonProperty("complianceStatus")]
        public ComplianceStatusEnum? ComplianceStatus { get; set; }

        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public ObjectTypeEnum? ObjectType { get; set; }

        //      C# -> ProtectionStatusEnum? ProtectionStatus
        // GraphQL -> protectionStatus: ProtectionStatusEnum! (enum)
        [JsonProperty("protectionStatus")]
        public ProtectionStatusEnum? ProtectionStatus { get; set; }

        //      C# -> ComplianceStatusEnum? ReplicationComplianceStatus
        // GraphQL -> replicationComplianceStatus: ComplianceStatusEnum (enum)
        [JsonProperty("replicationComplianceStatus")]
        public ComplianceStatusEnum? ReplicationComplianceStatus { get; set; }

        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        [JsonProperty("slaDomain")]
        public SlaDomain? SlaDomain { get; set; }

        //      C# -> System.Int32? ArchivalSnapshotLag
        // GraphQL -> archivalSnapshotLag: Int (scalar)
        [JsonProperty("archivalSnapshotLag")]
        public System.Int32? ArchivalSnapshotLag { get; set; }

        //      C# -> System.Int32? ArchiveSnapshots
        // GraphQL -> archiveSnapshots: Int (scalar)
        [JsonProperty("archiveSnapshots")]
        public System.Int32? ArchiveSnapshots { get; set; }

        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        [JsonProperty("archiveStorage")]
        public System.Int64? ArchiveStorage { get; set; }

        //      C# -> System.Boolean? AwaitingFirstFull
        // GraphQL -> awaitingFirstFull: Boolean (scalar)
        [JsonProperty("awaitingFirstFull")]
        public System.Boolean? AwaitingFirstFull { get; set; }

        //      C# -> System.Single? DataReduction
        // GraphQL -> dataReduction: Float (scalar)
        [JsonProperty("dataReduction")]
        public System.Single? DataReduction { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastSnapshot
        // GraphQL -> lastSnapshot: DateTime (scalar)
        [JsonProperty("lastSnapshot")]
        public DateTime? LastSnapshot { get; set; }

        //      C# -> System.Int64? LastSnapshotLogicalBytes
        // GraphQL -> lastSnapshotLogicalBytes: Long (scalar)
        [JsonProperty("lastSnapshotLogicalBytes")]
        public System.Int64? LastSnapshotLogicalBytes { get; set; }

        //      C# -> DateTime? LatestArchivalSnapshot
        // GraphQL -> latestArchivalSnapshot: DateTime (scalar)
        [JsonProperty("latestArchivalSnapshot")]
        public DateTime? LatestArchivalSnapshot { get; set; }

        //      C# -> DateTime? LatestReplicationSnapshot
        // GraphQL -> latestReplicationSnapshot: DateTime (scalar)
        [JsonProperty("latestReplicationSnapshot")]
        public DateTime? LatestReplicationSnapshot { get; set; }

        //      C# -> System.Int64? LocalEffectiveStorage
        // GraphQL -> localEffectiveStorage: Long (scalar)
        [JsonProperty("localEffectiveStorage")]
        public System.Int64? LocalEffectiveStorage { get; set; }

        //      C# -> System.Int64? LocalMeteredData
        // GraphQL -> localMeteredData: Long (scalar)
        [JsonProperty("localMeteredData")]
        public System.Int64? LocalMeteredData { get; set; }

        //      C# -> System.Int32? LocalOnDemandSnapshots
        // GraphQL -> localOnDemandSnapshots: Int (scalar)
        [JsonProperty("localOnDemandSnapshots")]
        public System.Int32? LocalOnDemandSnapshots { get; set; }

        //      C# -> System.Int64? LocalProtectedData
        // GraphQL -> localProtectedData: Long (scalar)
        [JsonProperty("localProtectedData")]
        public System.Int64? LocalProtectedData { get; set; }

        //      C# -> System.Int32? LocalSlaSnapshots
        // GraphQL -> localSlaSnapshots: Int (scalar)
        [JsonProperty("localSlaSnapshots")]
        public System.Int32? LocalSlaSnapshots { get; set; }

        //      C# -> System.Int32? LocalSnapshots
        // GraphQL -> localSnapshots: Int (scalar)
        [JsonProperty("localSnapshots")]
        public System.Int32? LocalSnapshots { get; set; }

        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        [JsonProperty("localStorage")]
        public System.Int64? LocalStorage { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long (scalar)
        [JsonProperty("logicalBytes")]
        public System.Int64? LogicalBytes { get; set; }

        //      C# -> System.Single? LogicalDataReduction
        // GraphQL -> logicalDataReduction: Float (scalar)
        [JsonProperty("logicalDataReduction")]
        public System.Single? LogicalDataReduction { get; set; }

        //      C# -> System.Int32? MissedSnapshots
        // GraphQL -> missedSnapshots: Int (scalar)
        [JsonProperty("missedSnapshots")]
        public System.Int32? MissedSnapshots { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long (scalar)
        [JsonProperty("physicalBytes")]
        public System.Int64? PhysicalBytes { get; set; }

        //      C# -> DateTime? ProtectedOn
        // GraphQL -> protectedOn: DateTime (scalar)
        [JsonProperty("protectedOn")]
        public DateTime? ProtectedOn { get; set; }

        //      C# -> System.Int64? ProvisionedBytes
        // GraphQL -> provisionedBytes: Long (scalar)
        [JsonProperty("provisionedBytes")]
        public System.Int64? ProvisionedBytes { get; set; }

        //      C# -> DateTime? PullTime
        // GraphQL -> pullTime: DateTime! (scalar)
        [JsonProperty("pullTime")]
        public DateTime? PullTime { get; set; }

        //      C# -> System.Int32? ReplicaSnapshots
        // GraphQL -> replicaSnapshots: Int (scalar)
        [JsonProperty("replicaSnapshots")]
        public System.Int32? ReplicaSnapshots { get; set; }

        //      C# -> System.Int64? ReplicaStorage
        // GraphQL -> replicaStorage: Long (scalar)
        [JsonProperty("replicaStorage")]
        public System.Int64? ReplicaStorage { get; set; }

        //      C# -> System.Int32? ReplicationSnapshotLag
        // GraphQL -> replicationSnapshotLag: Int (scalar)
        [JsonProperty("replicationSnapshotLag")]
        public System.Int32? ReplicationSnapshotLag { get; set; }

        //      C# -> System.Int32? TotalSnapshots
        // GraphQL -> totalSnapshots: Int (scalar)
        [JsonProperty("totalSnapshots")]
        public System.Int32? TotalSnapshots { get; set; }

        //      C# -> System.Int64? TransferredBytes
        // GraphQL -> transferredBytes: Long (scalar)
        [JsonProperty("transferredBytes")]
        public System.Int64? TransferredBytes { get; set; }

        //      C# -> System.Int64? UsedBytes
        // GraphQL -> usedBytes: Long (scalar)
        [JsonProperty("usedBytes")]
        public System.Int64? UsedBytes { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Snappable";
    }

    public Snappable Set(
        ComplianceStatusEnum? ArchivalComplianceStatus = null,
        ComplianceStatusEnum? ComplianceStatus = null,
        ObjectTypeEnum? ObjectType = null,
        ProtectionStatusEnum? ProtectionStatus = null,
        ComplianceStatusEnum? ReplicationComplianceStatus = null,
        SlaDomain? SlaDomain = null,
        System.Int32? ArchivalSnapshotLag = null,
        System.Int32? ArchiveSnapshots = null,
        System.Int64? ArchiveStorage = null,
        System.Boolean? AwaitingFirstFull = null,
        System.Single? DataReduction = null,
        System.String? Fid = null,
        System.String? Id = null,
        DateTime? LastSnapshot = null,
        System.Int64? LastSnapshotLogicalBytes = null,
        DateTime? LatestArchivalSnapshot = null,
        DateTime? LatestReplicationSnapshot = null,
        System.Int64? LocalEffectiveStorage = null,
        System.Int64? LocalMeteredData = null,
        System.Int32? LocalOnDemandSnapshots = null,
        System.Int64? LocalProtectedData = null,
        System.Int32? LocalSlaSnapshots = null,
        System.Int32? LocalSnapshots = null,
        System.Int64? LocalStorage = null,
        System.String? Location = null,
        System.Int64? LogicalBytes = null,
        System.Single? LogicalDataReduction = null,
        System.Int32? MissedSnapshots = null,
        System.String? Name = null,
        System.String? OrgId = null,
        System.String? OrgName = null,
        System.Int64? PhysicalBytes = null,
        DateTime? ProtectedOn = null,
        System.Int64? ProvisionedBytes = null,
        DateTime? PullTime = null,
        System.Int32? ReplicaSnapshots = null,
        System.Int64? ReplicaStorage = null,
        System.Int32? ReplicationSnapshotLag = null,
        System.Int32? TotalSnapshots = null,
        System.Int64? TransferredBytes = null,
        System.Int64? UsedBytes = null,
        Cluster? Cluster = null
    ) 
    {
        if ( ArchivalComplianceStatus != null ) {
            this.ArchivalComplianceStatus = ArchivalComplianceStatus;
        }
        if ( ComplianceStatus != null ) {
            this.ComplianceStatus = ComplianceStatus;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( ProtectionStatus != null ) {
            this.ProtectionStatus = ProtectionStatus;
        }
        if ( ReplicationComplianceStatus != null ) {
            this.ReplicationComplianceStatus = ReplicationComplianceStatus;
        }
        if ( SlaDomain != null ) {
            this.SlaDomain = SlaDomain;
        }
        if ( ArchivalSnapshotLag != null ) {
            this.ArchivalSnapshotLag = ArchivalSnapshotLag;
        }
        if ( ArchiveSnapshots != null ) {
            this.ArchiveSnapshots = ArchiveSnapshots;
        }
        if ( ArchiveStorage != null ) {
            this.ArchiveStorage = ArchiveStorage;
        }
        if ( AwaitingFirstFull != null ) {
            this.AwaitingFirstFull = AwaitingFirstFull;
        }
        if ( DataReduction != null ) {
            this.DataReduction = DataReduction;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastSnapshot != null ) {
            this.LastSnapshot = LastSnapshot;
        }
        if ( LastSnapshotLogicalBytes != null ) {
            this.LastSnapshotLogicalBytes = LastSnapshotLogicalBytes;
        }
        if ( LatestArchivalSnapshot != null ) {
            this.LatestArchivalSnapshot = LatestArchivalSnapshot;
        }
        if ( LatestReplicationSnapshot != null ) {
            this.LatestReplicationSnapshot = LatestReplicationSnapshot;
        }
        if ( LocalEffectiveStorage != null ) {
            this.LocalEffectiveStorage = LocalEffectiveStorage;
        }
        if ( LocalMeteredData != null ) {
            this.LocalMeteredData = LocalMeteredData;
        }
        if ( LocalOnDemandSnapshots != null ) {
            this.LocalOnDemandSnapshots = LocalOnDemandSnapshots;
        }
        if ( LocalProtectedData != null ) {
            this.LocalProtectedData = LocalProtectedData;
        }
        if ( LocalSlaSnapshots != null ) {
            this.LocalSlaSnapshots = LocalSlaSnapshots;
        }
        if ( LocalSnapshots != null ) {
            this.LocalSnapshots = LocalSnapshots;
        }
        if ( LocalStorage != null ) {
            this.LocalStorage = LocalStorage;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( LogicalBytes != null ) {
            this.LogicalBytes = LogicalBytes;
        }
        if ( LogicalDataReduction != null ) {
            this.LogicalDataReduction = LogicalDataReduction;
        }
        if ( MissedSnapshots != null ) {
            this.MissedSnapshots = MissedSnapshots;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( OrgName != null ) {
            this.OrgName = OrgName;
        }
        if ( PhysicalBytes != null ) {
            this.PhysicalBytes = PhysicalBytes;
        }
        if ( ProtectedOn != null ) {
            this.ProtectedOn = ProtectedOn;
        }
        if ( ProvisionedBytes != null ) {
            this.ProvisionedBytes = ProvisionedBytes;
        }
        if ( PullTime != null ) {
            this.PullTime = PullTime;
        }
        if ( ReplicaSnapshots != null ) {
            this.ReplicaSnapshots = ReplicaSnapshots;
        }
        if ( ReplicaStorage != null ) {
            this.ReplicaStorage = ReplicaStorage;
        }
        if ( ReplicationSnapshotLag != null ) {
            this.ReplicationSnapshotLag = ReplicationSnapshotLag;
        }
        if ( TotalSnapshots != null ) {
            this.TotalSnapshots = TotalSnapshots;
        }
        if ( TransferredBytes != null ) {
            this.TransferredBytes = TransferredBytes;
        }
        if ( UsedBytes != null ) {
            this.UsedBytes = UsedBytes;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
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
        //      C# -> ComplianceStatusEnum? ArchivalComplianceStatus
        // GraphQL -> archivalComplianceStatus: ComplianceStatusEnum (enum)
        if (this.ArchivalComplianceStatus != null) {
            s += ind + "archivalComplianceStatus\n" ;
        }
        //      C# -> ComplianceStatusEnum? ComplianceStatus
        // GraphQL -> complianceStatus: ComplianceStatusEnum (enum)
        if (this.ComplianceStatus != null) {
            s += ind + "complianceStatus\n" ;
        }
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> ProtectionStatusEnum? ProtectionStatus
        // GraphQL -> protectionStatus: ProtectionStatusEnum! (enum)
        if (this.ProtectionStatus != null) {
            s += ind + "protectionStatus\n" ;
        }
        //      C# -> ComplianceStatusEnum? ReplicationComplianceStatus
        // GraphQL -> replicationComplianceStatus: ComplianceStatusEnum (enum)
        if (this.ReplicationComplianceStatus != null) {
            s += ind + "replicationComplianceStatus\n" ;
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (this.SlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.SlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "slaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.Int32? ArchivalSnapshotLag
        // GraphQL -> archivalSnapshotLag: Int (scalar)
        if (this.ArchivalSnapshotLag != null) {
            s += ind + "archivalSnapshotLag\n" ;
        }
        //      C# -> System.Int32? ArchiveSnapshots
        // GraphQL -> archiveSnapshots: Int (scalar)
        if (this.ArchiveSnapshots != null) {
            s += ind + "archiveSnapshots\n" ;
        }
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        if (this.ArchiveStorage != null) {
            s += ind + "archiveStorage\n" ;
        }
        //      C# -> System.Boolean? AwaitingFirstFull
        // GraphQL -> awaitingFirstFull: Boolean (scalar)
        if (this.AwaitingFirstFull != null) {
            s += ind + "awaitingFirstFull\n" ;
        }
        //      C# -> System.Single? DataReduction
        // GraphQL -> dataReduction: Float (scalar)
        if (this.DataReduction != null) {
            s += ind + "dataReduction\n" ;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID (scalar)
        if (this.Fid != null) {
            s += ind + "fid\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> DateTime? LastSnapshot
        // GraphQL -> lastSnapshot: DateTime (scalar)
        if (this.LastSnapshot != null) {
            s += ind + "lastSnapshot\n" ;
        }
        //      C# -> System.Int64? LastSnapshotLogicalBytes
        // GraphQL -> lastSnapshotLogicalBytes: Long (scalar)
        if (this.LastSnapshotLogicalBytes != null) {
            s += ind + "lastSnapshotLogicalBytes\n" ;
        }
        //      C# -> DateTime? LatestArchivalSnapshot
        // GraphQL -> latestArchivalSnapshot: DateTime (scalar)
        if (this.LatestArchivalSnapshot != null) {
            s += ind + "latestArchivalSnapshot\n" ;
        }
        //      C# -> DateTime? LatestReplicationSnapshot
        // GraphQL -> latestReplicationSnapshot: DateTime (scalar)
        if (this.LatestReplicationSnapshot != null) {
            s += ind + "latestReplicationSnapshot\n" ;
        }
        //      C# -> System.Int64? LocalEffectiveStorage
        // GraphQL -> localEffectiveStorage: Long (scalar)
        if (this.LocalEffectiveStorage != null) {
            s += ind + "localEffectiveStorage\n" ;
        }
        //      C# -> System.Int64? LocalMeteredData
        // GraphQL -> localMeteredData: Long (scalar)
        if (this.LocalMeteredData != null) {
            s += ind + "localMeteredData\n" ;
        }
        //      C# -> System.Int32? LocalOnDemandSnapshots
        // GraphQL -> localOnDemandSnapshots: Int (scalar)
        if (this.LocalOnDemandSnapshots != null) {
            s += ind + "localOnDemandSnapshots\n" ;
        }
        //      C# -> System.Int64? LocalProtectedData
        // GraphQL -> localProtectedData: Long (scalar)
        if (this.LocalProtectedData != null) {
            s += ind + "localProtectedData\n" ;
        }
        //      C# -> System.Int32? LocalSlaSnapshots
        // GraphQL -> localSlaSnapshots: Int (scalar)
        if (this.LocalSlaSnapshots != null) {
            s += ind + "localSlaSnapshots\n" ;
        }
        //      C# -> System.Int32? LocalSnapshots
        // GraphQL -> localSnapshots: Int (scalar)
        if (this.LocalSnapshots != null) {
            s += ind + "localSnapshots\n" ;
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        if (this.LocalStorage != null) {
            s += ind + "localStorage\n" ;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            s += ind + "location\n" ;
        }
        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long (scalar)
        if (this.LogicalBytes != null) {
            s += ind + "logicalBytes\n" ;
        }
        //      C# -> System.Single? LogicalDataReduction
        // GraphQL -> logicalDataReduction: Float (scalar)
        if (this.LogicalDataReduction != null) {
            s += ind + "logicalDataReduction\n" ;
        }
        //      C# -> System.Int32? MissedSnapshots
        // GraphQL -> missedSnapshots: Int (scalar)
        if (this.MissedSnapshots != null) {
            s += ind + "missedSnapshots\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID (scalar)
        if (this.OrgId != null) {
            s += ind + "orgId\n" ;
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        if (this.OrgName != null) {
            s += ind + "orgName\n" ;
        }
        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long (scalar)
        if (this.PhysicalBytes != null) {
            s += ind + "physicalBytes\n" ;
        }
        //      C# -> DateTime? ProtectedOn
        // GraphQL -> protectedOn: DateTime (scalar)
        if (this.ProtectedOn != null) {
            s += ind + "protectedOn\n" ;
        }
        //      C# -> System.Int64? ProvisionedBytes
        // GraphQL -> provisionedBytes: Long (scalar)
        if (this.ProvisionedBytes != null) {
            s += ind + "provisionedBytes\n" ;
        }
        //      C# -> DateTime? PullTime
        // GraphQL -> pullTime: DateTime! (scalar)
        if (this.PullTime != null) {
            s += ind + "pullTime\n" ;
        }
        //      C# -> System.Int32? ReplicaSnapshots
        // GraphQL -> replicaSnapshots: Int (scalar)
        if (this.ReplicaSnapshots != null) {
            s += ind + "replicaSnapshots\n" ;
        }
        //      C# -> System.Int64? ReplicaStorage
        // GraphQL -> replicaStorage: Long (scalar)
        if (this.ReplicaStorage != null) {
            s += ind + "replicaStorage\n" ;
        }
        //      C# -> System.Int32? ReplicationSnapshotLag
        // GraphQL -> replicationSnapshotLag: Int (scalar)
        if (this.ReplicationSnapshotLag != null) {
            s += ind + "replicationSnapshotLag\n" ;
        }
        //      C# -> System.Int32? TotalSnapshots
        // GraphQL -> totalSnapshots: Int (scalar)
        if (this.TotalSnapshots != null) {
            s += ind + "totalSnapshots\n" ;
        }
        //      C# -> System.Int64? TransferredBytes
        // GraphQL -> transferredBytes: Long (scalar)
        if (this.TransferredBytes != null) {
            s += ind + "transferredBytes\n" ;
        }
        //      C# -> System.Int64? UsedBytes
        // GraphQL -> usedBytes: Long (scalar)
        if (this.UsedBytes != null) {
            s += ind + "usedBytes\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ComplianceStatusEnum? ArchivalComplianceStatus
        // GraphQL -> archivalComplianceStatus: ComplianceStatusEnum (enum)
        if (this.ArchivalComplianceStatus == null && ec.Includes("archivalComplianceStatus",true))
        {
            this.ArchivalComplianceStatus = new ComplianceStatusEnum();
        }
        //      C# -> ComplianceStatusEnum? ComplianceStatus
        // GraphQL -> complianceStatus: ComplianceStatusEnum (enum)
        if (this.ComplianceStatus == null && ec.Includes("complianceStatus",true))
        {
            this.ComplianceStatus = new ComplianceStatusEnum();
        }
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum! (enum)
        if (this.ObjectType == null && ec.Includes("objectType",true))
        {
            this.ObjectType = new ObjectTypeEnum();
        }
        //      C# -> ProtectionStatusEnum? ProtectionStatus
        // GraphQL -> protectionStatus: ProtectionStatusEnum! (enum)
        if (this.ProtectionStatus == null && ec.Includes("protectionStatus",true))
        {
            this.ProtectionStatus = new ProtectionStatusEnum();
        }
        //      C# -> ComplianceStatusEnum? ReplicationComplianceStatus
        // GraphQL -> replicationComplianceStatus: ComplianceStatusEnum (enum)
        if (this.ReplicationComplianceStatus == null && ec.Includes("replicationComplianceStatus",true))
        {
            this.ReplicationComplianceStatus = new ComplianceStatusEnum();
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (this.SlaDomain == null && ec.Includes("slaDomain",false))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));
            this.SlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.Int32? ArchivalSnapshotLag
        // GraphQL -> archivalSnapshotLag: Int (scalar)
        if (this.ArchivalSnapshotLag == null && ec.Includes("archivalSnapshotLag",true))
        {
            this.ArchivalSnapshotLag = Int32.MinValue;
        }
        //      C# -> System.Int32? ArchiveSnapshots
        // GraphQL -> archiveSnapshots: Int (scalar)
        if (this.ArchiveSnapshots == null && ec.Includes("archiveSnapshots",true))
        {
            this.ArchiveSnapshots = Int32.MinValue;
        }
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        if (this.ArchiveStorage == null && ec.Includes("archiveStorage",true))
        {
            this.ArchiveStorage = new System.Int64();
        }
        //      C# -> System.Boolean? AwaitingFirstFull
        // GraphQL -> awaitingFirstFull: Boolean (scalar)
        if (this.AwaitingFirstFull == null && ec.Includes("awaitingFirstFull",true))
        {
            this.AwaitingFirstFull = true;
        }
        //      C# -> System.Single? DataReduction
        // GraphQL -> dataReduction: Float (scalar)
        if (this.DataReduction == null && ec.Includes("dataReduction",true))
        {
            this.DataReduction = new System.Single();
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID (scalar)
        if (this.Fid == null && ec.Includes("fid",true))
        {
            this.Fid = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> DateTime? LastSnapshot
        // GraphQL -> lastSnapshot: DateTime (scalar)
        if (this.LastSnapshot == null && ec.Includes("lastSnapshot",true))
        {
            this.LastSnapshot = new DateTime();
        }
        //      C# -> System.Int64? LastSnapshotLogicalBytes
        // GraphQL -> lastSnapshotLogicalBytes: Long (scalar)
        if (this.LastSnapshotLogicalBytes == null && ec.Includes("lastSnapshotLogicalBytes",true))
        {
            this.LastSnapshotLogicalBytes = new System.Int64();
        }
        //      C# -> DateTime? LatestArchivalSnapshot
        // GraphQL -> latestArchivalSnapshot: DateTime (scalar)
        if (this.LatestArchivalSnapshot == null && ec.Includes("latestArchivalSnapshot",true))
        {
            this.LatestArchivalSnapshot = new DateTime();
        }
        //      C# -> DateTime? LatestReplicationSnapshot
        // GraphQL -> latestReplicationSnapshot: DateTime (scalar)
        if (this.LatestReplicationSnapshot == null && ec.Includes("latestReplicationSnapshot",true))
        {
            this.LatestReplicationSnapshot = new DateTime();
        }
        //      C# -> System.Int64? LocalEffectiveStorage
        // GraphQL -> localEffectiveStorage: Long (scalar)
        if (this.LocalEffectiveStorage == null && ec.Includes("localEffectiveStorage",true))
        {
            this.LocalEffectiveStorage = new System.Int64();
        }
        //      C# -> System.Int64? LocalMeteredData
        // GraphQL -> localMeteredData: Long (scalar)
        if (this.LocalMeteredData == null && ec.Includes("localMeteredData",true))
        {
            this.LocalMeteredData = new System.Int64();
        }
        //      C# -> System.Int32? LocalOnDemandSnapshots
        // GraphQL -> localOnDemandSnapshots: Int (scalar)
        if (this.LocalOnDemandSnapshots == null && ec.Includes("localOnDemandSnapshots",true))
        {
            this.LocalOnDemandSnapshots = Int32.MinValue;
        }
        //      C# -> System.Int64? LocalProtectedData
        // GraphQL -> localProtectedData: Long (scalar)
        if (this.LocalProtectedData == null && ec.Includes("localProtectedData",true))
        {
            this.LocalProtectedData = new System.Int64();
        }
        //      C# -> System.Int32? LocalSlaSnapshots
        // GraphQL -> localSlaSnapshots: Int (scalar)
        if (this.LocalSlaSnapshots == null && ec.Includes("localSlaSnapshots",true))
        {
            this.LocalSlaSnapshots = Int32.MinValue;
        }
        //      C# -> System.Int32? LocalSnapshots
        // GraphQL -> localSnapshots: Int (scalar)
        if (this.LocalSnapshots == null && ec.Includes("localSnapshots",true))
        {
            this.LocalSnapshots = Int32.MinValue;
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        if (this.LocalStorage == null && ec.Includes("localStorage",true))
        {
            this.LocalStorage = new System.Int64();
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location == null && ec.Includes("location",true))
        {
            this.Location = "FETCH";
        }
        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long (scalar)
        if (this.LogicalBytes == null && ec.Includes("logicalBytes",true))
        {
            this.LogicalBytes = new System.Int64();
        }
        //      C# -> System.Single? LogicalDataReduction
        // GraphQL -> logicalDataReduction: Float (scalar)
        if (this.LogicalDataReduction == null && ec.Includes("logicalDataReduction",true))
        {
            this.LogicalDataReduction = new System.Single();
        }
        //      C# -> System.Int32? MissedSnapshots
        // GraphQL -> missedSnapshots: Int (scalar)
        if (this.MissedSnapshots == null && ec.Includes("missedSnapshots",true))
        {
            this.MissedSnapshots = Int32.MinValue;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID (scalar)
        if (this.OrgId == null && ec.Includes("orgId",true))
        {
            this.OrgId = "FETCH";
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        if (this.OrgName == null && ec.Includes("orgName",true))
        {
            this.OrgName = "FETCH";
        }
        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long (scalar)
        if (this.PhysicalBytes == null && ec.Includes("physicalBytes",true))
        {
            this.PhysicalBytes = new System.Int64();
        }
        //      C# -> DateTime? ProtectedOn
        // GraphQL -> protectedOn: DateTime (scalar)
        if (this.ProtectedOn == null && ec.Includes("protectedOn",true))
        {
            this.ProtectedOn = new DateTime();
        }
        //      C# -> System.Int64? ProvisionedBytes
        // GraphQL -> provisionedBytes: Long (scalar)
        if (this.ProvisionedBytes == null && ec.Includes("provisionedBytes",true))
        {
            this.ProvisionedBytes = new System.Int64();
        }
        //      C# -> DateTime? PullTime
        // GraphQL -> pullTime: DateTime! (scalar)
        if (this.PullTime == null && ec.Includes("pullTime",true))
        {
            this.PullTime = new DateTime();
        }
        //      C# -> System.Int32? ReplicaSnapshots
        // GraphQL -> replicaSnapshots: Int (scalar)
        if (this.ReplicaSnapshots == null && ec.Includes("replicaSnapshots",true))
        {
            this.ReplicaSnapshots = Int32.MinValue;
        }
        //      C# -> System.Int64? ReplicaStorage
        // GraphQL -> replicaStorage: Long (scalar)
        if (this.ReplicaStorage == null && ec.Includes("replicaStorage",true))
        {
            this.ReplicaStorage = new System.Int64();
        }
        //      C# -> System.Int32? ReplicationSnapshotLag
        // GraphQL -> replicationSnapshotLag: Int (scalar)
        if (this.ReplicationSnapshotLag == null && ec.Includes("replicationSnapshotLag",true))
        {
            this.ReplicationSnapshotLag = Int32.MinValue;
        }
        //      C# -> System.Int32? TotalSnapshots
        // GraphQL -> totalSnapshots: Int (scalar)
        if (this.TotalSnapshots == null && ec.Includes("totalSnapshots",true))
        {
            this.TotalSnapshots = Int32.MinValue;
        }
        //      C# -> System.Int64? TransferredBytes
        // GraphQL -> transferredBytes: Long (scalar)
        if (this.TransferredBytes == null && ec.Includes("transferredBytes",true))
        {
            this.TransferredBytes = new System.Int64();
        }
        //      C# -> System.Int64? UsedBytes
        // GraphQL -> usedBytes: Long (scalar)
        if (this.UsedBytes == null && ec.Includes("usedBytes",true))
        {
            this.UsedBytes = new System.Int64();
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
    }


    #endregion

    } // class Snappable
    
    #endregion

    public static class ListSnappableExtensions
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
            this List<Snappable> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Snappable> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Snappable());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<Snappable> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types