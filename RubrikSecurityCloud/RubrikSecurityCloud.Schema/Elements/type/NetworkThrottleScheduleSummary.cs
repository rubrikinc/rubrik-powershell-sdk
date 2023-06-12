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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region NetworkThrottleScheduleSummary
    public class NetworkThrottleScheduleSummary: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.Int32>? DaysOfWeek
        // GraphQL -> daysOfWeek: [Int!]! (scalar)
        if (this.DaysOfWeek != null) {
            s += ind + "daysOfWeek\n" ;
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime != null) {
            s += ind + "endTime\n" ;
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> System.Single? ThrottleLimit
        // GraphQL -> throttleLimit: Float! (scalar)
        if (this.ThrottleLimit != null) {
            s += ind + "throttleLimit\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.Int32>? DaysOfWeek
        // GraphQL -> daysOfWeek: [Int!]! (scalar)
        if (this.DaysOfWeek == null && Exploration.Includes(parent + ".daysOfWeek", true))
        {
            this.DaysOfWeek = new List<System.Int32>();
        }
        //      C# -> System.Int64? EndTime
        // GraphQL -> endTime: Long! (scalar)
        if (this.EndTime == null && Exploration.Includes(parent + ".endTime", true))
        {
            this.EndTime = new System.Int64();
        }
        //      C# -> System.Int64? StartTime
        // GraphQL -> startTime: Long! (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = new System.Int64();
        }
        //      C# -> System.Single? ThrottleLimit
        // GraphQL -> throttleLimit: Float! (scalar)
        if (this.ThrottleLimit == null && Exploration.Includes(parent + ".throttleLimit", true))
        {
            this.ThrottleLimit = new System.Single();
        }
    }


    #endregion

    } // class NetworkThrottleScheduleSummary
    
    #endregion

    public static class ListNetworkThrottleScheduleSummaryExtensions
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
            this List<NetworkThrottleScheduleSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NetworkThrottleScheduleSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NetworkThrottleScheduleSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types