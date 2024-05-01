// TimeSeriesResult.cs
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
    #region TimeSeriesResult
    public class TimeSeriesResult: BaseType
    {
        #region members

        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        [JsonProperty("count")]
        public System.Int64? Count { get; set; }

        //      C# -> System.String? Timestamp
        // GraphQL -> timestamp: String! (scalar)
        [JsonProperty("timestamp")]
        public System.String? Timestamp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TimeSeriesResult";
    }

    public TimeSeriesResult Set(
        System.Int64? Count = null,
        System.String? Timestamp = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> System.String? Timestamp
        // GraphQL -> timestamp: String! (scalar)
        if (this.Timestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestamp\n" ;
            } else {
                s += ind + "timestamp\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = new System.Int64();

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
        //      C# -> System.String? Timestamp
        // GraphQL -> timestamp: String! (scalar)
        if (ec.Includes("timestamp",true))
        {
            if(this.Timestamp == null) {

                this.Timestamp = "FETCH";

            } else {


            }
        }
        else if (this.Timestamp != null && ec.Excludes("timestamp",true))
        {
            this.Timestamp = null;
        }
    }


    #endregion

    } // class TimeSeriesResult
    
    #endregion

    public static class ListTimeSeriesResultExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<TimeSeriesResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TimeSeriesResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TimeSeriesResult> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TimeSeriesResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TimeSeriesResult> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types