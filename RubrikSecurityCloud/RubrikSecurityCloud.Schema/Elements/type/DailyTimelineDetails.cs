// DailyTimelineDetails.cs
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
    #region DailyTimelineDetails
    public class DailyTimelineDetails: BaseType
    {
        #region members

        //      C# -> System.Int64? AnomaliesFound
        // GraphQL -> anomaliesFound: Long! (scalar)
        [JsonProperty("anomaliesFound")]
        public System.Int64? AnomaliesFound { get; set; }

        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        [JsonProperty("day")]
        public System.String? Day { get; set; }

        //      C# -> System.Int64? ThreatsFound
        // GraphQL -> threatsFound: Long! (scalar)
        [JsonProperty("threatsFound")]
        public System.Int64? ThreatsFound { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DailyTimelineDetails";
    }

    public DailyTimelineDetails Set(
        System.Int64? AnomaliesFound = null,
        System.String? Day = null,
        System.Int64? ThreatsFound = null
    ) 
    {
        if ( AnomaliesFound != null ) {
            this.AnomaliesFound = AnomaliesFound;
        }
        if ( Day != null ) {
            this.Day = Day;
        }
        if ( ThreatsFound != null ) {
            this.ThreatsFound = ThreatsFound;
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
        //      C# -> System.Int64? AnomaliesFound
        // GraphQL -> anomaliesFound: Long! (scalar)
        if (this.AnomaliesFound != null) {
            s += ind + "anomaliesFound\n" ;
        }
        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        if (this.Day != null) {
            s += ind + "day\n" ;
        }
        //      C# -> System.Int64? ThreatsFound
        // GraphQL -> threatsFound: Long! (scalar)
        if (this.ThreatsFound != null) {
            s += ind + "threatsFound\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? AnomaliesFound
        // GraphQL -> anomaliesFound: Long! (scalar)
        if (this.AnomaliesFound == null && ec.Includes("anomaliesFound",true))
        {
            this.AnomaliesFound = new System.Int64();
        }
        //      C# -> System.String? Day
        // GraphQL -> day: String! (scalar)
        if (this.Day == null && ec.Includes("day",true))
        {
            this.Day = "FETCH";
        }
        //      C# -> System.Int64? ThreatsFound
        // GraphQL -> threatsFound: Long! (scalar)
        if (this.ThreatsFound == null && ec.Includes("threatsFound",true))
        {
            this.ThreatsFound = new System.Int64();
        }
    }


    #endregion

    } // class DailyTimelineDetails
    
    #endregion

    public static class ListDailyTimelineDetailsExtensions
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
            this List<DailyTimelineDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DailyTimelineDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DailyTimelineDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<DailyTimelineDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types