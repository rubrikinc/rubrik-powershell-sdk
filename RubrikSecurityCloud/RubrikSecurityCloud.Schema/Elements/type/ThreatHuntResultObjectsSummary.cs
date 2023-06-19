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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region ThreatHuntResultObjectsSummary
    public class ThreatHuntResultObjectsSummary: BaseType
    {
        #region members

        //      C# -> CdmHierarchySnappableNew? Object
        // GraphQL -> object: CdmHierarchySnappableNew (interface)
        [JsonProperty("object")]
        public CdmHierarchySnappableNew? Object { get; set; }

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


        #endregion

    #region methods

    public ThreatHuntResultObjectsSummary Set(
        CdmHierarchySnappableNew? Object = null,
        DateTime? EarliestMatchedSnapshotDate = null,
        DateTime? LatestMatchedSnapshotDate = null,
        DateTime? LatestSnapshotWithoutMatchDate = null,
        System.String? Location = null,
        System.Int64? TotalMatchedPaths = null,
        System.Int32? TotalMatchedSnapshots = null,
        System.Int64? TotalUniqueMatchedPaths = null,
        List<IndicatorOfCompromise>? MatchTypes = null,
        List<ThreatHuntResultSnapshotStats>? SnapshotsStats = null
    ) 
    {
        if ( Object != null ) {
            this.Object = Object;
        }
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
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> CdmHierarchySnappableNew? Object
        // GraphQL -> object: CdmHierarchySnappableNew (interface)
        if (this.Object != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.Object).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "object {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> DateTime? EarliestMatchedSnapshotDate
        // GraphQL -> earliestMatchedSnapshotDate: DateTime (scalar)
        if (this.EarliestMatchedSnapshotDate != null) {
            s += ind + "earliestMatchedSnapshotDate\n" ;
        }
        //      C# -> DateTime? LatestMatchedSnapshotDate
        // GraphQL -> latestMatchedSnapshotDate: DateTime (scalar)
        if (this.LatestMatchedSnapshotDate != null) {
            s += ind + "latestMatchedSnapshotDate\n" ;
        }
        //      C# -> DateTime? LatestSnapshotWithoutMatchDate
        // GraphQL -> latestSnapshotWithoutMatchDate: DateTime (scalar)
        if (this.LatestSnapshotWithoutMatchDate != null) {
            s += ind + "latestSnapshotWithoutMatchDate\n" ;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            s += ind + "location\n" ;
        }
        //      C# -> System.Int64? TotalMatchedPaths
        // GraphQL -> totalMatchedPaths: Long! (scalar)
        if (this.TotalMatchedPaths != null) {
            s += ind + "totalMatchedPaths\n" ;
        }
        //      C# -> System.Int32? TotalMatchedSnapshots
        // GraphQL -> totalMatchedSnapshots: Int! (scalar)
        if (this.TotalMatchedSnapshots != null) {
            s += ind + "totalMatchedSnapshots\n" ;
        }
        //      C# -> System.Int64? TotalUniqueMatchedPaths
        // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
        if (this.TotalUniqueMatchedPaths != null) {
            s += ind + "totalUniqueMatchedPaths\n" ;
        }
        //      C# -> List<IndicatorOfCompromise>? MatchTypes
        // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
        if (this.MatchTypes != null) {
            var fspec = this.MatchTypes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "matchTypes {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ThreatHuntResultSnapshotStats>? SnapshotsStats
        // GraphQL -> snapshotsStats: [ThreatHuntResultSnapshotStats!]! (type)
        if (this.SnapshotsStats != null) {
            var fspec = this.SnapshotsStats.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotsStats {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CdmHierarchySnappableNew? Object
        // GraphQL -> object: CdmHierarchySnappableNew (interface)
        if (this.Object == null && Exploration.Includes(parent + ".object"))
        {
            var impls = new List<CdmHierarchySnappableNew>();
            impls.ApplyExploratoryFieldSpec(parent + ".object");
            this.Object = (CdmHierarchySnappableNew)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> DateTime? EarliestMatchedSnapshotDate
        // GraphQL -> earliestMatchedSnapshotDate: DateTime (scalar)
        if (this.EarliestMatchedSnapshotDate == null && Exploration.Includes(parent + ".earliestMatchedSnapshotDate", true))
        {
            this.EarliestMatchedSnapshotDate = new DateTime();
        }
        //      C# -> DateTime? LatestMatchedSnapshotDate
        // GraphQL -> latestMatchedSnapshotDate: DateTime (scalar)
        if (this.LatestMatchedSnapshotDate == null && Exploration.Includes(parent + ".latestMatchedSnapshotDate", true))
        {
            this.LatestMatchedSnapshotDate = new DateTime();
        }
        //      C# -> DateTime? LatestSnapshotWithoutMatchDate
        // GraphQL -> latestSnapshotWithoutMatchDate: DateTime (scalar)
        if (this.LatestSnapshotWithoutMatchDate == null && Exploration.Includes(parent + ".latestSnapshotWithoutMatchDate", true))
        {
            this.LatestSnapshotWithoutMatchDate = new DateTime();
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location == null && Exploration.Includes(parent + ".location", true))
        {
            this.Location = "FETCH";
        }
        //      C# -> System.Int64? TotalMatchedPaths
        // GraphQL -> totalMatchedPaths: Long! (scalar)
        if (this.TotalMatchedPaths == null && Exploration.Includes(parent + ".totalMatchedPaths", true))
        {
            this.TotalMatchedPaths = new System.Int64();
        }
        //      C# -> System.Int32? TotalMatchedSnapshots
        // GraphQL -> totalMatchedSnapshots: Int! (scalar)
        if (this.TotalMatchedSnapshots == null && Exploration.Includes(parent + ".totalMatchedSnapshots", true))
        {
            this.TotalMatchedSnapshots = Int32.MinValue;
        }
        //      C# -> System.Int64? TotalUniqueMatchedPaths
        // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
        if (this.TotalUniqueMatchedPaths == null && Exploration.Includes(parent + ".totalUniqueMatchedPaths", true))
        {
            this.TotalUniqueMatchedPaths = new System.Int64();
        }
        //      C# -> List<IndicatorOfCompromise>? MatchTypes
        // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
        if (this.MatchTypes == null && Exploration.Includes(parent + ".matchTypes"))
        {
            this.MatchTypes = new List<IndicatorOfCompromise>();
            this.MatchTypes.ApplyExploratoryFieldSpec(parent + ".matchTypes");
        }
        //      C# -> List<ThreatHuntResultSnapshotStats>? SnapshotsStats
        // GraphQL -> snapshotsStats: [ThreatHuntResultSnapshotStats!]! (type)
        if (this.SnapshotsStats == null && Exploration.Includes(parent + ".snapshotsStats"))
        {
            this.SnapshotsStats = new List<ThreatHuntResultSnapshotStats>();
            this.SnapshotsStats.ApplyExploratoryFieldSpec(parent + ".snapshotsStats");
        }
    }


    #endregion

    } // class ThreatHuntResultObjectsSummary
    
    #endregion

    public static class ListThreatHuntResultObjectsSummaryExtensions
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
            this List<ThreatHuntResultObjectsSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntResultObjectsSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntResultObjectsSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types