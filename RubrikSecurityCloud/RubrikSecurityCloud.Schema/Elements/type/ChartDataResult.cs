// ChartDataResult.cs
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
    #region ChartDataResult
    public class ChartDataResult: BaseType
    {
        #region members

        //      C# -> ChartType? ChartType
        // GraphQL -> chartType: ChartType! (enum)
        [JsonProperty("chartType")]
        public ChartType? ChartType { get; set; }

        //      C# -> List<ChartPrimaryGroupBy>? ChartData
        // GraphQL -> chartData: [ChartPrimaryGroupBy!]! (type)
        [JsonProperty("chartData")]
        public List<ChartPrimaryGroupBy>? ChartData { get; set; }


        #endregion

    #region methods

    public ChartDataResult Set(
        ChartType? ChartType = null,
        List<ChartPrimaryGroupBy>? ChartData = null
    ) 
    {
        if ( ChartType != null ) {
            this.ChartType = ChartType;
        }
        if ( ChartData != null ) {
            this.ChartData = ChartData;
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
        //      C# -> ChartType? ChartType
        // GraphQL -> chartType: ChartType! (enum)
        if (this.ChartType != null) {
            s += ind + "chartType\n" ;
        }
        //      C# -> List<ChartPrimaryGroupBy>? ChartData
        // GraphQL -> chartData: [ChartPrimaryGroupBy!]! (type)
        if (this.ChartData != null) {
            var fspec = this.ChartData.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "chartData {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ChartType? ChartType
        // GraphQL -> chartType: ChartType! (enum)
        if (this.ChartType == null && Exploration.Includes(parent + ".chartType", true))
        {
            this.ChartType = new ChartType();
        }
        //      C# -> List<ChartPrimaryGroupBy>? ChartData
        // GraphQL -> chartData: [ChartPrimaryGroupBy!]! (type)
        if (this.ChartData == null && Exploration.Includes(parent + ".chartData"))
        {
            this.ChartData = new List<ChartPrimaryGroupBy>();
            this.ChartData.ApplyExploratoryFieldSpec(parent + ".chartData");
        }
    }


    #endregion

    } // class ChartDataResult
    
    #endregion

    public static class ListChartDataResultExtensions
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
            this List<ChartDataResult> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ChartDataResult> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ChartDataResult());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types