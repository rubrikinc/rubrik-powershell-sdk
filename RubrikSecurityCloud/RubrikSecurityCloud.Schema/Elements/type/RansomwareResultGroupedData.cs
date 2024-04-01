// RansomwareResultGroupedData.cs
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
    #region RansomwareResultGroupedData
    public class RansomwareResultGroupedData: BaseType
    {
        #region members

        //      C# -> List<RansomwareResultGroupedData>? RansomwareResultGroupedDataField
        // GraphQL -> ransomwareResultGroupedData: [RansomwareResultGroupedData!]! (type)
        [JsonProperty("ransomwareResultGroupedData")]
        public List<RansomwareResultGroupedData>? RansomwareResultGroupedDataField { get; set; }

        //      C# -> RansomwareResultConnection? RansomwareResults
        // GraphQL -> ransomwareResults: RansomwareResultConnection! (type)
        [JsonProperty("ransomwareResults")]
        public RansomwareResultConnection? RansomwareResults { get; set; }

        //      C# -> RansomwareResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: RansomwareResultGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public RansomwareResultGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RansomwareResultGroupedData";
    }

    public RansomwareResultGroupedData Set(
        List<RansomwareResultGroupedData>? RansomwareResultGroupedDataField = null,
        RansomwareResultConnection? RansomwareResults = null,
        RansomwareResultGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( RansomwareResultGroupedDataField != null ) {
            this.RansomwareResultGroupedDataField = RansomwareResultGroupedDataField;
        }
        if ( RansomwareResults != null ) {
            this.RansomwareResults = RansomwareResults;
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
        //      C# -> List<RansomwareResultGroupedData>? RansomwareResultGroupedDataField
        // GraphQL -> ransomwareResultGroupedData: [RansomwareResultGroupedData!]! (type)
        if (this.RansomwareResultGroupedDataField != null) {
            var fspec = this.RansomwareResultGroupedDataField.AsFieldSpec(conf.Child("ransomwareResultGroupedData"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ransomwareResultGroupedData {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RansomwareResultConnection? RansomwareResults
        // GraphQL -> ransomwareResults: RansomwareResultConnection! (type)
        if (this.RansomwareResults != null) {
            var fspec = this.RansomwareResults.AsFieldSpec(conf.Child("ransomwareResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ransomwareResults {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RansomwareResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: RansomwareResultGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(conf.Child("groupByInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "groupByInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<RansomwareResultGroupedData>? RansomwareResultGroupedDataField
        // GraphQL -> ransomwareResultGroupedData: [RansomwareResultGroupedData!]! (type)
        if (ec.Includes("ransomwareResultGroupedData",false))
        {
            if(this.RansomwareResultGroupedDataField == null) {

                this.RansomwareResultGroupedDataField = new List<RansomwareResultGroupedData>();
                this.RansomwareResultGroupedDataField.ApplyExploratoryFieldSpec(ec.NewChild("ransomwareResultGroupedData"));

            } else {

                this.RansomwareResultGroupedDataField.ApplyExploratoryFieldSpec(ec.NewChild("ransomwareResultGroupedData"));

            }
        }
        else if (this.RansomwareResultGroupedDataField != null && ec.Excludes("ransomwareResultGroupedData",false))
        {
            this.RansomwareResultGroupedDataField = null;
        }
        //      C# -> RansomwareResultConnection? RansomwareResults
        // GraphQL -> ransomwareResults: RansomwareResultConnection! (type)
        if (ec.Includes("ransomwareResults",false))
        {
            if(this.RansomwareResults == null) {

                this.RansomwareResults = new RansomwareResultConnection();
                this.RansomwareResults.ApplyExploratoryFieldSpec(ec.NewChild("ransomwareResults"));

            } else {

                this.RansomwareResults.ApplyExploratoryFieldSpec(ec.NewChild("ransomwareResults"));

            }
        }
        else if (this.RansomwareResults != null && ec.Excludes("ransomwareResults",false))
        {
            this.RansomwareResults = null;
        }
        //      C# -> RansomwareResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: RansomwareResultGroupByInfo! (union)
        if (ec.Includes("groupByInfo",false))
        {
            if(this.GroupByInfo == null) {

                var impls = new List<RansomwareResultGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (RansomwareResultGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<RansomwareResultGroupByInfo>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("groupByInfo"));
                this.GroupByInfo = (RansomwareResultGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.GroupByInfo != null && ec.Excludes("groupByInfo",false))
        {
            this.GroupByInfo = null;
        }
    }


    #endregion

    } // class RansomwareResultGroupedData
    
    #endregion

    public static class ListRansomwareResultGroupedDataExtensions
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
            this List<RansomwareResultGroupedData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RansomwareResultGroupedData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RansomwareResultGroupedData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RansomwareResultGroupedData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RansomwareResultGroupedData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types