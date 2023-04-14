// ThreatHuntResultObjectsSummary.cs
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
    #region ThreatHuntResultObjectsSummary
    public class ThreatHuntResultObjectsSummary: IFragment
    {
        #region members
        //      C# -> DateTime? EarliestMatchedSnapshotDate
        // GraphQL -> earliestMatchedSnapshotDate: DateTime (scalar)
        [JsonProperty("earliestMatchedSnapshotDate")]
        public DateTime? EarliestMatchedSnapshotDate { get; set; }

        //      C# -> DateTime? LatestMatchedSnapshotDate
        // GraphQL -> latestMatchedSnapshotDate: DateTime (scalar)
        [JsonProperty("latestMatchedSnapshotDate")]
        public DateTime? LatestMatchedSnapshotDate { get; set; }

        //      C# -> DateTime? LatestSnapshotWithoutMatchDate
        // GraphQL -> latestSnapshotWithoutMatchDate: DateTime (scalar)
        [JsonProperty("latestSnapshotWithoutMatchDate")]
        public DateTime? LatestSnapshotWithoutMatchDate { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.Int64? TotalMatchedPaths
        // GraphQL -> totalMatchedPaths: Long! (scalar)
        [JsonProperty("totalMatchedPaths")]
        public System.Int64? TotalMatchedPaths { get; set; }

        //      C# -> System.Int32? TotalMatchedSnapshots
        // GraphQL -> totalMatchedSnapshots: Int! (scalar)
        [JsonProperty("totalMatchedSnapshots")]
        public System.Int32? TotalMatchedSnapshots { get; set; }

        //      C# -> System.Int64? TotalUniqueMatchedPaths
        // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
        [JsonProperty("totalUniqueMatchedPaths")]
        public System.Int64? TotalUniqueMatchedPaths { get; set; }

        //      C# -> List<IndicatorOfCompromise>? MatchTypes
        // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
        [JsonProperty("matchTypes")]
        public List<IndicatorOfCompromise>? MatchTypes { get; set; }

        //      C# -> List<ThreatHuntResultSnapshotStats>? SnapshotsStats
        // GraphQL -> snapshotsStats: [ThreatHuntResultSnapshotStats!]! (type)
        [JsonProperty("snapshotsStats")]
        public List<ThreatHuntResultSnapshotStats>? SnapshotsStats { get; set; }

        //      C# -> CdmHierarchySnappableNew? Object
        // GraphQL -> object: CdmHierarchySnappableNew (interface)
        [JsonProperty("object")]
        public CdmHierarchySnappableNew? Object { get; set; }

        #endregion

    #region methods

    public ThreatHuntResultObjectsSummary Set(
        DateTime? EarliestMatchedSnapshotDate = null,
        DateTime? LatestMatchedSnapshotDate = null,
        DateTime? LatestSnapshotWithoutMatchDate = null,
        System.String? Location = null,
        System.Int64? TotalMatchedPaths = null,
        System.Int32? TotalMatchedSnapshots = null,
        System.Int64? TotalUniqueMatchedPaths = null,
        List<IndicatorOfCompromise>? MatchTypes = null,
        List<ThreatHuntResultSnapshotStats>? SnapshotsStats = null,
        CdmHierarchySnappableNew? Object = null
    ) 
    {
        if ( EarliestMatchedSnapshotDate != null ) {
            this.EarliestMatchedSnapshotDate = EarliestMatchedSnapshotDate;
        }
        if ( LatestMatchedSnapshotDate != null ) {
            this.LatestMatchedSnapshotDate = LatestMatchedSnapshotDate;
        }
        if ( LatestSnapshotWithoutMatchDate != null ) {
            this.LatestSnapshotWithoutMatchDate = LatestSnapshotWithoutMatchDate;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( TotalMatchedPaths != null ) {
            this.TotalMatchedPaths = TotalMatchedPaths;
        }
        if ( TotalMatchedSnapshots != null ) {
            this.TotalMatchedSnapshots = TotalMatchedSnapshots;
        }
        if ( TotalUniqueMatchedPaths != null ) {
            this.TotalUniqueMatchedPaths = TotalUniqueMatchedPaths;
        }
        if ( MatchTypes != null ) {
            this.MatchTypes = MatchTypes;
        }
        if ( SnapshotsStats != null ) {
            this.SnapshotsStats = SnapshotsStats;
        }
        if ( Object != null ) {
            this.Object = Object;
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
            //      C# -> DateTime? EarliestMatchedSnapshotDate
            // GraphQL -> earliestMatchedSnapshotDate: DateTime (scalar)
            if (this.EarliestMatchedSnapshotDate != null)
            {
                 s += ind + "earliestMatchedSnapshotDate\n";

            }
            //      C# -> DateTime? LatestMatchedSnapshotDate
            // GraphQL -> latestMatchedSnapshotDate: DateTime (scalar)
            if (this.LatestMatchedSnapshotDate != null)
            {
                 s += ind + "latestMatchedSnapshotDate\n";

            }
            //      C# -> DateTime? LatestSnapshotWithoutMatchDate
            // GraphQL -> latestSnapshotWithoutMatchDate: DateTime (scalar)
            if (this.LatestSnapshotWithoutMatchDate != null)
            {
                 s += ind + "latestSnapshotWithoutMatchDate\n";

            }
            //      C# -> System.String? Location
            // GraphQL -> location: String! (scalar)
            if (this.Location != null)
            {
                 s += ind + "location\n";

            }
            //      C# -> System.Int64? TotalMatchedPaths
            // GraphQL -> totalMatchedPaths: Long! (scalar)
            if (this.TotalMatchedPaths != null)
            {
                 s += ind + "totalMatchedPaths\n";

            }
            //      C# -> System.Int32? TotalMatchedSnapshots
            // GraphQL -> totalMatchedSnapshots: Int! (scalar)
            if (this.TotalMatchedSnapshots != null)
            {
                 s += ind + "totalMatchedSnapshots\n";

            }
            //      C# -> System.Int64? TotalUniqueMatchedPaths
            // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
            if (this.TotalUniqueMatchedPaths != null)
            {
                 s += ind + "totalUniqueMatchedPaths\n";

            }
            //      C# -> List<IndicatorOfCompromise>? MatchTypes
            // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
            if (this.MatchTypes != null)
            {
                 s += ind + "matchTypes\n";

                 s += ind + "{\n" + 
                 this.MatchTypes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ThreatHuntResultSnapshotStats>? SnapshotsStats
            // GraphQL -> snapshotsStats: [ThreatHuntResultSnapshotStats!]! (type)
            if (this.SnapshotsStats != null)
            {
                 s += ind + "snapshotsStats\n";

                 s += ind + "{\n" + 
                 this.SnapshotsStats.AsFragment(indent+1) + 
                 ind + "}\n";
            }
                        //      C# -> CdmHierarchySnappableNew? Object
            // GraphQL -> object: CdmHierarchySnappableNew (interface)
            if (this.Object != null)
            {
                s += ind + "object\n";
                s += ind + "{\n";

                string typename = this.Object.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.Object.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? EarliestMatchedSnapshotDate
            // GraphQL -> earliestMatchedSnapshotDate: DateTime (scalar)
            if (this.EarliestMatchedSnapshotDate == null && Exploration.Includes(parent + ".earliestMatchedSnapshotDate$"))
            {
                this.EarliestMatchedSnapshotDate = new DateTime();
            }
            //      C# -> DateTime? LatestMatchedSnapshotDate
            // GraphQL -> latestMatchedSnapshotDate: DateTime (scalar)
            if (this.LatestMatchedSnapshotDate == null && Exploration.Includes(parent + ".latestMatchedSnapshotDate$"))
            {
                this.LatestMatchedSnapshotDate = new DateTime();
            }
            //      C# -> DateTime? LatestSnapshotWithoutMatchDate
            // GraphQL -> latestSnapshotWithoutMatchDate: DateTime (scalar)
            if (this.LatestSnapshotWithoutMatchDate == null && Exploration.Includes(parent + ".latestSnapshotWithoutMatchDate$"))
            {
                this.LatestSnapshotWithoutMatchDate = new DateTime();
            }
            //      C# -> System.String? Location
            // GraphQL -> location: String! (scalar)
            if (this.Location == null && Exploration.Includes(parent + ".location$"))
            {
                this.Location = new System.String("FETCH");
            }
            //      C# -> System.Int64? TotalMatchedPaths
            // GraphQL -> totalMatchedPaths: Long! (scalar)
            if (this.TotalMatchedPaths == null && Exploration.Includes(parent + ".totalMatchedPaths$"))
            {
                this.TotalMatchedPaths = new System.Int64();
            }
            //      C# -> System.Int32? TotalMatchedSnapshots
            // GraphQL -> totalMatchedSnapshots: Int! (scalar)
            if (this.TotalMatchedSnapshots == null && Exploration.Includes(parent + ".totalMatchedSnapshots$"))
            {
                this.TotalMatchedSnapshots = new System.Int32();
            }
            //      C# -> System.Int64? TotalUniqueMatchedPaths
            // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
            if (this.TotalUniqueMatchedPaths == null && Exploration.Includes(parent + ".totalUniqueMatchedPaths$"))
            {
                this.TotalUniqueMatchedPaths = new System.Int64();
            }
            //      C# -> List<IndicatorOfCompromise>? MatchTypes
            // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
            if (this.MatchTypes == null && Exploration.Includes(parent + ".matchTypes"))
            {
                this.MatchTypes = new List<IndicatorOfCompromise>();
                this.MatchTypes.ApplyExploratoryFragment(parent + ".matchTypes");
            }
            //      C# -> List<ThreatHuntResultSnapshotStats>? SnapshotsStats
            // GraphQL -> snapshotsStats: [ThreatHuntResultSnapshotStats!]! (type)
            if (this.SnapshotsStats == null && Exploration.Includes(parent + ".snapshotsStats"))
            {
                this.SnapshotsStats = new List<ThreatHuntResultSnapshotStats>();
                this.SnapshotsStats.ApplyExploratoryFragment(parent + ".snapshotsStats");
            }
            //      C# -> CdmHierarchySnappableNew? Object
            // GraphQL -> object: CdmHierarchySnappableNew (interface)
            if (this.Object == null && Exploration.Includes(parent + ".object"))
            {
                this.Object = (CdmHierarchySnappableNew)InterfaceHelper.CreateInstanceOfFirstType(typeof(CdmHierarchySnappableNew));
                this.Object.ApplyExploratoryFragment(parent + ".object");
            }
        }


    #endregion

    } // class ThreatHuntResultObjectsSummary
    #endregion

    public static class ListThreatHuntResultObjectsSummaryExtensions
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
            this List<ThreatHuntResultObjectsSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ThreatHuntResultObjectsSummary> list, 
            String parent = "")
        {
            var item = new ThreatHuntResultObjectsSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types