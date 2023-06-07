// ThreatHuntResultSnapshotStats.cs
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
    #region ThreatHuntResultSnapshotStats
    public class ThreatHuntResultSnapshotStats: BaseType
    {
        #region members

        //      C# -> MalwareScanInSnapshotStatus? Status
        // GraphQL -> status: MalwareScanInSnapshotStatus! (enum)
        [JsonProperty("status")]
        public MalwareScanInSnapshotStatus? Status { get; set; }

        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        [JsonProperty("isExpired")]
        public System.Boolean? IsExpired { get; set; }

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.Int64? TotalMatchedPaths
        // GraphQL -> totalMatchedPaths: Long! (scalar)
        [JsonProperty("totalMatchedPaths")]
        public System.Int64? TotalMatchedPaths { get; set; }

        //      C# -> List<IndicatorOfCompromise>? MatchTypes
        // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
        [JsonProperty("matchTypes")]
        public List<IndicatorOfCompromise>? MatchTypes { get; set; }


        #endregion

    #region methods

    public ThreatHuntResultSnapshotStats Set(
        MalwareScanInSnapshotStatus? Status = null,
        System.Boolean? IsExpired = null,
        System.Boolean? IsQuarantined = null,
        DateTime? SnapshotDate = null,
        System.String? SnapshotFid = null,
        System.Int64? TotalMatchedPaths = null,
        List<IndicatorOfCompromise>? MatchTypes = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( IsExpired != null ) {
            this.IsExpired = IsExpired;
        }
        if ( IsQuarantined != null ) {
            this.IsQuarantined = IsQuarantined;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( TotalMatchedPaths != null ) {
            this.TotalMatchedPaths = TotalMatchedPaths;
        }
        if ( MatchTypes != null ) {
            this.MatchTypes = MatchTypes;
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
        //      C# -> MalwareScanInSnapshotStatus? Status
        // GraphQL -> status: MalwareScanInSnapshotStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        if (this.IsExpired != null) {
            s += ind + "isExpired\n" ;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined != null) {
            s += ind + "isQuarantined\n" ;
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate != null) {
            s += ind + "snapshotDate\n" ;
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid != null) {
            s += ind + "snapshotFid\n" ;
        }
        //      C# -> System.Int64? TotalMatchedPaths
        // GraphQL -> totalMatchedPaths: Long! (scalar)
        if (this.TotalMatchedPaths != null) {
            s += ind + "totalMatchedPaths\n" ;
        }
        //      C# -> List<IndicatorOfCompromise>? MatchTypes
        // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
        if (this.MatchTypes != null) {
            s += ind + "matchTypes {\n" + this.MatchTypes.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> MalwareScanInSnapshotStatus? Status
        // GraphQL -> status: MalwareScanInSnapshotStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new MalwareScanInSnapshotStatus();
        }
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        if (this.IsExpired == null && Exploration.Includes(parent + ".isExpired", true))
        {
            this.IsExpired = true;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined == null && Exploration.Includes(parent + ".isQuarantined", true))
        {
            this.IsQuarantined = true;
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate == null && Exploration.Includes(parent + ".snapshotDate", true))
        {
            this.SnapshotDate = new DateTime();
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid == null && Exploration.Includes(parent + ".snapshotFid", true))
        {
            this.SnapshotFid = "FETCH";
        }
        //      C# -> System.Int64? TotalMatchedPaths
        // GraphQL -> totalMatchedPaths: Long! (scalar)
        if (this.TotalMatchedPaths == null && Exploration.Includes(parent + ".totalMatchedPaths", true))
        {
            this.TotalMatchedPaths = new System.Int64();
        }
        //      C# -> List<IndicatorOfCompromise>? MatchTypes
        // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
        if (this.MatchTypes == null && Exploration.Includes(parent + ".matchTypes"))
        {
            this.MatchTypes = new List<IndicatorOfCompromise>();
            this.MatchTypes.ApplyExploratoryFieldSpec(parent + ".matchTypes");
        }
    }


    #endregion

    } // class ThreatHuntResultSnapshotStats
    
    #endregion

    public static class ListThreatHuntResultSnapshotStatsExtensions
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
            this List<ThreatHuntResultSnapshotStats> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntResultSnapshotStats> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntResultSnapshotStats());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types