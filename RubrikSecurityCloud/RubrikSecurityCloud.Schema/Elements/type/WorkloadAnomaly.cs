// WorkloadAnomaly.cs
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
    #region WorkloadAnomaly
    public class WorkloadAnomaly: BaseType
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

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> ResolutionStatus? ResolutionStatus
        // GraphQL -> resolutionStatus: ResolutionStatus! (enum)
        [JsonProperty("resolutionStatus")]
        public ResolutionStatus? ResolutionStatus { get; set; }

        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        [JsonProperty("severity")]
        public ActivitySeverityEnum? Severity { get; set; }

        //      C# -> DateTime? AnomalousSnapshotDate
        // GraphQL -> anomalousSnapshotDate: DateTime! (scalar)
        [JsonProperty("anomalousSnapshotDate")]
        public DateTime? AnomalousSnapshotDate { get; set; }

        //      C# -> System.String? AnomalousSnapshotFid
        // GraphQL -> anomalousSnapshotFid: String! (scalar)
        [JsonProperty("anomalousSnapshotFid")]
        public System.String? AnomalousSnapshotFid { get; set; }

        //      C# -> System.String? AnomalousSnapshotId
        // GraphQL -> anomalousSnapshotId: String! (scalar)
        [JsonProperty("anomalousSnapshotId")]
        public System.String? AnomalousSnapshotId { get; set; }

        //      C# -> System.String? AnomalyId
        // GraphQL -> anomalyId: String! (scalar)
        [JsonProperty("anomalyId")]
        public System.String? AnomalyId { get; set; }

        //      C# -> System.Int64? CreatedFileCount
        // GraphQL -> createdFileCount: Long! (scalar)
        [JsonProperty("createdFileCount")]
        public System.Int64? CreatedFileCount { get; set; }

        //      C# -> System.Int64? DeletedFileCount
        // GraphQL -> deletedFileCount: Long! (scalar)
        [JsonProperty("deletedFileCount")]
        public System.Int64? DeletedFileCount { get; set; }

        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime (scalar)
        [JsonProperty("detectionTime")]
        public DateTime? DetectionTime { get; set; }

        //      C# -> System.Int64? ModifiedFileCount
        // GraphQL -> modifiedFileCount: Long! (scalar)
        [JsonProperty("modifiedFileCount")]
        public System.Int64? ModifiedFileCount { get; set; }

        //      C# -> System.String? PreviousSnapshotFid
        // GraphQL -> previousSnapshotFid: String! (scalar)
        [JsonProperty("previousSnapshotFid")]
        public System.String? PreviousSnapshotFid { get; set; }

        //      C# -> System.Int64? SuspiciousFileCount
        // GraphQL -> suspiciousFileCount: Long! (scalar)
        [JsonProperty("suspiciousFileCount")]
        public System.Int64? SuspiciousFileCount { get; set; }

        //      C# -> System.Int64? TotalChildren
        // GraphQL -> totalChildren: Long! (scalar)
        [JsonProperty("totalChildren")]
        public System.Int64? TotalChildren { get; set; }

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

        //      C# -> List<WorkloadAnomaly>? AnomalousChildren
        // GraphQL -> anomalousChildren: [WorkloadAnomaly!]! (type)
        [JsonProperty("anomalousChildren")]
        public List<WorkloadAnomaly>? AnomalousChildren { get; set; }

        //      C# -> AnomalyInfo? AnomalyInfo
        // GraphQL -> anomalyInfo: AnomalyInfo (type)
        [JsonProperty("anomalyInfo")]
        public AnomalyInfo? AnomalyInfo { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> PolicyObj? PreviousPolicyObj
        // GraphQL -> previousPolicyObj: PolicyObj (type)
        [JsonProperty("previousPolicyObj")]
        public PolicyObj? PreviousPolicyObj { get; set; }

        //      C# -> SnappableLocationType? Location
        // GraphQL -> location: SnappableLocationType! (union)
        [JsonProperty("location")]
        public SnappableLocationType? Location { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadAnomaly";
    }

    public WorkloadAnomaly Set(
        AnomalyType? AnomalyType = null,
        EncryptionLevel? Encryption = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        ResolutionStatus? ResolutionStatus = null,
        ActivitySeverityEnum? Severity = null,
        DateTime? AnomalousSnapshotDate = null,
        System.String? AnomalousSnapshotFid = null,
        System.String? AnomalousSnapshotId = null,
        System.String? AnomalyId = null,
        System.Int64? CreatedFileCount = null,
        System.Int64? DeletedFileCount = null,
        DateTime? DetectionTime = null,
        System.Int64? ModifiedFileCount = null,
        System.String? PreviousSnapshotFid = null,
        System.Int64? SuspiciousFileCount = null,
        System.Int64? TotalChildren = null,
        System.String? WorkloadFid = null,
        System.String? WorkloadId = null,
        System.String? WorkloadName = null,
        List<WorkloadAnomaly>? AnomalousChildren = null,
        AnomalyInfo? AnomalyInfo = null,
        Cluster? Cluster = null,
        PolicyObj? PreviousPolicyObj = null,
        SnappableLocationType? Location = null
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
        if ( ResolutionStatus != null ) {
            this.ResolutionStatus = ResolutionStatus;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( AnomalousSnapshotDate != null ) {
            this.AnomalousSnapshotDate = AnomalousSnapshotDate;
        }
        if ( AnomalousSnapshotFid != null ) {
            this.AnomalousSnapshotFid = AnomalousSnapshotFid;
        }
        if ( AnomalousSnapshotId != null ) {
            this.AnomalousSnapshotId = AnomalousSnapshotId;
        }
        if ( AnomalyId != null ) {
            this.AnomalyId = AnomalyId;
        }
        if ( CreatedFileCount != null ) {
            this.CreatedFileCount = CreatedFileCount;
        }
        if ( DeletedFileCount != null ) {
            this.DeletedFileCount = DeletedFileCount;
        }
        if ( DetectionTime != null ) {
            this.DetectionTime = DetectionTime;
        }
        if ( ModifiedFileCount != null ) {
            this.ModifiedFileCount = ModifiedFileCount;
        }
        if ( PreviousSnapshotFid != null ) {
            this.PreviousSnapshotFid = PreviousSnapshotFid;
        }
        if ( SuspiciousFileCount != null ) {
            this.SuspiciousFileCount = SuspiciousFileCount;
        }
        if ( TotalChildren != null ) {
            this.TotalChildren = TotalChildren;
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
        if ( AnomalousChildren != null ) {
            this.AnomalousChildren = AnomalousChildren;
        }
        if ( AnomalyInfo != null ) {
            this.AnomalyInfo = AnomalyInfo;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( PreviousPolicyObj != null ) {
            this.PreviousPolicyObj = PreviousPolicyObj;
        }
        if ( Location != null ) {
            this.Location = Location;
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
        //      C# -> AnomalyType? AnomalyType
        // GraphQL -> anomalyType: AnomalyType! (enum)
        if (this.AnomalyType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "anomalyType\n" ;
            } else {
                s += ind + "anomalyType\n" ;
            }
        }
        //      C# -> EncryptionLevel? Encryption
        // GraphQL -> encryption: EncryptionLevel! (enum)
        if (this.Encryption != null) {
            if (conf.Flat) {
                s += conf.Prefix + "encryption\n" ;
            } else {
                s += ind + "encryption\n" ;
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
        //      C# -> ResolutionStatus? ResolutionStatus
        // GraphQL -> resolutionStatus: ResolutionStatus! (enum)
        if (this.ResolutionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resolutionStatus\n" ;
            } else {
                s += ind + "resolutionStatus\n" ;
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
        //      C# -> DateTime? AnomalousSnapshotDate
        // GraphQL -> anomalousSnapshotDate: DateTime! (scalar)
        if (this.AnomalousSnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "anomalousSnapshotDate\n" ;
            } else {
                s += ind + "anomalousSnapshotDate\n" ;
            }
        }
        //      C# -> System.String? AnomalousSnapshotFid
        // GraphQL -> anomalousSnapshotFid: String! (scalar)
        if (this.AnomalousSnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "anomalousSnapshotFid\n" ;
            } else {
                s += ind + "anomalousSnapshotFid\n" ;
            }
        }
        //      C# -> System.String? AnomalousSnapshotId
        // GraphQL -> anomalousSnapshotId: String! (scalar)
        if (this.AnomalousSnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "anomalousSnapshotId\n" ;
            } else {
                s += ind + "anomalousSnapshotId\n" ;
            }
        }
        //      C# -> System.String? AnomalyId
        // GraphQL -> anomalyId: String! (scalar)
        if (this.AnomalyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "anomalyId\n" ;
            } else {
                s += ind + "anomalyId\n" ;
            }
        }
        //      C# -> System.Int64? CreatedFileCount
        // GraphQL -> createdFileCount: Long! (scalar)
        if (this.CreatedFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdFileCount\n" ;
            } else {
                s += ind + "createdFileCount\n" ;
            }
        }
        //      C# -> System.Int64? DeletedFileCount
        // GraphQL -> deletedFileCount: Long! (scalar)
        if (this.DeletedFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deletedFileCount\n" ;
            } else {
                s += ind + "deletedFileCount\n" ;
            }
        }
        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime (scalar)
        if (this.DetectionTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "detectionTime\n" ;
            } else {
                s += ind + "detectionTime\n" ;
            }
        }
        //      C# -> System.Int64? ModifiedFileCount
        // GraphQL -> modifiedFileCount: Long! (scalar)
        if (this.ModifiedFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "modifiedFileCount\n" ;
            } else {
                s += ind + "modifiedFileCount\n" ;
            }
        }
        //      C# -> System.String? PreviousSnapshotFid
        // GraphQL -> previousSnapshotFid: String! (scalar)
        if (this.PreviousSnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "previousSnapshotFid\n" ;
            } else {
                s += ind + "previousSnapshotFid\n" ;
            }
        }
        //      C# -> System.Int64? SuspiciousFileCount
        // GraphQL -> suspiciousFileCount: Long! (scalar)
        if (this.SuspiciousFileCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "suspiciousFileCount\n" ;
            } else {
                s += ind + "suspiciousFileCount\n" ;
            }
        }
        //      C# -> System.Int64? TotalChildren
        // GraphQL -> totalChildren: Long! (scalar)
        if (this.TotalChildren != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalChildren\n" ;
            } else {
                s += ind + "totalChildren\n" ;
            }
        }
        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: String! (scalar)
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
        // GraphQL -> workloadName: String! (scalar)
        if (this.WorkloadName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadName\n" ;
            } else {
                s += ind + "workloadName\n" ;
            }
        }
        //      C# -> List<WorkloadAnomaly>? AnomalousChildren
        // GraphQL -> anomalousChildren: [WorkloadAnomaly!]! (type)
        if (this.AnomalousChildren != null) {
            var fspec = this.AnomalousChildren.AsFieldSpec(conf.Child("anomalousChildren"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "anomalousChildren {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AnomalyInfo? AnomalyInfo
        // GraphQL -> anomalyInfo: AnomalyInfo (type)
        if (this.AnomalyInfo != null) {
            var fspec = this.AnomalyInfo.AsFieldSpec(conf.Child("anomalyInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "anomalyInfo {\n" + fspec + ind + "}\n" ;
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
                    s += ind + "cluster {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolicyObj? PreviousPolicyObj
        // GraphQL -> previousPolicyObj: PolicyObj (type)
        if (this.PreviousPolicyObj != null) {
            var fspec = this.PreviousPolicyObj.AsFieldSpec(conf.Child("previousPolicyObj"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "previousPolicyObj {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnappableLocationType? Location
        // GraphQL -> location: SnappableLocationType! (union)
        if (this.Location != null) {
            var fspec = this.Location.AsFieldSpec(conf.Child("location"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "location {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AnomalyType? AnomalyType
        // GraphQL -> anomalyType: AnomalyType! (enum)
        if (ec.Includes("anomalyType",true))
        {
            if(this.AnomalyType == null) {

                this.AnomalyType = new AnomalyType();

            } else {


            }
        }
        else if (this.AnomalyType != null && ec.Excludes("anomalyType",true))
        {
            this.AnomalyType = null;
        }
        //      C# -> EncryptionLevel? Encryption
        // GraphQL -> encryption: EncryptionLevel! (enum)
        if (ec.Includes("encryption",true))
        {
            if(this.Encryption == null) {

                this.Encryption = new EncryptionLevel();

            } else {


            }
        }
        else if (this.Encryption != null && ec.Excludes("encryption",true))
        {
            this.Encryption = null;
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
        //      C# -> ResolutionStatus? ResolutionStatus
        // GraphQL -> resolutionStatus: ResolutionStatus! (enum)
        if (ec.Includes("resolutionStatus",true))
        {
            if(this.ResolutionStatus == null) {

                this.ResolutionStatus = new ResolutionStatus();

            } else {


            }
        }
        else if (this.ResolutionStatus != null && ec.Excludes("resolutionStatus",true))
        {
            this.ResolutionStatus = null;
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
        //      C# -> DateTime? AnomalousSnapshotDate
        // GraphQL -> anomalousSnapshotDate: DateTime! (scalar)
        if (ec.Includes("anomalousSnapshotDate",true))
        {
            if(this.AnomalousSnapshotDate == null) {

                this.AnomalousSnapshotDate = new DateTime();

            } else {


            }
        }
        else if (this.AnomalousSnapshotDate != null && ec.Excludes("anomalousSnapshotDate",true))
        {
            this.AnomalousSnapshotDate = null;
        }
        //      C# -> System.String? AnomalousSnapshotFid
        // GraphQL -> anomalousSnapshotFid: String! (scalar)
        if (ec.Includes("anomalousSnapshotFid",true))
        {
            if(this.AnomalousSnapshotFid == null) {

                this.AnomalousSnapshotFid = "FETCH";

            } else {


            }
        }
        else if (this.AnomalousSnapshotFid != null && ec.Excludes("anomalousSnapshotFid",true))
        {
            this.AnomalousSnapshotFid = null;
        }
        //      C# -> System.String? AnomalousSnapshotId
        // GraphQL -> anomalousSnapshotId: String! (scalar)
        if (ec.Includes("anomalousSnapshotId",true))
        {
            if(this.AnomalousSnapshotId == null) {

                this.AnomalousSnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.AnomalousSnapshotId != null && ec.Excludes("anomalousSnapshotId",true))
        {
            this.AnomalousSnapshotId = null;
        }
        //      C# -> System.String? AnomalyId
        // GraphQL -> anomalyId: String! (scalar)
        if (ec.Includes("anomalyId",true))
        {
            if(this.AnomalyId == null) {

                this.AnomalyId = "FETCH";

            } else {


            }
        }
        else if (this.AnomalyId != null && ec.Excludes("anomalyId",true))
        {
            this.AnomalyId = null;
        }
        //      C# -> System.Int64? CreatedFileCount
        // GraphQL -> createdFileCount: Long! (scalar)
        if (ec.Includes("createdFileCount",true))
        {
            if(this.CreatedFileCount == null) {

                this.CreatedFileCount = new System.Int64();

            } else {


            }
        }
        else if (this.CreatedFileCount != null && ec.Excludes("createdFileCount",true))
        {
            this.CreatedFileCount = null;
        }
        //      C# -> System.Int64? DeletedFileCount
        // GraphQL -> deletedFileCount: Long! (scalar)
        if (ec.Includes("deletedFileCount",true))
        {
            if(this.DeletedFileCount == null) {

                this.DeletedFileCount = new System.Int64();

            } else {


            }
        }
        else if (this.DeletedFileCount != null && ec.Excludes("deletedFileCount",true))
        {
            this.DeletedFileCount = null;
        }
        //      C# -> DateTime? DetectionTime
        // GraphQL -> detectionTime: DateTime (scalar)
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
        //      C# -> System.Int64? ModifiedFileCount
        // GraphQL -> modifiedFileCount: Long! (scalar)
        if (ec.Includes("modifiedFileCount",true))
        {
            if(this.ModifiedFileCount == null) {

                this.ModifiedFileCount = new System.Int64();

            } else {


            }
        }
        else if (this.ModifiedFileCount != null && ec.Excludes("modifiedFileCount",true))
        {
            this.ModifiedFileCount = null;
        }
        //      C# -> System.String? PreviousSnapshotFid
        // GraphQL -> previousSnapshotFid: String! (scalar)
        if (ec.Includes("previousSnapshotFid",true))
        {
            if(this.PreviousSnapshotFid == null) {

                this.PreviousSnapshotFid = "FETCH";

            } else {


            }
        }
        else if (this.PreviousSnapshotFid != null && ec.Excludes("previousSnapshotFid",true))
        {
            this.PreviousSnapshotFid = null;
        }
        //      C# -> System.Int64? SuspiciousFileCount
        // GraphQL -> suspiciousFileCount: Long! (scalar)
        if (ec.Includes("suspiciousFileCount",true))
        {
            if(this.SuspiciousFileCount == null) {

                this.SuspiciousFileCount = new System.Int64();

            } else {


            }
        }
        else if (this.SuspiciousFileCount != null && ec.Excludes("suspiciousFileCount",true))
        {
            this.SuspiciousFileCount = null;
        }
        //      C# -> System.Int64? TotalChildren
        // GraphQL -> totalChildren: Long! (scalar)
        if (ec.Includes("totalChildren",true))
        {
            if(this.TotalChildren == null) {

                this.TotalChildren = new System.Int64();

            } else {


            }
        }
        else if (this.TotalChildren != null && ec.Excludes("totalChildren",true))
        {
            this.TotalChildren = null;
        }
        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: String! (scalar)
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
        // GraphQL -> workloadName: String! (scalar)
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
        //      C# -> List<WorkloadAnomaly>? AnomalousChildren
        // GraphQL -> anomalousChildren: [WorkloadAnomaly!]! (type)
        if (ec.Includes("anomalousChildren",false))
        {
            if(this.AnomalousChildren == null) {

                this.AnomalousChildren = new List<WorkloadAnomaly>();
                this.AnomalousChildren.ApplyExploratoryFieldSpec(ec.NewChild("anomalousChildren"));

            } else {

                this.AnomalousChildren.ApplyExploratoryFieldSpec(ec.NewChild("anomalousChildren"));

            }
        }
        else if (this.AnomalousChildren != null && ec.Excludes("anomalousChildren",false))
        {
            this.AnomalousChildren = null;
        }
        //      C# -> AnomalyInfo? AnomalyInfo
        // GraphQL -> anomalyInfo: AnomalyInfo (type)
        if (ec.Includes("anomalyInfo",false))
        {
            if(this.AnomalyInfo == null) {

                this.AnomalyInfo = new AnomalyInfo();
                this.AnomalyInfo.ApplyExploratoryFieldSpec(ec.NewChild("anomalyInfo"));

            } else {

                this.AnomalyInfo.ApplyExploratoryFieldSpec(ec.NewChild("anomalyInfo"));

            }
        }
        else if (this.AnomalyInfo != null && ec.Excludes("anomalyInfo",false))
        {
            this.AnomalyInfo = null;
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
        //      C# -> PolicyObj? PreviousPolicyObj
        // GraphQL -> previousPolicyObj: PolicyObj (type)
        if (ec.Includes("previousPolicyObj",false))
        {
            if(this.PreviousPolicyObj == null) {

                this.PreviousPolicyObj = new PolicyObj();
                this.PreviousPolicyObj.ApplyExploratoryFieldSpec(ec.NewChild("previousPolicyObj"));

            } else {

                this.PreviousPolicyObj.ApplyExploratoryFieldSpec(ec.NewChild("previousPolicyObj"));

            }
        }
        else if (this.PreviousPolicyObj != null && ec.Excludes("previousPolicyObj",false))
        {
            this.PreviousPolicyObj = null;
        }
        //      C# -> SnappableLocationType? Location
        // GraphQL -> location: SnappableLocationType! (union)
        if (ec.Includes("location",false))
        {
            if(this.Location == null) {

                var impls = new List<SnappableLocationType>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("location"));
                this.Location = (SnappableLocationType)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SnappableLocationType>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("location"));
                this.Location = (SnappableLocationType)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Location != null && ec.Excludes("location",false))
        {
            this.Location = null;
        }
    }


    #endregion

    } // class WorkloadAnomaly
    
    #endregion

    public static class ListWorkloadAnomalyExtensions
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
            this List<WorkloadAnomaly> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkloadAnomaly> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadAnomaly> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadAnomaly());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadAnomaly> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types