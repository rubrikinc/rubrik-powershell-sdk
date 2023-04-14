// ThreatHuntStats.cs
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
    #region ThreatHuntStats
    public class ThreatHuntStats: IFragment
    {
        #region members
        //      C# -> System.Int64? TotalAffectedObjects
        // GraphQL -> totalAffectedObjects: Long! (scalar)
        [JsonProperty("totalAffectedObjects")]
        public System.Int64? TotalAffectedObjects { get; set; }

        //      C# -> System.Int64? TotalAffectedSnapshots
        // GraphQL -> totalAffectedSnapshots: Long! (scalar)
        [JsonProperty("totalAffectedSnapshots")]
        public System.Int64? TotalAffectedSnapshots { get; set; }

        //      C# -> System.Int64? TotalSnapshotsScanned
        // GraphQL -> totalSnapshotsScanned: Long! (scalar)
        [JsonProperty("totalSnapshotsScanned")]
        public System.Int64? TotalSnapshotsScanned { get; set; }

        //      C# -> System.Int64? TotalSucceededScans
        // GraphQL -> totalSucceededScans: Long! (scalar)
        [JsonProperty("totalSucceededScans")]
        public System.Int64? TotalSucceededScans { get; set; }

        //      C# -> System.Int64? TotalUniqueMatchedPaths
        // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
        [JsonProperty("totalUniqueMatchedPaths")]
        public System.Int64? TotalUniqueMatchedPaths { get; set; }

        //      C# -> System.Int64? TotalUniqueQuarantinedPaths
        // GraphQL -> totalUniqueQuarantinedPaths: Long! (scalar)
        [JsonProperty("totalUniqueQuarantinedPaths")]
        public System.Int64? TotalUniqueQuarantinedPaths { get; set; }

        #endregion

    #region methods

    public ThreatHuntStats Set(
        System.Int64? TotalAffectedObjects = null,
        System.Int64? TotalAffectedSnapshots = null,
        System.Int64? TotalSnapshotsScanned = null,
        System.Int64? TotalSucceededScans = null,
        System.Int64? TotalUniqueMatchedPaths = null,
        System.Int64? TotalUniqueQuarantinedPaths = null
    ) 
    {
        if ( TotalAffectedObjects != null ) {
            this.TotalAffectedObjects = TotalAffectedObjects;
        }
        if ( TotalAffectedSnapshots != null ) {
            this.TotalAffectedSnapshots = TotalAffectedSnapshots;
        }
        if ( TotalSnapshotsScanned != null ) {
            this.TotalSnapshotsScanned = TotalSnapshotsScanned;
        }
        if ( TotalSucceededScans != null ) {
            this.TotalSucceededScans = TotalSucceededScans;
        }
        if ( TotalUniqueMatchedPaths != null ) {
            this.TotalUniqueMatchedPaths = TotalUniqueMatchedPaths;
        }
        if ( TotalUniqueQuarantinedPaths != null ) {
            this.TotalUniqueQuarantinedPaths = TotalUniqueQuarantinedPaths;
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
            //      C# -> System.Int64? TotalAffectedObjects
            // GraphQL -> totalAffectedObjects: Long! (scalar)
            if (this.TotalAffectedObjects != null)
            {
                 s += ind + "totalAffectedObjects\n";

            }
            //      C# -> System.Int64? TotalAffectedSnapshots
            // GraphQL -> totalAffectedSnapshots: Long! (scalar)
            if (this.TotalAffectedSnapshots != null)
            {
                 s += ind + "totalAffectedSnapshots\n";

            }
            //      C# -> System.Int64? TotalSnapshotsScanned
            // GraphQL -> totalSnapshotsScanned: Long! (scalar)
            if (this.TotalSnapshotsScanned != null)
            {
                 s += ind + "totalSnapshotsScanned\n";

            }
            //      C# -> System.Int64? TotalSucceededScans
            // GraphQL -> totalSucceededScans: Long! (scalar)
            if (this.TotalSucceededScans != null)
            {
                 s += ind + "totalSucceededScans\n";

            }
            //      C# -> System.Int64? TotalUniqueMatchedPaths
            // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
            if (this.TotalUniqueMatchedPaths != null)
            {
                 s += ind + "totalUniqueMatchedPaths\n";

            }
            //      C# -> System.Int64? TotalUniqueQuarantinedPaths
            // GraphQL -> totalUniqueQuarantinedPaths: Long! (scalar)
            if (this.TotalUniqueQuarantinedPaths != null)
            {
                 s += ind + "totalUniqueQuarantinedPaths\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? TotalAffectedObjects
            // GraphQL -> totalAffectedObjects: Long! (scalar)
            if (this.TotalAffectedObjects == null && Exploration.Includes(parent + ".totalAffectedObjects$"))
            {
                this.TotalAffectedObjects = new System.Int64();
            }
            //      C# -> System.Int64? TotalAffectedSnapshots
            // GraphQL -> totalAffectedSnapshots: Long! (scalar)
            if (this.TotalAffectedSnapshots == null && Exploration.Includes(parent + ".totalAffectedSnapshots$"))
            {
                this.TotalAffectedSnapshots = new System.Int64();
            }
            //      C# -> System.Int64? TotalSnapshotsScanned
            // GraphQL -> totalSnapshotsScanned: Long! (scalar)
            if (this.TotalSnapshotsScanned == null && Exploration.Includes(parent + ".totalSnapshotsScanned$"))
            {
                this.TotalSnapshotsScanned = new System.Int64();
            }
            //      C# -> System.Int64? TotalSucceededScans
            // GraphQL -> totalSucceededScans: Long! (scalar)
            if (this.TotalSucceededScans == null && Exploration.Includes(parent + ".totalSucceededScans$"))
            {
                this.TotalSucceededScans = new System.Int64();
            }
            //      C# -> System.Int64? TotalUniqueMatchedPaths
            // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
            if (this.TotalUniqueMatchedPaths == null && Exploration.Includes(parent + ".totalUniqueMatchedPaths$"))
            {
                this.TotalUniqueMatchedPaths = new System.Int64();
            }
            //      C# -> System.Int64? TotalUniqueQuarantinedPaths
            // GraphQL -> totalUniqueQuarantinedPaths: Long! (scalar)
            if (this.TotalUniqueQuarantinedPaths == null && Exploration.Includes(parent + ".totalUniqueQuarantinedPaths$"))
            {
                this.TotalUniqueQuarantinedPaths = new System.Int64();
            }
        }


    #endregion

    } // class ThreatHuntStats
    #endregion

    public static class ListThreatHuntStatsExtensions
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
            this List<ThreatHuntStats> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ThreatHuntStats> list, 
            String parent = "")
        {
            var item = new ThreatHuntStats();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types