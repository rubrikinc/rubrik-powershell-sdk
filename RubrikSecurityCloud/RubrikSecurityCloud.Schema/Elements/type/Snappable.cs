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

namespace Rubrik.SecurityCloud.Types
{
    #region Snappable
 
    public class Snappable: IFragment, AnomalyResultGroupByInfo, RansomwareResultGroupByInfo
    {
        #region members
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

        #endregion

    #region methods

    public Snappable Set(
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
        Cluster? Cluster = null,
        ComplianceStatusEnum? ArchivalComplianceStatus = null,
        ComplianceStatusEnum? ComplianceStatus = null,
        ObjectTypeEnum? ObjectType = null,
        ProtectionStatusEnum? ProtectionStatus = null,
        ComplianceStatusEnum? ReplicationComplianceStatus = null,
        SlaDomain? SlaDomain = null
    ) 
    {
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
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int32? ArchivalSnapshotLag
            // GraphQL -> archivalSnapshotLag: Int (scalar)
            if (this.ArchivalSnapshotLag != null)
            {
                 s += ind + "archivalSnapshotLag\n";

            }
            //      C# -> System.Int32? ArchiveSnapshots
            // GraphQL -> archiveSnapshots: Int (scalar)
            if (this.ArchiveSnapshots != null)
            {
                 s += ind + "archiveSnapshots\n";

            }
            //      C# -> System.Int64? ArchiveStorage
            // GraphQL -> archiveStorage: Long (scalar)
            if (this.ArchiveStorage != null)
            {
                 s += ind + "archiveStorage\n";

            }
            //      C# -> System.Boolean? AwaitingFirstFull
            // GraphQL -> awaitingFirstFull: Boolean (scalar)
            if (this.AwaitingFirstFull != null)
            {
                 s += ind + "awaitingFirstFull\n";

            }
            //      C# -> System.Single? DataReduction
            // GraphQL -> dataReduction: Float (scalar)
            if (this.DataReduction != null)
            {
                 s += ind + "dataReduction\n";

            }
            //      C# -> System.String? Fid
            // GraphQL -> fid: UUID (scalar)
            if (this.Fid != null)
            {
                 s += ind + "fid\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> DateTime? LastSnapshot
            // GraphQL -> lastSnapshot: DateTime (scalar)
            if (this.LastSnapshot != null)
            {
                 s += ind + "lastSnapshot\n";

            }
            //      C# -> System.Int64? LastSnapshotLogicalBytes
            // GraphQL -> lastSnapshotLogicalBytes: Long (scalar)
            if (this.LastSnapshotLogicalBytes != null)
            {
                 s += ind + "lastSnapshotLogicalBytes\n";

            }
            //      C# -> DateTime? LatestArchivalSnapshot
            // GraphQL -> latestArchivalSnapshot: DateTime (scalar)
            if (this.LatestArchivalSnapshot != null)
            {
                 s += ind + "latestArchivalSnapshot\n";

            }
            //      C# -> DateTime? LatestReplicationSnapshot
            // GraphQL -> latestReplicationSnapshot: DateTime (scalar)
            if (this.LatestReplicationSnapshot != null)
            {
                 s += ind + "latestReplicationSnapshot\n";

            }
            //      C# -> System.Int64? LocalEffectiveStorage
            // GraphQL -> localEffectiveStorage: Long (scalar)
            if (this.LocalEffectiveStorage != null)
            {
                 s += ind + "localEffectiveStorage\n";

            }
            //      C# -> System.Int64? LocalMeteredData
            // GraphQL -> localMeteredData: Long (scalar)
            if (this.LocalMeteredData != null)
            {
                 s += ind + "localMeteredData\n";

            }
            //      C# -> System.Int32? LocalOnDemandSnapshots
            // GraphQL -> localOnDemandSnapshots: Int (scalar)
            if (this.LocalOnDemandSnapshots != null)
            {
                 s += ind + "localOnDemandSnapshots\n";

            }
            //      C# -> System.Int64? LocalProtectedData
            // GraphQL -> localProtectedData: Long (scalar)
            if (this.LocalProtectedData != null)
            {
                 s += ind + "localProtectedData\n";

            }
            //      C# -> System.Int32? LocalSlaSnapshots
            // GraphQL -> localSlaSnapshots: Int (scalar)
            if (this.LocalSlaSnapshots != null)
            {
                 s += ind + "localSlaSnapshots\n";

            }
            //      C# -> System.Int32? LocalSnapshots
            // GraphQL -> localSnapshots: Int (scalar)
            if (this.LocalSnapshots != null)
            {
                 s += ind + "localSnapshots\n";

            }
            //      C# -> System.Int64? LocalStorage
            // GraphQL -> localStorage: Long (scalar)
            if (this.LocalStorage != null)
            {
                 s += ind + "localStorage\n";

            }
            //      C# -> System.String? Location
            // GraphQL -> location: String! (scalar)
            if (this.Location != null)
            {
                 s += ind + "location\n";

            }
            //      C# -> System.Int64? LogicalBytes
            // GraphQL -> logicalBytes: Long (scalar)
            if (this.LogicalBytes != null)
            {
                 s += ind + "logicalBytes\n";

            }
            //      C# -> System.Single? LogicalDataReduction
            // GraphQL -> logicalDataReduction: Float (scalar)
            if (this.LogicalDataReduction != null)
            {
                 s += ind + "logicalDataReduction\n";

            }
            //      C# -> System.Int32? MissedSnapshots
            // GraphQL -> missedSnapshots: Int (scalar)
            if (this.MissedSnapshots != null)
            {
                 s += ind + "missedSnapshots\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: UUID (scalar)
            if (this.OrgId != null)
            {
                 s += ind + "orgId\n";

            }
            //      C# -> System.String? OrgName
            // GraphQL -> orgName: String (scalar)
            if (this.OrgName != null)
            {
                 s += ind + "orgName\n";

            }
            //      C# -> System.Int64? PhysicalBytes
            // GraphQL -> physicalBytes: Long (scalar)
            if (this.PhysicalBytes != null)
            {
                 s += ind + "physicalBytes\n";

            }
            //      C# -> DateTime? ProtectedOn
            // GraphQL -> protectedOn: DateTime (scalar)
            if (this.ProtectedOn != null)
            {
                 s += ind + "protectedOn\n";

            }
            //      C# -> System.Int64? ProvisionedBytes
            // GraphQL -> provisionedBytes: Long (scalar)
            if (this.ProvisionedBytes != null)
            {
                 s += ind + "provisionedBytes\n";

            }
            //      C# -> DateTime? PullTime
            // GraphQL -> pullTime: DateTime! (scalar)
            if (this.PullTime != null)
            {
                 s += ind + "pullTime\n";

            }
            //      C# -> System.Int32? ReplicaSnapshots
            // GraphQL -> replicaSnapshots: Int (scalar)
            if (this.ReplicaSnapshots != null)
            {
                 s += ind + "replicaSnapshots\n";

            }
            //      C# -> System.Int64? ReplicaStorage
            // GraphQL -> replicaStorage: Long (scalar)
            if (this.ReplicaStorage != null)
            {
                 s += ind + "replicaStorage\n";

            }
            //      C# -> System.Int32? ReplicationSnapshotLag
            // GraphQL -> replicationSnapshotLag: Int (scalar)
            if (this.ReplicationSnapshotLag != null)
            {
                 s += ind + "replicationSnapshotLag\n";

            }
            //      C# -> System.Int32? TotalSnapshots
            // GraphQL -> totalSnapshots: Int (scalar)
            if (this.TotalSnapshots != null)
            {
                 s += ind + "totalSnapshots\n";

            }
            //      C# -> System.Int64? TransferredBytes
            // GraphQL -> transferredBytes: Long (scalar)
            if (this.TransferredBytes != null)
            {
                 s += ind + "transferredBytes\n";

            }
            //      C# -> System.Int64? UsedBytes
            // GraphQL -> usedBytes: Long (scalar)
            if (this.UsedBytes != null)
            {
                 s += ind + "usedBytes\n";

            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ComplianceStatusEnum? ArchivalComplianceStatus
            // GraphQL -> archivalComplianceStatus: ComplianceStatusEnum (enum)
            if (this.ArchivalComplianceStatus != null)
            {
                 s += ind + "archivalComplianceStatus\n";

            }
            //      C# -> ComplianceStatusEnum? ComplianceStatus
            // GraphQL -> complianceStatus: ComplianceStatusEnum (enum)
            if (this.ComplianceStatus != null)
            {
                 s += ind + "complianceStatus\n";

            }
            //      C# -> ObjectTypeEnum? ObjectType
            // GraphQL -> objectType: ObjectTypeEnum! (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            //      C# -> ProtectionStatusEnum? ProtectionStatus
            // GraphQL -> protectionStatus: ProtectionStatusEnum! (enum)
            if (this.ProtectionStatus != null)
            {
                 s += ind + "protectionStatus\n";

            }
            //      C# -> ComplianceStatusEnum? ReplicationComplianceStatus
            // GraphQL -> replicationComplianceStatus: ComplianceStatusEnum (enum)
            if (this.ReplicationComplianceStatus != null)
            {
                 s += ind + "replicationComplianceStatus\n";

            }
                        //      C# -> SlaDomain? SlaDomain
            // GraphQL -> slaDomain: SlaDomain (interface)
            if (this.SlaDomain != null)
            {
                s += ind + "slaDomain\n";
                s += ind + "{\n";

                string typename = this.SlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.SlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? ArchivalSnapshotLag
            // GraphQL -> archivalSnapshotLag: Int (scalar)
            if (this.ArchivalSnapshotLag == null && Exploration.Includes(parent + ".archivalSnapshotLag$"))
            {
                this.ArchivalSnapshotLag = new System.Int32();
            }
            //      C# -> System.Int32? ArchiveSnapshots
            // GraphQL -> archiveSnapshots: Int (scalar)
            if (this.ArchiveSnapshots == null && Exploration.Includes(parent + ".archiveSnapshots$"))
            {
                this.ArchiveSnapshots = new System.Int32();
            }
            //      C# -> System.Int64? ArchiveStorage
            // GraphQL -> archiveStorage: Long (scalar)
            if (this.ArchiveStorage == null && Exploration.Includes(parent + ".archiveStorage$"))
            {
                this.ArchiveStorage = new System.Int64();
            }
            //      C# -> System.Boolean? AwaitingFirstFull
            // GraphQL -> awaitingFirstFull: Boolean (scalar)
            if (this.AwaitingFirstFull == null && Exploration.Includes(parent + ".awaitingFirstFull$"))
            {
                this.AwaitingFirstFull = new System.Boolean();
            }
            //      C# -> System.Single? DataReduction
            // GraphQL -> dataReduction: Float (scalar)
            if (this.DataReduction == null && Exploration.Includes(parent + ".dataReduction$"))
            {
                this.DataReduction = new System.Single();
            }
            //      C# -> System.String? Fid
            // GraphQL -> fid: UUID (scalar)
            if (this.Fid == null && Exploration.Includes(parent + ".fid$"))
            {
                this.Fid = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> DateTime? LastSnapshot
            // GraphQL -> lastSnapshot: DateTime (scalar)
            if (this.LastSnapshot == null && Exploration.Includes(parent + ".lastSnapshot$"))
            {
                this.LastSnapshot = new DateTime();
            }
            //      C# -> System.Int64? LastSnapshotLogicalBytes
            // GraphQL -> lastSnapshotLogicalBytes: Long (scalar)
            if (this.LastSnapshotLogicalBytes == null && Exploration.Includes(parent + ".lastSnapshotLogicalBytes$"))
            {
                this.LastSnapshotLogicalBytes = new System.Int64();
            }
            //      C# -> DateTime? LatestArchivalSnapshot
            // GraphQL -> latestArchivalSnapshot: DateTime (scalar)
            if (this.LatestArchivalSnapshot == null && Exploration.Includes(parent + ".latestArchivalSnapshot$"))
            {
                this.LatestArchivalSnapshot = new DateTime();
            }
            //      C# -> DateTime? LatestReplicationSnapshot
            // GraphQL -> latestReplicationSnapshot: DateTime (scalar)
            if (this.LatestReplicationSnapshot == null && Exploration.Includes(parent + ".latestReplicationSnapshot$"))
            {
                this.LatestReplicationSnapshot = new DateTime();
            }
            //      C# -> System.Int64? LocalEffectiveStorage
            // GraphQL -> localEffectiveStorage: Long (scalar)
            if (this.LocalEffectiveStorage == null && Exploration.Includes(parent + ".localEffectiveStorage$"))
            {
                this.LocalEffectiveStorage = new System.Int64();
            }
            //      C# -> System.Int64? LocalMeteredData
            // GraphQL -> localMeteredData: Long (scalar)
            if (this.LocalMeteredData == null && Exploration.Includes(parent + ".localMeteredData$"))
            {
                this.LocalMeteredData = new System.Int64();
            }
            //      C# -> System.Int32? LocalOnDemandSnapshots
            // GraphQL -> localOnDemandSnapshots: Int (scalar)
            if (this.LocalOnDemandSnapshots == null && Exploration.Includes(parent + ".localOnDemandSnapshots$"))
            {
                this.LocalOnDemandSnapshots = new System.Int32();
            }
            //      C# -> System.Int64? LocalProtectedData
            // GraphQL -> localProtectedData: Long (scalar)
            if (this.LocalProtectedData == null && Exploration.Includes(parent + ".localProtectedData$"))
            {
                this.LocalProtectedData = new System.Int64();
            }
            //      C# -> System.Int32? LocalSlaSnapshots
            // GraphQL -> localSlaSnapshots: Int (scalar)
            if (this.LocalSlaSnapshots == null && Exploration.Includes(parent + ".localSlaSnapshots$"))
            {
                this.LocalSlaSnapshots = new System.Int32();
            }
            //      C# -> System.Int32? LocalSnapshots
            // GraphQL -> localSnapshots: Int (scalar)
            if (this.LocalSnapshots == null && Exploration.Includes(parent + ".localSnapshots$"))
            {
                this.LocalSnapshots = new System.Int32();
            }
            //      C# -> System.Int64? LocalStorage
            // GraphQL -> localStorage: Long (scalar)
            if (this.LocalStorage == null && Exploration.Includes(parent + ".localStorage$"))
            {
                this.LocalStorage = new System.Int64();
            }
            //      C# -> System.String? Location
            // GraphQL -> location: String! (scalar)
            if (this.Location == null && Exploration.Includes(parent + ".location$"))
            {
                this.Location = new System.String("FETCH");
            }
            //      C# -> System.Int64? LogicalBytes
            // GraphQL -> logicalBytes: Long (scalar)
            if (this.LogicalBytes == null && Exploration.Includes(parent + ".logicalBytes$"))
            {
                this.LogicalBytes = new System.Int64();
            }
            //      C# -> System.Single? LogicalDataReduction
            // GraphQL -> logicalDataReduction: Float (scalar)
            if (this.LogicalDataReduction == null && Exploration.Includes(parent + ".logicalDataReduction$"))
            {
                this.LogicalDataReduction = new System.Single();
            }
            //      C# -> System.Int32? MissedSnapshots
            // GraphQL -> missedSnapshots: Int (scalar)
            if (this.MissedSnapshots == null && Exploration.Includes(parent + ".missedSnapshots$"))
            {
                this.MissedSnapshots = new System.Int32();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: UUID (scalar)
            if (this.OrgId == null && Exploration.Includes(parent + ".orgId$"))
            {
                this.OrgId = new System.String("FETCH");
            }
            //      C# -> System.String? OrgName
            // GraphQL -> orgName: String (scalar)
            if (this.OrgName == null && Exploration.Includes(parent + ".orgName$"))
            {
                this.OrgName = new System.String("FETCH");
            }
            //      C# -> System.Int64? PhysicalBytes
            // GraphQL -> physicalBytes: Long (scalar)
            if (this.PhysicalBytes == null && Exploration.Includes(parent + ".physicalBytes$"))
            {
                this.PhysicalBytes = new System.Int64();
            }
            //      C# -> DateTime? ProtectedOn
            // GraphQL -> protectedOn: DateTime (scalar)
            if (this.ProtectedOn == null && Exploration.Includes(parent + ".protectedOn$"))
            {
                this.ProtectedOn = new DateTime();
            }
            //      C# -> System.Int64? ProvisionedBytes
            // GraphQL -> provisionedBytes: Long (scalar)
            if (this.ProvisionedBytes == null && Exploration.Includes(parent + ".provisionedBytes$"))
            {
                this.ProvisionedBytes = new System.Int64();
            }
            //      C# -> DateTime? PullTime
            // GraphQL -> pullTime: DateTime! (scalar)
            if (this.PullTime == null && Exploration.Includes(parent + ".pullTime$"))
            {
                this.PullTime = new DateTime();
            }
            //      C# -> System.Int32? ReplicaSnapshots
            // GraphQL -> replicaSnapshots: Int (scalar)
            if (this.ReplicaSnapshots == null && Exploration.Includes(parent + ".replicaSnapshots$"))
            {
                this.ReplicaSnapshots = new System.Int32();
            }
            //      C# -> System.Int64? ReplicaStorage
            // GraphQL -> replicaStorage: Long (scalar)
            if (this.ReplicaStorage == null && Exploration.Includes(parent + ".replicaStorage$"))
            {
                this.ReplicaStorage = new System.Int64();
            }
            //      C# -> System.Int32? ReplicationSnapshotLag
            // GraphQL -> replicationSnapshotLag: Int (scalar)
            if (this.ReplicationSnapshotLag == null && Exploration.Includes(parent + ".replicationSnapshotLag$"))
            {
                this.ReplicationSnapshotLag = new System.Int32();
            }
            //      C# -> System.Int32? TotalSnapshots
            // GraphQL -> totalSnapshots: Int (scalar)
            if (this.TotalSnapshots == null && Exploration.Includes(parent + ".totalSnapshots$"))
            {
                this.TotalSnapshots = new System.Int32();
            }
            //      C# -> System.Int64? TransferredBytes
            // GraphQL -> transferredBytes: Long (scalar)
            if (this.TransferredBytes == null && Exploration.Includes(parent + ".transferredBytes$"))
            {
                this.TransferredBytes = new System.Int64();
            }
            //      C# -> System.Int64? UsedBytes
            // GraphQL -> usedBytes: Long (scalar)
            if (this.UsedBytes == null && Exploration.Includes(parent + ".usedBytes$"))
            {
                this.UsedBytes = new System.Int64();
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> ComplianceStatusEnum? ArchivalComplianceStatus
            // GraphQL -> archivalComplianceStatus: ComplianceStatusEnum (enum)
            if (this.ArchivalComplianceStatus == null && Exploration.Includes(parent + ".archivalComplianceStatus$"))
            {
                this.ArchivalComplianceStatus = new ComplianceStatusEnum();
            }
            //      C# -> ComplianceStatusEnum? ComplianceStatus
            // GraphQL -> complianceStatus: ComplianceStatusEnum (enum)
            if (this.ComplianceStatus == null && Exploration.Includes(parent + ".complianceStatus$"))
            {
                this.ComplianceStatus = new ComplianceStatusEnum();
            }
            //      C# -> ObjectTypeEnum? ObjectType
            // GraphQL -> objectType: ObjectTypeEnum! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new ObjectTypeEnum();
            }
            //      C# -> ProtectionStatusEnum? ProtectionStatus
            // GraphQL -> protectionStatus: ProtectionStatusEnum! (enum)
            if (this.ProtectionStatus == null && Exploration.Includes(parent + ".protectionStatus$"))
            {
                this.ProtectionStatus = new ProtectionStatusEnum();
            }
            //      C# -> ComplianceStatusEnum? ReplicationComplianceStatus
            // GraphQL -> replicationComplianceStatus: ComplianceStatusEnum (enum)
            if (this.ReplicationComplianceStatus == null && Exploration.Includes(parent + ".replicationComplianceStatus$"))
            {
                this.ReplicationComplianceStatus = new ComplianceStatusEnum();
            }
            //      C# -> SlaDomain? SlaDomain
            // GraphQL -> slaDomain: SlaDomain (interface)
            if (this.SlaDomain == null && Exploration.Includes(parent + ".slaDomain"))
            {
                this.SlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.SlaDomain.ApplyExploratoryFragment(parent + ".slaDomain");
            }
        }


    #endregion

    } // class Snappable
    #endregion

    public static class ListSnappableExtensions
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
            this List<Snappable> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Snappable> list, 
            String parent = "")
        {
            var item = new Snappable();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types