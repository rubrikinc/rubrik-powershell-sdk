// RubrikSyncStatus.cs
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
    #region RubrikSyncStatus
    public class RubrikSyncStatus: BaseType
    {
        #region members

        //      C# -> DateTime? ClusterSyncLastSuccessTime
        // GraphQL -> clusterSyncLastSuccessTime: DateTime (scalar)
        [JsonProperty("clusterSyncLastSuccessTime")]
        public DateTime? ClusterSyncLastSuccessTime { get; set; }

        //      C# -> DateTime? EventsSyncLastSuccessTime
        // GraphQL -> eventsSyncLastSuccessTime: DateTime (scalar)
        [JsonProperty("eventsSyncLastSuccessTime")]
        public DateTime? EventsSyncLastSuccessTime { get; set; }

        //      C# -> System.Boolean? IsClusterSyncHealthy
        // GraphQL -> isClusterSyncHealthy: Boolean! (scalar)
        [JsonProperty("isClusterSyncHealthy")]
        public System.Boolean? IsClusterSyncHealthy { get; set; }

        //      C# -> System.Boolean? IsEventsSyncHealthy
        // GraphQL -> isEventsSyncHealthy: Boolean! (scalar)
        [JsonProperty("isEventsSyncHealthy")]
        public System.Boolean? IsEventsSyncHealthy { get; set; }

        //      C# -> System.Boolean? IsJobMonitoringSyncHealthy
        // GraphQL -> isJobMonitoringSyncHealthy: Boolean! (scalar)
        [JsonProperty("isJobMonitoringSyncHealthy")]
        public System.Boolean? IsJobMonitoringSyncHealthy { get; set; }

        //      C# -> System.Boolean? IsMetadataSyncHealthy
        // GraphQL -> isMetadataSyncHealthy: Boolean! (scalar)
        [JsonProperty("isMetadataSyncHealthy")]
        public System.Boolean? IsMetadataSyncHealthy { get; set; }

        //      C# -> System.Boolean? IsReportsSyncHealthy
        // GraphQL -> isReportsSyncHealthy: Boolean! (scalar)
        [JsonProperty("isReportsSyncHealthy")]
        public System.Boolean? IsReportsSyncHealthy { get; set; }

        //      C# -> DateTime? JobMonitoringSyncLastSuccessTime
        // GraphQL -> jobMonitoringSyncLastSuccessTime: DateTime (scalar)
        [JsonProperty("jobMonitoringSyncLastSuccessTime")]
        public DateTime? JobMonitoringSyncLastSuccessTime { get; set; }

        //      C# -> DateTime? ObjectMetadataSyncLastSuccessTime
        // GraphQL -> objectMetadataSyncLastSuccessTime: DateTime (scalar)
        [JsonProperty("objectMetadataSyncLastSuccessTime")]
        public DateTime? ObjectMetadataSyncLastSuccessTime { get; set; }

        //      C# -> DateTime? ReportsSyncLastSuccessTime
        // GraphQL -> reportsSyncLastSuccessTime: DateTime (scalar)
        [JsonProperty("reportsSyncLastSuccessTime")]
        public DateTime? ReportsSyncLastSuccessTime { get; set; }


        #endregion

    #region methods

    public RubrikSyncStatus Set(
        DateTime? ClusterSyncLastSuccessTime = null,
        DateTime? EventsSyncLastSuccessTime = null,
        System.Boolean? IsClusterSyncHealthy = null,
        System.Boolean? IsEventsSyncHealthy = null,
        System.Boolean? IsJobMonitoringSyncHealthy = null,
        System.Boolean? IsMetadataSyncHealthy = null,
        System.Boolean? IsReportsSyncHealthy = null,
        DateTime? JobMonitoringSyncLastSuccessTime = null,
        DateTime? ObjectMetadataSyncLastSuccessTime = null,
        DateTime? ReportsSyncLastSuccessTime = null
    ) 
    {
        if ( ClusterSyncLastSuccessTime != null ) {
            this.ClusterSyncLastSuccessTime = ClusterSyncLastSuccessTime;
        }
        if ( EventsSyncLastSuccessTime != null ) {
            this.EventsSyncLastSuccessTime = EventsSyncLastSuccessTime;
        }
        if ( IsClusterSyncHealthy != null ) {
            this.IsClusterSyncHealthy = IsClusterSyncHealthy;
        }
        if ( IsEventsSyncHealthy != null ) {
            this.IsEventsSyncHealthy = IsEventsSyncHealthy;
        }
        if ( IsJobMonitoringSyncHealthy != null ) {
            this.IsJobMonitoringSyncHealthy = IsJobMonitoringSyncHealthy;
        }
        if ( IsMetadataSyncHealthy != null ) {
            this.IsMetadataSyncHealthy = IsMetadataSyncHealthy;
        }
        if ( IsReportsSyncHealthy != null ) {
            this.IsReportsSyncHealthy = IsReportsSyncHealthy;
        }
        if ( JobMonitoringSyncLastSuccessTime != null ) {
            this.JobMonitoringSyncLastSuccessTime = JobMonitoringSyncLastSuccessTime;
        }
        if ( ObjectMetadataSyncLastSuccessTime != null ) {
            this.ObjectMetadataSyncLastSuccessTime = ObjectMetadataSyncLastSuccessTime;
        }
        if ( ReportsSyncLastSuccessTime != null ) {
            this.ReportsSyncLastSuccessTime = ReportsSyncLastSuccessTime;
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
        //      C# -> DateTime? ClusterSyncLastSuccessTime
        // GraphQL -> clusterSyncLastSuccessTime: DateTime (scalar)
        if (this.ClusterSyncLastSuccessTime != null) {
            s += ind + "clusterSyncLastSuccessTime\n" ;
        }
        //      C# -> DateTime? EventsSyncLastSuccessTime
        // GraphQL -> eventsSyncLastSuccessTime: DateTime (scalar)
        if (this.EventsSyncLastSuccessTime != null) {
            s += ind + "eventsSyncLastSuccessTime\n" ;
        }
        //      C# -> System.Boolean? IsClusterSyncHealthy
        // GraphQL -> isClusterSyncHealthy: Boolean! (scalar)
        if (this.IsClusterSyncHealthy != null) {
            s += ind + "isClusterSyncHealthy\n" ;
        }
        //      C# -> System.Boolean? IsEventsSyncHealthy
        // GraphQL -> isEventsSyncHealthy: Boolean! (scalar)
        if (this.IsEventsSyncHealthy != null) {
            s += ind + "isEventsSyncHealthy\n" ;
        }
        //      C# -> System.Boolean? IsJobMonitoringSyncHealthy
        // GraphQL -> isJobMonitoringSyncHealthy: Boolean! (scalar)
        if (this.IsJobMonitoringSyncHealthy != null) {
            s += ind + "isJobMonitoringSyncHealthy\n" ;
        }
        //      C# -> System.Boolean? IsMetadataSyncHealthy
        // GraphQL -> isMetadataSyncHealthy: Boolean! (scalar)
        if (this.IsMetadataSyncHealthy != null) {
            s += ind + "isMetadataSyncHealthy\n" ;
        }
        //      C# -> System.Boolean? IsReportsSyncHealthy
        // GraphQL -> isReportsSyncHealthy: Boolean! (scalar)
        if (this.IsReportsSyncHealthy != null) {
            s += ind + "isReportsSyncHealthy\n" ;
        }
        //      C# -> DateTime? JobMonitoringSyncLastSuccessTime
        // GraphQL -> jobMonitoringSyncLastSuccessTime: DateTime (scalar)
        if (this.JobMonitoringSyncLastSuccessTime != null) {
            s += ind + "jobMonitoringSyncLastSuccessTime\n" ;
        }
        //      C# -> DateTime? ObjectMetadataSyncLastSuccessTime
        // GraphQL -> objectMetadataSyncLastSuccessTime: DateTime (scalar)
        if (this.ObjectMetadataSyncLastSuccessTime != null) {
            s += ind + "objectMetadataSyncLastSuccessTime\n" ;
        }
        //      C# -> DateTime? ReportsSyncLastSuccessTime
        // GraphQL -> reportsSyncLastSuccessTime: DateTime (scalar)
        if (this.ReportsSyncLastSuccessTime != null) {
            s += ind + "reportsSyncLastSuccessTime\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DateTime? ClusterSyncLastSuccessTime
        // GraphQL -> clusterSyncLastSuccessTime: DateTime (scalar)
        if (this.ClusterSyncLastSuccessTime == null && Exploration.Includes(parent + ".clusterSyncLastSuccessTime", true))
        {
            this.ClusterSyncLastSuccessTime = new DateTime();
        }
        //      C# -> DateTime? EventsSyncLastSuccessTime
        // GraphQL -> eventsSyncLastSuccessTime: DateTime (scalar)
        if (this.EventsSyncLastSuccessTime == null && Exploration.Includes(parent + ".eventsSyncLastSuccessTime", true))
        {
            this.EventsSyncLastSuccessTime = new DateTime();
        }
        //      C# -> System.Boolean? IsClusterSyncHealthy
        // GraphQL -> isClusterSyncHealthy: Boolean! (scalar)
        if (this.IsClusterSyncHealthy == null && Exploration.Includes(parent + ".isClusterSyncHealthy", true))
        {
            this.IsClusterSyncHealthy = true;
        }
        //      C# -> System.Boolean? IsEventsSyncHealthy
        // GraphQL -> isEventsSyncHealthy: Boolean! (scalar)
        if (this.IsEventsSyncHealthy == null && Exploration.Includes(parent + ".isEventsSyncHealthy", true))
        {
            this.IsEventsSyncHealthy = true;
        }
        //      C# -> System.Boolean? IsJobMonitoringSyncHealthy
        // GraphQL -> isJobMonitoringSyncHealthy: Boolean! (scalar)
        if (this.IsJobMonitoringSyncHealthy == null && Exploration.Includes(parent + ".isJobMonitoringSyncHealthy", true))
        {
            this.IsJobMonitoringSyncHealthy = true;
        }
        //      C# -> System.Boolean? IsMetadataSyncHealthy
        // GraphQL -> isMetadataSyncHealthy: Boolean! (scalar)
        if (this.IsMetadataSyncHealthy == null && Exploration.Includes(parent + ".isMetadataSyncHealthy", true))
        {
            this.IsMetadataSyncHealthy = true;
        }
        //      C# -> System.Boolean? IsReportsSyncHealthy
        // GraphQL -> isReportsSyncHealthy: Boolean! (scalar)
        if (this.IsReportsSyncHealthy == null && Exploration.Includes(parent + ".isReportsSyncHealthy", true))
        {
            this.IsReportsSyncHealthy = true;
        }
        //      C# -> DateTime? JobMonitoringSyncLastSuccessTime
        // GraphQL -> jobMonitoringSyncLastSuccessTime: DateTime (scalar)
        if (this.JobMonitoringSyncLastSuccessTime == null && Exploration.Includes(parent + ".jobMonitoringSyncLastSuccessTime", true))
        {
            this.JobMonitoringSyncLastSuccessTime = new DateTime();
        }
        //      C# -> DateTime? ObjectMetadataSyncLastSuccessTime
        // GraphQL -> objectMetadataSyncLastSuccessTime: DateTime (scalar)
        if (this.ObjectMetadataSyncLastSuccessTime == null && Exploration.Includes(parent + ".objectMetadataSyncLastSuccessTime", true))
        {
            this.ObjectMetadataSyncLastSuccessTime = new DateTime();
        }
        //      C# -> DateTime? ReportsSyncLastSuccessTime
        // GraphQL -> reportsSyncLastSuccessTime: DateTime (scalar)
        if (this.ReportsSyncLastSuccessTime == null && Exploration.Includes(parent + ".reportsSyncLastSuccessTime", true))
        {
            this.ReportsSyncLastSuccessTime = new DateTime();
        }
    }


    #endregion

    } // class RubrikSyncStatus
    
    #endregion

    public static class ListRubrikSyncStatusExtensions
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
            this List<RubrikSyncStatus> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RubrikSyncStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RubrikSyncStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types