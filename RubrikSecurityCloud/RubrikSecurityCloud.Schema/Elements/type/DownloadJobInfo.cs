// DownloadJobInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:11.
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
    #region DownloadJobInfo
    public class DownloadJobInfo: IFragment
    {
        #region members
        //      C# -> System.String? EventId
        // GraphQL -> eventId: String! (scalar)
        [JsonProperty("eventId")]
        public System.String? EventId { get; set; }

        //      C# -> System.String? JobInstanceId
        // GraphQL -> jobInstanceId: String! (scalar)
        [JsonProperty("jobInstanceId")]
        public System.String? JobInstanceId { get; set; }

        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        [JsonProperty("progress")]
        public System.Single? Progress { get; set; }

        //      C# -> System.Int64? RemainingTimeEstimateInSeconds
        // GraphQL -> remainingTimeEstimateInSeconds: Long! (scalar)
        [JsonProperty("remainingTimeEstimateInSeconds")]
        public System.Int64? RemainingTimeEstimateInSeconds { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        #endregion

    #region methods

    public DownloadJobInfo Set(
        System.String? EventId = null,
        System.String? JobInstanceId = null,
        System.Single? Progress = null,
        System.Int64? RemainingTimeEstimateInSeconds = null,
        System.String? Status = null
    ) 
    {
        if ( EventId != null ) {
            this.EventId = EventId;
        }
        if ( JobInstanceId != null ) {
            this.JobInstanceId = JobInstanceId;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( RemainingTimeEstimateInSeconds != null ) {
            this.RemainingTimeEstimateInSeconds = RemainingTimeEstimateInSeconds;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.String? EventId
            // GraphQL -> eventId: String! (scalar)
            if (this.EventId != null)
            {
                 s += ind + "eventId\n";

            }
            //      C# -> System.String? JobInstanceId
            // GraphQL -> jobInstanceId: String! (scalar)
            if (this.JobInstanceId != null)
            {
                 s += ind + "jobInstanceId\n";

            }
            //      C# -> System.Single? Progress
            // GraphQL -> progress: Float! (scalar)
            if (this.Progress != null)
            {
                 s += ind + "progress\n";

            }
            //      C# -> System.Int64? RemainingTimeEstimateInSeconds
            // GraphQL -> remainingTimeEstimateInSeconds: Long! (scalar)
            if (this.RemainingTimeEstimateInSeconds != null)
            {
                 s += ind + "remainingTimeEstimateInSeconds\n";

            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? EventId
            // GraphQL -> eventId: String! (scalar)
            if (this.EventId == null && Exploration.Includes(parent + ".eventId$"))
            {
                this.EventId = new System.String("FETCH");
            }
            //      C# -> System.String? JobInstanceId
            // GraphQL -> jobInstanceId: String! (scalar)
            if (this.JobInstanceId == null && Exploration.Includes(parent + ".jobInstanceId$"))
            {
                this.JobInstanceId = new System.String("FETCH");
            }
            //      C# -> System.Single? Progress
            // GraphQL -> progress: Float! (scalar)
            if (this.Progress == null && Exploration.Includes(parent + ".progress$"))
            {
                this.Progress = new System.Single();
            }
            //      C# -> System.Int64? RemainingTimeEstimateInSeconds
            // GraphQL -> remainingTimeEstimateInSeconds: Long! (scalar)
            if (this.RemainingTimeEstimateInSeconds == null && Exploration.Includes(parent + ".remainingTimeEstimateInSeconds$"))
            {
                this.RemainingTimeEstimateInSeconds = new System.Int64();
            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new System.String("FETCH");
            }
        }


    #endregion

    } // class DownloadJobInfo
    #endregion

    public static class ListDownloadJobInfoExtensions
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
            this List<DownloadJobInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DownloadJobInfo> list, 
            String parent = "")
        {
            var item = new DownloadJobInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types