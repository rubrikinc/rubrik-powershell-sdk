// NetworkThrottleScheduleSummary.cs
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
    #region NetworkThrottleScheduleSummary
    public class NetworkThrottleScheduleSummary: IFragment
    {
        #region members
        //      C# -> List<System.Int32>? DaysOfWeek
        // GraphQL -> daysOfWeek: [Int!]! (scalar)
        [JsonProperty("daysOfWeek")]
        public List<System.Int32>? DaysOfWeek { get; set; }

        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        [JsonProperty("endTime")]
        public System.Int64? EndTime { get; set; }

        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        [JsonProperty("startTime")]
        public System.Int64? StartTime { get; set; }

        //      C# -> System.Single? ThrottleLimit
        // GraphQL -> throttleLimit: Float! (scalar)
        [JsonProperty("throttleLimit")]
        public System.Single? ThrottleLimit { get; set; }

        #endregion

    #region methods

    public NetworkThrottleScheduleSummary Set(
        List<System.Int32>? DaysOfWeek = null,
        System.Int64? EndTime = null,
        System.Int64? StartTime = null,
        System.Single? ThrottleLimit = null
    ) 
    {
        if ( DaysOfWeek != null ) {
            this.DaysOfWeek = DaysOfWeek;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( ThrottleLimit != null ) {
            this.ThrottleLimit = ThrottleLimit;
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
            //      C# -> List<System.Int32>? DaysOfWeek
            // GraphQL -> daysOfWeek: [Int!]! (scalar)
            if (this.DaysOfWeek != null)
            {
                 s += ind + "daysOfWeek\n";

            }
            //      C# -> System.Int64? EndTime
            // GraphQL -> endTime: Long! (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> System.Int64? StartTime
            // GraphQL -> startTime: Long! (scalar)
            if (this.StartTime != null)
            {
                 s += ind + "startTime\n";

            }
            //      C# -> System.Single? ThrottleLimit
            // GraphQL -> throttleLimit: Float! (scalar)
            if (this.ThrottleLimit != null)
            {
                 s += ind + "throttleLimit\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.Int32>? DaysOfWeek
            // GraphQL -> daysOfWeek: [Int!]! (scalar)
            if (this.DaysOfWeek == null && Exploration.Includes(parent + ".daysOfWeek$"))
            {
                this.DaysOfWeek = new List<System.Int32>();
            }
            //      C# -> System.Int64? EndTime
            // GraphQL -> endTime: Long! (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new System.Int64();
            }
            //      C# -> System.Int64? StartTime
            // GraphQL -> startTime: Long! (scalar)
            if (this.StartTime == null && Exploration.Includes(parent + ".startTime$"))
            {
                this.StartTime = new System.Int64();
            }
            //      C# -> System.Single? ThrottleLimit
            // GraphQL -> throttleLimit: Float! (scalar)
            if (this.ThrottleLimit == null && Exploration.Includes(parent + ".throttleLimit$"))
            {
                this.ThrottleLimit = new System.Single();
            }
        }


    #endregion

    } // class NetworkThrottleScheduleSummary
    #endregion

    public static class ListNetworkThrottleScheduleSummaryExtensions
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
            this List<NetworkThrottleScheduleSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NetworkThrottleScheduleSummary> list, 
            String parent = "")
        {
            var item = new NetworkThrottleScheduleSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types