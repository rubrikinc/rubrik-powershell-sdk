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

        //      C# -> ObjectState? ObjectState
        // GraphQL -> objectState: ObjectState! (enum)
        [JsonProperty("objectState")]
        public ObjectState? ObjectState { get; set; }

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
        public RscInterface<SlaDomain> SlaDomain { get; set; }

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

        //      C# -> DateTime? NcdLatestArchiveSnapshot
        // GraphQL -> ncdLatestArchiveSnapshot: DateTime (scalar)
        [JsonProperty("ncdLatestArchiveSnapshot")]
        public DateTime? NcdLatestArchiveSnapshot { get; set; }

        //      C# -> System.String? NcdPolicyName
        // GraphQL -> ncdPolicyName: String (scalar)
        [JsonProperty("ncdPolicyName")]
        public System.String? NcdPolicyName { get; set; }

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

        //      C# -> System.String? SourceProtocol
        // GraphQL -> sourceProtocol: String (scalar)
        [JsonProperty("sourceProtocol")]
        public System.String? SourceProtocol { get; set; }

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

        //      C# -> WorkloadOrganization? WorkloadOrg
        // GraphQL -> workloadOrg: WorkloadOrganization (type)
        [JsonProperty("workloadOrg")]
        public WorkloadOrganization? WorkloadOrg { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Snappable";
    }

    public Snappable Set(
        ComplianceStatusEnum? ArchivalComplianceStatus = null,
        ComplianceStatusEnum? ComplianceStatus = null,
        ObjectState? ObjectState = null,
        ObjectTypeEnum? ObjectType = null,
        ProtectionStatusEnum? ProtectionStatus = null,
        ComplianceStatusEnum? ReplicationComplianceStatus = null,
        RscInterface<SlaDomain> SlaDomain = null,
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
        DateTime? NcdLatestArchiveSnapshot = null,
        System.String? NcdPolicyName = null,
        System.String? OrgId = null,
        System.String? OrgName = null,
        System.Int64? PhysicalBytes = null,
        DateTime? ProtectedOn = null,
        System.Int64? ProvisionedBytes = null,
        DateTime? PullTime = null,
        System.Int32? ReplicaSnapshots = null,
        System.Int64? ReplicaStorage = null,
        System.Int32? ReplicationSnapshotLag = null,
        System.String? SourceProtocol = null,
        System.Int32? TotalSnapshots = null,
        System.Int64? TransferredBytes = null,
        System.Int64? UsedBytes = null,
        Cluster? Cluster = null,
        WorkloadOrganization? WorkloadOrg = null
    ) 
    {
        if ( ArchivalComplianceStatus != null ) {
            this.ArchivalComplianceStatus = ArchivalComplianceStatus;
        }
        if ( ComplianceStatus != null ) {
            this.ComplianceStatus = ComplianceStatus;
        }
        if ( ObjectState != null ) {
            this.ObjectState = ObjectState;
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
        if ( NcdLatestArchiveSnapshot != null ) {
            this.NcdLatestArchiveSnapshot = NcdLatestArchiveSnapshot;
        }
        if ( NcdPolicyName != null ) {
            this.NcdPolicyName = NcdPolicyName;
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
        if ( SourceProtocol != null ) {
            this.SourceProtocol = SourceProtocol;
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
        if ( WorkloadOrg != null ) {
            this.WorkloadOrg = WorkloadOrg;
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
        //      C# -> ComplianceStatusEnum? ArchivalComplianceStatus
        // GraphQL -> archivalComplianceStatus: ComplianceStatusEnum (enum)
        if (this.ArchivalComplianceStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalComplianceStatus\n" ;
            } else {
                s += ind + "archivalComplianceStatus\n" ;
            }
        }
        //      C# -> ComplianceStatusEnum? ComplianceStatus
        // GraphQL -> complianceStatus: ComplianceStatusEnum (enum)
        if (this.ComplianceStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "complianceStatus\n" ;
            } else {
                s += ind + "complianceStatus\n" ;
            }
        }
        //      C# -> ObjectState? ObjectState
        // GraphQL -> objectState: ObjectState! (enum)
        if (this.ObjectState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectState\n" ;
            } else {
                s += ind + "objectState\n" ;
            }
        }
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> ProtectionStatusEnum? ProtectionStatus
        // GraphQL -> protectionStatus: ProtectionStatusEnum! (enum)
        if (this.ProtectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionStatus\n" ;
            } else {
                s += ind + "protectionStatus\n" ;
            }
        }
        //      C# -> ComplianceStatusEnum? ReplicationComplianceStatus
        // GraphQL -> replicationComplianceStatus: ComplianceStatusEnum (enum)
        if (this.ReplicationComplianceStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationComplianceStatus\n" ;
            } else {
                s += ind + "replicationComplianceStatus\n" ;
            }
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (this.SlaDomain != null) {
            var fspec = this.SlaDomain.AsFieldSpec(conf.Child("slaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaDomain" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.Int32? ArchivalSnapshotLag
        // GraphQL -> archivalSnapshotLag: Int (scalar)
        if (this.ArchivalSnapshotLag != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalSnapshotLag\n" ;
            } else {
                s += ind + "archivalSnapshotLag\n" ;
            }
        }
        //      C# -> System.Int32? ArchiveSnapshots
        // GraphQL -> archiveSnapshots: Int (scalar)
        if (this.ArchiveSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archiveSnapshots\n" ;
            } else {
                s += ind + "archiveSnapshots\n" ;
            }
        }
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        if (this.ArchiveStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archiveStorage\n" ;
            } else {
                s += ind + "archiveStorage\n" ;
            }
        }
        //      C# -> System.Boolean? AwaitingFirstFull
        // GraphQL -> awaitingFirstFull: Boolean (scalar)
        if (this.AwaitingFirstFull != null) {
            if (conf.Flat) {
                s += conf.Prefix + "awaitingFirstFull\n" ;
            } else {
                s += ind + "awaitingFirstFull\n" ;
            }
        }
        //      C# -> System.Single? DataReduction
        // GraphQL -> dataReduction: Float (scalar)
        if (this.DataReduction != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataReduction\n" ;
            } else {
                s += ind + "dataReduction\n" ;
            }
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> DateTime? LastSnapshot
        // GraphQL -> lastSnapshot: DateTime (scalar)
        if (this.LastSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSnapshot\n" ;
            } else {
                s += ind + "lastSnapshot\n" ;
            }
        }
        //      C# -> System.Int64? LastSnapshotLogicalBytes
        // GraphQL -> lastSnapshotLogicalBytes: Long (scalar)
        if (this.LastSnapshotLogicalBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSnapshotLogicalBytes\n" ;
            } else {
                s += ind + "lastSnapshotLogicalBytes\n" ;
            }
        }
        //      C# -> DateTime? LatestArchivalSnapshot
        // GraphQL -> latestArchivalSnapshot: DateTime (scalar)
        if (this.LatestArchivalSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestArchivalSnapshot\n" ;
            } else {
                s += ind + "latestArchivalSnapshot\n" ;
            }
        }
        //      C# -> DateTime? LatestReplicationSnapshot
        // GraphQL -> latestReplicationSnapshot: DateTime (scalar)
        if (this.LatestReplicationSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestReplicationSnapshot\n" ;
            } else {
                s += ind + "latestReplicationSnapshot\n" ;
            }
        }
        //      C# -> System.Int64? LocalEffectiveStorage
        // GraphQL -> localEffectiveStorage: Long (scalar)
        if (this.LocalEffectiveStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localEffectiveStorage\n" ;
            } else {
                s += ind + "localEffectiveStorage\n" ;
            }
        }
        //      C# -> System.Int64? LocalMeteredData
        // GraphQL -> localMeteredData: Long (scalar)
        if (this.LocalMeteredData != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localMeteredData\n" ;
            } else {
                s += ind + "localMeteredData\n" ;
            }
        }
        //      C# -> System.Int32? LocalOnDemandSnapshots
        // GraphQL -> localOnDemandSnapshots: Int (scalar)
        if (this.LocalOnDemandSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localOnDemandSnapshots\n" ;
            } else {
                s += ind + "localOnDemandSnapshots\n" ;
            }
        }
        //      C# -> System.Int64? LocalProtectedData
        // GraphQL -> localProtectedData: Long (scalar)
        if (this.LocalProtectedData != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localProtectedData\n" ;
            } else {
                s += ind + "localProtectedData\n" ;
            }
        }
        //      C# -> System.Int32? LocalSlaSnapshots
        // GraphQL -> localSlaSnapshots: Int (scalar)
        if (this.LocalSlaSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localSlaSnapshots\n" ;
            } else {
                s += ind + "localSlaSnapshots\n" ;
            }
        }
        //      C# -> System.Int32? LocalSnapshots
        // GraphQL -> localSnapshots: Int (scalar)
        if (this.LocalSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localSnapshots\n" ;
            } else {
                s += ind + "localSnapshots\n" ;
            }
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        if (this.LocalStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localStorage\n" ;
            } else {
                s += ind + "localStorage\n" ;
            }
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            if (conf.Flat) {
                s += conf.Prefix + "location\n" ;
            } else {
                s += ind + "location\n" ;
            }
        }
        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long (scalar)
        if (this.LogicalBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logicalBytes\n" ;
            } else {
                s += ind + "logicalBytes\n" ;
            }
        }
        //      C# -> System.Single? LogicalDataReduction
        // GraphQL -> logicalDataReduction: Float (scalar)
        if (this.LogicalDataReduction != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logicalDataReduction\n" ;
            } else {
                s += ind + "logicalDataReduction\n" ;
            }
        }
        //      C# -> System.Int32? MissedSnapshots
        // GraphQL -> missedSnapshots: Int (scalar)
        if (this.MissedSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "missedSnapshots\n" ;
            } else {
                s += ind + "missedSnapshots\n" ;
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
        //      C# -> DateTime? NcdLatestArchiveSnapshot
        // GraphQL -> ncdLatestArchiveSnapshot: DateTime (scalar)
        if (this.NcdLatestArchiveSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ncdLatestArchiveSnapshot\n" ;
            } else {
                s += ind + "ncdLatestArchiveSnapshot\n" ;
            }
        }
        //      C# -> System.String? NcdPolicyName
        // GraphQL -> ncdPolicyName: String (scalar)
        if (this.NcdPolicyName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ncdPolicyName\n" ;
            } else {
                s += ind + "ncdPolicyName\n" ;
            }
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        if (this.OrgName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgName\n" ;
            } else {
                s += ind + "orgName\n" ;
            }
        }
        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long (scalar)
        if (this.PhysicalBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "physicalBytes\n" ;
            } else {
                s += ind + "physicalBytes\n" ;
            }
        }
        //      C# -> DateTime? ProtectedOn
        // GraphQL -> protectedOn: DateTime (scalar)
        if (this.ProtectedOn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectedOn\n" ;
            } else {
                s += ind + "protectedOn\n" ;
            }
        }
        //      C# -> System.Int64? ProvisionedBytes
        // GraphQL -> provisionedBytes: Long (scalar)
        if (this.ProvisionedBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "provisionedBytes\n" ;
            } else {
                s += ind + "provisionedBytes\n" ;
            }
        }
        //      C# -> DateTime? PullTime
        // GraphQL -> pullTime: DateTime! (scalar)
        if (this.PullTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pullTime\n" ;
            } else {
                s += ind + "pullTime\n" ;
            }
        }
        //      C# -> System.Int32? ReplicaSnapshots
        // GraphQL -> replicaSnapshots: Int (scalar)
        if (this.ReplicaSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicaSnapshots\n" ;
            } else {
                s += ind + "replicaSnapshots\n" ;
            }
        }
        //      C# -> System.Int64? ReplicaStorage
        // GraphQL -> replicaStorage: Long (scalar)
        if (this.ReplicaStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicaStorage\n" ;
            } else {
                s += ind + "replicaStorage\n" ;
            }
        }
        //      C# -> System.Int32? ReplicationSnapshotLag
        // GraphQL -> replicationSnapshotLag: Int (scalar)
        if (this.ReplicationSnapshotLag != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationSnapshotLag\n" ;
            } else {
                s += ind + "replicationSnapshotLag\n" ;
            }
        }
        //      C# -> System.String? SourceProtocol
        // GraphQL -> sourceProtocol: String (scalar)
        if (this.SourceProtocol != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceProtocol\n" ;
            } else {
                s += ind + "sourceProtocol\n" ;
            }
        }
        //      C# -> System.Int32? TotalSnapshots
        // GraphQL -> totalSnapshots: Int (scalar)
        if (this.TotalSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSnapshots\n" ;
            } else {
                s += ind + "totalSnapshots\n" ;
            }
        }
        //      C# -> System.Int64? TransferredBytes
        // GraphQL -> transferredBytes: Long (scalar)
        if (this.TransferredBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "transferredBytes\n" ;
            } else {
                s += ind + "transferredBytes\n" ;
            }
        }
        //      C# -> System.Int64? UsedBytes
        // GraphQL -> usedBytes: Long (scalar)
        if (this.UsedBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedBytes\n" ;
            } else {
                s += ind + "usedBytes\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> WorkloadOrganization? WorkloadOrg
        // GraphQL -> workloadOrg: WorkloadOrganization (type)
        if (this.WorkloadOrg != null) {
            var fspec = this.WorkloadOrg.AsFieldSpec(conf.Child("workloadOrg"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 ) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "workloadOrg" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ComplianceStatusEnum? ArchivalComplianceStatus
        // GraphQL -> archivalComplianceStatus: ComplianceStatusEnum (enum)
        if (ec.Includes("archivalComplianceStatus",true))
        {
            if(this.ArchivalComplianceStatus == null) {

                this.ArchivalComplianceStatus = new ComplianceStatusEnum();

            } else {


            }
        }
        else if (this.ArchivalComplianceStatus != null && ec.Excludes("archivalComplianceStatus",true))
        {
            this.ArchivalComplianceStatus = null;
        }
        //      C# -> ComplianceStatusEnum? ComplianceStatus
        // GraphQL -> complianceStatus: ComplianceStatusEnum (enum)
        if (ec.Includes("complianceStatus",true))
        {
            if(this.ComplianceStatus == null) {

                this.ComplianceStatus = new ComplianceStatusEnum();

            } else {


            }
        }
        else if (this.ComplianceStatus != null && ec.Excludes("complianceStatus",true))
        {
            this.ComplianceStatus = null;
        }
        //      C# -> ObjectState? ObjectState
        // GraphQL -> objectState: ObjectState! (enum)
        if (ec.Includes("objectState",true))
        {
            if(this.ObjectState == null) {

                this.ObjectState = new ObjectState();

            } else {


            }
        }
        else if (this.ObjectState != null && ec.Excludes("objectState",true))
        {
            this.ObjectState = null;
        }
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new ObjectTypeEnum();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> ProtectionStatusEnum? ProtectionStatus
        // GraphQL -> protectionStatus: ProtectionStatusEnum! (enum)
        if (ec.Includes("protectionStatus",true))
        {
            if(this.ProtectionStatus == null) {

                this.ProtectionStatus = new ProtectionStatusEnum();

            } else {


            }
        }
        else if (this.ProtectionStatus != null && ec.Excludes("protectionStatus",true))
        {
            this.ProtectionStatus = null;
        }
        //      C# -> ComplianceStatusEnum? ReplicationComplianceStatus
        // GraphQL -> replicationComplianceStatus: ComplianceStatusEnum (enum)
        if (ec.Includes("replicationComplianceStatus",true))
        {
            if(this.ReplicationComplianceStatus == null) {

                this.ReplicationComplianceStatus = new ComplianceStatusEnum();

            } else {


            }
        }
        else if (this.ReplicationComplianceStatus != null && ec.Excludes("replicationComplianceStatus",true))
        {
            this.ReplicationComplianceStatus = null;
        }
        //      C# -> SlaDomain? SlaDomain
        // GraphQL -> slaDomain: SlaDomain (interface)
        if (ec.Includes("slaDomain",false))
        {
            if(this.SlaDomain == null) {

                this.SlaDomain = new RscInterface<SlaDomain>();
                this.SlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));

            } else {

                this.SlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("slaDomain"));

            }
        }
        else if (this.SlaDomain != null && ec.Excludes("slaDomain",false))
        {
            this.SlaDomain = null;
        }
        //      C# -> System.Int32? ArchivalSnapshotLag
        // GraphQL -> archivalSnapshotLag: Int (scalar)
        if (ec.Includes("archivalSnapshotLag",true))
        {
            if(this.ArchivalSnapshotLag == null) {

                this.ArchivalSnapshotLag = Int32.MinValue;

            } else {


            }
        }
        else if (this.ArchivalSnapshotLag != null && ec.Excludes("archivalSnapshotLag",true))
        {
            this.ArchivalSnapshotLag = null;
        }
        //      C# -> System.Int32? ArchiveSnapshots
        // GraphQL -> archiveSnapshots: Int (scalar)
        if (ec.Includes("archiveSnapshots",true))
        {
            if(this.ArchiveSnapshots == null) {

                this.ArchiveSnapshots = Int32.MinValue;

            } else {


            }
        }
        else if (this.ArchiveSnapshots != null && ec.Excludes("archiveSnapshots",true))
        {
            this.ArchiveSnapshots = null;
        }
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long (scalar)
        if (ec.Includes("archiveStorage",true))
        {
            if(this.ArchiveStorage == null) {

                this.ArchiveStorage = new System.Int64();

            } else {


            }
        }
        else if (this.ArchiveStorage != null && ec.Excludes("archiveStorage",true))
        {
            this.ArchiveStorage = null;
        }
        //      C# -> System.Boolean? AwaitingFirstFull
        // GraphQL -> awaitingFirstFull: Boolean (scalar)
        if (ec.Includes("awaitingFirstFull",true))
        {
            if(this.AwaitingFirstFull == null) {

                this.AwaitingFirstFull = true;

            } else {


            }
        }
        else if (this.AwaitingFirstFull != null && ec.Excludes("awaitingFirstFull",true))
        {
            this.AwaitingFirstFull = null;
        }
        //      C# -> System.Single? DataReduction
        // GraphQL -> dataReduction: Float (scalar)
        if (ec.Includes("dataReduction",true))
        {
            if(this.DataReduction == null) {

                this.DataReduction = new System.Single();

            } else {


            }
        }
        else if (this.DataReduction != null && ec.Excludes("dataReduction",true))
        {
            this.DataReduction = null;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> DateTime? LastSnapshot
        // GraphQL -> lastSnapshot: DateTime (scalar)
        if (ec.Includes("lastSnapshot",true))
        {
            if(this.LastSnapshot == null) {

                this.LastSnapshot = new DateTime();

            } else {


            }
        }
        else if (this.LastSnapshot != null && ec.Excludes("lastSnapshot",true))
        {
            this.LastSnapshot = null;
        }
        //      C# -> System.Int64? LastSnapshotLogicalBytes
        // GraphQL -> lastSnapshotLogicalBytes: Long (scalar)
        if (ec.Includes("lastSnapshotLogicalBytes",true))
        {
            if(this.LastSnapshotLogicalBytes == null) {

                this.LastSnapshotLogicalBytes = new System.Int64();

            } else {


            }
        }
        else if (this.LastSnapshotLogicalBytes != null && ec.Excludes("lastSnapshotLogicalBytes",true))
        {
            this.LastSnapshotLogicalBytes = null;
        }
        //      C# -> DateTime? LatestArchivalSnapshot
        // GraphQL -> latestArchivalSnapshot: DateTime (scalar)
        if (ec.Includes("latestArchivalSnapshot",true))
        {
            if(this.LatestArchivalSnapshot == null) {

                this.LatestArchivalSnapshot = new DateTime();

            } else {


            }
        }
        else if (this.LatestArchivalSnapshot != null && ec.Excludes("latestArchivalSnapshot",true))
        {
            this.LatestArchivalSnapshot = null;
        }
        //      C# -> DateTime? LatestReplicationSnapshot
        // GraphQL -> latestReplicationSnapshot: DateTime (scalar)
        if (ec.Includes("latestReplicationSnapshot",true))
        {
            if(this.LatestReplicationSnapshot == null) {

                this.LatestReplicationSnapshot = new DateTime();

            } else {


            }
        }
        else if (this.LatestReplicationSnapshot != null && ec.Excludes("latestReplicationSnapshot",true))
        {
            this.LatestReplicationSnapshot = null;
        }
        //      C# -> System.Int64? LocalEffectiveStorage
        // GraphQL -> localEffectiveStorage: Long (scalar)
        if (ec.Includes("localEffectiveStorage",true))
        {
            if(this.LocalEffectiveStorage == null) {

                this.LocalEffectiveStorage = new System.Int64();

            } else {


            }
        }
        else if (this.LocalEffectiveStorage != null && ec.Excludes("localEffectiveStorage",true))
        {
            this.LocalEffectiveStorage = null;
        }
        //      C# -> System.Int64? LocalMeteredData
        // GraphQL -> localMeteredData: Long (scalar)
        if (ec.Includes("localMeteredData",true))
        {
            if(this.LocalMeteredData == null) {

                this.LocalMeteredData = new System.Int64();

            } else {


            }
        }
        else if (this.LocalMeteredData != null && ec.Excludes("localMeteredData",true))
        {
            this.LocalMeteredData = null;
        }
        //      C# -> System.Int32? LocalOnDemandSnapshots
        // GraphQL -> localOnDemandSnapshots: Int (scalar)
        if (ec.Includes("localOnDemandSnapshots",true))
        {
            if(this.LocalOnDemandSnapshots == null) {

                this.LocalOnDemandSnapshots = Int32.MinValue;

            } else {


            }
        }
        else if (this.LocalOnDemandSnapshots != null && ec.Excludes("localOnDemandSnapshots",true))
        {
            this.LocalOnDemandSnapshots = null;
        }
        //      C# -> System.Int64? LocalProtectedData
        // GraphQL -> localProtectedData: Long (scalar)
        if (ec.Includes("localProtectedData",true))
        {
            if(this.LocalProtectedData == null) {

                this.LocalProtectedData = new System.Int64();

            } else {


            }
        }
        else if (this.LocalProtectedData != null && ec.Excludes("localProtectedData",true))
        {
            this.LocalProtectedData = null;
        }
        //      C# -> System.Int32? LocalSlaSnapshots
        // GraphQL -> localSlaSnapshots: Int (scalar)
        if (ec.Includes("localSlaSnapshots",true))
        {
            if(this.LocalSlaSnapshots == null) {

                this.LocalSlaSnapshots = Int32.MinValue;

            } else {


            }
        }
        else if (this.LocalSlaSnapshots != null && ec.Excludes("localSlaSnapshots",true))
        {
            this.LocalSlaSnapshots = null;
        }
        //      C# -> System.Int32? LocalSnapshots
        // GraphQL -> localSnapshots: Int (scalar)
        if (ec.Includes("localSnapshots",true))
        {
            if(this.LocalSnapshots == null) {

                this.LocalSnapshots = Int32.MinValue;

            } else {


            }
        }
        else if (this.LocalSnapshots != null && ec.Excludes("localSnapshots",true))
        {
            this.LocalSnapshots = null;
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long (scalar)
        if (ec.Includes("localStorage",true))
        {
            if(this.LocalStorage == null) {

                this.LocalStorage = new System.Int64();

            } else {


            }
        }
        else if (this.LocalStorage != null && ec.Excludes("localStorage",true))
        {
            this.LocalStorage = null;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (ec.Includes("location",true))
        {
            if(this.Location == null) {

                this.Location = "FETCH";

            } else {


            }
        }
        else if (this.Location != null && ec.Excludes("location",true))
        {
            this.Location = null;
        }
        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long (scalar)
        if (ec.Includes("logicalBytes",true))
        {
            if(this.LogicalBytes == null) {

                this.LogicalBytes = new System.Int64();

            } else {


            }
        }
        else if (this.LogicalBytes != null && ec.Excludes("logicalBytes",true))
        {
            this.LogicalBytes = null;
        }
        //      C# -> System.Single? LogicalDataReduction
        // GraphQL -> logicalDataReduction: Float (scalar)
        if (ec.Includes("logicalDataReduction",true))
        {
            if(this.LogicalDataReduction == null) {

                this.LogicalDataReduction = new System.Single();

            } else {


            }
        }
        else if (this.LogicalDataReduction != null && ec.Excludes("logicalDataReduction",true))
        {
            this.LogicalDataReduction = null;
        }
        //      C# -> System.Int32? MissedSnapshots
        // GraphQL -> missedSnapshots: Int (scalar)
        if (ec.Includes("missedSnapshots",true))
        {
            if(this.MissedSnapshots == null) {

                this.MissedSnapshots = Int32.MinValue;

            } else {


            }
        }
        else if (this.MissedSnapshots != null && ec.Excludes("missedSnapshots",true))
        {
            this.MissedSnapshots = null;
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
        //      C# -> DateTime? NcdLatestArchiveSnapshot
        // GraphQL -> ncdLatestArchiveSnapshot: DateTime (scalar)
        if (ec.Includes("ncdLatestArchiveSnapshot",true))
        {
            if(this.NcdLatestArchiveSnapshot == null) {

                this.NcdLatestArchiveSnapshot = new DateTime();

            } else {


            }
        }
        else if (this.NcdLatestArchiveSnapshot != null && ec.Excludes("ncdLatestArchiveSnapshot",true))
        {
            this.NcdLatestArchiveSnapshot = null;
        }
        //      C# -> System.String? NcdPolicyName
        // GraphQL -> ncdPolicyName: String (scalar)
        if (ec.Includes("ncdPolicyName",true))
        {
            if(this.NcdPolicyName == null) {

                this.NcdPolicyName = "FETCH";

            } else {


            }
        }
        else if (this.NcdPolicyName != null && ec.Excludes("ncdPolicyName",true))
        {
            this.NcdPolicyName = null;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = "FETCH";

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        if (ec.Includes("orgName",true))
        {
            if(this.OrgName == null) {

                this.OrgName = "FETCH";

            } else {


            }
        }
        else if (this.OrgName != null && ec.Excludes("orgName",true))
        {
            this.OrgName = null;
        }
        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long (scalar)
        if (ec.Includes("physicalBytes",true))
        {
            if(this.PhysicalBytes == null) {

                this.PhysicalBytes = new System.Int64();

            } else {


            }
        }
        else if (this.PhysicalBytes != null && ec.Excludes("physicalBytes",true))
        {
            this.PhysicalBytes = null;
        }
        //      C# -> DateTime? ProtectedOn
        // GraphQL -> protectedOn: DateTime (scalar)
        if (ec.Includes("protectedOn",true))
        {
            if(this.ProtectedOn == null) {

                this.ProtectedOn = new DateTime();

            } else {


            }
        }
        else if (this.ProtectedOn != null && ec.Excludes("protectedOn",true))
        {
            this.ProtectedOn = null;
        }
        //      C# -> System.Int64? ProvisionedBytes
        // GraphQL -> provisionedBytes: Long (scalar)
        if (ec.Includes("provisionedBytes",true))
        {
            if(this.ProvisionedBytes == null) {

                this.ProvisionedBytes = new System.Int64();

            } else {


            }
        }
        else if (this.ProvisionedBytes != null && ec.Excludes("provisionedBytes",true))
        {
            this.ProvisionedBytes = null;
        }
        //      C# -> DateTime? PullTime
        // GraphQL -> pullTime: DateTime! (scalar)
        if (ec.Includes("pullTime",true))
        {
            if(this.PullTime == null) {

                this.PullTime = new DateTime();

            } else {


            }
        }
        else if (this.PullTime != null && ec.Excludes("pullTime",true))
        {
            this.PullTime = null;
        }
        //      C# -> System.Int32? ReplicaSnapshots
        // GraphQL -> replicaSnapshots: Int (scalar)
        if (ec.Includes("replicaSnapshots",true))
        {
            if(this.ReplicaSnapshots == null) {

                this.ReplicaSnapshots = Int32.MinValue;

            } else {


            }
        }
        else if (this.ReplicaSnapshots != null && ec.Excludes("replicaSnapshots",true))
        {
            this.ReplicaSnapshots = null;
        }
        //      C# -> System.Int64? ReplicaStorage
        // GraphQL -> replicaStorage: Long (scalar)
        if (ec.Includes("replicaStorage",true))
        {
            if(this.ReplicaStorage == null) {

                this.ReplicaStorage = new System.Int64();

            } else {


            }
        }
        else if (this.ReplicaStorage != null && ec.Excludes("replicaStorage",true))
        {
            this.ReplicaStorage = null;
        }
        //      C# -> System.Int32? ReplicationSnapshotLag
        // GraphQL -> replicationSnapshotLag: Int (scalar)
        if (ec.Includes("replicationSnapshotLag",true))
        {
            if(this.ReplicationSnapshotLag == null) {

                this.ReplicationSnapshotLag = Int32.MinValue;

            } else {


            }
        }
        else if (this.ReplicationSnapshotLag != null && ec.Excludes("replicationSnapshotLag",true))
        {
            this.ReplicationSnapshotLag = null;
        }
        //      C# -> System.String? SourceProtocol
        // GraphQL -> sourceProtocol: String (scalar)
        if (ec.Includes("sourceProtocol",true))
        {
            if(this.SourceProtocol == null) {

                this.SourceProtocol = "FETCH";

            } else {


            }
        }
        else if (this.SourceProtocol != null && ec.Excludes("sourceProtocol",true))
        {
            this.SourceProtocol = null;
        }
        //      C# -> System.Int32? TotalSnapshots
        // GraphQL -> totalSnapshots: Int (scalar)
        if (ec.Includes("totalSnapshots",true))
        {
            if(this.TotalSnapshots == null) {

                this.TotalSnapshots = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalSnapshots != null && ec.Excludes("totalSnapshots",true))
        {
            this.TotalSnapshots = null;
        }
        //      C# -> System.Int64? TransferredBytes
        // GraphQL -> transferredBytes: Long (scalar)
        if (ec.Includes("transferredBytes",true))
        {
            if(this.TransferredBytes == null) {

                this.TransferredBytes = new System.Int64();

            } else {


            }
        }
        else if (this.TransferredBytes != null && ec.Excludes("transferredBytes",true))
        {
            this.TransferredBytes = null;
        }
        //      C# -> System.Int64? UsedBytes
        // GraphQL -> usedBytes: Long (scalar)
        if (ec.Includes("usedBytes",true))
        {
            if(this.UsedBytes == null) {

                this.UsedBytes = new System.Int64();

            } else {


            }
        }
        else if (this.UsedBytes != null && ec.Excludes("usedBytes",true))
        {
            this.UsedBytes = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
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
        //      C# -> WorkloadOrganization? WorkloadOrg
        // GraphQL -> workloadOrg: WorkloadOrganization (type)
        if (ec.Includes("workloadOrg",false))
        {
            if(this.WorkloadOrg == null) {

                this.WorkloadOrg = new WorkloadOrganization();
                this.WorkloadOrg.ApplyExploratoryFieldSpec(ec.NewChild("workloadOrg"));

            } else {

                this.WorkloadOrg.ApplyExploratoryFieldSpec(ec.NewChild("workloadOrg"));

            }
        }
        else if (this.WorkloadOrg != null && ec.Excludes("workloadOrg",false))
        {
            this.WorkloadOrg = null;
        }
    }


    #endregion

    } // class Snappable
    
    #endregion

    public static class ListSnappableExtensions
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
            this List<Snappable> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Snappable> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<Snappable> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types