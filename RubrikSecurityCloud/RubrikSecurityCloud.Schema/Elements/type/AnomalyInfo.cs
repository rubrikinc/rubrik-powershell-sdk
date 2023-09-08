// AnomalyInfo.cs
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
    #region AnomalyInfo
    public class AnomalyInfo: BaseType
    {
        #region members

        //      C# -> List<StrainInfo>? StrainAnalysisInfo
        // GraphQL -> strainAnalysisInfo: [StrainInfo!]! (type)
        [JsonProperty("strainAnalysisInfo")]
        public List<StrainInfo>? StrainAnalysisInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnomalyInfo";
    }

    public AnomalyInfo Set(
        List<StrainInfo>? StrainAnalysisInfo = null
    ) 
    {
        if ( StrainAnalysisInfo != null ) {
            this.StrainAnalysisInfo = StrainAnalysisInfo;
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
        //      C# -> List<StrainInfo>? StrainAnalysisInfo
        // GraphQL -> strainAnalysisInfo: [StrainInfo!]! (type)
        if (this.StrainAnalysisInfo != null) {
            var fspec = this.StrainAnalysisInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "strainAnalysisInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<StrainInfo>? StrainAnalysisInfo
        // GraphQL -> strainAnalysisInfo: [StrainInfo!]! (type)
        if (this.StrainAnalysisInfo == null && ec.Includes("strainAnalysisInfo",false))
        {
            this.StrainAnalysisInfo = new List<StrainInfo>();
            this.StrainAnalysisInfo.ApplyExploratoryFieldSpec(ec.NewChild("strainAnalysisInfo"));
        }
    }


    #endregion

    } // class AnomalyInfo
    
    #endregion

    public static class ListAnomalyInfoExtensions
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
            this List<AnomalyInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AnomalyInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnomalyInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AnomalyInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types