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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region ThreatMonitoringStats
    public class ThreatMonitoringStats: BaseType
    {
        #region members

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

    public override string GetGqlTypeName() {
        return "ThreatMonitoringStats";
    }

    public ThreatMonitoringStats Set(
        System.Int64? ObjectsWithMatches = null,
        System.Int64? ObjectsWithNoMatches = null,
        System.Int64? TotalObjectsScanned = null
    ) 
    {
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int64? ObjectsWithMatches
        // GraphQL -> objectsWithMatches: Long! (scalar)
        if (this.ObjectsWithMatches != null) {
            s += ind + "objectsWithMatches\n" ;
        }
        //      C# -> System.Int64? ObjectsWithNoMatches
        // GraphQL -> objectsWithNoMatches: Long! (scalar)
        if (this.ObjectsWithNoMatches != null) {
            s += ind + "objectsWithNoMatches\n" ;
        }
        //      C# -> System.Int64? TotalObjectsScanned
        // GraphQL -> totalObjectsScanned: Long! (scalar)
        if (this.TotalObjectsScanned != null) {
            s += ind + "totalObjectsScanned\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? ObjectsWithMatches
        // GraphQL -> objectsWithMatches: Long! (scalar)
        if (this.ObjectsWithMatches == null && ec.Includes("objectsWithMatches",true))
        {
            this.ObjectsWithMatches = new System.Int64();
        }
        //      C# -> System.Int64? ObjectsWithNoMatches
        // GraphQL -> objectsWithNoMatches: Long! (scalar)
        if (this.ObjectsWithNoMatches == null && ec.Includes("objectsWithNoMatches",true))
        {
            this.ObjectsWithNoMatches = new System.Int64();
        }
        //      C# -> System.Int64? TotalObjectsScanned
        // GraphQL -> totalObjectsScanned: Long! (scalar)
        if (this.TotalObjectsScanned == null && ec.Includes("totalObjectsScanned",true))
        {
            this.TotalObjectsScanned = new System.Int64();
        }
    }


    #endregion

    } // class ThreatMonitoringStats
    
    #endregion

    public static class ListThreatMonitoringStatsExtensions
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
            this List<ThreatMonitoringStats> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ThreatMonitoringStats> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatMonitoringStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ThreatMonitoringStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types