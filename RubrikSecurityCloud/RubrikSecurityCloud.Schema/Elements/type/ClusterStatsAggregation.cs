// ClusterStatsAggregation.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:21.
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
    #region ClusterStatsAggregation
    public class ClusterStatsAggregation: IFragment
    {
        #region members
        //      C# -> System.Int64? IngestedArchivalStorage
        // GraphQL -> ingestedArchivalStorage: Long! (scalar)
        [JsonProperty("ingestedArchivalStorage")]
        public System.Int64? IngestedArchivalStorage { get; set; }

        //      C# -> System.Int64? IngestedSnapshotStorage
        // GraphQL -> ingestedSnapshotStorage: Long! (scalar)
        [JsonProperty("ingestedSnapshotStorage")]
        public System.Int64? IngestedSnapshotStorage { get; set; }

        //      C# -> System.Int64? PhysicalArchivalStorage
        // GraphQL -> physicalArchivalStorage: Long! (scalar)
        [JsonProperty("physicalArchivalStorage")]
        public System.Int64? PhysicalArchivalStorage { get; set; }

        //      C# -> System.Int64? PhysicalSnapshotStorage
        // GraphQL -> physicalSnapshotStorage: Long! (scalar)
        [JsonProperty("physicalSnapshotStorage")]
        public System.Int64? PhysicalSnapshotStorage { get; set; }

        #endregion

    #region methods

    public ClusterStatsAggregation Set(
        System.Int64? IngestedArchivalStorage = null,
        System.Int64? IngestedSnapshotStorage = null,
        System.Int64? PhysicalArchivalStorage = null,
        System.Int64? PhysicalSnapshotStorage = null
    ) 
    {
        if ( IngestedArchivalStorage != null ) {
            this.IngestedArchivalStorage = IngestedArchivalStorage;
        }
        if ( IngestedSnapshotStorage != null ) {
            this.IngestedSnapshotStorage = IngestedSnapshotStorage;
        }
        if ( PhysicalArchivalStorage != null ) {
            this.PhysicalArchivalStorage = PhysicalArchivalStorage;
        }
        if ( PhysicalSnapshotStorage != null ) {
            this.PhysicalSnapshotStorage = PhysicalSnapshotStorage;
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
            //      C# -> System.Int64? IngestedArchivalStorage
            // GraphQL -> ingestedArchivalStorage: Long! (scalar)
            if (this.IngestedArchivalStorage != null)
            {
                 s += ind + "ingestedArchivalStorage\n";

            }
            //      C# -> System.Int64? IngestedSnapshotStorage
            // GraphQL -> ingestedSnapshotStorage: Long! (scalar)
            if (this.IngestedSnapshotStorage != null)
            {
                 s += ind + "ingestedSnapshotStorage\n";

            }
            //      C# -> System.Int64? PhysicalArchivalStorage
            // GraphQL -> physicalArchivalStorage: Long! (scalar)
            if (this.PhysicalArchivalStorage != null)
            {
                 s += ind + "physicalArchivalStorage\n";

            }
            //      C# -> System.Int64? PhysicalSnapshotStorage
            // GraphQL -> physicalSnapshotStorage: Long! (scalar)
            if (this.PhysicalSnapshotStorage != null)
            {
                 s += ind + "physicalSnapshotStorage\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? IngestedArchivalStorage
            // GraphQL -> ingestedArchivalStorage: Long! (scalar)
            if (this.IngestedArchivalStorage == null && Exploration.Includes(parent + ".ingestedArchivalStorage$"))
            {
                this.IngestedArchivalStorage = new System.Int64();
            }
            //      C# -> System.Int64? IngestedSnapshotStorage
            // GraphQL -> ingestedSnapshotStorage: Long! (scalar)
            if (this.IngestedSnapshotStorage == null && Exploration.Includes(parent + ".ingestedSnapshotStorage$"))
            {
                this.IngestedSnapshotStorage = new System.Int64();
            }
            //      C# -> System.Int64? PhysicalArchivalStorage
            // GraphQL -> physicalArchivalStorage: Long! (scalar)
            if (this.PhysicalArchivalStorage == null && Exploration.Includes(parent + ".physicalArchivalStorage$"))
            {
                this.PhysicalArchivalStorage = new System.Int64();
            }
            //      C# -> System.Int64? PhysicalSnapshotStorage
            // GraphQL -> physicalSnapshotStorage: Long! (scalar)
            if (this.PhysicalSnapshotStorage == null && Exploration.Includes(parent + ".physicalSnapshotStorage$"))
            {
                this.PhysicalSnapshotStorage = new System.Int64();
            }
        }


    #endregion

    } // class ClusterStatsAggregation
    #endregion

    public static class ListClusterStatsAggregationExtensions
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
            this List<ClusterStatsAggregation> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterStatsAggregation> list, 
            String parent = "")
        {
            var item = new ClusterStatsAggregation();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types