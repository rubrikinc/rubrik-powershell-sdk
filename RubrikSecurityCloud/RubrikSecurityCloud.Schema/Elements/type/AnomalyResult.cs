// AnomalyResult.cs
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
    #region AnomalyResult
    public class AnomalyResult: BaseType
    {
        #region members

        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum (enum)
        [JsonProperty("objectType")]
        public ObjectTypeEnum? ObjectType { get; set; }

        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        [JsonProperty("severity")]
        public ActivitySeverityEnum? Severity { get; set; }

        //      C# -> System.Single? AnomalyProbability
        // GraphQL -> anomalyProbability: Float! (scalar)
        [JsonProperty("anomalyProbability")]
        public System.Single? AnomalyProbability { get; set; }

        //      C# -> System.Int64? BytesCreatedCount
        // GraphQL -> bytesCreatedCount: Long (scalar)
        [JsonProperty("bytesCreatedCount")]
        public System.Int64? BytesCreatedCount { get; set; }

        //      C# -> System.Int64? BytesDeletedCount
        // GraphQL -> bytesDeletedCount: Long (scalar)
        [JsonProperty("bytesDeletedCount")]
        public System.Int64? BytesDeletedCount { get; set; }

        //      C# -> System.Int64? BytesModifiedCount
        // GraphQL -> bytesModifiedCount: Long (scalar)
        [JsonProperty("bytesModifiedCount")]
        public System.Int64? BytesModifiedCount { get; set; }

        //      C# -> System.Int64? BytesNetChangedCount
        // GraphQL -> bytesNetChangedCount: Long (scalar)
        [JsonProperty("bytesNetChangedCount")]
        public System.Int64? BytesNetChangedCount { get; set; }

        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime! (scalar)
        [JsonProperty("detectionTime")]
        public DateTime? DetectionTime { get; set; }

        //      C# -> System.Int64? FilesCreatedCount
        // GraphQL -> filesCreatedCount: Long (scalar)
        [JsonProperty("filesCreatedCount")]
        public System.Int64? FilesCreatedCount { get; set; }

        //      C# -> System.Int64? FilesDeletedCount
        // GraphQL -> filesDeletedCount: Long (scalar)
        [JsonProperty("filesDeletedCount")]
        public System.Int64? FilesDeletedCount { get; set; }

        //      C# -> System.Int64? FilesModifiedCount
        // GraphQL -> filesModifiedCount: Long (scalar)
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

        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean (scalar)
        [JsonProperty("isEncrypted")]
        public System.Boolean? IsEncrypted { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        [JsonProperty("managedId")]
        public System.String? ManagedId { get; set; }

        //      C# -> DateTime? PreviousSnapshotDate
        // GraphQL -> previousSnapshotDate: DateTime! (scalar)
        [JsonProperty("previousSnapshotDate")]
        public DateTime? PreviousSnapshotDate { get; set; }

        //      C# -> System.String? PreviousSnapshotId
        // GraphQL -> previousSnapshotId: String! (scalar)
        [JsonProperty("previousSnapshotId")]
        public System.String? PreviousSnapshotId { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime! (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: UUID! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Int64? SuspiciousFilesCount
        // GraphQL -> suspiciousFilesCount: Long (scalar)
        [JsonProperty("suspiciousFilesCount")]
        public System.Int64? SuspiciousFilesCount { get; set; }

        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: UUID! (scalar)
        [JsonProperty("workloadFid")]
        public System.String? WorkloadFid { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String (scalar)
        [JsonProperty("workloadName")]
        public System.String? WorkloadName { get; set; }

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
        return "AnomalyResult";
    }

    public AnomalyResult Set(
        ObjectTypeEnum? ObjectType = null,
        ActivitySeverityEnum? Severity = null,
        System.Single? AnomalyProbability = null,
        System.Int64? BytesCreatedCount = null,
        System.Int64? BytesDeletedCount = null,
        System.Int64? BytesModifiedCount = null,
        System.Int64? BytesNetChangedCount = null,
        DateTime? DetectionTime = null,
        System.Int64? FilesCreatedCount = null,
        System.Int64? FilesDeletedCount = null,
        System.Int64? FilesModifiedCount = null,
        System.String? Id = null,
        System.Boolean? IsAnomaly = null,
        System.Boolean? IsEncrypted = null,
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
        Cluster? Cluster = null,
        RansomwareResult? RansomwareResult = null,
        CdmSnapshot? Snapshot = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
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
        if ( IsEncrypted != null ) {
            this.IsEncrypted = IsEncrypted;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> System.Single? AnomalyProbability
        // GraphQL -> anomalyProbability: Float! (scalar)
        if (this.AnomalyProbability != null) {
            if (conf.Flat) {
                s += conf.Prefix + "anomalyProbability\n" ;
            } else {
                s += ind + "anomalyProbability\n" ;
            }
        }
        //      C# -> System.Int64? BytesCreatedCount
        // GraphQL -> bytesCreatedCount: Long (scalar)
        if (this.BytesCreatedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesCreatedCount\n" ;
            } else {
                s += ind + "bytesCreatedCount\n" ;
            }
        }
        //      C# -> System.Int64? BytesDeletedCount
        // GraphQL -> bytesDeletedCount: Long (scalar)
        if (this.BytesDeletedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesDeletedCount\n" ;
            } else {
                s += ind + "bytesDeletedCount\n" ;
            }
        }
        //      C# -> System.Int64? BytesModifiedCount
        // GraphQL -> bytesModifiedCount: Long (scalar)
        if (this.BytesModifiedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesModifiedCount\n" ;
            } else {
                s += ind + "bytesModifiedCount\n" ;
            }
        }
        //      C# -> System.Int64? BytesNetChangedCount
        // GraphQL -> bytesNetChangedCount: Long (scalar)
        if (this.BytesNetChangedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bytesNetChangedCount\n" ;
            } else {
                s += ind + "bytesNetChangedCount\n" ;
            }
        }
        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime! (scalar)
        if (this.DetectionTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "detectionTime\n" ;
            } else {
                s += ind + "detectionTime\n" ;
            }
        }
        //      C# -> System.Int64? FilesCreatedCount
        // GraphQL -> filesCreatedCount: Long (scalar)
        if (this.FilesCreatedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesCreatedCount\n" ;
            } else {
                s += ind + "filesCreatedCount\n" ;
            }
        }
        //      C# -> System.Int64? FilesDeletedCount
        // GraphQL -> filesDeletedCount: Long (scalar)
        if (this.FilesDeletedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesDeletedCount\n" ;
            } else {
                s += ind + "filesDeletedCount\n" ;
            }
        }
        //      C# -> System.Int64? FilesModifiedCount
        // GraphQL -> filesModifiedCount: Long (scalar)
        if (this.FilesModifiedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filesModifiedCount\n" ;
            } else {
                s += ind + "filesModifiedCount\n" ;
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
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (this.IsAnomaly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAnomaly\n" ;
            } else {
                s += ind + "isAnomaly\n" ;
            }
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean (scalar)
        if (this.IsEncrypted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEncrypted\n" ;
            } else {
                s += ind + "isEncrypted\n" ;
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
        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        if (this.ManagedId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "managedId\n" ;
            } else {
                s += ind + "managedId\n" ;
            }
        }
        //      C# -> DateTime? PreviousSnapshotDate
        // GraphQL -> previousSnapshotDate: DateTime! (scalar)
        if (this.PreviousSnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "previousSnapshotDate\n" ;
            } else {
                s += ind + "previousSnapshotDate\n" ;
            }
        }
        //      C# -> System.String? PreviousSnapshotId
        // GraphQL -> previousSnapshotId: String! (scalar)
        if (this.PreviousSnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "previousSnapshotId\n" ;
            } else {
                s += ind + "previousSnapshotId\n" ;
            }
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime! (scalar)
        if (this.SnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotDate\n" ;
            } else {
                s += ind + "snapshotDate\n" ;
            }
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: UUID! (scalar)
        if (this.SnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotFid\n" ;
            } else {
                s += ind + "snapshotFid\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.Int64? SuspiciousFilesCount
        // GraphQL -> suspiciousFilesCount: Long (scalar)
        if (this.SuspiciousFilesCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "suspiciousFilesCount\n" ;
            } else {
                s += ind + "suspiciousFilesCount\n" ;
            }
        }
        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: UUID! (scalar)
        if (this.WorkloadFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadFid\n" ;
            } else {
                s += ind + "workloadFid\n" ;
            }
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadId\n" ;
            } else {
                s += ind + "workloadId\n" ;
            }
        }
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String (scalar)
        if (this.WorkloadName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadName\n" ;
            } else {
                s += ind + "workloadName\n" ;
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
        //      C# -> RansomwareResult? RansomwareResult
        // GraphQL -> ransomwareResult: RansomwareResult (type)
        if (this.RansomwareResult != null) {
            var fspec = this.RansomwareResult.AsFieldSpec(conf.Child("ransomwareResult"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ransomwareResult" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot (type)
        if (this.Snapshot != null) {
            var fspec = this.Snapshot.AsFieldSpec(conf.Child("snapshot"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshot" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum (enum)
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
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new ActivitySeverityEnum();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> System.Single? AnomalyProbability
        // GraphQL -> anomalyProbability: Float! (scalar)
        if (ec.Includes("anomalyProbability",true))
        {
            if(this.AnomalyProbability == null) {

                this.AnomalyProbability = new System.Single();

            } else {


            }
        }
        else if (this.AnomalyProbability != null && ec.Excludes("anomalyProbability",true))
        {
            this.AnomalyProbability = null;
        }
        //      C# -> System.Int64? BytesCreatedCount
        // GraphQL -> bytesCreatedCount: Long (scalar)
        if (ec.Includes("bytesCreatedCount",true))
        {
            if(this.BytesCreatedCount == null) {

                this.BytesCreatedCount = new System.Int64();

            } else {


            }
        }
        else if (this.BytesCreatedCount != null && ec.Excludes("bytesCreatedCount",true))
        {
            this.BytesCreatedCount = null;
        }
        //      C# -> System.Int64? BytesDeletedCount
        // GraphQL -> bytesDeletedCount: Long (scalar)
        if (ec.Includes("bytesDeletedCount",true))
        {
            if(this.BytesDeletedCount == null) {

                this.BytesDeletedCount = new System.Int64();

            } else {


            }
        }
        else if (this.BytesDeletedCount != null && ec.Excludes("bytesDeletedCount",true))
        {
            this.BytesDeletedCount = null;
        }
        //      C# -> System.Int64? BytesModifiedCount
        // GraphQL -> bytesModifiedCount: Long (scalar)
        if (ec.Includes("bytesModifiedCount",true))
        {
            if(this.BytesModifiedCount == null) {

                this.BytesModifiedCount = new System.Int64();

            } else {


            }
        }
        else if (this.BytesModifiedCount != null && ec.Excludes("bytesModifiedCount",true))
        {
            this.BytesModifiedCount = null;
        }
        //      C# -> System.Int64? BytesNetChangedCount
        // GraphQL -> bytesNetChangedCount: Long (scalar)
        if (ec.Includes("bytesNetChangedCount",true))
        {
            if(this.BytesNetChangedCount == null) {

                this.BytesNetChangedCount = new System.Int64();

            } else {


            }
        }
        else if (this.BytesNetChangedCount != null && ec.Excludes("bytesNetChangedCount",true))
        {
            this.BytesNetChangedCount = null;
        }
        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime! (scalar)
        if (ec.Includes("detectionTime",true))
        {
            if(this.DetectionTime == null) {

                this.DetectionTime = new DateTime();

            } else {


            }
        }
        else if (this.DetectionTime != null && ec.Excludes("detectionTime",true))
        {
            this.DetectionTime = null;
        }
        //      C# -> System.Int64? FilesCreatedCount
        // GraphQL -> filesCreatedCount: Long (scalar)
        if (ec.Includes("filesCreatedCount",true))
        {
            if(this.FilesCreatedCount == null) {

                this.FilesCreatedCount = new System.Int64();

            } else {


            }
        }
        else if (this.FilesCreatedCount != null && ec.Excludes("filesCreatedCount",true))
        {
            this.FilesCreatedCount = null;
        }
        //      C# -> System.Int64? FilesDeletedCount
        // GraphQL -> filesDeletedCount: Long (scalar)
        if (ec.Includes("filesDeletedCount",true))
        {
            if(this.FilesDeletedCount == null) {

                this.FilesDeletedCount = new System.Int64();

            } else {


            }
        }
        else if (this.FilesDeletedCount != null && ec.Excludes("filesDeletedCount",true))
        {
            this.FilesDeletedCount = null;
        }
        //      C# -> System.Int64? FilesModifiedCount
        // GraphQL -> filesModifiedCount: Long (scalar)
        if (ec.Includes("filesModifiedCount",true))
        {
            if(this.FilesModifiedCount == null) {

                this.FilesModifiedCount = new System.Int64();

            } else {


            }
        }
        else if (this.FilesModifiedCount != null && ec.Excludes("filesModifiedCount",true))
        {
            this.FilesModifiedCount = null;
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
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (ec.Includes("isAnomaly",true))
        {
            if(this.IsAnomaly == null) {

                this.IsAnomaly = true;

            } else {


            }
        }
        else if (this.IsAnomaly != null && ec.Excludes("isAnomaly",true))
        {
            this.IsAnomaly = null;
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean (scalar)
        if (ec.Includes("isEncrypted",true))
        {
            if(this.IsEncrypted == null) {

                this.IsEncrypted = true;

            } else {


            }
        }
        else if (this.IsEncrypted != null && ec.Excludes("isEncrypted",true))
        {
            this.IsEncrypted = null;
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
        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        if (ec.Includes("managedId",true))
        {
            if(this.ManagedId == null) {

                this.ManagedId = "FETCH";

            } else {


            }
        }
        else if (this.ManagedId != null && ec.Excludes("managedId",true))
        {
            this.ManagedId = null;
        }
        //      C# -> DateTime? PreviousSnapshotDate
        // GraphQL -> previousSnapshotDate: DateTime! (scalar)
        if (ec.Includes("previousSnapshotDate",true))
        {
            if(this.PreviousSnapshotDate == null) {

                this.PreviousSnapshotDate = new DateTime();

            } else {


            }
        }
        else if (this.PreviousSnapshotDate != null && ec.Excludes("previousSnapshotDate",true))
        {
            this.PreviousSnapshotDate = null;
        }
        //      C# -> System.String? PreviousSnapshotId
        // GraphQL -> previousSnapshotId: String! (scalar)
        if (ec.Includes("previousSnapshotId",true))
        {
            if(this.PreviousSnapshotId == null) {

                this.PreviousSnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.PreviousSnapshotId != null && ec.Excludes("previousSnapshotId",true))
        {
            this.PreviousSnapshotId = null;
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime! (scalar)
        if (ec.Includes("snapshotDate",true))
        {
            if(this.SnapshotDate == null) {

                this.SnapshotDate = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotDate != null && ec.Excludes("snapshotDate",true))
        {
            this.SnapshotDate = null;
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: UUID! (scalar)
        if (ec.Includes("snapshotFid",true))
        {
            if(this.SnapshotFid == null) {

                this.SnapshotFid = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotFid != null && ec.Excludes("snapshotFid",true))
        {
            this.SnapshotFid = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> System.Int64? SuspiciousFilesCount
        // GraphQL -> suspiciousFilesCount: Long (scalar)
        if (ec.Includes("suspiciousFilesCount",true))
        {
            if(this.SuspiciousFilesCount == null) {

                this.SuspiciousFilesCount = new System.Int64();

            } else {


            }
        }
        else if (this.SuspiciousFilesCount != null && ec.Excludes("suspiciousFilesCount",true))
        {
            this.SuspiciousFilesCount = null;
        }
        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: UUID! (scalar)
        if (ec.Includes("workloadFid",true))
        {
            if(this.WorkloadFid == null) {

                this.WorkloadFid = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadFid != null && ec.Excludes("workloadFid",true))
        {
            this.WorkloadFid = null;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (ec.Includes("workloadId",true))
        {
            if(this.WorkloadId == null) {

                this.WorkloadId = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadId != null && ec.Excludes("workloadId",true))
        {
            this.WorkloadId = null;
        }
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String (scalar)
        if (ec.Includes("workloadName",true))
        {
            if(this.WorkloadName == null) {

                this.WorkloadName = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadName != null && ec.Excludes("workloadName",true))
        {
            this.WorkloadName = null;
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
        //      C# -> RansomwareResult? RansomwareResult
        // GraphQL -> ransomwareResult: RansomwareResult (type)
        if (ec.Includes("ransomwareResult",false))
        {
            if(this.RansomwareResult == null) {

                this.RansomwareResult = new RansomwareResult();
                this.RansomwareResult.ApplyExploratoryFieldSpec(ec.NewChild("ransomwareResult"));

            } else {

                this.RansomwareResult.ApplyExploratoryFieldSpec(ec.NewChild("ransomwareResult"));

            }
        }
        else if (this.RansomwareResult != null && ec.Excludes("ransomwareResult",false))
        {
            this.RansomwareResult = null;
        }
        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot (type)
        if (ec.Includes("snapshot",false))
        {
            if(this.Snapshot == null) {

                this.Snapshot = new CdmSnapshot();
                this.Snapshot.ApplyExploratoryFieldSpec(ec.NewChild("snapshot"));

            } else {

                this.Snapshot.ApplyExploratoryFieldSpec(ec.NewChild("snapshot"));

            }
        }
        else if (this.Snapshot != null && ec.Excludes("snapshot",false))
        {
            this.Snapshot = null;
        }
    }


    #endregion

    } // class AnomalyResult
    
    #endregion

    public static class ListAnomalyResultExtensions
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
            this List<AnomalyResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnomalyResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AnomalyResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnomalyResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnomalyResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types