// GetAnomalyDetailsReply.cs
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
    #region GetAnomalyDetailsReply
    public class GetAnomalyDetailsReply: BaseType
    {
        #region members

        //      C# -> AnomalyType? AnomalyType
        // GraphQL -> anomalyType: AnomalyType! (enum)
        [JsonProperty("anomalyType")]
        public AnomalyType? AnomalyType { get; set; }

        //      C# -> EncryptionLevel? Encryption
        // GraphQL -> encryption: EncryptionLevel! (enum)
        [JsonProperty("encryption")]
        public EncryptionLevel? Encryption { get; set; }

        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum (enum)
        [JsonProperty("objectType")]
        public ObjectTypeEnum? ObjectType { get; set; }

        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        [JsonProperty("severity")]
        public ActivitySeverityEnum? Severity { get; set; }

        //      C# -> System.String? ActivitySeriesId
        // GraphQL -> activitySeriesId: String! (scalar)
        [JsonProperty("activitySeriesId")]
        public System.String? ActivitySeriesId { get; set; }

        //      C# -> System.Single? AnomalyProbability
        // GraphQL -> anomalyProbability: Float! (scalar)
        [JsonProperty("anomalyProbability")]
        public System.Single? AnomalyProbability { get; set; }

        //      C# -> System.Int64? BytesCreatedCount
        // GraphQL -> bytesCreatedCount: Long! (scalar)
        [JsonProperty("bytesCreatedCount")]
        public System.Int64? BytesCreatedCount { get; set; }

        //      C# -> System.Int64? BytesDeletedCount
        // GraphQL -> bytesDeletedCount: Long! (scalar)
        [JsonProperty("bytesDeletedCount")]
        public System.Int64? BytesDeletedCount { get; set; }

        //      C# -> System.Int64? BytesModifiedCount
        // GraphQL -> bytesModifiedCount: Long! (scalar)
        [JsonProperty("bytesModifiedCount")]
        public System.Int64? BytesModifiedCount { get; set; }

        //      C# -> System.Int64? BytesNetChangedCount
        // GraphQL -> bytesNetChangedCount: Long! (scalar)
        [JsonProperty("bytesNetChangedCount")]
        public System.Int64? BytesNetChangedCount { get; set; }

        //      C# -> System.Int64? BytesSuspiciousCount
        // GraphQL -> bytesSuspiciousCount: Long! (scalar)
        [JsonProperty("bytesSuspiciousCount")]
        public System.Int64? BytesSuspiciousCount { get; set; }

        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime (scalar)
        [JsonProperty("detectionTime")]
        public DateTime? DetectionTime { get; set; }

        //      C# -> System.Int64? FilesCreatedCount
        // GraphQL -> filesCreatedCount: Long! (scalar)
        [JsonProperty("filesCreatedCount")]
        public System.Int64? FilesCreatedCount { get; set; }

        //      C# -> System.Int64? FilesDeletedCount
        // GraphQL -> filesDeletedCount: Long! (scalar)
        [JsonProperty("filesDeletedCount")]
        public System.Int64? FilesDeletedCount { get; set; }

        //      C# -> System.Int64? FilesModifiedCount
        // GraphQL -> filesModifiedCount: Long! (scalar)
        [JsonProperty("filesModifiedCount")]
        public System.Int64? FilesModifiedCount { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        [JsonProperty("isAnomaly")]
        public System.Boolean? IsAnomaly { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        [JsonProperty("managedId")]
        public System.String? ManagedId { get; set; }

        //      C# -> DateTime? PreviousSnapshotDate
        // GraphQL -> previousSnapshotDate: DateTime (scalar)
        [JsonProperty("previousSnapshotDate")]
        public DateTime? PreviousSnapshotDate { get; set; }

        //      C# -> System.String? PreviousSnapshotId
        // GraphQL -> previousSnapshotId: String! (scalar)
        [JsonProperty("previousSnapshotId")]
        public System.String? PreviousSnapshotId { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Int64? SuspiciousFilesCount
        // GraphQL -> suspiciousFilesCount: Long! (scalar)
        [JsonProperty("suspiciousFilesCount")]
        public System.Int64? SuspiciousFilesCount { get; set; }

        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: String! (scalar)
        [JsonProperty("workloadFid")]
        public System.String? WorkloadFid { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        [JsonProperty("workloadName")]
        public System.String? WorkloadName { get; set; }

        //      C# -> AnomalyInfo? AnomalyInfo
        // GraphQL -> anomalyInfo: AnomalyInfo (type)
        [JsonProperty("anomalyInfo")]
        public AnomalyInfo? AnomalyInfo { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> RansomwareResult? RansomwareResult
        // GraphQL -> ransomwareResult: RansomwareResult (type)
        [JsonProperty("ransomwareResult")]
        public RansomwareResult? RansomwareResult { get; set; }

        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot (type)
        [JsonProperty("snapshot")]
        public CdmSnapshot? Snapshot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetAnomalyDetailsReply";
    }

    public GetAnomalyDetailsReply Set(
        AnomalyType? AnomalyType = null,
        EncryptionLevel? Encryption = null,
        ObjectTypeEnum? ObjectType = null,
        ActivitySeverityEnum? Severity = null,
        System.String? ActivitySeriesId = null,
        System.Single? AnomalyProbability = null,
        System.Int64? BytesCreatedCount = null,
        System.Int64? BytesDeletedCount = null,
        System.Int64? BytesModifiedCount = null,
        System.Int64? BytesNetChangedCount = null,
        System.Int64? BytesSuspiciousCount = null,
        DateTime? DetectionTime = null,
        System.Int64? FilesCreatedCount = null,
        System.Int64? FilesDeletedCount = null,
        System.Int64? FilesModifiedCount = null,
        System.String? Id = null,
        System.Boolean? IsAnomaly = null,
        System.String? Location = null,
        System.String? ManagedId = null,
        DateTime? PreviousSnapshotDate = null,
        System.String? PreviousSnapshotId = null,
        DateTime? SnapshotDate = null,
        System.String? SnapshotFid = null,
        System.String? SnapshotId = null,
        System.Int64? SuspiciousFilesCount = null,
        System.String? WorkloadFid = null,
        System.String? WorkloadId = null,
        System.String? WorkloadName = null,
        AnomalyInfo? AnomalyInfo = null,
        Cluster? Cluster = null,
        RansomwareResult? RansomwareResult = null,
        CdmSnapshot? Snapshot = null
    ) 
    {
        if ( AnomalyType != null ) {
            this.AnomalyType = AnomalyType;
        }
        if ( Encryption != null ) {
            this.Encryption = Encryption;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( ActivitySeriesId != null ) {
            this.ActivitySeriesId = ActivitySeriesId;
        }
        if ( AnomalyProbability != null ) {
            this.AnomalyProbability = AnomalyProbability;
        }
        if ( BytesCreatedCount != null ) {
            this.BytesCreatedCount = BytesCreatedCount;
        }
        if ( BytesDeletedCount != null ) {
            this.BytesDeletedCount = BytesDeletedCount;
        }
        if ( BytesModifiedCount != null ) {
            this.BytesModifiedCount = BytesModifiedCount;
        }
        if ( BytesNetChangedCount != null ) {
            this.BytesNetChangedCount = BytesNetChangedCount;
        }
        if ( BytesSuspiciousCount != null ) {
            this.BytesSuspiciousCount = BytesSuspiciousCount;
        }
        if ( DetectionTime != null ) {
            this.DetectionTime = DetectionTime;
        }
        if ( FilesCreatedCount != null ) {
            this.FilesCreatedCount = FilesCreatedCount;
        }
        if ( FilesDeletedCount != null ) {
            this.FilesDeletedCount = FilesDeletedCount;
        }
        if ( FilesModifiedCount != null ) {
            this.FilesModifiedCount = FilesModifiedCount;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsAnomaly != null ) {
            this.IsAnomaly = IsAnomaly;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( ManagedId != null ) {
            this.ManagedId = ManagedId;
        }
        if ( PreviousSnapshotDate != null ) {
            this.PreviousSnapshotDate = PreviousSnapshotDate;
        }
        if ( PreviousSnapshotId != null ) {
            this.PreviousSnapshotId = PreviousSnapshotId;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( SuspiciousFilesCount != null ) {
            this.SuspiciousFilesCount = SuspiciousFilesCount;
        }
        if ( WorkloadFid != null ) {
            this.WorkloadFid = WorkloadFid;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( WorkloadName != null ) {
            this.WorkloadName = WorkloadName;
        }
        if ( AnomalyInfo != null ) {
            this.AnomalyInfo = AnomalyInfo;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( RansomwareResult != null ) {
            this.RansomwareResult = RansomwareResult;
        }
        if ( Snapshot != null ) {
            this.Snapshot = Snapshot;
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
        //      C# -> AnomalyType? AnomalyType
        // GraphQL -> anomalyType: AnomalyType! (enum)
        if (this.AnomalyType != null) {
            s += ind + "anomalyType\n" ;
        }
        //      C# -> EncryptionLevel? Encryption
        // GraphQL -> encryption: EncryptionLevel! (enum)
        if (this.Encryption != null) {
            s += ind + "encryption\n" ;
        }
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (this.Severity != null) {
            s += ind + "severity\n" ;
        }
        //      C# -> System.String? ActivitySeriesId
        // GraphQL -> activitySeriesId: String! (scalar)
        if (this.ActivitySeriesId != null) {
            s += ind + "activitySeriesId\n" ;
        }
        //      C# -> System.Single? AnomalyProbability
        // GraphQL -> anomalyProbability: Float! (scalar)
        if (this.AnomalyProbability != null) {
            s += ind + "anomalyProbability\n" ;
        }
        //      C# -> System.Int64? BytesCreatedCount
        // GraphQL -> bytesCreatedCount: Long! (scalar)
        if (this.BytesCreatedCount != null) {
            s += ind + "bytesCreatedCount\n" ;
        }
        //      C# -> System.Int64? BytesDeletedCount
        // GraphQL -> bytesDeletedCount: Long! (scalar)
        if (this.BytesDeletedCount != null) {
            s += ind + "bytesDeletedCount\n" ;
        }
        //      C# -> System.Int64? BytesModifiedCount
        // GraphQL -> bytesModifiedCount: Long! (scalar)
        if (this.BytesModifiedCount != null) {
            s += ind + "bytesModifiedCount\n" ;
        }
        //      C# -> System.Int64? BytesNetChangedCount
        // GraphQL -> bytesNetChangedCount: Long! (scalar)
        if (this.BytesNetChangedCount != null) {
            s += ind + "bytesNetChangedCount\n" ;
        }
        //      C# -> System.Int64? BytesSuspiciousCount
        // GraphQL -> bytesSuspiciousCount: Long! (scalar)
        if (this.BytesSuspiciousCount != null) {
            s += ind + "bytesSuspiciousCount\n" ;
        }
        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime (scalar)
        if (this.DetectionTime != null) {
            s += ind + "detectionTime\n" ;
        }
        //      C# -> System.Int64? FilesCreatedCount
        // GraphQL -> filesCreatedCount: Long! (scalar)
        if (this.FilesCreatedCount != null) {
            s += ind + "filesCreatedCount\n" ;
        }
        //      C# -> System.Int64? FilesDeletedCount
        // GraphQL -> filesDeletedCount: Long! (scalar)
        if (this.FilesDeletedCount != null) {
            s += ind + "filesDeletedCount\n" ;
        }
        //      C# -> System.Int64? FilesModifiedCount
        // GraphQL -> filesModifiedCount: Long! (scalar)
        if (this.FilesModifiedCount != null) {
            s += ind + "filesModifiedCount\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (this.IsAnomaly != null) {
            s += ind + "isAnomaly\n" ;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            s += ind + "location\n" ;
        }
        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        if (this.ManagedId != null) {
            s += ind + "managedId\n" ;
        }
        //      C# -> DateTime? PreviousSnapshotDate
        // GraphQL -> previousSnapshotDate: DateTime (scalar)
        if (this.PreviousSnapshotDate != null) {
            s += ind + "previousSnapshotDate\n" ;
        }
        //      C# -> System.String? PreviousSnapshotId
        // GraphQL -> previousSnapshotId: String! (scalar)
        if (this.PreviousSnapshotId != null) {
            s += ind + "previousSnapshotId\n" ;
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate != null) {
            s += ind + "snapshotDate\n" ;
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid != null) {
            s += ind + "snapshotFid\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> System.Int64? SuspiciousFilesCount
        // GraphQL -> suspiciousFilesCount: Long! (scalar)
        if (this.SuspiciousFilesCount != null) {
            s += ind + "suspiciousFilesCount\n" ;
        }
        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: String! (scalar)
        if (this.WorkloadFid != null) {
            s += ind + "workloadFid\n" ;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId != null) {
            s += ind + "workloadId\n" ;
        }
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        if (this.WorkloadName != null) {
            s += ind + "workloadName\n" ;
        }
        //      C# -> AnomalyInfo? AnomalyInfo
        // GraphQL -> anomalyInfo: AnomalyInfo (type)
        if (this.AnomalyInfo != null) {
            var fspec = this.AnomalyInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "anomalyInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RansomwareResult? RansomwareResult
        // GraphQL -> ransomwareResult: RansomwareResult (type)
        if (this.RansomwareResult != null) {
            var fspec = this.RansomwareResult.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ransomwareResult {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot (type)
        if (this.Snapshot != null) {
            var fspec = this.Snapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AnomalyType? AnomalyType
        // GraphQL -> anomalyType: AnomalyType! (enum)
        if (this.AnomalyType == null && Exploration.Includes(parent + ".anomalyType", true))
        {
            this.AnomalyType = new AnomalyType();
        }
        //      C# -> EncryptionLevel? Encryption
        // GraphQL -> encryption: EncryptionLevel! (enum)
        if (this.Encryption == null && Exploration.Includes(parent + ".encryption", true))
        {
            this.Encryption = new EncryptionLevel();
        }
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new ObjectTypeEnum();
        }
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (this.Severity == null && Exploration.Includes(parent + ".severity", true))
        {
            this.Severity = new ActivitySeverityEnum();
        }
        //      C# -> System.String? ActivitySeriesId
        // GraphQL -> activitySeriesId: String! (scalar)
        if (this.ActivitySeriesId == null && Exploration.Includes(parent + ".activitySeriesId", true))
        {
            this.ActivitySeriesId = "FETCH";
        }
        //      C# -> System.Single? AnomalyProbability
        // GraphQL -> anomalyProbability: Float! (scalar)
        if (this.AnomalyProbability == null && Exploration.Includes(parent + ".anomalyProbability", true))
        {
            this.AnomalyProbability = new System.Single();
        }
        //      C# -> System.Int64? BytesCreatedCount
        // GraphQL -> bytesCreatedCount: Long! (scalar)
        if (this.BytesCreatedCount == null && Exploration.Includes(parent + ".bytesCreatedCount", true))
        {
            this.BytesCreatedCount = new System.Int64();
        }
        //      C# -> System.Int64? BytesDeletedCount
        // GraphQL -> bytesDeletedCount: Long! (scalar)
        if (this.BytesDeletedCount == null && Exploration.Includes(parent + ".bytesDeletedCount", true))
        {
            this.BytesDeletedCount = new System.Int64();
        }
        //      C# -> System.Int64? BytesModifiedCount
        // GraphQL -> bytesModifiedCount: Long! (scalar)
        if (this.BytesModifiedCount == null && Exploration.Includes(parent + ".bytesModifiedCount", true))
        {
            this.BytesModifiedCount = new System.Int64();
        }
        //      C# -> System.Int64? BytesNetChangedCount
        // GraphQL -> bytesNetChangedCount: Long! (scalar)
        if (this.BytesNetChangedCount == null && Exploration.Includes(parent + ".bytesNetChangedCount", true))
        {
            this.BytesNetChangedCount = new System.Int64();
        }
        //      C# -> System.Int64? BytesSuspiciousCount
        // GraphQL -> bytesSuspiciousCount: Long! (scalar)
        if (this.BytesSuspiciousCount == null && Exploration.Includes(parent + ".bytesSuspiciousCount", true))
        {
            this.BytesSuspiciousCount = new System.Int64();
        }
        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime (scalar)
        if (this.DetectionTime == null && Exploration.Includes(parent + ".detectionTime", true))
        {
            this.DetectionTime = new DateTime();
        }
        //      C# -> System.Int64? FilesCreatedCount
        // GraphQL -> filesCreatedCount: Long! (scalar)
        if (this.FilesCreatedCount == null && Exploration.Includes(parent + ".filesCreatedCount", true))
        {
            this.FilesCreatedCount = new System.Int64();
        }
        //      C# -> System.Int64? FilesDeletedCount
        // GraphQL -> filesDeletedCount: Long! (scalar)
        if (this.FilesDeletedCount == null && Exploration.Includes(parent + ".filesDeletedCount", true))
        {
            this.FilesDeletedCount = new System.Int64();
        }
        //      C# -> System.Int64? FilesModifiedCount
        // GraphQL -> filesModifiedCount: Long! (scalar)
        if (this.FilesModifiedCount == null && Exploration.Includes(parent + ".filesModifiedCount", true))
        {
            this.FilesModifiedCount = new System.Int64();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (this.IsAnomaly == null && Exploration.Includes(parent + ".isAnomaly", true))
        {
            this.IsAnomaly = true;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location == null && Exploration.Includes(parent + ".location", true))
        {
            this.Location = "FETCH";
        }
        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        if (this.ManagedId == null && Exploration.Includes(parent + ".managedId", true))
        {
            this.ManagedId = "FETCH";
        }
        //      C# -> DateTime? PreviousSnapshotDate
        // GraphQL -> previousSnapshotDate: DateTime (scalar)
        if (this.PreviousSnapshotDate == null && Exploration.Includes(parent + ".previousSnapshotDate", true))
        {
            this.PreviousSnapshotDate = new DateTime();
        }
        //      C# -> System.String? PreviousSnapshotId
        // GraphQL -> previousSnapshotId: String! (scalar)
        if (this.PreviousSnapshotId == null && Exploration.Includes(parent + ".previousSnapshotId", true))
        {
            this.PreviousSnapshotId = "FETCH";
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate == null && Exploration.Includes(parent + ".snapshotDate", true))
        {
            this.SnapshotDate = new DateTime();
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid == null && Exploration.Includes(parent + ".snapshotFid", true))
        {
            this.SnapshotFid = "FETCH";
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> System.Int64? SuspiciousFilesCount
        // GraphQL -> suspiciousFilesCount: Long! (scalar)
        if (this.SuspiciousFilesCount == null && Exploration.Includes(parent + ".suspiciousFilesCount", true))
        {
            this.SuspiciousFilesCount = new System.Int64();
        }
        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: String! (scalar)
        if (this.WorkloadFid == null && Exploration.Includes(parent + ".workloadFid", true))
        {
            this.WorkloadFid = "FETCH";
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId", true))
        {
            this.WorkloadId = "FETCH";
        }
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String! (scalar)
        if (this.WorkloadName == null && Exploration.Includes(parent + ".workloadName", true))
        {
            this.WorkloadName = "FETCH";
        }
        //      C# -> AnomalyInfo? AnomalyInfo
        // GraphQL -> anomalyInfo: AnomalyInfo (type)
        if (this.AnomalyInfo == null && Exploration.Includes(parent + ".anomalyInfo"))
        {
            this.AnomalyInfo = new AnomalyInfo();
            this.AnomalyInfo.ApplyExploratoryFieldSpec(parent + ".anomalyInfo");
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> RansomwareResult? RansomwareResult
        // GraphQL -> ransomwareResult: RansomwareResult (type)
        if (this.RansomwareResult == null && Exploration.Includes(parent + ".ransomwareResult"))
        {
            this.RansomwareResult = new RansomwareResult();
            this.RansomwareResult.ApplyExploratoryFieldSpec(parent + ".ransomwareResult");
        }
        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot (type)
        if (this.Snapshot == null && Exploration.Includes(parent + ".snapshot"))
        {
            this.Snapshot = new CdmSnapshot();
            this.Snapshot.ApplyExploratoryFieldSpec(parent + ".snapshot");
        }
    }


    #endregion

    } // class GetAnomalyDetailsReply
    
    #endregion

    public static class ListGetAnomalyDetailsReplyExtensions
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
            this List<GetAnomalyDetailsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetAnomalyDetailsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetAnomalyDetailsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types