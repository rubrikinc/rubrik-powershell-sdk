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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
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
        //      C# -> System.Single? AnomalyProbability
        // GraphQL -> anomalyProbability: Float! (scalar)
        if (this.AnomalyProbability != null) {
            s += ind + "anomalyProbability\n" ;
        }
        //      C# -> System.Int64? BytesCreatedCount
        // GraphQL -> bytesCreatedCount: Long (scalar)
        if (this.BytesCreatedCount != null) {
            s += ind + "bytesCreatedCount\n" ;
        }
        //      C# -> System.Int64? BytesDeletedCount
        // GraphQL -> bytesDeletedCount: Long (scalar)
        if (this.BytesDeletedCount != null) {
            s += ind + "bytesDeletedCount\n" ;
        }
        //      C# -> System.Int64? BytesModifiedCount
        // GraphQL -> bytesModifiedCount: Long (scalar)
        if (this.BytesModifiedCount != null) {
            s += ind + "bytesModifiedCount\n" ;
        }
        //      C# -> System.Int64? BytesNetChangedCount
        // GraphQL -> bytesNetChangedCount: Long (scalar)
        if (this.BytesNetChangedCount != null) {
            s += ind + "bytesNetChangedCount\n" ;
        }
        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime! (scalar)
        if (this.DetectionTime != null) {
            s += ind + "detectionTime\n" ;
        }
        //      C# -> System.Int64? FilesCreatedCount
        // GraphQL -> filesCreatedCount: Long (scalar)
        if (this.FilesCreatedCount != null) {
            s += ind + "filesCreatedCount\n" ;
        }
        //      C# -> System.Int64? FilesDeletedCount
        // GraphQL -> filesDeletedCount: Long (scalar)
        if (this.FilesDeletedCount != null) {
            s += ind + "filesDeletedCount\n" ;
        }
        //      C# -> System.Int64? FilesModifiedCount
        // GraphQL -> filesModifiedCount: Long (scalar)
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
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean (scalar)
        if (this.IsEncrypted != null) {
            s += ind + "isEncrypted\n" ;
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
        // GraphQL -> previousSnapshotDate: DateTime! (scalar)
        if (this.PreviousSnapshotDate != null) {
            s += ind + "previousSnapshotDate\n" ;
        }
        //      C# -> System.String? PreviousSnapshotId
        // GraphQL -> previousSnapshotId: String! (scalar)
        if (this.PreviousSnapshotId != null) {
            s += ind + "previousSnapshotId\n" ;
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime! (scalar)
        if (this.SnapshotDate != null) {
            s += ind + "snapshotDate\n" ;
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: UUID! (scalar)
        if (this.SnapshotFid != null) {
            s += ind + "snapshotFid\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> System.Int64? SuspiciousFilesCount
        // GraphQL -> suspiciousFilesCount: Long (scalar)
        if (this.SuspiciousFilesCount != null) {
            s += ind + "suspiciousFilesCount\n" ;
        }
        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: UUID! (scalar)
        if (this.WorkloadFid != null) {
            s += ind + "workloadFid\n" ;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId != null) {
            s += ind + "workloadId\n" ;
        }
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String (scalar)
        if (this.WorkloadName != null) {
            s += ind + "workloadName\n" ;
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ObjectTypeEnum? ObjectType
        // GraphQL -> objectType: ObjectTypeEnum (enum)
        if (this.ObjectType == null && ec.Includes("objectType",true))
        {
            this.ObjectType = new ObjectTypeEnum();
        }
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (this.Severity == null && ec.Includes("severity",true))
        {
            this.Severity = new ActivitySeverityEnum();
        }
        //      C# -> System.Single? AnomalyProbability
        // GraphQL -> anomalyProbability: Float! (scalar)
        if (this.AnomalyProbability == null && ec.Includes("anomalyProbability",true))
        {
            this.AnomalyProbability = new System.Single();
        }
        //      C# -> System.Int64? BytesCreatedCount
        // GraphQL -> bytesCreatedCount: Long (scalar)
        if (this.BytesCreatedCount == null && ec.Includes("bytesCreatedCount",true))
        {
            this.BytesCreatedCount = new System.Int64();
        }
        //      C# -> System.Int64? BytesDeletedCount
        // GraphQL -> bytesDeletedCount: Long (scalar)
        if (this.BytesDeletedCount == null && ec.Includes("bytesDeletedCount",true))
        {
            this.BytesDeletedCount = new System.Int64();
        }
        //      C# -> System.Int64? BytesModifiedCount
        // GraphQL -> bytesModifiedCount: Long (scalar)
        if (this.BytesModifiedCount == null && ec.Includes("bytesModifiedCount",true))
        {
            this.BytesModifiedCount = new System.Int64();
        }
        //      C# -> System.Int64? BytesNetChangedCount
        // GraphQL -> bytesNetChangedCount: Long (scalar)
        if (this.BytesNetChangedCount == null && ec.Includes("bytesNetChangedCount",true))
        {
            this.BytesNetChangedCount = new System.Int64();
        }
        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime! (scalar)
        if (this.DetectionTime == null && ec.Includes("detectionTime",true))
        {
            this.DetectionTime = new DateTime();
        }
        //      C# -> System.Int64? FilesCreatedCount
        // GraphQL -> filesCreatedCount: Long (scalar)
        if (this.FilesCreatedCount == null && ec.Includes("filesCreatedCount",true))
        {
            this.FilesCreatedCount = new System.Int64();
        }
        //      C# -> System.Int64? FilesDeletedCount
        // GraphQL -> filesDeletedCount: Long (scalar)
        if (this.FilesDeletedCount == null && ec.Includes("filesDeletedCount",true))
        {
            this.FilesDeletedCount = new System.Int64();
        }
        //      C# -> System.Int64? FilesModifiedCount
        // GraphQL -> filesModifiedCount: Long (scalar)
        if (this.FilesModifiedCount == null && ec.Includes("filesModifiedCount",true))
        {
            this.FilesModifiedCount = new System.Int64();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (this.IsAnomaly == null && ec.Includes("isAnomaly",true))
        {
            this.IsAnomaly = true;
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean (scalar)
        if (this.IsEncrypted == null && ec.Includes("isEncrypted",true))
        {
            this.IsEncrypted = true;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location == null && ec.Includes("location",true))
        {
            this.Location = "FETCH";
        }
        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        if (this.ManagedId == null && ec.Includes("managedId",true))
        {
            this.ManagedId = "FETCH";
        }
        //      C# -> DateTime? PreviousSnapshotDate
        // GraphQL -> previousSnapshotDate: DateTime! (scalar)
        if (this.PreviousSnapshotDate == null && ec.Includes("previousSnapshotDate",true))
        {
            this.PreviousSnapshotDate = new DateTime();
        }
        //      C# -> System.String? PreviousSnapshotId
        // GraphQL -> previousSnapshotId: String! (scalar)
        if (this.PreviousSnapshotId == null && ec.Includes("previousSnapshotId",true))
        {
            this.PreviousSnapshotId = "FETCH";
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime! (scalar)
        if (this.SnapshotDate == null && ec.Includes("snapshotDate",true))
        {
            this.SnapshotDate = new DateTime();
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: UUID! (scalar)
        if (this.SnapshotFid == null && ec.Includes("snapshotFid",true))
        {
            this.SnapshotFid = "FETCH";
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId == null && ec.Includes("snapshotId",true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> System.Int64? SuspiciousFilesCount
        // GraphQL -> suspiciousFilesCount: Long (scalar)
        if (this.SuspiciousFilesCount == null && ec.Includes("suspiciousFilesCount",true))
        {
            this.SuspiciousFilesCount = new System.Int64();
        }
        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: UUID! (scalar)
        if (this.WorkloadFid == null && ec.Includes("workloadFid",true))
        {
            this.WorkloadFid = "FETCH";
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId == null && ec.Includes("workloadId",true))
        {
            this.WorkloadId = "FETCH";
        }
        //      C# -> System.String? WorkloadName
        // GraphQL -> workloadName: String (scalar)
        if (this.WorkloadName == null && ec.Includes("workloadName",true))
        {
            this.WorkloadName = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
        //      C# -> RansomwareResult? RansomwareResult
        // GraphQL -> ransomwareResult: RansomwareResult (type)
        if (this.RansomwareResult == null && ec.Includes("ransomwareResult",false))
        {
            this.RansomwareResult = new RansomwareResult();
            this.RansomwareResult.ApplyExploratoryFieldSpec(ec.NewChild("ransomwareResult"));
        }
        //      C# -> CdmSnapshot? Snapshot
        // GraphQL -> snapshot: CdmSnapshot (type)
        if (this.Snapshot == null && ec.Includes("snapshot",false))
        {
            this.Snapshot = new CdmSnapshot();
            this.Snapshot.ApplyExploratoryFieldSpec(ec.NewChild("snapshot"));
        }
    }


    #endregion

    } // class AnomalyResult
    
    #endregion

    public static class ListAnomalyResultExtensions
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
            this List<AnomalyResult> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<AnomalyResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types