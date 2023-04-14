// SnapshotDistribution.cs
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
    #region SnapshotDistribution
    public class SnapshotDistribution: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? OnDemandCount
        // GraphQL -> onDemandCount: Long! (scalar)
        [JsonProperty("onDemandCount")]
        public System.Int64? OnDemandCount { get; set; }

        //      C# -> System.Int64? RetrievedCount
        // GraphQL -> retrievedCount: Long! (scalar)
        [JsonProperty("retrievedCount")]
        public System.Int64? RetrievedCount { get; set; }

        //      C# -> System.Int64? ScheduledCount
        // GraphQL -> scheduledCount: Long! (scalar)
        [JsonProperty("scheduledCount")]
        public System.Int64? ScheduledCount { get; set; }

        //      C# -> System.Int64? TotalCount
        // GraphQL -> totalCount: Long! (scalar)
        [JsonProperty("totalCount")]
        public System.Int64? TotalCount { get; set; }

        #endregion

    #region methods

    public SnapshotDistribution Set(
        System.String? Id = null,
        System.Int64? OnDemandCount = null,
        System.Int64? RetrievedCount = null,
        System.Int64? ScheduledCount = null,
        System.Int64? TotalCount = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( OnDemandCount != null ) {
            this.OnDemandCount = OnDemandCount;
        }
        if ( RetrievedCount != null ) {
            this.RetrievedCount = RetrievedCount;
        }
        if ( ScheduledCount != null ) {
            this.ScheduledCount = ScheduledCount;
        }
        if ( TotalCount != null ) {
            this.TotalCount = TotalCount;
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
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Int64? OnDemandCount
            // GraphQL -> onDemandCount: Long! (scalar)
            if (this.OnDemandCount != null)
            {
                 s += ind + "onDemandCount\n";

            }
            //      C# -> System.Int64? RetrievedCount
            // GraphQL -> retrievedCount: Long! (scalar)
            if (this.RetrievedCount != null)
            {
                 s += ind + "retrievedCount\n";

            }
            //      C# -> System.Int64? ScheduledCount
            // GraphQL -> scheduledCount: Long! (scalar)
            if (this.ScheduledCount != null)
            {
                 s += ind + "scheduledCount\n";

            }
            //      C# -> System.Int64? TotalCount
            // GraphQL -> totalCount: Long! (scalar)
            if (this.TotalCount != null)
            {
                 s += ind + "totalCount\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Int64? OnDemandCount
            // GraphQL -> onDemandCount: Long! (scalar)
            if (this.OnDemandCount == null && Exploration.Includes(parent + ".onDemandCount$"))
            {
                this.OnDemandCount = new System.Int64();
            }
            //      C# -> System.Int64? RetrievedCount
            // GraphQL -> retrievedCount: Long! (scalar)
            if (this.RetrievedCount == null && Exploration.Includes(parent + ".retrievedCount$"))
            {
                this.RetrievedCount = new System.Int64();
            }
            //      C# -> System.Int64? ScheduledCount
            // GraphQL -> scheduledCount: Long! (scalar)
            if (this.ScheduledCount == null && Exploration.Includes(parent + ".scheduledCount$"))
            {
                this.ScheduledCount = new System.Int64();
            }
            //      C# -> System.Int64? TotalCount
            // GraphQL -> totalCount: Long! (scalar)
            if (this.TotalCount == null && Exploration.Includes(parent + ".totalCount$"))
            {
                this.TotalCount = new System.Int64();
            }
        }


    #endregion

    } // class SnapshotDistribution
    #endregion

    public static class ListSnapshotDistributionExtensions
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
            this List<SnapshotDistribution> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SnapshotDistribution> list, 
            String parent = "")
        {
            var item = new SnapshotDistribution();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types