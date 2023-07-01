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

        //      C# -> EncryptionLevel? Encryption
        // GraphQL -> encryption: EncryptionLevel! (enum)
        [JsonProperty("encryption")]
        public EncryptionLevel? Encryption { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

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

        //      C# -> System.Int64? CreatedFileCount
        // GraphQL -> createdFileCount: Long! (scalar)
        [JsonProperty("createdFileCount")]
        public System.Int64? CreatedFileCount { get; set; }

        //      C# -> System.Int64? DeletedFileCount
        // GraphQL -> deletedFileCount: Long! (scalar)
        [JsonProperty("deletedFileCount")]
        public System.Int64? DeletedFileCount { get; set; }

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
        EncryptionLevel? Encryption = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        ActivitySeverityEnum? Severity = null,
        DateTime? AnomalousSnapshotDate = null,
        System.String? AnomalousSnapshotFid = null,
        System.String? AnomalousSnapshotId = null,
        System.Int64? CreatedFileCount = null,
        System.Int64? DeletedFileCount = null,
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
        if ( Encryption != null ) {
            this.Encryption = Encryption;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
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
        if ( CreatedFileCount != null ) {
            this.CreatedFileCount = CreatedFileCount;
        }
        if ( DeletedFileCount != null ) {
            this.DeletedFileCount = DeletedFileCount;
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> EncryptionLevel? Encryption
        // GraphQL -> encryption: EncryptionLevel! (enum)
        if (this.Encryption != null) {
            s += ind + "encryption\n" ;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (this.Severity != null) {
            s += ind + "severity\n" ;
        }
        //      C# -> DateTime? AnomalousSnapshotDate
        // GraphQL -> anomalousSnapshotDate: DateTime! (scalar)
        if (this.AnomalousSnapshotDate != null) {
            s += ind + "anomalousSnapshotDate\n" ;
        }
        //      C# -> System.String? AnomalousSnapshotFid
        // GraphQL -> anomalousSnapshotFid: String! (scalar)
        if (this.AnomalousSnapshotFid != null) {
            s += ind + "anomalousSnapshotFid\n" ;
        }
        //      C# -> System.String? AnomalousSnapshotId
        // GraphQL -> anomalousSnapshotId: String! (scalar)
        if (this.AnomalousSnapshotId != null) {
            s += ind + "anomalousSnapshotId\n" ;
        }
        //      C# -> System.Int64? CreatedFileCount
        // GraphQL -> createdFileCount: Long! (scalar)
        if (this.CreatedFileCount != null) {
            s += ind + "createdFileCount\n" ;
        }
        //      C# -> System.Int64? DeletedFileCount
        // GraphQL -> deletedFileCount: Long! (scalar)
        if (this.DeletedFileCount != null) {
            s += ind + "deletedFileCount\n" ;
        }
        //      C# -> System.Int64? ModifiedFileCount
        // GraphQL -> modifiedFileCount: Long! (scalar)
        if (this.ModifiedFileCount != null) {
            s += ind + "modifiedFileCount\n" ;
        }
        //      C# -> System.String? PreviousSnapshotFid
        // GraphQL -> previousSnapshotFid: String! (scalar)
        if (this.PreviousSnapshotFid != null) {
            s += ind + "previousSnapshotFid\n" ;
        }
        //      C# -> System.Int64? SuspiciousFileCount
        // GraphQL -> suspiciousFileCount: Long! (scalar)
        if (this.SuspiciousFileCount != null) {
            s += ind + "suspiciousFileCount\n" ;
        }
        //      C# -> System.Int64? TotalChildren
        // GraphQL -> totalChildren: Long! (scalar)
        if (this.TotalChildren != null) {
            s += ind + "totalChildren\n" ;
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
        //      C# -> List<WorkloadAnomaly>? AnomalousChildren
        // GraphQL -> anomalousChildren: [WorkloadAnomaly!]! (type)
        if (this.AnomalousChildren != null) {
            var fspec = this.AnomalousChildren.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "anomalousChildren {\n" + fspec + ind + "}\n" ;
            }
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
        //      C# -> PolicyObj? PreviousPolicyObj
        // GraphQL -> previousPolicyObj: PolicyObj (type)
        if (this.PreviousPolicyObj != null) {
            var fspec = this.PreviousPolicyObj.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "previousPolicyObj {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SnappableLocationType? Location
        // GraphQL -> location: SnappableLocationType! (union)
        if (this.Location != null) {
            var fspec = this.Location.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "location {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> EncryptionLevel? Encryption
        // GraphQL -> encryption: EncryptionLevel! (enum)
        if (this.Encryption == null && Exploration.Includes(parent + ".encryption", true))
        {
            this.Encryption = new EncryptionLevel();
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new HierarchyObjectTypeEnum();
        }
        //      C# -> ActivitySeverityEnum? Severity
        // GraphQL -> severity: ActivitySeverityEnum! (enum)
        if (this.Severity == null && Exploration.Includes(parent + ".severity", true))
        {
            this.Severity = new ActivitySeverityEnum();
        }
        //      C# -> DateTime? AnomalousSnapshotDate
        // GraphQL -> anomalousSnapshotDate: DateTime! (scalar)
        if (this.AnomalousSnapshotDate == null && Exploration.Includes(parent + ".anomalousSnapshotDate", true))
        {
            this.AnomalousSnapshotDate = new DateTime();
        }
        //      C# -> System.String? AnomalousSnapshotFid
        // GraphQL -> anomalousSnapshotFid: String! (scalar)
        if (this.AnomalousSnapshotFid == null && Exploration.Includes(parent + ".anomalousSnapshotFid", true))
        {
            this.AnomalousSnapshotFid = "FETCH";
        }
        //      C# -> System.String? AnomalousSnapshotId
        // GraphQL -> anomalousSnapshotId: String! (scalar)
        if (this.AnomalousSnapshotId == null && Exploration.Includes(parent + ".anomalousSnapshotId", true))
        {
            this.AnomalousSnapshotId = "FETCH";
        }
        //      C# -> System.Int64? CreatedFileCount
        // GraphQL -> createdFileCount: Long! (scalar)
        if (this.CreatedFileCount == null && Exploration.Includes(parent + ".createdFileCount", true))
        {
            this.CreatedFileCount = new System.Int64();
        }
        //      C# -> System.Int64? DeletedFileCount
        // GraphQL -> deletedFileCount: Long! (scalar)
        if (this.DeletedFileCount == null && Exploration.Includes(parent + ".deletedFileCount", true))
        {
            this.DeletedFileCount = new System.Int64();
        }
        //      C# -> System.Int64? ModifiedFileCount
        // GraphQL -> modifiedFileCount: Long! (scalar)
        if (this.ModifiedFileCount == null && Exploration.Includes(parent + ".modifiedFileCount", true))
        {
            this.ModifiedFileCount = new System.Int64();
        }
        //      C# -> System.String? PreviousSnapshotFid
        // GraphQL -> previousSnapshotFid: String! (scalar)
        if (this.PreviousSnapshotFid == null && Exploration.Includes(parent + ".previousSnapshotFid", true))
        {
            this.PreviousSnapshotFid = "FETCH";
        }
        //      C# -> System.Int64? SuspiciousFileCount
        // GraphQL -> suspiciousFileCount: Long! (scalar)
        if (this.SuspiciousFileCount == null && Exploration.Includes(parent + ".suspiciousFileCount", true))
        {
            this.SuspiciousFileCount = new System.Int64();
        }
        //      C# -> System.Int64? TotalChildren
        // GraphQL -> totalChildren: Long! (scalar)
        if (this.TotalChildren == null && Exploration.Includes(parent + ".totalChildren", true))
        {
            this.TotalChildren = new System.Int64();
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
        //      C# -> List<WorkloadAnomaly>? AnomalousChildren
        // GraphQL -> anomalousChildren: [WorkloadAnomaly!]! (type)
        if (this.AnomalousChildren == null && Exploration.Includes(parent + ".anomalousChildren"))
        {
            this.AnomalousChildren = new List<WorkloadAnomaly>();
            this.AnomalousChildren.ApplyExploratoryFieldSpec(parent + ".anomalousChildren");
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
        //      C# -> PolicyObj? PreviousPolicyObj
        // GraphQL -> previousPolicyObj: PolicyObj (type)
        if (this.PreviousPolicyObj == null && Exploration.Includes(parent + ".previousPolicyObj"))
        {
            this.PreviousPolicyObj = new PolicyObj();
            this.PreviousPolicyObj.ApplyExploratoryFieldSpec(parent + ".previousPolicyObj");
        }
        //      C# -> SnappableLocationType? Location
        // GraphQL -> location: SnappableLocationType! (union)
        if (this.Location == null && Exploration.Includes(parent + ".location"))
        {
            var impls = new List<SnappableLocationType>();
            impls.ApplyExploratoryFieldSpec(parent + ".location");
            this.Location = (SnappableLocationType)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class WorkloadAnomaly
    
    #endregion

    public static class ListWorkloadAnomalyExtensions
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
            this List<WorkloadAnomaly> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadAnomaly> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadAnomaly());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types