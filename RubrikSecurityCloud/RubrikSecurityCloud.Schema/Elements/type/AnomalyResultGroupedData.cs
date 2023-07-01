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
        public AnomalyResultGroupByInfo? GroupByInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnomalyResultGroupedData";
    }

    public AnomalyResultGroupedData Set(
        List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField = null,
        AnomalyResultConnection? AnomalyResults = null,
        AnomalyResultGroupByInfo? GroupByInfo = null
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField
        // GraphQL -> anomalyResultGroupedData: [AnomalyResultGroupedData!]! (type)
        if (this.AnomalyResultGroupedDataField != null) {
            var fspec = this.AnomalyResultGroupedDataField.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "anomalyResultGroupedData {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AnomalyResultConnection? AnomalyResults
        // GraphQL -> anomalyResults: AnomalyResultConnection! (type)
        if (this.AnomalyResults != null) {
            var fspec = this.AnomalyResults.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "anomalyResults {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AnomalyResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: AnomalyResultGroupByInfo! (union)
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
        //      C# -> List<AnomalyResultGroupedData>? AnomalyResultGroupedDataField
        // GraphQL -> anomalyResultGroupedData: [AnomalyResultGroupedData!]! (type)
        if (this.AnomalyResultGroupedDataField == null && Exploration.Includes(parent + ".anomalyResultGroupedData"))
        {
            this.AnomalyResultGroupedDataField = new List<AnomalyResultGroupedData>();
            this.AnomalyResultGroupedDataField.ApplyExploratoryFieldSpec(parent + ".anomalyResultGroupedData");
        }
        //      C# -> AnomalyResultConnection? AnomalyResults
        // GraphQL -> anomalyResults: AnomalyResultConnection! (type)
        if (this.AnomalyResults == null && Exploration.Includes(parent + ".anomalyResults"))
        {
            this.AnomalyResults = new AnomalyResultConnection();
            this.AnomalyResults.ApplyExploratoryFieldSpec(parent + ".anomalyResults");
        }
        //      C# -> AnomalyResultGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: AnomalyResultGroupByInfo! (union)
        if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
        {
            var impls = new List<AnomalyResultGroupByInfo>();
            impls.ApplyExploratoryFieldSpec(parent + ".groupByInfo");
            this.GroupByInfo = (AnomalyResultGroupByInfo)InterfaceHelper.MakeCompositeFromList(impls);
        }
    }


    #endregion

    } // class AnomalyResultGroupedData
    
    #endregion

    public static class ListAnomalyResultGroupedDataExtensions
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
            this List<AnomalyResultGroupedData> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AnomalyResultGroupedData> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AnomalyResultGroupedData());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types