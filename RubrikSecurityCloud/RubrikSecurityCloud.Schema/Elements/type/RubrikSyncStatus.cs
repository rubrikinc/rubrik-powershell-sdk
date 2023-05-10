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

namespace Rubrik.SecurityCloud.Types
{
    #region RubrikSyncStatus
    public class RubrikSyncStatus: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> DateTime? ClusterSyncLastSuccessTime
            // GraphQL -> clusterSyncLastSuccessTime: DateTime (scalar)
            if (this.ClusterSyncLastSuccessTime != null)
            {
                 s += ind + "clusterSyncLastSuccessTime\n";

            }
            //      C# -> DateTime? EventsSyncLastSuccessTime
            // GraphQL -> eventsSyncLastSuccessTime: DateTime (scalar)
            if (this.EventsSyncLastSuccessTime != null)
            {
                 s += ind + "eventsSyncLastSuccessTime\n";

            }
            //      C# -> System.Boolean? IsClusterSyncHealthy
            // GraphQL -> isClusterSyncHealthy: Boolean! (scalar)
            if (this.IsClusterSyncHealthy != null)
            {
                 s += ind + "isClusterSyncHealthy\n";

            }
            //      C# -> System.Boolean? IsEventsSyncHealthy
            // GraphQL -> isEventsSyncHealthy: Boolean! (scalar)
            if (this.IsEventsSyncHealthy != null)
            {
                 s += ind + "isEventsSyncHealthy\n";

            }
            //      C# -> System.Boolean? IsJobMonitoringSyncHealthy
            // GraphQL -> isJobMonitoringSyncHealthy: Boolean! (scalar)
            if (this.IsJobMonitoringSyncHealthy != null)
            {
                 s += ind + "isJobMonitoringSyncHealthy\n";

            }
            //      C# -> System.Boolean? IsMetadataSyncHealthy
            // GraphQL -> isMetadataSyncHealthy: Boolean! (scalar)
            if (this.IsMetadataSyncHealthy != null)
            {
                 s += ind + "isMetadataSyncHealthy\n";

            }
            //      C# -> System.Boolean? IsReportsSyncHealthy
            // GraphQL -> isReportsSyncHealthy: Boolean! (scalar)
            if (this.IsReportsSyncHealthy != null)
            {
                 s += ind + "isReportsSyncHealthy\n";

            }
            //      C# -> DateTime? JobMonitoringSyncLastSuccessTime
            // GraphQL -> jobMonitoringSyncLastSuccessTime: DateTime (scalar)
            if (this.JobMonitoringSyncLastSuccessTime != null)
            {
                 s += ind + "jobMonitoringSyncLastSuccessTime\n";

            }
            //      C# -> DateTime? ObjectMetadataSyncLastSuccessTime
            // GraphQL -> objectMetadataSyncLastSuccessTime: DateTime (scalar)
            if (this.ObjectMetadataSyncLastSuccessTime != null)
            {
                 s += ind + "objectMetadataSyncLastSuccessTime\n";

            }
            //      C# -> DateTime? ReportsSyncLastSuccessTime
            // GraphQL -> reportsSyncLastSuccessTime: DateTime (scalar)
            if (this.ReportsSyncLastSuccessTime != null)
            {
                 s += ind + "reportsSyncLastSuccessTime\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? ClusterSyncLastSuccessTime
            // GraphQL -> clusterSyncLastSuccessTime: DateTime (scalar)
            if (this.ClusterSyncLastSuccessTime == null && Exploration.Includes(parent + ".clusterSyncLastSuccessTime$"))
            {
                this.ClusterSyncLastSuccessTime = new DateTime();
            }
            //      C# -> DateTime? EventsSyncLastSuccessTime
            // GraphQL -> eventsSyncLastSuccessTime: DateTime (scalar)
            if (this.EventsSyncLastSuccessTime == null && Exploration.Includes(parent + ".eventsSyncLastSuccessTime$"))
            {
                this.EventsSyncLastSuccessTime = new DateTime();
            }
            //      C# -> System.Boolean? IsClusterSyncHealthy
            // GraphQL -> isClusterSyncHealthy: Boolean! (scalar)
            if (this.IsClusterSyncHealthy == null && Exploration.Includes(parent + ".isClusterSyncHealthy$"))
            {
                this.IsClusterSyncHealthy = new System.Boolean();
            }
            //      C# -> System.Boolean? IsEventsSyncHealthy
            // GraphQL -> isEventsSyncHealthy: Boolean! (scalar)
            if (this.IsEventsSyncHealthy == null && Exploration.Includes(parent + ".isEventsSyncHealthy$"))
            {
                this.IsEventsSyncHealthy = new System.Boolean();
            }
            //      C# -> System.Boolean? IsJobMonitoringSyncHealthy
            // GraphQL -> isJobMonitoringSyncHealthy: Boolean! (scalar)
            if (this.IsJobMonitoringSyncHealthy == null && Exploration.Includes(parent + ".isJobMonitoringSyncHealthy$"))
            {
                this.IsJobMonitoringSyncHealthy = new System.Boolean();
            }
            //      C# -> System.Boolean? IsMetadataSyncHealthy
            // GraphQL -> isMetadataSyncHealthy: Boolean! (scalar)
            if (this.IsMetadataSyncHealthy == null && Exploration.Includes(parent + ".isMetadataSyncHealthy$"))
            {
                this.IsMetadataSyncHealthy = new System.Boolean();
            }
            //      C# -> System.Boolean? IsReportsSyncHealthy
            // GraphQL -> isReportsSyncHealthy: Boolean! (scalar)
            if (this.IsReportsSyncHealthy == null && Exploration.Includes(parent + ".isReportsSyncHealthy$"))
            {
                this.IsReportsSyncHealthy = new System.Boolean();
            }
            //      C# -> DateTime? JobMonitoringSyncLastSuccessTime
            // GraphQL -> jobMonitoringSyncLastSuccessTime: DateTime (scalar)
            if (this.JobMonitoringSyncLastSuccessTime == null && Exploration.Includes(parent + ".jobMonitoringSyncLastSuccessTime$"))
            {
                this.JobMonitoringSyncLastSuccessTime = new DateTime();
            }
            //      C# -> DateTime? ObjectMetadataSyncLastSuccessTime
            // GraphQL -> objectMetadataSyncLastSuccessTime: DateTime (scalar)
            if (this.ObjectMetadataSyncLastSuccessTime == null && Exploration.Includes(parent + ".objectMetadataSyncLastSuccessTime$"))
            {
                this.ObjectMetadataSyncLastSuccessTime = new DateTime();
            }
            //      C# -> DateTime? ReportsSyncLastSuccessTime
            // GraphQL -> reportsSyncLastSuccessTime: DateTime (scalar)
            if (this.ReportsSyncLastSuccessTime == null && Exploration.Includes(parent + ".reportsSyncLastSuccessTime$"))
            {
                this.ReportsSyncLastSuccessTime = new DateTime();
            }
        }


    #endregion

    } // class RubrikSyncStatus
    #endregion

    public static class ListRubrikSyncStatusExtensions
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
            this List<RubrikSyncStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RubrikSyncStatus> list, 
            String parent = "")
        {
            var item = new RubrikSyncStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types