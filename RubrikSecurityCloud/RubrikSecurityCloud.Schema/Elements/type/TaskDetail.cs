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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region TaskDetail
    public class TaskDetail: BaseType
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

    public override string GetGqlTypeName() {
        return "TaskDetail";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? ArchivalTarget
        // GraphQL -> archivalTarget: String (scalar)
        if (this.ArchivalTarget != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalTarget\n" ;
            } else {
                s += ind + "archivalTarget\n" ;
            }
        }
        //      C# -> System.String? ClusterLocation
        // GraphQL -> clusterLocation: String! (scalar)
        if (this.ClusterLocation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterLocation\n" ;
            } else {
                s += ind + "clusterLocation\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.String? ClusterType
        // GraphQL -> clusterType: String! (scalar)
        if (this.ClusterType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterType\n" ;
            } else {
                s += ind + "clusterType\n" ;
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
        //      C# -> System.Single? DataReduction
        // GraphQL -> dataReduction: Float (scalar)
        if (this.DataReduction != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataReduction\n" ;
            } else {
                s += ind + "dataReduction\n" ;
            }
        }
        //      C# -> System.Int64? DataTransferred
        // GraphQL -> dataTransferred: Long (scalar)
        if (this.DataTransferred != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataTransferred\n" ;
            } else {
                s += ind + "dataTransferred\n" ;
            }
        }
        //      C# -> System.Single? DedupRatio
        // GraphQL -> dedupRatio: Float (scalar)
        if (this.DedupRatio != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dedupRatio\n" ;
            } else {
                s += ind + "dedupRatio\n" ;
            }
        }
        //      C# -> System.String? DirectArchive
        // GraphQL -> directArchive: String (scalar)
        if (this.DirectArchive != null) {
            if (conf.Flat) {
                s += conf.Prefix + "directArchive\n" ;
            } else {
                s += ind + "directArchive\n" ;
            }
        }
        //      C# -> System.Int64? Duration
        // GraphQL -> duration: Long! (scalar)
        if (this.Duration != null) {
            if (conf.Flat) {
                s += conf.Prefix + "duration\n" ;
            } else {
                s += ind + "duration\n" ;
            }
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (this.FailureReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failureReason\n" ;
            } else {
                s += ind + "failureReason\n" ;
            }
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
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
        //      C# -> System.Single? LogicalDedupRatio
        // GraphQL -> logicalDedupRatio: Float (scalar)
        if (this.LogicalDedupRatio != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logicalDedupRatio\n" ;
            } else {
                s += ind + "logicalDedupRatio\n" ;
            }
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: String! (scalar)
        if (this.ObjectFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectFid\n" ;
            } else {
                s += ind + "objectFid\n" ;
            }
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectName\n" ;
            } else {
                s += ind + "objectName\n" ;
            }
        }
        //      C# -> System.String? ObjectType
        // GraphQL -> objectType: String! (scalar)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String (scalar)
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
        //      C# -> System.String? ProtectedVolume
        // GraphQL -> protectedVolume: String (scalar)
        if (this.ProtectedVolume != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectedVolume\n" ;
            } else {
                s += ind + "protectedVolume\n" ;
            }
        }
        //      C# -> System.String? RecoveryPoint
        // GraphQL -> recoveryPoint: String (scalar)
        if (this.RecoveryPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPoint\n" ;
            } else {
                s += ind + "recoveryPoint\n" ;
            }
        }
        //      C# -> System.String? RecoveryPointType
        // GraphQL -> recoveryPointType: String (scalar)
        if (this.RecoveryPointType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPointType\n" ;
            } else {
                s += ind + "recoveryPointType\n" ;
            }
        }
        //      C# -> System.String? ReplicationSource
        // GraphQL -> replicationSource: String (scalar)
        if (this.ReplicationSource != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationSource\n" ;
            } else {
                s += ind + "replicationSource\n" ;
            }
        }
        //      C# -> System.String? ReplicationTarget
        // GraphQL -> replicationTarget: String (scalar)
        if (this.ReplicationTarget != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicationTarget\n" ;
            } else {
                s += ind + "replicationTarget\n" ;
            }
        }
        //      C# -> System.String? ReportJobInstanceId
        // GraphQL -> reportJobInstanceId: String! (scalar)
        if (this.ReportJobInstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "reportJobInstanceId\n" ;
            } else {
                s += ind + "reportJobInstanceId\n" ;
            }
        }
        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        if (this.SlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaDomainId\n" ;
            } else {
                s += ind + "slaDomainId\n" ;
            }
        }
        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        if (this.SlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "slaDomainName\n" ;
            } else {
                s += ind + "slaDomainName\n" ;
            }
        }
        //      C# -> System.String? SnapshotConsistency
        // GraphQL -> snapshotConsistency: String (scalar)
        if (this.SnapshotConsistency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotConsistency\n" ;
            } else {
                s += ind + "snapshotConsistency\n" ;
            }
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? TaskCategory
        // GraphQL -> taskCategory: String! (scalar)
        if (this.TaskCategory != null) {
            if (conf.Flat) {
                s += conf.Prefix + "taskCategory\n" ;
            } else {
                s += ind + "taskCategory\n" ;
            }
        }
        //      C# -> System.String? TaskType
        // GraphQL -> taskType: String! (scalar)
        if (this.TaskType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "taskType\n" ;
            } else {
                s += ind + "taskType\n" ;
            }
        }
        //      C# -> System.Int64? TotalFilesTransferred
        // GraphQL -> totalFilesTransferred: Long (scalar)
        if (this.TotalFilesTransferred != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalFilesTransferred\n" ;
            } else {
                s += ind + "totalFilesTransferred\n" ;
            }
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String (scalar)
        if (this.UserName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userName\n" ;
            } else {
                s += ind + "userName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ArchivalTarget
        // GraphQL -> archivalTarget: String (scalar)
        if (ec.Includes("archivalTarget",true))
        {
            if(this.ArchivalTarget == null) {

                this.ArchivalTarget = "FETCH";

            } else {


            }
        }
        else if (this.ArchivalTarget != null && ec.Excludes("archivalTarget",true))
        {
            this.ArchivalTarget = null;
        }
        //      C# -> System.String? ClusterLocation
        // GraphQL -> clusterLocation: String! (scalar)
        if (ec.Includes("clusterLocation",true))
        {
            if(this.ClusterLocation == null) {

                this.ClusterLocation = "FETCH";

            } else {


            }
        }
        else if (this.ClusterLocation != null && ec.Excludes("clusterLocation",true))
        {
            this.ClusterLocation = null;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
        }
        //      C# -> System.String? ClusterType
        // GraphQL -> clusterType: String! (scalar)
        if (ec.Includes("clusterType",true))
        {
            if(this.ClusterType == null) {

                this.ClusterType = "FETCH";

            } else {


            }
        }
        else if (this.ClusterType != null && ec.Excludes("clusterType",true))
        {
            this.ClusterType = null;
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
        //      C# -> System.Int64? DataTransferred
        // GraphQL -> dataTransferred: Long (scalar)
        if (ec.Includes("dataTransferred",true))
        {
            if(this.DataTransferred == null) {

                this.DataTransferred = new System.Int64();

            } else {


            }
        }
        else if (this.DataTransferred != null && ec.Excludes("dataTransferred",true))
        {
            this.DataTransferred = null;
        }
        //      C# -> System.Single? DedupRatio
        // GraphQL -> dedupRatio: Float (scalar)
        if (ec.Includes("dedupRatio",true))
        {
            if(this.DedupRatio == null) {

                this.DedupRatio = new System.Single();

            } else {


            }
        }
        else if (this.DedupRatio != null && ec.Excludes("dedupRatio",true))
        {
            this.DedupRatio = null;
        }
        //      C# -> System.String? DirectArchive
        // GraphQL -> directArchive: String (scalar)
        if (ec.Includes("directArchive",true))
        {
            if(this.DirectArchive == null) {

                this.DirectArchive = "FETCH";

            } else {


            }
        }
        else if (this.DirectArchive != null && ec.Excludes("directArchive",true))
        {
            this.DirectArchive = null;
        }
        //      C# -> System.Int64? Duration
        // GraphQL -> duration: Long! (scalar)
        if (ec.Includes("duration",true))
        {
            if(this.Duration == null) {

                this.Duration = new System.Int64();

            } else {


            }
        }
        else if (this.Duration != null && ec.Excludes("duration",true))
        {
            this.Duration = null;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new DateTime();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (ec.Includes("failureReason",true))
        {
            if(this.FailureReason == null) {

                this.FailureReason = "FETCH";

            } else {


            }
        }
        else if (this.FailureReason != null && ec.Excludes("failureReason",true))
        {
            this.FailureReason = null;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = new System.Int64();

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
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
        //      C# -> System.Single? LogicalDedupRatio
        // GraphQL -> logicalDedupRatio: Float (scalar)
        if (ec.Includes("logicalDedupRatio",true))
        {
            if(this.LogicalDedupRatio == null) {

                this.LogicalDedupRatio = new System.Single();

            } else {


            }
        }
        else if (this.LogicalDedupRatio != null && ec.Excludes("logicalDedupRatio",true))
        {
            this.LogicalDedupRatio = null;
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: String! (scalar)
        if (ec.Includes("objectFid",true))
        {
            if(this.ObjectFid == null) {

                this.ObjectFid = "FETCH";

            } else {


            }
        }
        else if (this.ObjectFid != null && ec.Excludes("objectFid",true))
        {
            this.ObjectFid = null;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (ec.Includes("objectName",true))
        {
            if(this.ObjectName == null) {

                this.ObjectName = "FETCH";

            } else {


            }
        }
        else if (this.ObjectName != null && ec.Excludes("objectName",true))
        {
            this.ObjectName = null;
        }
        //      C# -> System.String? ObjectType
        // GraphQL -> objectType: String! (scalar)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = "FETCH";

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String (scalar)
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
        //      C# -> System.String? ProtectedVolume
        // GraphQL -> protectedVolume: String (scalar)
        if (ec.Includes("protectedVolume",true))
        {
            if(this.ProtectedVolume == null) {

                this.ProtectedVolume = "FETCH";

            } else {


            }
        }
        else if (this.ProtectedVolume != null && ec.Excludes("protectedVolume",true))
        {
            this.ProtectedVolume = null;
        }
        //      C# -> System.String? RecoveryPoint
        // GraphQL -> recoveryPoint: String (scalar)
        if (ec.Includes("recoveryPoint",true))
        {
            if(this.RecoveryPoint == null) {

                this.RecoveryPoint = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryPoint != null && ec.Excludes("recoveryPoint",true))
        {
            this.RecoveryPoint = null;
        }
        //      C# -> System.String? RecoveryPointType
        // GraphQL -> recoveryPointType: String (scalar)
        if (ec.Includes("recoveryPointType",true))
        {
            if(this.RecoveryPointType == null) {

                this.RecoveryPointType = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryPointType != null && ec.Excludes("recoveryPointType",true))
        {
            this.RecoveryPointType = null;
        }
        //      C# -> System.String? ReplicationSource
        // GraphQL -> replicationSource: String (scalar)
        if (ec.Includes("replicationSource",true))
        {
            if(this.ReplicationSource == null) {

                this.ReplicationSource = "FETCH";

            } else {


            }
        }
        else if (this.ReplicationSource != null && ec.Excludes("replicationSource",true))
        {
            this.ReplicationSource = null;
        }
        //      C# -> System.String? ReplicationTarget
        // GraphQL -> replicationTarget: String (scalar)
        if (ec.Includes("replicationTarget",true))
        {
            if(this.ReplicationTarget == null) {

                this.ReplicationTarget = "FETCH";

            } else {


            }
        }
        else if (this.ReplicationTarget != null && ec.Excludes("replicationTarget",true))
        {
            this.ReplicationTarget = null;
        }
        //      C# -> System.String? ReportJobInstanceId
        // GraphQL -> reportJobInstanceId: String! (scalar)
        if (ec.Includes("reportJobInstanceId",true))
        {
            if(this.ReportJobInstanceId == null) {

                this.ReportJobInstanceId = "FETCH";

            } else {


            }
        }
        else if (this.ReportJobInstanceId != null && ec.Excludes("reportJobInstanceId",true))
        {
            this.ReportJobInstanceId = null;
        }
        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        if (ec.Includes("slaDomainId",true))
        {
            if(this.SlaDomainId == null) {

                this.SlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.SlaDomainId != null && ec.Excludes("slaDomainId",true))
        {
            this.SlaDomainId = null;
        }
        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        if (ec.Includes("slaDomainName",true))
        {
            if(this.SlaDomainName == null) {

                this.SlaDomainName = "FETCH";

            } else {


            }
        }
        else if (this.SlaDomainName != null && ec.Excludes("slaDomainName",true))
        {
            this.SlaDomainName = null;
        }
        //      C# -> System.String? SnapshotConsistency
        // GraphQL -> snapshotConsistency: String (scalar)
        if (ec.Includes("snapshotConsistency",true))
        {
            if(this.SnapshotConsistency == null) {

                this.SnapshotConsistency = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotConsistency != null && ec.Excludes("snapshotConsistency",true))
        {
            this.SnapshotConsistency = null;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new DateTime();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = "FETCH";

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? TaskCategory
        // GraphQL -> taskCategory: String! (scalar)
        if (ec.Includes("taskCategory",true))
        {
            if(this.TaskCategory == null) {

                this.TaskCategory = "FETCH";

            } else {


            }
        }
        else if (this.TaskCategory != null && ec.Excludes("taskCategory",true))
        {
            this.TaskCategory = null;
        }
        //      C# -> System.String? TaskType
        // GraphQL -> taskType: String! (scalar)
        if (ec.Includes("taskType",true))
        {
            if(this.TaskType == null) {

                this.TaskType = "FETCH";

            } else {


            }
        }
        else if (this.TaskType != null && ec.Excludes("taskType",true))
        {
            this.TaskType = null;
        }
        //      C# -> System.Int64? TotalFilesTransferred
        // GraphQL -> totalFilesTransferred: Long (scalar)
        if (ec.Includes("totalFilesTransferred",true))
        {
            if(this.TotalFilesTransferred == null) {

                this.TotalFilesTransferred = new System.Int64();

            } else {


            }
        }
        else if (this.TotalFilesTransferred != null && ec.Excludes("totalFilesTransferred",true))
        {
            this.TotalFilesTransferred = null;
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String (scalar)
        if (ec.Includes("userName",true))
        {
            if(this.UserName == null) {

                this.UserName = "FETCH";

            } else {


            }
        }
        else if (this.UserName != null && ec.Excludes("userName",true))
        {
            this.UserName = null;
        }
    }


    #endregion

    } // class TaskDetail
    
    #endregion

    public static class ListTaskDetailExtensions
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
            this List<TaskDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<TaskDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TaskDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TaskDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TaskDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types