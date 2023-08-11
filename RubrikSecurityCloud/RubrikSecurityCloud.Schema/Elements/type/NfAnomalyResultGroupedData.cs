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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<NfAnomalyResultGroupedData>? NfAnomalyResultGroupedDataField
        // GraphQL -> nfAnomalyResultGroupedData: [NfAnomalyResultGroupedData!]! (type)
        if (this.NfAnomalyResultGroupedDataField != null) {
            var fspec = this.NfAnomalyResultGroupedDataField.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nfAnomalyResultGroupedData {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> NfAnomalyResultConnection? NfAnomalyResults
        // GraphQL -> nfAnomalyResults: NfAnomalyResultConnection! (type)
        if (this.NfAnomalyResults != null) {
            var fspec = this.NfAnomalyResults.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nfAnomalyResults {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> NfAnomalyResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: NfAnomalyResultGroupByInfo! (union)
        if (this.GroupByInfo != null) {
            var fspec = this.GroupByInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "groupByInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<NfAnomalyResultGroupedData>? NfAnomalyResultGroupedDataField
        // GraphQL -> nfAnomalyResultGroupedData: [NfAnomalyResultGroupedData!]! (type)
        if (this.NfAnomalyResultGroupedDataField == null && Exploration.Includes(parent + ".nfAnomalyResultGroupedData"))
        {
            this.NfAnomalyResultGroupedDataField = new List<NfAnomalyResultGroupedData>();
            this.NfAnomalyResultGroupedDataField.ApplyExploratoryFieldSpec(parent + ".nfAnomalyResultGroupedData");
        }
        //      C# -> NfAnomalyResultConnection? NfAnomalyResults
        // GraphQL -> nfAnomalyResults: NfAnomalyResultConnection! (type)
        if (this.NfAnomalyResults == null && Exploration.Includes(parent + ".nfAnomalyResults"))
        {
            this.NfAnomalyResults = new NfAnomalyResultConnection();
            this.NfAnomalyResults.ApplyExploratoryFieldSpec(parent + ".nfAnomalyResults");
        }
        //      C# -> NfAnomalyResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: NfAnomalyResultGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<NfAnomalyResultGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
            this.GroupByInfo = (NfAnomalyResultGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NfAnomalyResultGroupedData> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NfAnomalyResultGroupedData());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types