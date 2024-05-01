// AnomalyResultGroupedData.cs
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
    #region AnomalyResultGroupedData
    public class AnomalyResultGroupedData: BaseType
    {
        #region members

        //      C# -> List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField
        // GraphQL -> anomalyResultGroupedData: [AnomalyResultGroupedData!]! (type)
        [JsonProperty("anomalyResultGroupedData")]
        public List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField { get; set; }

        //      C# -> AnomalyResultConnection? AnomalyResults
        // GraphQL -> anomalyResults: AnomalyResultConnection! (type)
        [JsonProperty("anomalyResults")]
        public AnomalyResultConnection? AnomalyResults { get; set; }

        //      C# -> AnomalyResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: AnomalyResultGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public RscInterface<AnomalyResultGroupByInfo> GroupByInfo { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars AnomalyResultGroupedDataField { get; set; }

        public RscGqlVars AnomalyResults { get; set; }


        public InlineVars() {
            Tuple<string, string>[] anomalyResultGroupedDataArgs = {
                    Tuple.Create("groupBy", "AnomalyResultGroupBy!"),
                };
            this.AnomalyResultGroupedDataField =
                new RscGqlVars(null, anomalyResultGroupedDataArgs, null, true);
            Tuple<string, string>[] anomalyResultsArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("sortBy", "AnomalyResultSortBy"),
                    Tuple.Create("filter", "AnomalyResultFilterInput"),
                };
            this.AnomalyResults =
                new RscGqlVars(null, anomalyResultsArgs, null, true);
        }
    }

    public AnomalyResultGroupedData()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "AnomalyResultGroupedData";
    }

    public AnomalyResultGroupedData Set(
        List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField = null,
        AnomalyResultConnection? AnomalyResults = null,
        RscInterface<AnomalyResultGroupByInfo> GroupByInfo = null
    ) 
    {
        if ( AnomalyResultGroupedDataField != null ) {
            this.AnomalyResultGroupedDataField = AnomalyResultGroupedDataField;
        }
        if ( AnomalyResults != null ) {
            this.AnomalyResults = AnomalyResults;
        }
        if ( GroupByInfo != null ) {
            this.GroupByInfo = GroupByInfo;
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
        //      C# -> List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField
        // GraphQL -> anomalyResultGroupedData: [AnomalyResultGroupedData!]! (type)
        if (this.AnomalyResultGroupedDataField != null) {
            var fspec = this.AnomalyResultGroupedDataField.AsFieldSpec(conf.Child("anomalyResultGroupedData"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "anomalyResultGroupedData" + "\n(" + this.Vars.AnomalyResultGroupedDataField.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AnomalyResultConnection? AnomalyResults
        // GraphQL -> anomalyResults: AnomalyResultConnection! (type)
        if (this.AnomalyResults != null) {
            var fspec = this.AnomalyResults.AsFieldSpec(conf.Child("anomalyResults"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "anomalyResults" + "\n(" + this.Vars.AnomalyResults.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AnomalyResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: AnomalyResultGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(conf.Child("groupByInfo"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupByInfo" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField
        // GraphQL -> anomalyResultGroupedData: [AnomalyResultGroupedData!]! (type)
        if (ec.Includes("anomalyResultGroupedData",false))
        {
            if(this.AnomalyResultGroupedDataField == null) {

                this.AnomalyResultGroupedDataField = new List<AnomalyResultGroupedData>();
                this.AnomalyResultGroupedDataField.ApplyExploratoryFieldSpec(ec.NewChild("anomalyResultGroupedData"));

            } else {

                this.AnomalyResultGroupedDataField.ApplyExploratoryFieldSpec(ec.NewChild("anomalyResultGroupedData"));

            }
        }
        else if (this.AnomalyResultGroupedDataField != null && ec.Excludes("anomalyResultGroupedData",false))
        {
            this.AnomalyResultGroupedDataField = null;
        }
        //      C# -> AnomalyResultConnection? AnomalyResults
        // GraphQL -> anomalyResults: AnomalyResultConnection! (type)
        if (ec.Includes("anomalyResults",false))
        {
            if(this.AnomalyResults == null) {

                this.AnomalyResults = new AnomalyResultConnection();
                this.AnomalyResults.ApplyExploratoryFieldSpec(ec.NewChild("anomalyResults"));

            } else {

                this.AnomalyResults.ApplyExploratoryFieldSpec(ec.NewChild("anomalyResults"));

            }
        }
        else if (this.AnomalyResults != null && ec.Excludes("anomalyResults",false))
        {
            this.AnomalyResults = null;
        }
        //      C# -> AnomalyResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: AnomalyResultGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                this.GroupByInfo = new RscInterface<AnomalyResultGroupByInfo>();
                this.GroupByInfo.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));

            } else {

                this.GroupByInfo.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class AnomalyResultGroupedData
    
    #endregion

    public static class ListAnomalyResultGroupedDataExtensions
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
            this List<AnomalyResultGroupedData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnomalyResultGroupedData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AnomalyResultGroupedData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnomalyResultGroupedData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnomalyResultGroupedData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types