// ChartViewWithName.cs
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
    #region ChartViewWithName
    public class ChartViewWithName: BaseType
    {
        #region members

        //      C# -> ChartViewType? ChartViewType
        // GraphQL -> chartViewType: ChartViewType! (enum)
        [JsonProperty("chartViewType")]
        public ChartViewType? ChartViewType { get; set; }

        //      C# -> System.String? ChartName
        // GraphQL -> chartName: String! (scalar)
        [JsonProperty("chartName")]
        public System.String? ChartName { get; set; }


        #endregion

    #region methods

    public ChartViewWithName Set(
        ChartViewType? ChartViewType = null,
        System.String? ChartName = null
    ) 
    {
        if ( ChartViewType != null ) {
            this.ChartViewType = ChartViewType;
        }
        if ( ChartName != null ) {
            this.ChartName = ChartName;
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
        //      C# -> ChartViewType? ChartViewType
        // GraphQL -> chartViewType: ChartViewType! (enum)
        if (this.ChartViewType != null) {
            s += ind + "chartViewType\n" ;
        }
        //      C# -> System.String? ChartName
        // GraphQL -> chartName: String! (scalar)
        if (this.ChartName != null) {
            s += ind + "chartName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ChartViewType? ChartViewType
        // GraphQL -> chartViewType: ChartViewType! (enum)
        if (this.ChartViewType == null && Exploration.Includes(parent + ".chartViewType", true))
        {
            this.ChartViewType = new ChartViewType();
        }
        //      C# -> System.String? ChartName
        // GraphQL -> chartName: String! (scalar)
        if (this.ChartName == null && Exploration.Includes(parent + ".chartName", true))
        {
            this.ChartName = "FETCH";
        }
    }


    #endregion

    } // class ChartViewWithName
    
    #endregion

    public static class ListChartViewWithNameExtensions
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
            this List<ChartViewWithName> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ChartViewWithName> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ChartViewWithName());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types