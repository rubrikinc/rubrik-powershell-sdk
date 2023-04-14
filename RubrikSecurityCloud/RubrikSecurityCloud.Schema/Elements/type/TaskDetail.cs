// TaskDetail.cs
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
    #region TaskDetail
    public class TaskDetail: IFragment
    {
        #region members
        //      C# -> System.String? ArchivalTarget
        // GraphQL -> archivalTarget: String (scalar)
        [JsonProperty("archivalTarget")]
        public System.String? ArchivalTarget { get; set; }

        //      C# -> System.String? ClusterLocation
        // GraphQL -> clusterLocation: String! (scalar)
        [JsonProperty("clusterLocation")]
        public System.String? ClusterLocation { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? ClusterType
        // GraphQL -> clusterType: String! (scalar)
        [JsonProperty("clusterType")]
        public System.String? ClusterType { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Single? DataReduction
        // GraphQL -> dataReduction: Float (scalar)
        [JsonProperty("dataReduction")]
        public System.Single? DataReduction { get; set; }

        //      C# -> System.Int64? DataTransferred
        // GraphQL -> dataTransferred: Long (scalar)
        [JsonProperty("dataTransferred")]
        public System.Int64? DataTransferred { get; set; }

        //      C# -> System.Single? DedupRatio
        // GraphQL -> dedupRatio: Float (scalar)
        [JsonProperty("dedupRatio")]
        public System.Single? DedupRatio { get; set; }

        //      C# -> System.String? DirectArchive
        // GraphQL -> directArchive: String (scalar)
        [JsonProperty("directArchive")]
        public System.String? DirectArchive { get; set; }

        //      C# -> System.Int64? Duration
        // GraphQL -> duration: Long! (scalar)
        [JsonProperty("duration")]
        public System.Int64? Duration { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        [JsonProperty("failureReason")]
        public System.String? FailureReason { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

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

        //      C# -> System.Single? LogicalDedupRatio
        // GraphQL -> logicalDedupRatio: Float (scalar)
        [JsonProperty("logicalDedupRatio")]
        public System.Single? LogicalDedupRatio { get; set; }

        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: String! (scalar)
        [JsonProperty("objectFid")]
        public System.String? ObjectFid { get; set; }

        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        [JsonProperty("objectName")]
        public System.String? ObjectName { get; set; }

        //      C# -> System.String? ObjectType
        // GraphQL -> objectType: String! (scalar)
        [JsonProperty("objectType")]
        public System.String? ObjectType { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String (scalar)
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

        //      C# -> System.String? ProtectedVolume
        // GraphQL -> protectedVolume: String (scalar)
        [JsonProperty("protectedVolume")]
        public System.String? ProtectedVolume { get; set; }

        //      C# -> System.String? RecoveryPoint
        // GraphQL -> recoveryPoint: String (scalar)
        [JsonProperty("recoveryPoint")]
        public System.String? RecoveryPoint { get; set; }

        //      C# -> System.String? RecoveryPointType
        // GraphQL -> recoveryPointType: String (scalar)
        [JsonProperty("recoveryPointType")]
        public System.String? RecoveryPointType { get; set; }

        //      C# -> System.String? ReplicationSource
        // GraphQL -> replicationSource: String (scalar)
        [JsonProperty("replicationSource")]
        public System.String? ReplicationSource { get; set; }

        //      C# -> System.String? ReplicationTarget
        // GraphQL -> replicationTarget: String (scalar)
        [JsonProperty("replicationTarget")]
        public System.String? ReplicationTarget { get; set; }

        //      C# -> System.String? ReportJobInstanceId
        // GraphQL -> reportJobInstanceId: String! (scalar)
        [JsonProperty("reportJobInstanceId")]
        public System.String? ReportJobInstanceId { get; set; }

        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        [JsonProperty("slaDomainId")]
        public System.String? SlaDomainId { get; set; }

        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        [JsonProperty("slaDomainName")]
        public System.String? SlaDomainName { get; set; }

        //      C# -> System.String? SnapshotConsistency
        // GraphQL -> snapshotConsistency: String (scalar)
        [JsonProperty("snapshotConsistency")]
        public System.String? SnapshotConsistency { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> System.String? TaskCategory
        // GraphQL -> taskCategory: String! (scalar)
        [JsonProperty("taskCategory")]
        public System.String? TaskCategory { get; set; }

        //      C# -> System.String? TaskType
        // GraphQL -> taskType: String! (scalar)
        [JsonProperty("taskType")]
        public System.String? TaskType { get; set; }

        //      C# -> System.Int64? TotalFilesTransferred
        // GraphQL -> totalFilesTransferred: Long (scalar)
        [JsonProperty("totalFilesTransferred")]
        public System.Int64? TotalFilesTransferred { get; set; }

        //      C# -> System.String? UserName
        // GraphQL -> userName: String (scalar)
        [JsonProperty("userName")]
        public System.String? UserName { get; set; }

        #endregion

    #region methods

    public TaskDetail Set(
        System.String? ArchivalTarget = null,
        System.String? ClusterLocation = null,
        System.String? ClusterName = null,
        System.String? ClusterType = null,
        System.String? ClusterUuid = null,
        System.Single? DataReduction = null,
        System.Int64? DataTransferred = null,
        System.Single? DedupRatio = null,
        System.String? DirectArchive = null,
        System.Int64? Duration = null,
        DateTime? EndTime = null,
        System.String? FailureReason = null,
        System.Int64? Id = null,
        System.String? Location = null,
        System.Int64? LogicalBytes = null,
        System.Single? LogicalDataReduction = null,
        System.Single? LogicalDedupRatio = null,
        System.String? ObjectFid = null,
        System.String? ObjectName = null,
        System.String? ObjectType = null,
        System.String? OrgId = null,
        System.String? OrgName = null,
        System.Int64? PhysicalBytes = null,
        System.String? ProtectedVolume = null,
        System.String? RecoveryPoint = null,
        System.String? RecoveryPointType = null,
        System.String? ReplicationSource = null,
        System.String? ReplicationTarget = null,
        System.String? ReportJobInstanceId = null,
        System.String? SlaDomainId = null,
        System.String? SlaDomainName = null,
        System.String? SnapshotConsistency = null,
        DateTime? StartTime = null,
        System.String? Status = null,
        System.String? TaskCategory = null,
        System.String? TaskType = null,
        System.Int64? TotalFilesTransferred = null,
        System.String? UserName = null
    ) 
    {
        if ( ArchivalTarget != null ) {
            this.ArchivalTarget = ArchivalTarget;
        }
        if ( ClusterLocation != null ) {
            this.ClusterLocation = ClusterLocation;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( ClusterType != null ) {
            this.ClusterType = ClusterType;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( DataReduction != null ) {
            this.DataReduction = DataReduction;
        }
        if ( DataTransferred != null ) {
            this.DataTransferred = DataTransferred;
        }
        if ( DedupRatio != null ) {
            this.DedupRatio = DedupRatio;
        }
        if ( DirectArchive != null ) {
            this.DirectArchive = DirectArchive;
        }
        if ( Duration != null ) {
            this.Duration = Duration;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( FailureReason != null ) {
            this.FailureReason = FailureReason;
        }
        if ( Id != null ) {
            this.Id = Id;
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
        if ( LogicalDedupRatio != null ) {
            this.LogicalDedupRatio = LogicalDedupRatio;
        }
        if ( ObjectFid != null ) {
            this.ObjectFid = ObjectFid;
        }
        if ( ObjectName != null ) {
            this.ObjectName = ObjectName;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
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
        if ( ProtectedVolume != null ) {
            this.ProtectedVolume = ProtectedVolume;
        }
        if ( RecoveryPoint != null ) {
            this.RecoveryPoint = RecoveryPoint;
        }
        if ( RecoveryPointType != null ) {
            this.RecoveryPointType = RecoveryPointType;
        }
        if ( ReplicationSource != null ) {
            this.ReplicationSource = ReplicationSource;
        }
        if ( ReplicationTarget != null ) {
            this.ReplicationTarget = ReplicationTarget;
        }
        if ( ReportJobInstanceId != null ) {
            this.ReportJobInstanceId = ReportJobInstanceId;
        }
        if ( SlaDomainId != null ) {
            this.SlaDomainId = SlaDomainId;
        }
        if ( SlaDomainName != null ) {
            this.SlaDomainName = SlaDomainName;
        }
        if ( SnapshotConsistency != null ) {
            this.SnapshotConsistency = SnapshotConsistency;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( TaskCategory != null ) {
            this.TaskCategory = TaskCategory;
        }
        if ( TaskType != null ) {
            this.TaskType = TaskType;
        }
        if ( TotalFilesTransferred != null ) {
            this.TotalFilesTransferred = TotalFilesTransferred;
        }
        if ( UserName != null ) {
            this.UserName = UserName;
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
            //      C# -> System.String? ArchivalTarget
            // GraphQL -> archivalTarget: String (scalar)
            if (this.ArchivalTarget != null)
            {
                 s += ind + "archivalTarget\n";

            }
            //      C# -> System.String? ClusterLocation
            // GraphQL -> clusterLocation: String! (scalar)
            if (this.ClusterLocation != null)
            {
                 s += ind + "clusterLocation\n";

            }
            //      C# -> System.String? ClusterName
            // GraphQL -> clusterName: String! (scalar)
            if (this.ClusterName != null)
            {
                 s += ind + "clusterName\n";

            }
            //      C# -> System.String? ClusterType
            // GraphQL -> clusterType: String! (scalar)
            if (this.ClusterType != null)
            {
                 s += ind + "clusterType\n";

            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> System.Single? DataReduction
            // GraphQL -> dataReduction: Float (scalar)
            if (this.DataReduction != null)
            {
                 s += ind + "dataReduction\n";

            }
            //      C# -> System.Int64? DataTransferred
            // GraphQL -> dataTransferred: Long (scalar)
            if (this.DataTransferred != null)
            {
                 s += ind + "dataTransferred\n";

            }
            //      C# -> System.Single? DedupRatio
            // GraphQL -> dedupRatio: Float (scalar)
            if (this.DedupRatio != null)
            {
                 s += ind + "dedupRatio\n";

            }
            //      C# -> System.String? DirectArchive
            // GraphQL -> directArchive: String (scalar)
            if (this.DirectArchive != null)
            {
                 s += ind + "directArchive\n";

            }
            //      C# -> System.Int64? Duration
            // GraphQL -> duration: Long! (scalar)
            if (this.Duration != null)
            {
                 s += ind + "duration\n";

            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime! (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> System.String? FailureReason
            // GraphQL -> failureReason: String (scalar)
            if (this.FailureReason != null)
            {
                 s += ind + "failureReason\n";

            }
            //      C# -> System.Int64? Id
            // GraphQL -> id: Long! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

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
            //      C# -> System.Single? LogicalDedupRatio
            // GraphQL -> logicalDedupRatio: Float (scalar)
            if (this.LogicalDedupRatio != null)
            {
                 s += ind + "logicalDedupRatio\n";

            }
            //      C# -> System.String? ObjectFid
            // GraphQL -> objectFid: String! (scalar)
            if (this.ObjectFid != null)
            {
                 s += ind + "objectFid\n";

            }
            //      C# -> System.String? ObjectName
            // GraphQL -> objectName: String! (scalar)
            if (this.ObjectName != null)
            {
                 s += ind + "objectName\n";

            }
            //      C# -> System.String? ObjectType
            // GraphQL -> objectType: String! (scalar)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: String (scalar)
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
            //      C# -> System.String? ProtectedVolume
            // GraphQL -> protectedVolume: String (scalar)
            if (this.ProtectedVolume != null)
            {
                 s += ind + "protectedVolume\n";

            }
            //      C# -> System.String? RecoveryPoint
            // GraphQL -> recoveryPoint: String (scalar)
            if (this.RecoveryPoint != null)
            {
                 s += ind + "recoveryPoint\n";

            }
            //      C# -> System.String? RecoveryPointType
            // GraphQL -> recoveryPointType: String (scalar)
            if (this.RecoveryPointType != null)
            {
                 s += ind + "recoveryPointType\n";

            }
            //      C# -> System.String? ReplicationSource
            // GraphQL -> replicationSource: String (scalar)
            if (this.ReplicationSource != null)
            {
                 s += ind + "replicationSource\n";

            }
            //      C# -> System.String? ReplicationTarget
            // GraphQL -> replicationTarget: String (scalar)
            if (this.ReplicationTarget != null)
            {
                 s += ind + "replicationTarget\n";

            }
            //      C# -> System.String? ReportJobInstanceId
            // GraphQL -> reportJobInstanceId: String! (scalar)
            if (this.ReportJobInstanceId != null)
            {
                 s += ind + "reportJobInstanceId\n";

            }
            //      C# -> System.String? SlaDomainId
            // GraphQL -> slaDomainId: String! (scalar)
            if (this.SlaDomainId != null)
            {
                 s += ind + "slaDomainId\n";

            }
            //      C# -> System.String? SlaDomainName
            // GraphQL -> slaDomainName: String! (scalar)
            if (this.SlaDomainName != null)
            {
                 s += ind + "slaDomainName\n";

            }
            //      C# -> System.String? SnapshotConsistency
            // GraphQL -> snapshotConsistency: String (scalar)
            if (this.SnapshotConsistency != null)
            {
                 s += ind + "snapshotConsistency\n";

            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime! (scalar)
            if (this.StartTime != null)
            {
                 s += ind + "startTime\n";

            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            //      C# -> System.String? TaskCategory
            // GraphQL -> taskCategory: String! (scalar)
            if (this.TaskCategory != null)
            {
                 s += ind + "taskCategory\n";

            }
            //      C# -> System.String? TaskType
            // GraphQL -> taskType: String! (scalar)
            if (this.TaskType != null)
            {
                 s += ind + "taskType\n";

            }
            //      C# -> System.Int64? TotalFilesTransferred
            // GraphQL -> totalFilesTransferred: Long (scalar)
            if (this.TotalFilesTransferred != null)
            {
                 s += ind + "totalFilesTransferred\n";

            }
            //      C# -> System.String? UserName
            // GraphQL -> userName: String (scalar)
            if (this.UserName != null)
            {
                 s += ind + "userName\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ArchivalTarget
            // GraphQL -> archivalTarget: String (scalar)
            if (this.ArchivalTarget == null && Exploration.Includes(parent + ".archivalTarget$"))
            {
                this.ArchivalTarget = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterLocation
            // GraphQL -> clusterLocation: String! (scalar)
            if (this.ClusterLocation == null && Exploration.Includes(parent + ".clusterLocation$"))
            {
                this.ClusterLocation = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterName
            // GraphQL -> clusterName: String! (scalar)
            if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName$"))
            {
                this.ClusterName = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterType
            // GraphQL -> clusterType: String! (scalar)
            if (this.ClusterType == null && Exploration.Includes(parent + ".clusterType$"))
            {
                this.ClusterType = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: UUID! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.Single? DataReduction
            // GraphQL -> dataReduction: Float (scalar)
            if (this.DataReduction == null && Exploration.Includes(parent + ".dataReduction$"))
            {
                this.DataReduction = new System.Single();
            }
            //      C# -> System.Int64? DataTransferred
            // GraphQL -> dataTransferred: Long (scalar)
            if (this.DataTransferred == null && Exploration.Includes(parent + ".dataTransferred$"))
            {
                this.DataTransferred = new System.Int64();
            }
            //      C# -> System.Single? DedupRatio
            // GraphQL -> dedupRatio: Float (scalar)
            if (this.DedupRatio == null && Exploration.Includes(parent + ".dedupRatio$"))
            {
                this.DedupRatio = new System.Single();
            }
            //      C# -> System.String? DirectArchive
            // GraphQL -> directArchive: String (scalar)
            if (this.DirectArchive == null && Exploration.Includes(parent + ".directArchive$"))
            {
                this.DirectArchive = new System.String("FETCH");
            }
            //      C# -> System.Int64? Duration
            // GraphQL -> duration: Long! (scalar)
            if (this.Duration == null && Exploration.Includes(parent + ".duration$"))
            {
                this.Duration = new System.Int64();
            }
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime! (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new DateTime();
            }
            //      C# -> System.String? FailureReason
            // GraphQL -> failureReason: String (scalar)
            if (this.FailureReason == null && Exploration.Includes(parent + ".failureReason$"))
            {
                this.FailureReason = new System.String("FETCH");
            }
            //      C# -> System.Int64? Id
            // GraphQL -> id: Long! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.Int64();
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
            //      C# -> System.Single? LogicalDedupRatio
            // GraphQL -> logicalDedupRatio: Float (scalar)
            if (this.LogicalDedupRatio == null && Exploration.Includes(parent + ".logicalDedupRatio$"))
            {
                this.LogicalDedupRatio = new System.Single();
            }
            //      C# -> System.String? ObjectFid
            // GraphQL -> objectFid: String! (scalar)
            if (this.ObjectFid == null && Exploration.Includes(parent + ".objectFid$"))
            {
                this.ObjectFid = new System.String("FETCH");
            }
            //      C# -> System.String? ObjectName
            // GraphQL -> objectName: String! (scalar)
            if (this.ObjectName == null && Exploration.Includes(parent + ".objectName$"))
            {
                this.ObjectName = new System.String("FETCH");
            }
            //      C# -> System.String? ObjectType
            // GraphQL -> objectType: String! (scalar)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new System.String("FETCH");
            }
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: String (scalar)
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
            //      C# -> System.String? ProtectedVolume
            // GraphQL -> protectedVolume: String (scalar)
            if (this.ProtectedVolume == null && Exploration.Includes(parent + ".protectedVolume$"))
            {
                this.ProtectedVolume = new System.String("FETCH");
            }
            //      C# -> System.String? RecoveryPoint
            // GraphQL -> recoveryPoint: String (scalar)
            if (this.RecoveryPoint == null && Exploration.Includes(parent + ".recoveryPoint$"))
            {
                this.RecoveryPoint = new System.String("FETCH");
            }
            //      C# -> System.String? RecoveryPointType
            // GraphQL -> recoveryPointType: String (scalar)
            if (this.RecoveryPointType == null && Exploration.Includes(parent + ".recoveryPointType$"))
            {
                this.RecoveryPointType = new System.String("FETCH");
            }
            //      C# -> System.String? ReplicationSource
            // GraphQL -> replicationSource: String (scalar)
            if (this.ReplicationSource == null && Exploration.Includes(parent + ".replicationSource$"))
            {
                this.ReplicationSource = new System.String("FETCH");
            }
            //      C# -> System.String? ReplicationTarget
            // GraphQL -> replicationTarget: String (scalar)
            if (this.ReplicationTarget == null && Exploration.Includes(parent + ".replicationTarget$"))
            {
                this.ReplicationTarget = new System.String("FETCH");
            }
            //      C# -> System.String? ReportJobInstanceId
            // GraphQL -> reportJobInstanceId: String! (scalar)
            if (this.ReportJobInstanceId == null && Exploration.Includes(parent + ".reportJobInstanceId$"))
            {
                this.ReportJobInstanceId = new System.String("FETCH");
            }
            //      C# -> System.String? SlaDomainId
            // GraphQL -> slaDomainId: String! (scalar)
            if (this.SlaDomainId == null && Exploration.Includes(parent + ".slaDomainId$"))
            {
                this.SlaDomainId = new System.String("FETCH");
            }
            //      C# -> System.String? SlaDomainName
            // GraphQL -> slaDomainName: String! (scalar)
            if (this.SlaDomainName == null && Exploration.Includes(parent + ".slaDomainName$"))
            {
                this.SlaDomainName = new System.String("FETCH");
            }
            //      C# -> System.String? SnapshotConsistency
            // GraphQL -> snapshotConsistency: String (scalar)
            if (this.SnapshotConsistency == null && Exploration.Includes(parent + ".snapshotConsistency$"))
            {
                this.SnapshotConsistency = new System.String("FETCH");
            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime! (scalar)
            if (this.StartTime == null && Exploration.Includes(parent + ".startTime$"))
            {
                this.StartTime = new DateTime();
            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new System.String("FETCH");
            }
            //      C# -> System.String? TaskCategory
            // GraphQL -> taskCategory: String! (scalar)
            if (this.TaskCategory == null && Exploration.Includes(parent + ".taskCategory$"))
            {
                this.TaskCategory = new System.String("FETCH");
            }
            //      C# -> System.String? TaskType
            // GraphQL -> taskType: String! (scalar)
            if (this.TaskType == null && Exploration.Includes(parent + ".taskType$"))
            {
                this.TaskType = new System.String("FETCH");
            }
            //      C# -> System.Int64? TotalFilesTransferred
            // GraphQL -> totalFilesTransferred: Long (scalar)
            if (this.TotalFilesTransferred == null && Exploration.Includes(parent + ".totalFilesTransferred$"))
            {
                this.TotalFilesTransferred = new System.Int64();
            }
            //      C# -> System.String? UserName
            // GraphQL -> userName: String (scalar)
            if (this.UserName == null && Exploration.Includes(parent + ".userName$"))
            {
                this.UserName = new System.String("FETCH");
            }
        }


    #endregion

    } // class TaskDetail
    #endregion

    public static class ListTaskDetailExtensions
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
            this List<TaskDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<TaskDetail> list, 
            String parent = "")
        {
            var item = new TaskDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types