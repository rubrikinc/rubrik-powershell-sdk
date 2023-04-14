// PrecheckStatusNextRunInfo.cs
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
    #region PrecheckStatusNextRunInfo
    public class PrecheckStatusNextRunInfo: IFragment
    {
        #region members
        //      C# -> System.String? JobInstanceId
        // GraphQL -> jobInstanceId: String! (scalar)
        [JsonProperty("jobInstanceId")]
        public System.String? JobInstanceId { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        #endregion

    #region methods

    public PrecheckStatusNextRunInfo Set(
        System.String? JobInstanceId = null,
        System.Int64? StartTime = null,
        System.String? Status = null
    ) 
    {
        if ( JobInstanceId != null ) {
            this.JobInstanceId = JobInstanceId;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
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
            //      C# -> System.String? JobInstanceId
            // GraphQL -> jobInstanceId: String! (scalar)
            if (this.JobInstanceId != null)
            {
                 s += ind + "jobInstanceId\n";

            }
            //      C# -> System.Int64? StartTime
            // GraphQL -> startTime: Long! (scalar)
            if (this.StartTime != null)
            {
                 s += ind + "startTime\n";

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
            //      C# -> System.String? JobInstanceId
            // GraphQL -> jobInstanceId: String! (scalar)
            if (this.JobInstanceId == null && Exploration.Includes(parent + ".jobInstanceId$"))
            {
                this.JobInstanceId = new System.String("FETCH");
            }
            //      C# -> System.Int64? StartTime
            // GraphQL -> startTime: Long! (scalar)
            if (this.StartTime == null && Exploration.Includes(parent + ".startTime$"))
            {
                this.StartTime = new System.Int64();
            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new System.String("FETCH");
            }
        }


    #endregion

    } // class PrecheckStatusNextRunInfo
    #endregion

    public static class ListPrecheckStatusNextRunInfoExtensions
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
            this List<PrecheckStatusNextRunInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PrecheckStatusNextRunInfo> list, 
            String parent = "")
        {
            var item = new PrecheckStatusNextRunInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types