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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ThreatHuntStats
    public class ThreatHuntStats: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? TotalAffectedObjects
        // GraphQL -> totalAffectedObjects: Long! (scalar)
        if (this.TotalAffectedObjects != null) {
            s += ind + "totalAffectedObjects\n" ;
        }
        //      C# -> System.Int64? TotalAffectedSnapshots
        // GraphQL -> totalAffectedSnapshots: Long! (scalar)
        if (this.TotalAffectedSnapshots != null) {
            s += ind + "totalAffectedSnapshots\n" ;
        }
        //      C# -> System.Int64? TotalSnapshotsScanned
        // GraphQL -> totalSnapshotsScanned: Long! (scalar)
        if (this.TotalSnapshotsScanned != null) {
            s += ind + "totalSnapshotsScanned\n" ;
        }
        //      C# -> System.Int64? TotalSucceededScans
        // GraphQL -> totalSucceededScans: Long! (scalar)
        if (this.TotalSucceededScans != null) {
            s += ind + "totalSucceededScans\n" ;
        }
        //      C# -> System.Int64? TotalUniqueMatchedPaths
        // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
        if (this.TotalUniqueMatchedPaths != null) {
            s += ind + "totalUniqueMatchedPaths\n" ;
        }
        //      C# -> System.Int64? TotalUniqueQuarantinedPaths
        // GraphQL -> totalUniqueQuarantinedPaths: Long! (scalar)
        if (this.TotalUniqueQuarantinedPaths != null) {
            s += ind + "totalUniqueQuarantinedPaths\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? TotalAffectedObjects
        // GraphQL -> totalAffectedObjects: Long! (scalar)
        if (this.TotalAffectedObjects == null && Exploration.Includes(parent + ".totalAffectedObjects", true))
        {
            this.TotalAffectedObjects = new System.Int64();
        }
        //      C# -> System.Int64? TotalAffectedSnapshots
        // GraphQL -> totalAffectedSnapshots: Long! (scalar)
        if (this.TotalAffectedSnapshots == null && Exploration.Includes(parent + ".totalAffectedSnapshots", true))
        {
            this.TotalAffectedSnapshots = new System.Int64();
        }
        //      C# -> System.Int64? TotalSnapshotsScanned
        // GraphQL -> totalSnapshotsScanned: Long! (scalar)
        if (this.TotalSnapshotsScanned == null && Exploration.Includes(parent + ".totalSnapshotsScanned", true))
        {
            this.TotalSnapshotsScanned = new System.Int64();
        }
        //      C# -> System.Int64? TotalSucceededScans
        // GraphQL -> totalSucceededScans: Long! (scalar)
        if (this.TotalSucceededScans == null && Exploration.Includes(parent + ".totalSucceededScans", true))
        {
            this.TotalSucceededScans = new System.Int64();
        }
        //      C# -> System.Int64? TotalUniqueMatchedPaths
        // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
        if (this.TotalUniqueMatchedPaths == null && Exploration.Includes(parent + ".totalUniqueMatchedPaths", true))
        {
            this.TotalUniqueMatchedPaths = new System.Int64();
        }
        //      C# -> System.Int64? TotalUniqueQuarantinedPaths
        // GraphQL -> totalUniqueQuarantinedPaths: Long! (scalar)
        if (this.TotalUniqueQuarantinedPaths == null && Exploration.Includes(parent + ".totalUniqueQuarantinedPaths", true))
        {
            this.TotalUniqueQuarantinedPaths = new System.Int64();
        }
    }


    #endregion

    } // class ThreatHuntStats
    
    #endregion

    public static class ListThreatHuntStatsExtensions
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
            this List<ThreatHuntStats> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntStats> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntStats());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types