// NfAnomalyResultGroupedData.cs
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
    #region NfAnomalyResultGroupedData
    public class NfAnomalyResultGroupedData: BaseType
    {
        #region members

        //      C# -> List<NfAnomalyResultGroupedData>? NfAnomalyResultGroupedDataField
        // GraphQL -> nfAnomalyResultGroupedData: [NfAnomalyResultGroupedData!]! (type)
        [JsonProperty("nfAnomalyResultGroupedData")]
        public List<NfAnomalyResultGroupedData>? NfAnomalyResultGroupedDataField { get; set; }

        //      C# -> NfAnomalyResultConnection? NfAnomalyResults
        // GraphQL -> nfAnomalyResults: NfAnomalyResultConnection! (type)
        [JsonProperty("nfAnomalyResults")]
        public NfAnomalyResultConnection? NfAnomalyResults { get; set; }

        //      C# -> NfAnomalyResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: NfAnomalyResultGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public NfAnomalyResultGroupByInfo? GroupByInfo { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars NfAnomalyResultGroupedDataField { get; set; }

        public RscGqlVars NfAnomalyResults { get; set; }


        public InlineVars() {
            Tuple<string, string>[] nfAnomalyResultGroupedDataArgs = {
                    Tuple.Create("groupBy", "NfAnomalyResultGroupBy!"),
                };
            this.NfAnomalyResultGroupedDataField =
                new RscGqlVars(null, nfAnomalyResultGroupedDataArgs, null, true);
            Tuple<string, string>[] nfAnomalyResultsArgs = {
                    Tuple.Create("first", "Int"),
                    Tuple.Create("after", "String"),
                    Tuple.Create("last", "Int"),
                    Tuple.Create("before", "String"),
                    Tuple.Create("sortOrder", "SortOrder"),
                    Tuple.Create("sortBy", "NfAnomalyResultSortBy"),
                    Tuple.Create("filter", "NfAnomalyResultFilterInput"),
                };
            this.NfAnomalyResults =
                new RscGqlVars(null, nfAnomalyResultsArgs, null, true);
        }
    }

    public NfAnomalyResultGroupedData()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "NfAnomalyResultGroupedData";
    }

    public NfAnomalyResultGroupedData Set(
        List<NfAnomalyResultGroupedData>? NfAnomalyResultGroupedDataField = null,
        NfAnomalyResultConnection? NfAnomalyResults = null,
        NfAnomalyResultGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( NfAnomalyResultGroupedDataField != null ) {
            this.NfAnomalyResultGroupedDataField = NfAnomalyResultGroupedDataField;
        }
        if ( NfAnomalyResults != null ) {
            this.NfAnomalyResults = NfAnomalyResults;
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<NfAnomalyResultGroupedData>? NfAnomalyResultGroupedDataField
        // GraphQL -> nfAnomalyResultGroupedData: [NfAnomalyResultGroupedData!]! (type)
        if (this.NfAnomalyResultGroupedDataField != null) {
            var fspec = this.NfAnomalyResultGroupedDataField.AsFieldSpec(conf.Child("nfAnomalyResultGroupedData"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nfAnomalyResultGroupedData" + "\n(" + this.Vars.NfAnomalyResultGroupedDataField.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NfAnomalyResultConnection? NfAnomalyResults
        // GraphQL -> nfAnomalyResults: NfAnomalyResultConnection! (type)
        if (this.NfAnomalyResults != null) {
            var fspec = this.NfAnomalyResults.AsFieldSpec(conf.Child("nfAnomalyResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nfAnomalyResults" + "\n(" + this.Vars.NfAnomalyResults.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NfAnomalyResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: NfAnomalyResultGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(conf.Child("groupByInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupByInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<NfAnomalyResultGroupedData>? NfAnomalyResultGroupedDataField
        // GraphQL -> nfAnomalyResultGroupedData: [NfAnomalyResultGroupedData!]! (type)
        if (ec.Includes("nfAnomalyResultGroupedData",false))
        {
            if(this.NfAnomalyResultGroupedDataField == null) {

                this.NfAnomalyResultGroupedDataField = new List<NfAnomalyResultGroupedData>();
                this.NfAnomalyResultGroupedDataField.ApplyExploratoryFieldSpec(ec.NewChild("nfAnomalyResultGroupedData"));

            } else {

                this.NfAnomalyResultGroupedDataField.ApplyExploratoryFieldSpec(ec.NewChild("nfAnomalyResultGroupedData"));

            }
        }
        else if (this.NfAnomalyResultGroupedDataField != null && ec.Excludes("nfAnomalyResultGroupedData",false))
        {
            this.NfAnomalyResultGroupedDataField = null;
        }
        //      C# -> NfAnomalyResultConnection? NfAnomalyResults
        // GraphQL -> nfAnomalyResults: NfAnomalyResultConnection! (type)
        if (ec.Includes("nfAnomalyResults",false))
        {
            if(this.NfAnomalyResults == null) {

                this.NfAnomalyResults = new NfAnomalyResultConnection();
                this.NfAnomalyResults.ApplyExploratoryFieldSpec(ec.NewChild("nfAnomalyResults"));

            } else {

                this.NfAnomalyResults.ApplyExploratoryFieldSpec(ec.NewChild("nfAnomalyResults"));

            }
        }
        else if (this.NfAnomalyResults != null && ec.Excludes("nfAnomalyResults",false))
        {
            this.NfAnomalyResults = null;
        }
        //      C# -> NfAnomalyResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: NfAnomalyResultGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                var impls = new RscInterface<NfAnomalyResultGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (NfAnomalyResultGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<NfAnomalyResultGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (NfAnomalyResultGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class NfAnomalyResultGroupedData
    
    #endregion

    public static class ListNfAnomalyResultGroupedDataExtensions
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
            this List<NfAnomalyResultGroupedData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NfAnomalyResultGroupedData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NfAnomalyResultGroupedData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NfAnomalyResultGroupedData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NfAnomalyResultGroupedData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types