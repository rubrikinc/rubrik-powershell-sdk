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

namespace Rubrik.SecurityCloud.Types
{
    #region WorkloadAnomaly
    public class WorkloadAnomaly: IFragment
    {
        #region members
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

        //      C# -> SnappableLocationType? Location
        // GraphQL -> location: SnappableLocationType! (union)
        [JsonProperty("location")]
        public SnappableLocationType? Location { get; set; }

        #endregion

    #region methods

    public WorkloadAnomaly Set(
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
        EncryptionLevel? Encryption = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        ActivitySeverityEnum? Severity = null,
        SnappableLocationType? Location = null
    ) 
    {
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
        if ( Encryption != null ) {
            this.Encryption = Encryption;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( Location != null ) {
            this.Location = Location;
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
            //      C# -> DateTime? AnomalousSnapshotDate
            // GraphQL -> anomalousSnapshotDate: DateTime! (scalar)
            if (this.AnomalousSnapshotDate != null)
            {
                 s += ind + "anomalousSnapshotDate\n";

            }
            //      C# -> System.String? AnomalousSnapshotFid
            // GraphQL -> anomalousSnapshotFid: String! (scalar)
            if (this.AnomalousSnapshotFid != null)
            {
                 s += ind + "anomalousSnapshotFid\n";

            }
            //      C# -> System.String? AnomalousSnapshotId
            // GraphQL -> anomalousSnapshotId: String! (scalar)
            if (this.AnomalousSnapshotId != null)
            {
                 s += ind + "anomalousSnapshotId\n";

            }
            //      C# -> System.Int64? CreatedFileCount
            // GraphQL -> createdFileCount: Long! (scalar)
            if (this.CreatedFileCount != null)
            {
                 s += ind + "createdFileCount\n";

            }
            //      C# -> System.Int64? DeletedFileCount
            // GraphQL -> deletedFileCount: Long! (scalar)
            if (this.DeletedFileCount != null)
            {
                 s += ind + "deletedFileCount\n";

            }
            //      C# -> System.Int64? ModifiedFileCount
            // GraphQL -> modifiedFileCount: Long! (scalar)
            if (this.ModifiedFileCount != null)
            {
                 s += ind + "modifiedFileCount\n";

            }
            //      C# -> System.String? PreviousSnapshotFid
            // GraphQL -> previousSnapshotFid: String! (scalar)
            if (this.PreviousSnapshotFid != null)
            {
                 s += ind + "previousSnapshotFid\n";

            }
            //      C# -> System.Int64? SuspiciousFileCount
            // GraphQL -> suspiciousFileCount: Long! (scalar)
            if (this.SuspiciousFileCount != null)
            {
                 s += ind + "suspiciousFileCount\n";

            }
            //      C# -> System.Int64? TotalChildren
            // GraphQL -> totalChildren: Long! (scalar)
            if (this.TotalChildren != null)
            {
                 s += ind + "totalChildren\n";

            }
            //      C# -> System.String? WorkloadFid
            // GraphQL -> workloadFid: String! (scalar)
            if (this.WorkloadFid != null)
            {
                 s += ind + "workloadFid\n";

            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: String! (scalar)
            if (this.WorkloadId != null)
            {
                 s += ind + "workloadId\n";

            }
            //      C# -> System.String? WorkloadName
            // GraphQL -> workloadName: String! (scalar)
            if (this.WorkloadName != null)
            {
                 s += ind + "workloadName\n";

            }
            //      C# -> List<WorkloadAnomaly>? AnomalousChildren
            // GraphQL -> anomalousChildren: [WorkloadAnomaly!]! (type)
            if (this.AnomalousChildren != null)
            {
                 s += ind + "anomalousChildren\n";

                 s += ind + "{\n" + 
                 this.AnomalousChildren.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> AnomalyInfo? AnomalyInfo
            // GraphQL -> anomalyInfo: AnomalyInfo (type)
            if (this.AnomalyInfo != null)
            {
                 s += ind + "anomalyInfo\n";

                 s += ind + "{\n" + 
                 this.AnomalyInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PolicyObj? PreviousPolicyObj
            // GraphQL -> previousPolicyObj: PolicyObj (type)
            if (this.PreviousPolicyObj != null)
            {
                 s += ind + "previousPolicyObj\n";

                 s += ind + "{\n" + 
                 this.PreviousPolicyObj.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> EncryptionLevel? Encryption
            // GraphQL -> encryption: EncryptionLevel! (enum)
            if (this.Encryption != null)
            {
                 s += ind + "encryption\n";

            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            //      C# -> ActivitySeverityEnum? Severity
            // GraphQL -> severity: ActivitySeverityEnum! (enum)
            if (this.Severity != null)
            {
                 s += ind + "severity\n";

            }
            //      C# -> SnappableLocationType? Location
            // GraphQL -> location: SnappableLocationType! (union)
            if (this.Location != null)
            {
                 s += ind + "location\n";

                 s += ind + "{\n" + 
                 this.Location.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? AnomalousSnapshotDate
            // GraphQL -> anomalousSnapshotDate: DateTime! (scalar)
            if (this.AnomalousSnapshotDate == null && Exploration.Includes(parent + ".anomalousSnapshotDate$"))
            {
                this.AnomalousSnapshotDate = new DateTime();
            }
            //      C# -> System.String? AnomalousSnapshotFid
            // GraphQL -> anomalousSnapshotFid: String! (scalar)
            if (this.AnomalousSnapshotFid == null && Exploration.Includes(parent + ".anomalousSnapshotFid$"))
            {
                this.AnomalousSnapshotFid = new System.String("FETCH");
            }
            //      C# -> System.String? AnomalousSnapshotId
            // GraphQL -> anomalousSnapshotId: String! (scalar)
            if (this.AnomalousSnapshotId == null && Exploration.Includes(parent + ".anomalousSnapshotId$"))
            {
                this.AnomalousSnapshotId = new System.String("FETCH");
            }
            //      C# -> System.Int64? CreatedFileCount
            // GraphQL -> createdFileCount: Long! (scalar)
            if (this.CreatedFileCount == null && Exploration.Includes(parent + ".createdFileCount$"))
            {
                this.CreatedFileCount = new System.Int64();
            }
            //      C# -> System.Int64? DeletedFileCount
            // GraphQL -> deletedFileCount: Long! (scalar)
            if (this.DeletedFileCount == null && Exploration.Includes(parent + ".deletedFileCount$"))
            {
                this.DeletedFileCount = new System.Int64();
            }
            //      C# -> System.Int64? ModifiedFileCount
            // GraphQL -> modifiedFileCount: Long! (scalar)
            if (this.ModifiedFileCount == null && Exploration.Includes(parent + ".modifiedFileCount$"))
            {
                this.ModifiedFileCount = new System.Int64();
            }
            //      C# -> System.String? PreviousSnapshotFid
            // GraphQL -> previousSnapshotFid: String! (scalar)
            if (this.PreviousSnapshotFid == null && Exploration.Includes(parent + ".previousSnapshotFid$"))
            {
                this.PreviousSnapshotFid = new System.String("FETCH");
            }
            //      C# -> System.Int64? SuspiciousFileCount
            // GraphQL -> suspiciousFileCount: Long! (scalar)
            if (this.SuspiciousFileCount == null && Exploration.Includes(parent + ".suspiciousFileCount$"))
            {
                this.SuspiciousFileCount = new System.Int64();
            }
            //      C# -> System.Int64? TotalChildren
            // GraphQL -> totalChildren: Long! (scalar)
            if (this.TotalChildren == null && Exploration.Includes(parent + ".totalChildren$"))
            {
                this.TotalChildren = new System.Int64();
            }
            //      C# -> System.String? WorkloadFid
            // GraphQL -> workloadFid: String! (scalar)
            if (this.WorkloadFid == null && Exploration.Includes(parent + ".workloadFid$"))
            {
                this.WorkloadFid = new System.String("FETCH");
            }
            //      C# -> System.String? WorkloadId
            // GraphQL -> workloadId: String! (scalar)
            if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId$"))
            {
                this.WorkloadId = new System.String("FETCH");
            }
            //      C# -> System.String? WorkloadName
            // GraphQL -> workloadName: String! (scalar)
            if (this.WorkloadName == null && Exploration.Includes(parent + ".workloadName$"))
            {
                this.WorkloadName = new System.String("FETCH");
            }
            //      C# -> List<WorkloadAnomaly>? AnomalousChildren
            // GraphQL -> anomalousChildren: [WorkloadAnomaly!]! (type)
            if (this.AnomalousChildren == null && Exploration.Includes(parent + ".anomalousChildren"))
            {
                this.AnomalousChildren = new List<WorkloadAnomaly>();
                this.AnomalousChildren.ApplyExploratoryFragment(parent + ".anomalousChildren");
            }
            //      C# -> AnomalyInfo? AnomalyInfo
            // GraphQL -> anomalyInfo: AnomalyInfo (type)
            if (this.AnomalyInfo == null && Exploration.Includes(parent + ".anomalyInfo"))
            {
                this.AnomalyInfo = new AnomalyInfo();
                this.AnomalyInfo.ApplyExploratoryFragment(parent + ".anomalyInfo");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> PolicyObj? PreviousPolicyObj
            // GraphQL -> previousPolicyObj: PolicyObj (type)
            if (this.PreviousPolicyObj == null && Exploration.Includes(parent + ".previousPolicyObj"))
            {
                this.PreviousPolicyObj = new PolicyObj();
                this.PreviousPolicyObj.ApplyExploratoryFragment(parent + ".previousPolicyObj");
            }
            //      C# -> EncryptionLevel? Encryption
            // GraphQL -> encryption: EncryptionLevel! (enum)
            if (this.Encryption == null && Exploration.Includes(parent + ".encryption$"))
            {
                this.Encryption = new EncryptionLevel();
            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new HierarchyObjectTypeEnum();
            }
            //      C# -> ActivitySeverityEnum? Severity
            // GraphQL -> severity: ActivitySeverityEnum! (enum)
            if (this.Severity == null && Exploration.Includes(parent + ".severity$"))
            {
                this.Severity = new ActivitySeverityEnum();
            }
            //      C# -> SnappableLocationType? Location
            // GraphQL -> location: SnappableLocationType! (union)
            if (this.Location == null && Exploration.Includes(parent + ".location"))
            {
                this.Location = (SnappableLocationType)InterfaceHelper.CreateInstanceOfFirstType(typeof(SnappableLocationType));
                this.Location.ApplyExploratoryFragment(parent + ".location");
            }
        }


    #endregion

    } // class WorkloadAnomaly
    #endregion

    public static class ListWorkloadAnomalyExtensions
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
            this List<WorkloadAnomaly> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<WorkloadAnomaly> list, 
            String parent = "")
        {
            var item = new WorkloadAnomaly();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types