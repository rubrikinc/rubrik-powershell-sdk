// ThreatMonitoringStats.cs
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
    #region ThreatMonitoringStats
    public class ThreatMonitoringStats: IFragment
    {
        #region members
        //      C# -> System.Int64? ObjectsFailedScans
        // GraphQL -> objectsFailedScans: Long! (scalar)
        [JsonProperty("objectsFailedScans")]
        public System.Int64? ObjectsFailedScans { get; set; }

        //      C# -> System.Int64? ObjectsWithMatches
        // GraphQL -> objectsWithMatches: Long! (scalar)
        [JsonProperty("objectsWithMatches")]
        public System.Int64? ObjectsWithMatches { get; set; }

        //      C# -> System.Int64? ObjectsWithNoMatches
        // GraphQL -> objectsWithNoMatches: Long! (scalar)
        [JsonProperty("objectsWithNoMatches")]
        public System.Int64? ObjectsWithNoMatches { get; set; }

        //      C# -> System.Int64? TotalObjectsScanned
        // GraphQL -> totalObjectsScanned: Long! (scalar)
        [JsonProperty("totalObjectsScanned")]
        public System.Int64? TotalObjectsScanned { get; set; }

        #endregion

    #region methods

    public ThreatMonitoringStats Set(
        System.Int64? ObjectsFailedScans = null,
        System.Int64? ObjectsWithMatches = null,
        System.Int64? ObjectsWithNoMatches = null,
        System.Int64? TotalObjectsScanned = null
    ) 
    {
        if ( ObjectsFailedScans != null ) {
            this.ObjectsFailedScans = ObjectsFailedScans;
        }
        if ( ObjectsWithMatches != null ) {
            this.ObjectsWithMatches = ObjectsWithMatches;
        }
        if ( ObjectsWithNoMatches != null ) {
            this.ObjectsWithNoMatches = ObjectsWithNoMatches;
        }
        if ( TotalObjectsScanned != null ) {
            this.TotalObjectsScanned = TotalObjectsScanned;
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
            //      C# -> System.Int64? ObjectsFailedScans
            // GraphQL -> objectsFailedScans: Long! (scalar)
            if (this.ObjectsFailedScans != null)
            {
                 s += ind + "objectsFailedScans\n";

            }
            //      C# -> System.Int64? ObjectsWithMatches
            // GraphQL -> objectsWithMatches: Long! (scalar)
            if (this.ObjectsWithMatches != null)
            {
                 s += ind + "objectsWithMatches\n";

            }
            //      C# -> System.Int64? ObjectsWithNoMatches
            // GraphQL -> objectsWithNoMatches: Long! (scalar)
            if (this.ObjectsWithNoMatches != null)
            {
                 s += ind + "objectsWithNoMatches\n";

            }
            //      C# -> System.Int64? TotalObjectsScanned
            // GraphQL -> totalObjectsScanned: Long! (scalar)
            if (this.TotalObjectsScanned != null)
            {
                 s += ind + "totalObjectsScanned\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? ObjectsFailedScans
            // GraphQL -> objectsFailedScans: Long! (scalar)
            if (this.ObjectsFailedScans == null && Exploration.Includes(parent + ".objectsFailedScans$"))
            {
                this.ObjectsFailedScans = new System.Int64();
            }
            //      C# -> System.Int64? ObjectsWithMatches
            // GraphQL -> objectsWithMatches: Long! (scalar)
            if (this.ObjectsWithMatches == null && Exploration.Includes(parent + ".objectsWithMatches$"))
            {
                this.ObjectsWithMatches = new System.Int64();
            }
            //      C# -> System.Int64? ObjectsWithNoMatches
            // GraphQL -> objectsWithNoMatches: Long! (scalar)
            if (this.ObjectsWithNoMatches == null && Exploration.Includes(parent + ".objectsWithNoMatches$"))
            {
                this.ObjectsWithNoMatches = new System.Int64();
            }
            //      C# -> System.Int64? TotalObjectsScanned
            // GraphQL -> totalObjectsScanned: Long! (scalar)
            if (this.TotalObjectsScanned == null && Exploration.Includes(parent + ".totalObjectsScanned$"))
            {
                this.TotalObjectsScanned = new System.Int64();
            }
        }


    #endregion

    } // class ThreatMonitoringStats
    #endregion

    public static class ListThreatMonitoringStatsExtensions
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
            this List<ThreatMonitoringStats> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ThreatMonitoringStats> list, 
            String parent = "")
        {
            var item = new ThreatMonitoringStats();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types