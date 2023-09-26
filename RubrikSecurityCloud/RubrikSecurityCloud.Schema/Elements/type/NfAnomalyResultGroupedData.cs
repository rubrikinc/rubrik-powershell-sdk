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


        #endregion

    #region methods

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
                    s += ind + "nfAnomalyResultGroupedData {\n" + fspec + ind + "}\n" ;
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
                    s += ind + "nfAnomalyResults {\n" + fspec + ind + "}\n" ;
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
                    s += ind + "groupByInfo {\n" + fspec + ind + "}\n" ;
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

                var impls = new List<NfAnomalyResultGroupByInfo>();
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
            this List<NfAnomalyResultGroupedData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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