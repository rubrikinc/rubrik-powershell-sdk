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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? ArchivalTarget
        // GraphQL -> archivalTarget: String (scalar)
        if (this.ArchivalTarget != null) {
            s += ind + "archivalTarget\n" ;
        }
        //      C# -> System.String? ClusterLocation
        // GraphQL -> clusterLocation: String! (scalar)
        if (this.ClusterLocation != null) {
            s += ind + "clusterLocation\n" ;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            s += ind + "clusterName\n" ;
        }
        //      C# -> System.String? ClusterType
        // GraphQL -> clusterType: String! (scalar)
        if (this.ClusterType != null) {
            s += ind + "clusterType\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.Single? DataReduction
        // GraphQL -> dataReduction: Float (scalar)
        if (this.DataReduction != null) {
            s += ind + "dataReduction\n" ;
        }
        //      C# -> System.Int64? DataTransferred
        // GraphQL -> dataTransferred: Long (scalar)
        if (this.DataTransferred != null) {
            s += ind + "dataTransferred\n" ;
        }
        //      C# -> System.Single? DedupRatio
        // GraphQL -> dedupRatio: Float (scalar)
        if (this.DedupRatio != null) {
            s += ind + "dedupRatio\n" ;
        }
        //      C# -> System.String? DirectArchive
        // GraphQL -> directArchive: String (scalar)
        if (this.DirectArchive != null) {
            s += ind + "directArchive\n" ;
        }
        //      C# -> System.Int64? Duration
        // GraphQL -> duration: Long! (scalar)
        if (this.Duration != null) {
            s += ind + "duration\n" ;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (this.FailureReason != null) {
            s += ind + "failureReason\n" ;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
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
        //      C# -> System.Single? LogicalDedupRatio
        // GraphQL -> logicalDedupRatio: Float (scalar)
        if (this.LogicalDedupRatio != null) {
            s += ind + "logicalDedupRatio\n" ;
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: String! (scalar)
        if (this.ObjectFid != null) {
            s += ind + "objectFid\n" ;
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName != null) {
            s += ind + "objectName\n" ;
        }
        //      C# -> System.String? ObjectType
        // GraphQL -> objectType: String! (scalar)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String (scalar)
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
        //      C# -> System.String? ProtectedVolume
        // GraphQL -> protectedVolume: String (scalar)
        if (this.ProtectedVolume != null) {
            s += ind + "protectedVolume\n" ;
        }
        //      C# -> System.String? RecoveryPoint
        // GraphQL -> recoveryPoint: String (scalar)
        if (this.RecoveryPoint != null) {
            s += ind + "recoveryPoint\n" ;
        }
        //      C# -> System.String? RecoveryPointType
        // GraphQL -> recoveryPointType: String (scalar)
        if (this.RecoveryPointType != null) {
            s += ind + "recoveryPointType\n" ;
        }
        //      C# -> System.String? ReplicationSource
        // GraphQL -> replicationSource: String (scalar)
        if (this.ReplicationSource != null) {
            s += ind + "replicationSource\n" ;
        }
        //      C# -> System.String? ReplicationTarget
        // GraphQL -> replicationTarget: String (scalar)
        if (this.ReplicationTarget != null) {
            s += ind + "replicationTarget\n" ;
        }
        //      C# -> System.String? ReportJobInstanceId
        // GraphQL -> reportJobInstanceId: String! (scalar)
        if (this.ReportJobInstanceId != null) {
            s += ind + "reportJobInstanceId\n" ;
        }
        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        if (this.SlaDomainId != null) {
            s += ind + "slaDomainId\n" ;
        }
        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        if (this.SlaDomainName != null) {
            s += ind + "slaDomainName\n" ;
        }
        //      C# -> System.String? SnapshotConsistency
        // GraphQL -> snapshotConsistency: String (scalar)
        if (this.SnapshotConsistency != null) {
            s += ind + "snapshotConsistency\n" ;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? TaskCategory
        // GraphQL -> taskCategory: String! (scalar)
        if (this.TaskCategory != null) {
            s += ind + "taskCategory\n" ;
        }
        //      C# -> System.String? TaskType
        // GraphQL -> taskType: String! (scalar)
        if (this.TaskType != null) {
            s += ind + "taskType\n" ;
        }
        //      C# -> System.Int64? TotalFilesTransferred
        // GraphQL -> totalFilesTransferred: Long (scalar)
        if (this.TotalFilesTransferred != null) {
            s += ind + "totalFilesTransferred\n" ;
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String (scalar)
        if (this.UserName != null) {
            s += ind + "userName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ArchivalTarget
        // GraphQL -> archivalTarget: String (scalar)
        if (this.ArchivalTarget == null && Exploration.Includes(parent + ".archivalTarget", true))
        {
            this.ArchivalTarget = "FETCH";
        }
        //      C# -> System.String? ClusterLocation
        // GraphQL -> clusterLocation: String! (scalar)
        if (this.ClusterLocation == null && Exploration.Includes(parent + ".clusterLocation", true))
        {
            this.ClusterLocation = "FETCH";
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName", true))
        {
            this.ClusterName = "FETCH";
        }
        //      C# -> System.String? ClusterType
        // GraphQL -> clusterType: String! (scalar)
        if (this.ClusterType == null && Exploration.Includes(parent + ".clusterType", true))
        {
            this.ClusterType = "FETCH";
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.Single? DataReduction
        // GraphQL -> dataReduction: Float (scalar)
        if (this.DataReduction == null && Exploration.Includes(parent + ".dataReduction", true))
        {
            this.DataReduction = new System.Single();
        }
        //      C# -> System.Int64? DataTransferred
        // GraphQL -> dataTransferred: Long (scalar)
        if (this.DataTransferred == null && Exploration.Includes(parent + ".dataTransferred", true))
        {
            this.DataTransferred = new System.Int64();
        }
        //      C# -> System.Single? DedupRatio
        // GraphQL -> dedupRatio: Float (scalar)
        if (this.DedupRatio == null && Exploration.Includes(parent + ".dedupRatio", true))
        {
            this.DedupRatio = new System.Single();
        }
        //      C# -> System.String? DirectArchive
        // GraphQL -> directArchive: String (scalar)
        if (this.DirectArchive == null && Exploration.Includes(parent + ".directArchive", true))
        {
            this.DirectArchive = "FETCH";
        }
        //      C# -> System.Int64? Duration
        // GraphQL -> duration: Long! (scalar)
        if (this.Duration == null && Exploration.Includes(parent + ".duration", true))
        {
            this.Duration = new System.Int64();
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = new DateTime();
        }
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String (scalar)
        if (this.FailureReason == null && Exploration.Includes(parent + ".failureReason", true))
        {
            this.FailureReason = "FETCH";
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.Int64();
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location == null && Exploration.Includes(parent + ".location", true))
        {
            this.Location = "FETCH";
        }
        //      C# -> System.Int64? LogicalBytes
        // GraphQL -> logicalBytes: Long (scalar)
        if (this.LogicalBytes == null && Exploration.Includes(parent + ".logicalBytes", true))
        {
            this.LogicalBytes = new System.Int64();
        }
        //      C# -> System.Single? LogicalDataReduction
        // GraphQL -> logicalDataReduction: Float (scalar)
        if (this.LogicalDataReduction == null && Exploration.Includes(parent + ".logicalDataReduction", true))
        {
            this.LogicalDataReduction = new System.Single();
        }
        //      C# -> System.Single? LogicalDedupRatio
        // GraphQL -> logicalDedupRatio: Float (scalar)
        if (this.LogicalDedupRatio == null && Exploration.Includes(parent + ".logicalDedupRatio", true))
        {
            this.LogicalDedupRatio = new System.Single();
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: String! (scalar)
        if (this.ObjectFid == null && Exploration.Includes(parent + ".objectFid", true))
        {
            this.ObjectFid = "FETCH";
        }
        //      C# -> System.String? ObjectName
        // GraphQL -> objectName: String! (scalar)
        if (this.ObjectName == null && Exploration.Includes(parent + ".objectName", true))
        {
            this.ObjectName = "FETCH";
        }
        //      C# -> System.String? ObjectType
        // GraphQL -> objectType: String! (scalar)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = "FETCH";
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String (scalar)
        if (this.OrgId == null && Exploration.Includes(parent + ".orgId", true))
        {
            this.OrgId = "FETCH";
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String (scalar)
        if (this.OrgName == null && Exploration.Includes(parent + ".orgName", true))
        {
            this.OrgName = "FETCH";
        }
        //      C# -> System.Int64? PhysicalBytes
        // GraphQL -> physicalBytes: Long (scalar)
        if (this.PhysicalBytes == null && Exploration.Includes(parent + ".physicalBytes", true))
        {
            this.PhysicalBytes = new System.Int64();
        }
        //      C# -> System.String? ProtectedVolume
        // GraphQL -> protectedVolume: String (scalar)
        if (this.ProtectedVolume == null && Exploration.Includes(parent + ".protectedVolume", true))
        {
            this.ProtectedVolume = "FETCH";
        }
        //      C# -> System.String? RecoveryPoint
        // GraphQL -> recoveryPoint: String (scalar)
        if (this.RecoveryPoint == null && Exploration.Includes(parent + ".recoveryPoint", true))
        {
            this.RecoveryPoint = "FETCH";
        }
        //      C# -> System.String? RecoveryPointType
        // GraphQL -> recoveryPointType: String (scalar)
        if (this.RecoveryPointType == null && Exploration.Includes(parent + ".recoveryPointType", true))
        {
            this.RecoveryPointType = "FETCH";
        }
        //      C# -> System.String? ReplicationSource
        // GraphQL -> replicationSource: String (scalar)
        if (this.ReplicationSource == null && Exploration.Includes(parent + ".replicationSource", true))
        {
            this.ReplicationSource = "FETCH";
        }
        //      C# -> System.String? ReplicationTarget
        // GraphQL -> replicationTarget: String (scalar)
        if (this.ReplicationTarget == null && Exploration.Includes(parent + ".replicationTarget", true))
        {
            this.ReplicationTarget = "FETCH";
        }
        //      C# -> System.String? ReportJobInstanceId
        // GraphQL -> reportJobInstanceId: String! (scalar)
        if (this.ReportJobInstanceId == null && Exploration.Includes(parent + ".reportJobInstanceId", true))
        {
            this.ReportJobInstanceId = "FETCH";
        }
        //      C# -> System.String? SlaDomainId
        // GraphQL -> slaDomainId: String! (scalar)
        if (this.SlaDomainId == null && Exploration.Includes(parent + ".slaDomainId", true))
        {
            this.SlaDomainId = "FETCH";
        }
        //      C# -> System.String? SlaDomainName
        // GraphQL -> slaDomainName: String! (scalar)
        if (this.SlaDomainName == null && Exploration.Includes(parent + ".slaDomainName", true))
        {
            this.SlaDomainName = "FETCH";
        }
        //      C# -> System.String? SnapshotConsistency
        // GraphQL -> snapshotConsistency: String (scalar)
        if (this.SnapshotConsistency == null && Exploration.Includes(parent + ".snapshotConsistency", true))
        {
            this.SnapshotConsistency = "FETCH";
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = new DateTime();
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = "FETCH";
        }
        //      C# -> System.String? TaskCategory
        // GraphQL -> taskCategory: String! (scalar)
        if (this.TaskCategory == null && Exploration.Includes(parent + ".taskCategory", true))
        {
            this.TaskCategory = "FETCH";
        }
        //      C# -> System.String? TaskType
        // GraphQL -> taskType: String! (scalar)
        if (this.TaskType == null && Exploration.Includes(parent + ".taskType", true))
        {
            this.TaskType = "FETCH";
        }
        //      C# -> System.Int64? TotalFilesTransferred
        // GraphQL -> totalFilesTransferred: Long (scalar)
        if (this.TotalFilesTransferred == null && Exploration.Includes(parent + ".totalFilesTransferred", true))
        {
            this.TotalFilesTransferred = new System.Int64();
        }
        //      C# -> System.String? UserName
        // GraphQL -> userName: String (scalar)
        if (this.UserName == null && Exploration.Includes(parent + ".userName", true))
        {
            this.UserName = "FETCH";
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
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TaskDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new TaskDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types