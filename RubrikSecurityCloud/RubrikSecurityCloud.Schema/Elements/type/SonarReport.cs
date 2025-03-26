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

    public override string GetGqlTypeName() {
        return "SonarReport";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        if (this.GroupByValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "groupByValue\n" ;
            } else {
                s += ind + "groupByValue\n" ;
            }
        }
        //      C# -> List<TimeSeriesResult>? TimeSeriesResults
        // GraphQL -> timeSeriesResults: [TimeSeriesResult!]! (type)
        if (this.TimeSeriesResults != null) {
            var fspec = this.TimeSeriesResults.AsFieldSpec(conf.Child("timeSeriesResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "timeSeriesResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        //      C# -> System.String? GroupByValue
        // GraphQL -> groupByValue: String! (scalar)
        if (ec.Includes("groupByValue",true))
        {
            if(this.GroupByValue == null) {

                this.GroupByValue = "FETCH";

            } else {


            }
        }
        else if (this.GroupByValue != null && ec.Excludes("groupByValue",true))
        {
            this.GroupByValue = null;
        }
        //      C# -> List<TimeSeriesResult>? TimeSeriesResults
        // GraphQL -> timeSeriesResults: [TimeSeriesResult!]! (type)
        if (ec.Includes("timeSeriesResults",false))
        {
            if(this.TimeSeriesResults == null) {

                this.TimeSeriesResults = new List<TimeSeriesResult>();
                this.TimeSeriesResults.ApplyExploratoryFieldSpec(ec.NewChild("timeSeriesResults"));

            } else {

                this.TimeSeriesResults.ApplyExploratoryFieldSpec(ec.NewChild("timeSeriesResults"));

            }
        }
        else if (this.TimeSeriesResults != null && ec.Excludes("timeSeriesResults",false))
        {
            this.TimeSeriesResults = null;
        }
    }


    #endregion

    } // class SonarReport
    
    #endregion

    public static class ListSonarReportExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<SonarReport> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SonarReport> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SonarReport> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SonarReport());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SonarReport> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types