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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<RansomwareResultGroupedData>? RansomwareResultGroupedDataField
        // GraphQL -> ransomwareResultGroupedData: [RansomwareResultGroupedData!]! (type)
        if (this.RansomwareResultGroupedDataField != null) {
            var fspec = this.RansomwareResultGroupedDataField.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ransomwareResultGroupedData {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RansomwareResultConnection? RansomwareResults
        // GraphQL -> ransomwareResults: RansomwareResultConnection! (type)
        if (this.RansomwareResults != null) {
            var fspec = this.RansomwareResults.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ransomwareResults {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RansomwareResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: RansomwareResultGroupByInfo! (union)
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
        //      C# -> List<RansomwareResultGroupedData>? RansomwareResultGroupedDataField
        // GraphQL -> ransomwareResultGroupedData: [RansomwareResultGroupedData!]! (type)
        if (this.RansomwareResultGroupedDataField == null && Exploration.Includes(parent + ".ransomwareResultGroupedData"))
        {
            this.RansomwareResultGroupedDataField = new List<RansomwareResultGroupedData>();
            this.RansomwareResultGroupedDataField.ApplyExploratoryFieldSpec(parent + ".ransomwareResultGroupedData");
        }
        //      C# -> RansomwareResultConnection? RansomwareResults
        // GraphQL -> ransomwareResults: RansomwareResultConnection! (type)
        if (this.RansomwareResults == null && Exploration.Includes(parent + ".ransomwareResults"))
        {
            this.RansomwareResults = new RansomwareResultConnection();
            this.RansomwareResults.ApplyExploratoryFieldSpec(parent + ".ransomwareResults");
        }
        //      C# -> RansomwareResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: RansomwareResultGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<RansomwareResultGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
            this.GroupByInfo = (RansomwareResultGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class RansomwareResultGroupedData
    
    #endregion

    public static class ListRansomwareResultGroupedDataExtensions
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
            this List<RansomwareResultGroupedData> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RansomwareResultGroupedData> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RansomwareResultGroupedData());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types