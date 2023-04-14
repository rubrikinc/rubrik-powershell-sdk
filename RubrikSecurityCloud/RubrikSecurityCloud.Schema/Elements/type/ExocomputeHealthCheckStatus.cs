// ExocomputeHealthCheckStatus.cs
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
    #region ExocomputeHealthCheckStatus
    public class ExocomputeHealthCheckStatus: IFragment
    {
        #region members
        //      C# -> System.String? FailureReason
        // GraphQL -> failureReason: String! (scalar)
        [JsonProperty("failureReason")]
        public System.String? FailureReason { get; set; }

        //      C# -> DateTime? LastUpdatedAt
        // GraphQL -> lastUpdatedAt: DateTime (scalar)
        [JsonProperty("lastUpdatedAt")]
        public DateTime? LastUpdatedAt { get; set; }

        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        [JsonProperty("taskchainId")]
        public System.String? TaskchainId { get; set; }

        //      C# -> ExocomputeHealthCheckStatusValue? Status
        // GraphQL -> status: ExocomputeHealthCheckStatusValue! (enum)
        [JsonProperty("status")]
        public ExocomputeHealthCheckStatusValue? Status { get; set; }

        #endregion

    #region methods

    public ExocomputeHealthCheckStatus Set(
        System.String? FailureReason = null,
        DateTime? LastUpdatedAt = null,
        System.String? TaskchainId = null,
        ExocomputeHealthCheckStatusValue? Status = null
    ) 
    {
        if ( FailureReason != null ) {
            this.FailureReason = FailureReason;
        }
        if ( LastUpdatedAt != null ) {
            this.LastUpdatedAt = LastUpdatedAt;
        }
        if ( TaskchainId != null ) {
            this.TaskchainId = TaskchainId;
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
            //      C# -> System.String? FailureReason
            // GraphQL -> failureReason: String! (scalar)
            if (this.FailureReason != null)
            {
                 s += ind + "failureReason\n";

            }
            //      C# -> DateTime? LastUpdatedAt
            // GraphQL -> lastUpdatedAt: DateTime (scalar)
            if (this.LastUpdatedAt != null)
            {
                 s += ind + "lastUpdatedAt\n";

            }
            //      C# -> System.String? TaskchainId
            // GraphQL -> taskchainId: String! (scalar)
            if (this.TaskchainId != null)
            {
                 s += ind + "taskchainId\n";

            }
            //      C# -> ExocomputeHealthCheckStatusValue? Status
            // GraphQL -> status: ExocomputeHealthCheckStatusValue! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? FailureReason
            // GraphQL -> failureReason: String! (scalar)
            if (this.FailureReason == null && Exploration.Includes(parent + ".failureReason$"))
            {
                this.FailureReason = new System.String("FETCH");
            }
            //      C# -> DateTime? LastUpdatedAt
            // GraphQL -> lastUpdatedAt: DateTime (scalar)
            if (this.LastUpdatedAt == null && Exploration.Includes(parent + ".lastUpdatedAt$"))
            {
                this.LastUpdatedAt = new DateTime();
            }
            //      C# -> System.String? TaskchainId
            // GraphQL -> taskchainId: String! (scalar)
            if (this.TaskchainId == null && Exploration.Includes(parent + ".taskchainId$"))
            {
                this.TaskchainId = new System.String("FETCH");
            }
            //      C# -> ExocomputeHealthCheckStatusValue? Status
            // GraphQL -> status: ExocomputeHealthCheckStatusValue! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new ExocomputeHealthCheckStatusValue();
            }
        }


    #endregion

    } // class ExocomputeHealthCheckStatus
    #endregion

    public static class ListExocomputeHealthCheckStatusExtensions
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
            this List<ExocomputeHealthCheckStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ExocomputeHealthCheckStatus> list, 
            String parent = "")
        {
            var item = new ExocomputeHealthCheckStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types