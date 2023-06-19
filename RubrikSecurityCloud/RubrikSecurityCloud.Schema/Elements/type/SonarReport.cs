// SonarReport.cs
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
    #region SonarReport
    public class SonarReport: BaseType
    {
        #region members

        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        [JsonProperty("count")]
        public System.Int64? Count { get; set; }

        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        [JsonProperty("groupByValue")]
        public System.String? GroupByValue { get; set; }

        //      C# -> List<TimeSeriesResult>? TimeSeriesResults
        // GraphQL -> timeSeriesResults: [TimeSeriesResult!]! (type)
        [JsonProperty("timeSeriesResults")]
        public List<TimeSeriesResult>? TimeSeriesResults { get; set; }


        #endregion

    #region methods

    public SonarReport Set(
        System.Int64? Count = null,
        System.String? GroupByValue = null,
        List<TimeSeriesResult>? TimeSeriesResults = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( GroupByValue != null ) {
            this.GroupByValue = GroupByValue;
        }
        if ( TimeSeriesResults != null ) {
            this.TimeSeriesResults = TimeSeriesResults;
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
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        if (this.GroupByValue != null) {
            s += ind + "groupByValue\n" ;
        }
        //      C# -> List<TimeSeriesResult>? TimeSeriesResults
        // GraphQL -> timeSeriesResults: [TimeSeriesResult!]! (type)
        if (this.TimeSeriesResults != null) {
            var fspec = this.TimeSeriesResults.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "timeSeriesResults {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = new System.Int64();
        }
        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        if (this.GroupByValue == null && Exploration.Includes(parent + ".groupByValue", true))
        {
            this.GroupByValue = "FETCH";
        }
        //      C# -> List<TimeSeriesResult>? TimeSeriesResults
        // GraphQL -> timeSeriesResults: [TimeSeriesResult!]! (type)
        if (this.TimeSeriesResults == null && Exploration.Includes(parent + ".timeSeriesResults"))
        {
            this.TimeSeriesResults = new List<TimeSeriesResult>();
            this.TimeSeriesResults.ApplyExploratoryFieldSpec(parent + ".timeSeriesResults");
        }
    }


    #endregion

    } // class SonarReport
    
    #endregion

    public static class ListSonarReportExtensions
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
            this List<SonarReport> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SonarReport> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SonarReport());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types